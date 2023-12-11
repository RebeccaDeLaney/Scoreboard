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
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
            List<string> playerList = new List<string>();
                playerList = DB.GetPlayers();
                plyaersComboBox.DataSource = playerList;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            if(newPlayerName.Text != "New Player Name")
            {
                DB.AddPlayer(newPlayerName.Text);
                MessageBox.Show("New player is saved.", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
