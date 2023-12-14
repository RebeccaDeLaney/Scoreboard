using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                    game_dateList.Add(((DateTime)dataReader.GetValue(0)).ToString("yyyy'-'MM'-'dd"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return game_dateList;
        }

        public static string GetWinner(string gameDate)
        {
            SqlConnection cnn;
            SqlDataReader dataReader;

            string winner = "unknown";

            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));
            cnn.Open();

            
            string getWinnerQuery = "select Players.player_name from Scoring1 " +
                "left join Players on Scoring1.player_ID=Players.player_ID " +
                "left join [Game Session] on Scoring1.game_ID=[Game Session].game_ID " +
                "where dbo.Scoring1.score in " +
                "((select MIN(score) from Scoring1 left join [Game Session] on Scoring1.game_ID=[Game Session].game_ID where [Game Session].game_date='" + gameDate + "'))" +
                " and [Game Session].game_date='" + gameDate + "'";
            SqlCommand getWinnerCmd = new SqlCommand(getWinnerQuery, cnn);
            dataReader = getWinnerCmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    winner = dataReader.GetValue(0).ToString();
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message); 
                }
            }
            cnn.Close();  
            
            return winner;
        }

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
            SqlDataReader gameIdDataReader;
            
            //using objects to declare variables to be used in queries
            string gameDate = game.startTime.ToString("yyyy'-'MM'-'dd");
            
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

            //insert the game_date and retrieve the game_id
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));
            cnn.Open();
                        
            string insertGameQuery = "insert into [Game Session] (game_date) values ('" + gameDate + "'); ";
            SqlCommand insertGameCmd = new SqlCommand(insertGameQuery, cnn);
            insertGameCmd.ExecuteNonQuery();
            cnn.Close();

            cnn.Open();
            string getGameIdQuery = "select game_id from [Game Session] where game_date = '" + gameDate + "';";
            SqlCommand getGameIdCmd = new SqlCommand(getGameIdQuery, cnn);
            gameIdDataReader = getGameIdCmd.ExecuteReader();
            while (gameIdDataReader.Read())
            {
                try
                {
                    gameId = gameIdDataReader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();

            //get the player1 id
            string player1id = GetPlayerIdFromName(player1name);
                        
            //insert player1 score
            cnn.Open();
            string insertPlayer1Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player1id + ", " + player1score + ", " + gameId + ");";
            SqlCommand insertPlayer1Cmd = new SqlCommand(insertPlayer1Score, cnn);
            insertPlayer1Cmd.ExecuteNonQuery();
            cnn.Close(); 
            
            //get the player2 id
            string player2id = GetPlayerIdFromName(player2name);
            
            
            //insert player2 score
            cnn.Open();
            string insertPlayer2Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player2id + ", " + player2score + ", " + gameId + ");";
            SqlCommand insertPlayer2Cmd = new SqlCommand(insertPlayer2Score, cnn);
            insertPlayer2Cmd.ExecuteNonQuery();
            cnn.Close();

            //get the player3 id
            string player3id = GetPlayerIdFromName(player3name);

            //insert player3 score
            cnn.Open ();
            string insertPlayer3Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player3id + ", " + player3score + ", " + gameId + ");";
            SqlCommand insertPlayer3Cmd = new SqlCommand(insertPlayer3Score, cnn);
            insertPlayer3Cmd.ExecuteNonQuery();
            cnn.Close ();

            //get the player4 id
            string player4id = GetPlayerIdFromName(player4name);

            //insert player4 score
            cnn.Open();
            string insertPlayer4Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player4id + ", " + player4score + ", " + gameId + ");";
            SqlCommand insertPlayer4Cmd = new SqlCommand(insertPlayer4Score, cnn);
            insertPlayer4Cmd.ExecuteNonQuery();
            cnn.Close();

            //get the player5 id
            string player5id = GetPlayerIdFromName(player5name);
            
            //insert player5 score
            cnn.Open();
            string insertPlayer5Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player5id + ", " + player5score + ", " + gameId + ");";
            SqlCommand insertPlayer5Cmd = new SqlCommand(insertPlayer5Score, cnn);
            insertPlayer5Cmd.ExecuteNonQuery();
            cnn.Close();

            //get the player6 id
            string player6id = GetPlayerIdFromName(player6name);

            //insert player6 score
            cnn.Open();
            string insertPlayer6Score = "insert into [Scoring1] (player_ID, score, game_ID) values (" + player6id + ", " + player6score + ", " + gameId + ");";
            SqlCommand insertPlayer6Cmd = new SqlCommand(insertPlayer6Score, cnn);
            insertPlayer6Cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static string GetPlayerNameFromId(string id)
        {
            string playerName = "";

            SqlConnection cnn;
            SqlDataReader dataReader;

            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));

            cnn.Open();
            string getPlayerNameQuery = "select player_name from Players where player_ID = " + id + ";";
            SqlCommand getPlayerNameCmd = new SqlCommand(getPlayerNameQuery, cnn);
            dataReader = getPlayerNameCmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    playerName = dataReader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();

            return playerName;
        }

        public static string GetPlayerIdFromName(string name)
        {
            string playerId = "";

            SqlConnection cnn;
            SqlDataReader dataReader;

            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters"));

            cnn.Open();
            string getPlayerNameQuery = "select player_ID from Players where player_name = '" + name + "';";
            SqlCommand getPlayerNameCmd = new SqlCommand(getPlayerNameQuery, cnn);
            dataReader = getPlayerNameCmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    playerId = dataReader.GetValue(0).ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();


            return playerId;
        }
    }
}
