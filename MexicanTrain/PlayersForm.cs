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

    }
}
