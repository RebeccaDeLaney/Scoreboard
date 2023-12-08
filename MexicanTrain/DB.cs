using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

             public static List<string> DateList()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMasters3"));
            cnn.Open();
            List<string> game_date = new List<string>();

            string dateListQuery = "select game_session from GameSessions";
            SqlCommand cmd = new SqlCommand(dateListQuery, cnn);
            SqlDataReader reader= cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    game_dateList.Add((string)dataReader.GetValue(0));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                cnn.Close();
                return game_date;
            }

        }

        //public List<MTGame> GetGames()
        //{

        //}

        public static void SaveGame(Game game)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal("GameMaster"));
            cnn.Open();
            string gameDate = game.StartTime.ToLongDateString();
            string insertGameQuery = "insert into Session (game_date) values ('" + gameDate + "');";
            SqlCommand cmd = new SqlCommand(insertGameQuery, cnn);
            cnn.Close();
        }
    }
}
