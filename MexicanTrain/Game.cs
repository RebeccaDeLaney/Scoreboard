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
        public int Rounds { get; set; }
        public List<Player> Players { get; set; }
        public DateTime StartTime { get; set; }
        
        public Game(string gameName, int rounds, List<Player> players, DateTime startTime) 
        {
            GameName = gameName;
            Rounds = rounds;
            Players = players;
            StartTime = startTime;
        }
        //class Player
        //{
        //    public string name { get; set; }
        //    public int[] roundScores { get; set; }

        //    //A constructor method
        //    public Player(string name, int[] roundScores)
        //    {
        //        this.name = name;
        //        this.roundScores = roundScores;
        //    }


        //    //A method to tally the total score from a player's array of scores by iterating through the array and adding them together
        //    public int ScoreTotal()
        //    {
        //        int total = 0;
        //        for (int i = 0; i < roundScores.Length; i++)
        //        {
        //            total = total + roundScores[i];
        //        }
        //        return total;
        //    }

        //    //A method to tally the player's highest scoring round by iterating through the array and choosing the higher as you go through
        //    public int HighestRound()
        //    {
        //        int highestRound = 0;
        //        int highestScore = 0;

        //        for (int i = 0; i < roundScores.Length; i++)
        //        {
        //            if (roundScores[i] > highestScore)
        //            {
        //                highestRound = i;
        //            }
        //        }
        //        return highestRound;
        //    }

        //    //A method to tally the player's lowest scoring round by iterating through the array and choosing the lower as you go through
        //    public int LowestRound()
        //    {
        //        int lowestRound = 0;
        //        int lowestScore = roundScores[0];

        //        for (int i = 0; i < roundScores.Length; i++)
        //        {
        //            if (roundScores[i] < lowestScore)
        //            {
        //                lowestRound = i;
        //            }
        //        }
        //        return lowestRound;
        //    }

        //    //A method to calculate the player's average score using the ScoreTotal method and the # of rounds based on the length of the array
        //    public int AverageRoundScore()
        //    {
        //        int averageRound = ScoreTotal() / roundScores.Length;
        //        return averageRound;
        //    }

        //    //A method to validate user names
        //    public static bool IsUsernameValid(string username)
        //    {
        //        //Valid usernames must contain only alphanumeric characters and underscores
        //        string pattern = @"^[a-zA-Z0-9_]{3,20}$";
        //        return Regex.IsMatch(pattern, username);
        //    }
        //}
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
