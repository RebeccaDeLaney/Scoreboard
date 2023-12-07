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
    public partial class MTGame : Form
    {
        public MTGame()
        {
            InitializeComponent();
            List<string> player1list = new List<string>();
            player1list = DB.GetPlayers();
            List<string> player2list = new List<string>();
            player2list = DB.GetPlayers();
            List<string> player3list = new List<string>();
            player3list = DB.GetPlayers();
            List<string> player4list = new List<string>();
            player4list = DB.GetPlayers();
            List<string> player5list = new List<string>();
            player5list = DB.GetPlayers();
            List<string> player6list = new List<string>();
            player6list = DB.GetPlayers();
            player1comboBox.DataSource = player1list;
            player2comboBox.DataSource = player2list;
            player3comboBox.DataSource = player3list;
            player4comboBox.DataSource = player4list;
            player5comboBox.DataSource = player5list;
            player6comboBox.DataSource = player6list;
                       
        }

        public Player player1 { get; set; }
        public Player player2 { get; set; }
        public Player player3 { get; set; }
        public Player player4 { get; set; }
        public Player player5 { get; set; }
        public Player player6 { get; set; }
        private void player1comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1.name = player1comboBox.SelectedText;
        }
        private void player2comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player2.name = player2comboBox.SelectedText;
        }
        private void player3comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player3.name = player3comboBox.SelectedText;
        }
        private void player4comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player4.name = player4comboBox.SelectedText;
        }
        private void player5comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player5.name = player5comboBox.SelectedText;
        }
        private void player6comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            player6.name = player6comboBox.SelectedText;
        }

        public void player1round12_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[12] = Int32.Parse(player1round12.Text);
        }

        public void player1round11_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[11] = Int32.Parse(player1round11.Text);
        }
        public void player1round10_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[10] = Int32.Parse(player1round10.Text);
        }
        public void player1round9_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[9] = Int32.Parse(player1round9.Text);
        }
        public void player1round8_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[8] = Int32.Parse(player1round8.Text);
        }
        public void player1round7_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[7] = Int32.Parse(player1round7.Text);
        }
        public void player1round6_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[6] = Int32.Parse(player1round6.Text);
        }
        public void player1round5_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[5] = Int32.Parse(player1round5.Text);
        }
        public void player1round4_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[4] = Int32.Parse(player1round4.Text);
        }
        public void player1round3_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[3] = Int32.Parse(player1round3.Text);
        }
        public void player1round2_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[2] = Int32.Parse(player1round2.Text);
        }
        public void player1round1_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[1] = Int32.Parse(player1round1.Text);
        }
        public void player1round0_TextChanged(object sender, EventArgs e)
        {
            player1.roundScores[0] = Int32.Parse(player1round0.Text);
        }
        public void player2round12_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[12] = Int32.Parse(player2round12.Text);
        }
        public void player2round11_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[11] = Int32.Parse(player2round11.Text);
        }
        public void player2round10_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[10] = Int32.Parse(player2round10.Text);
        }
        public void player2round9_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[9] = Int32.Parse(player2round9.Text);
        }
        public void player2round8_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[8] = Int32.Parse(player2round8.Text);
        }
        public void player2round7_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[7] = Int32.Parse(player2round7.Text);
        }
        public void player2round6_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[6] = Int32.Parse(player2round6.Text);
        }
        public void player2round5_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[5] = Int32.Parse(player2round5.Text);
        }
        public void player2round4_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[4] = Int32.Parse(player2round4.Text);
        }
        public void player2round3_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[3] = Int32.Parse(player2round3.Text);
        }
        public void player2round2_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[2] = Int32.Parse(player2round2.Text);
        }
        public void player2round1_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[1] = Int32.Parse(player2round1.Text);
        }
        public void player2round0_TextChanged(object sender, EventArgs e)
        {
            player2.roundScores[0] = Int32.Parse(player2round0.Text);
        }
        public void player3round12_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[12] = Int32.Parse(player3round12.Text);
        }
        public void player3round11_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[11] = Int32.Parse(player3round11.Text);
        }
        public void player3round10_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[10] = Int32.Parse(player3round10.Text);
        }
        public void player3round9_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[9] = Int32.Parse(player3round9.Text);
        }
        public void player3round8_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[8] = Int32.Parse(player3round8.Text);
        }
        public void player3round7_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[7] = Int32.Parse(player3round7.Text);
        }
        public void player3round6_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[6] = Int32.Parse(player3round6.Text);
        }
        public void player3round5_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[5] = Int32.Parse(player3round5.Text);
        }
        public void player3round4_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[4] = Int32.Parse(player3round4.Text);
        }
        public void player3round3_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[3] = Int32.Parse(player3round3.Text);
        }
        public void player3round2_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[2] = Int32.Parse(player3round2.Text);
        }
        public void player3round1_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[1] = Int32.Parse(player3round1.Text);
        }
        public void player3round0_TextChanged(object sender, EventArgs e)
        {
            player3.roundScores[0] = Int32.Parse(player3round0.Text);
        }
        public void player4round12_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[12] = Int32.Parse(player4round12.Text);
        }
        public void player4round11_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[11] = Int32.Parse(player4round11.Text);
        }
        public void player4round10_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[10] = Int32.Parse(player4round10.Text);
        }
        public void player4round9_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[9] = Int32.Parse(player4round9.Text);
        }
        public void player4round8_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[8] = Int32.Parse(player4round8.Text);
        }
        public void player4round7_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[7] = Int32.Parse(player4round7.Text);
        }
        public void player4round6_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[6] = Int32.Parse(player4round6.Text);
        }
        public void player4round5_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[5] = Int32.Parse(player4round5.Text);
        }
        public void player4round4_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[4] = Int32.Parse(player4round4.Text);
        }
        public void player4round3_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[3] = Int32.Parse(player4round3.Text);
        }
        public void player4round2_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[2] = Int32.Parse(player4round2.Text);
        }
        public void player4round1_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[1] = Int32.Parse(player4round1.Text);
        }
        public void player4round0_TextChanged(object sender, EventArgs e)
        {
            player4.roundScores[0] = Int32.Parse(player4round0.Text);
        }
        public void player5round12_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[12] = Int32.Parse(player5round12.Text);
        }
        public void player5round11_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[11] = Int32.Parse(player5round11.Text);
        }
        public void player5round10_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[10] = Int32.Parse(player5round10.Text);
        }
        public void player5round9_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[9] = Int32.Parse(player5round9.Text);
        }
        public void player5round8_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[8] = Int32.Parse(player5round8.Text);
        }
        public void player5round7_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[7] = Int32.Parse(player5round7.Text);
        }
        public void player5round6_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[6] = Int32.Parse(player5round6.Text);
        }
        public void player5round5_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[5] = Int32.Parse(player5round5.Text);
        }
        public void player5round4_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[4] = Int32.Parse(player5round4.Text);
        }
        public void player5round3_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[3] = Int32.Parse(player5round3.Text);
        }
        public void player5round2_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[2] = Int32.Parse(player5round2.Text);
        }
        public void player5round1_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[1] = Int32.Parse(player5round1.Text);
        }
        public void player5round0_TextChanged(object sender, EventArgs e)
        {
            player5.roundScores[0] = Int32.Parse(player5round0.Text);
        }
        public void player6round12_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[12] = Int32.Parse(player6round12.Text);
        }
        public void player6round11_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[11] = Int32.Parse(player6round11.Text);
        }
        public void player6round10_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[10] = Int32.Parse(player6round10.Text);
        }
        public void player6round9_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[9] = Int32.Parse(player6round9.Text);
        }
        public void player6round8_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[8] = Int32.Parse(player6round8.Text);
        }
        public void player6round7_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[7] = Int32.Parse(player6round7.Text);
        }
        public void player6round6_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[6] = Int32.Parse(player6round6.Text);
        }
        public void player6round5_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[5] = Int32.Parse(player6round5.Text);
        }
        public void player6round4_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[4] = Int32.Parse(player6round4.Text);
        }
        public void player6round3_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[3] = Int32.Parse(player6round3.Text);
        }
        public void player6round2_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[2] = Int32.Parse(player6round2.Text);
        }
        public void player6round1_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[1] = Int32.Parse(player6round1.Text);
        }
        public void player6round0_TextChanged(object sender, EventArgs e)
        {
            player6.roundScores[0] = Int32.Parse(player6round0.Text);
        }
        private void totalButton_Click(object sender, EventArgs e)
        {
            player1total.Text = (player1.ScoreTotal()).ToString();
            player2total.Text = (player2.ScoreTotal()).ToString();
            player3total.Text = (player3.ScoreTotal()).ToString();
            player4total.Text = (player4.ScoreTotal()).ToString();
            player5total.Text = (player5.ScoreTotal()).ToString();
            player6total.Text = (player6.ScoreTotal()).ToString();

            if ((player1.roundScores[0] != 0) || 
                (player2.roundScores[0] != 0) || 
                (player3.roundScores[0] != 0) || 
                (player4.roundScores[0] != 0) || 
                (player5.roundScores[0] != 0) || 
                (player6.roundScores[0] != 0))
            {
                List<Player> playerList = new List<Player>();
                playerList.Add(player1);
                playerList.Add(player2);
                playerList.Add(player3);
                playerList.Add(player4);
                playerList.Add(player5);
                playerList.Add(player6);

                Player winner = Game.DetermineWinner(playerList);

                winnerLabel.Text = "Winner : " + winner.name;
                winnerLabel.Visible = true;
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();            
        }

        private void previousGamesButton_Click(object sender, EventArgs e)
        {
            MTPreviousGames previousGamesForm = new MTPreviousGames();
            previousGamesForm.Show();            
        }

        private void playersButton_Click(object sender, EventArgs e)
        {
            //open player screen
            PlayersForm newPlayersForm = new PlayersForm();
            newPlayersForm.Show();
        }
    }
}
