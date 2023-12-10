using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MexicanTrain
{
    public class Game
    {
        public string GameName { get; set; }
        //public int Rounds { get; set; }
        //public List<Player> Players { get; set; }
        public DateTime StartTime { get; set; }
        
        public Game(string gameName, DateTime startTime) 
        {
            GameName = gameName;
            StartTime = startTime;
        }
        
            public static Player DetermineWinner(List<Player> players)
        {
            //Determine the winner based on the lowest score
            //Assume the first player is the winner
            Player winner = players[0];

            //iterate through the list of players comparing scores to find the lowest

            foreach (Player player in players)
            {
                if (player.ScoreTotal() < winner.ScoreTotal())
                {
                    winner = player;
                }
            }

            return winner;
        }

        

    }

}
