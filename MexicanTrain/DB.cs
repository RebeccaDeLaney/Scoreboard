using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MexicanTrain
{
    public class DB
    {
        string connectionString;
        SqlConnection conn;

        public DB(string conn)
        {
            connectionString = CnnHelper.CnnVal(conn);
        }

        public static List<string> GetPlayers()
        {
            SqlDataReader dataReader;

            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));
            cnn.Open();
            List<string> playerList = new List<string>();

            string playerNameQuery = "select player_name from Players;";
            SqlCommand cmd = new SqlCommand(playerNameQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    playerList.Add((string)dataReader.GetValue(0));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return playerList;
        }

        public static List<string> DateList()
        {
            SqlDataReader dataReader;

            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));
            cnn.Open();
            List<string> game_dateList = new List<string>();

            string dateListQuery = "select game_date from [Game Session];";
            SqlCommand cmd = new SqlCommand(dateListQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    game_dateList.Add(((DateTime)dataReader.GetValue(0)).ToLongDateString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return game_dateList;
        }

        //public List<MTGame> GetGames()
        //{

        //}

        public static void AddPlayer(string player_name)
        {
            if (Player.IsUsernameValid(player_name))
            {
                SqlConnection cnn;
                cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));
                cnn.Open();
                string newPlayer = player_name;
                string newPlayerQuery = "INSERT INTO [Players] (player_name) VALUES ('" + player_name + "')";
                SqlCommand cmd = new SqlCommand(newPlayerQuery, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();    
            } else
            {
                MessageBox.Show("This name is invalid");
            }
        }
        public static void SaveGame(Game game, Player player1, Player player2, Player player3, Player player4, Player player5, Player player6)
        {
            //declaring sql variables to be used
            SqlConnection cnn;
            SqlDataReader player1idDataReader;
            SqlDataReader player2idDataReader;
            SqlDataReader player3idDataReader;
            SqlDataReader player4idDataReader;
            SqlDataReader player5idDataReader;
            SqlDataReader player6idDataReader;
            SqlDataReader gameIdDataReader;
            
            //using objects to declare variables to be used in queries
            string gameDate = game.startTime.ToString("yyyy'-'MM'-'dd'");
            
            string player1name = player1.name;
            string player2name = player2.name;
            string player3name = player3.name;
            string player4name = player4.name;
            string player5name = player5.name;
            string player6name = player6.name;
            
            int player1score = player1.ScoreTotal();
            int player2score = player2.ScoreTotal();
            int player3score = player3.ScoreTotal();
            int player4score = player4.ScoreTotal();
            int player5score = player5.ScoreTotal();
            int player6score = player6.ScoreTotal();
            
            //declaring variables to be populated by and used by queries
            string gameId = "";
            string player1id = "";
            string player2id = "";
            string player3id = "";
            string player4id = "";
            string player5id = "";
            string player6id = "";

            cnn = new SqlConnection(CnnHelper.CnnVal("GameMaster"));
            cnn.Open();
            
            //insert the game_date and retrieve the game_id
            string insertGameQuery = "insert into [Game Session] (game_date) values ('" + gameDate + "'); ";
            SqlCommand insertGameCmd = new SqlCommand(insertGameQuery, cnn);
            insertGameCmd.ExecuteNonQuery();

            string getGameIdQuery = "select game_id from [Game Session] where game_date = '" + gameDate + "';";
            SqlCommand getGameIdCmd = new SqlCommand(getGameIdQuery, cnn);
            gameIdDataReader = getGameIdCmd.ExecuteReader();
            while (gameIdDataReader.Read())
            {
                try
                {
                    gameId = gameIdDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //get the player1 id
            string getPlayer1id = "select player_ID from Players where player_name = '" + player1name + "';";
            SqlCommand getPlayer1idCmd = new SqlCommand (getPlayer1id, cnn);
            player1idDataReader = getPlayer1idCmd.ExecuteReader();
            while (player1idDataReader.Read()) 
            {
                try
                {
                    player1id = player1idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player1 score
            string insertPlayer1Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player1id + ", " + gameId + ");";
            SqlCommand insertPlayer1Cmd = new SqlCommand(insertPlayer1Score, cnn);
            insertPlayer1Cmd.ExecuteNonQuery();

            //get the player2 id
            string getPlayer2id = "select player_ID from Players where player_name = '" + player2name + "';";
            SqlCommand getPlayer2idCmd = new SqlCommand(getPlayer2id, cnn);
            player2idDataReader = getPlayer2idCmd.ExecuteReader();
            while (player2idDataReader.Read())
            {
                try
                {
                    player2id = player2idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player2 score
            string insertPlayer2Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player2id + ", " + gameId + ");";
            SqlCommand insertPlayer2Cmd = new SqlCommand(insertPlayer2Score, cnn);
            insertPlayer2Cmd.ExecuteNonQuery();

            //get the player3 id
            string getPlayer3id = "select player_ID from Players where player_name = '" + player3name + "';";
            SqlCommand getPlayer3idCmd = new SqlCommand(getPlayer3id, cnn);
            player3idDataReader = getPlayer3idCmd.ExecuteReader();
            while (player3idDataReader.Read())
            {
                try
                {
                    player3id = player3idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player3 score
            string insertPlayer3Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player3id + ", " + gameId + ");";
            SqlCommand insertPlayer3Cmd = new SqlCommand(insertPlayer3Score, cnn);
            insertPlayer3Cmd.ExecuteNonQuery();

            //get the player4 id
            string getPlayer4id = "select player_ID from Players where player_name = '" + player4name + "';";
            SqlCommand getPlayer4idCmd = new SqlCommand(getPlayer4id, cnn);
            player4idDataReader = getPlayer4idCmd.ExecuteReader();
            while (player4idDataReader.Read())
            {
                try
                {
                    player4id = player4idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player4 score
            string insertPlayer4Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player4id + ", " + gameId + ");";
            SqlCommand insertPlayer4Cmd = new SqlCommand(insertPlayer2Score, cnn);
            insertPlayer4Cmd.ExecuteNonQuery();

            //get the player5 id
            string getPlayer5id = "select player_ID from Players where player_name = '" + player5name + "';";
            SqlCommand getPlayer5idCmd = new SqlCommand(getPlayer5id, cnn);
            player5idDataReader = getPlayer5idCmd.ExecuteReader();
            while (player5idDataReader.Read())
            {
                try
                {
                    player5id = player5idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player5 score
            string insertPlayer5Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player5id + ", " + gameId + ");";
            SqlCommand insertPlayer5Cmd = new SqlCommand(insertPlayer5Score, cnn);
            insertPlayer5Cmd.ExecuteNonQuery();

            //get the player6 id
            string getPlayer6id = "select player_ID from Players where player_name = '" + player6name + "';";
            SqlCommand getPlayer6idCmd = new SqlCommand(getPlayer6id, cnn);
            player6idDataReader = getPlayer6idCmd.ExecuteReader();
            while (player6idDataReader.Read())
            {
                try
                {
                    player6id = player6idDataReader.GetString(0);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //insert player6 score
            string insertPlayer6Score = "insert into [Scoring1] (player_ID, game_ID) values (" + player6id + ", " + gameId + ");";
            SqlCommand insertPlayer6Cmd = new SqlCommand(insertPlayer6Score, cnn);
            insertPlayer6Cmd.ExecuteNonQuery();

            cnn.Close();
        }
    }
}
