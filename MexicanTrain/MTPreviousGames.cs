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

    }

}
