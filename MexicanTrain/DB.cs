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

        //public static string GetWinnerFromDB
        
        //public List<MTGame> GetGames()
        //{

        //}

        public static void AddPlayer(string player_name)
        {
            if (Player.IsUsernameValid(player_name))
            {
                SqlConnection cnn;
                cnn = new SqlConnection(CnnHelper.CnnVal("GameMaster"));
                cnn.Open();
                cnn.Close();    
            } else
            {
                MessageBox.Show("This name is invalid");
            }
        }
        public static void SaveGame(Game game)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMaster"));
            cnn.Open();
            DateTime gameDate = game.StartTime;
            string insertGameQuery = "insert into Session (game_date) values ('" + gameDate + "');";
            SqlCommand cmd = new SqlCommand(insertGameQuery, cnn);
            cnn.Close();
        }
    }
}
