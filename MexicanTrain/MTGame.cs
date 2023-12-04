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
            List<string> playerList = new List<string>();
            playerList = DB.GetPlayers();
            player1comboBox.DataSource = playerList;
            player2comboBox.DataSource = playerList;
            player3comboBox.DataSource = playerList;
            player4comboBox.DataSource = playerList;
            player5comboBox.DataSource = playerList;
            player6comboBox.DataSource = playerList;

            string player1name = "";
            int[] player1scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player1 = new Player(player1name, player1scores);

            string player2name = "";
            int[] player2scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player2 = new Player(player2name, player2scores);

            string player3name = "";
            int[] player3scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player3 = new Player(player3name, player3scores);

            string player4name = "";
            int[] player4scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player4 = new Player(player4name, player4scores);

            string player5name = "";
            int[] player5scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player5 = new Player(player5name, player5scores);

            string player6name = "";
            int[] player6scores = new int[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Player player6 = new Player(player6name, player6scores);
                        
        }

        

        private void totalButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
