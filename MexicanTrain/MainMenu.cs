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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void connectionTestForm_Click(object sender, EventArgs e)
        {
            // open connection test form
            ConnectionTestForm newConnTest = new ConnectionTestForm();
            newConnTest.Show();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //open new Game Form
            MTGame newGame = new MTGame();
            newGame.Show();
        }

        private void playersButton_Click(object sender, EventArgs e)
        {
            //open player screen
            PlayersForm newPlayers = new PlayersForm();
            newPlayers.Show();
        }

        private void previousGamesButton_Click(object sender, EventArgs e)
        {
            MTPreviousGames previousGamesForm = new MTPreviousGames();
            previousGamesForm.Show();
        }

    }
}
