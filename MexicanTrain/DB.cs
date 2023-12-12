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
            dataReader= cmd.ExecuteReader();
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
                cnn.Close();    
            } else
            {
                MessageBox.Show("This name is invalid");
            }
        }
        public static void SaveGame(Game game, Player player1, Player player2, Player player3, Player player4, Player player5, Player player6)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMaster"));
            cnn.Open();
            DateTime gameDate = game.startTime;
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
            string insertGameQuery = "insert into [Game Session] (game_date) values ('" + gameDate + "');";
            SqlCommand cmd = new SqlCommand(insertGameQuery, cnn);
            //string insertPlayer1Score = "intsert into [Scoring1] values ";
            //SqlCommand cmd2 = new SqlCommand(insertPlayer1Score, cnn);
            cnn.Close();
        }
    }
}
