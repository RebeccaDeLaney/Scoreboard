using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MexicanTrain
{
    public partial class MTPreviousGames : Form
    {
        public MTPreviousGames()
        {
            InitializeComponent();
            List<string> gameList = new List<string>();
            gameList = DB.DateList();
            gameDateComboBox.DataSource = gameList;
        }

        private void gameDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gameDate = gameDateComboBox.SelectedValue.ToString();
            gameDateLabel.Text = "Game Date: " + gameDate;
            string winner = DB.GetWinner(gameDate);
            winnerLabel.Text = "Winner: " + winner;
            List<string> playerList = new List<string>();
            playerList = DB.GetPlayerListFromGame(gameDate);
            string[] playerArray = playerList.ToArray();
            if (playerArray.Length >= 1) { player1label.Text = playerArray[0]; } else { player1label.Text = " "; }
            if (playerArray.Length >= 2) { player2label.Text = playerArray[1]; } else { player2label.Text = " "; }
            if (playerArray.Length >= 3) { player3label.Text = playerArray[2]; } else { player3label.Text = " "; }
            if (playerArray.Length >= 4) { player4label.Text = playerArray[3]; } else { player4label.Text = " "; }
            if (playerArray.Length >= 5) { player5label.Text = playerArray[4]; } else { player5label.Text = " "; }
            if (playerArray.Length >= 6) { player6label.Text = playerArray[5]; } else { player6label.Text = " "; }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
