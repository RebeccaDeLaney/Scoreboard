using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MexicanTrain
{
    public partial class ConnectionTestForm : Form
    {
        public ConnectionTestForm()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            string testResults = TestResults();
            MessageBox.Show(testResults, "Tables of Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        public string TestResults()
        {
            string tableNames = "";
            SqlDataReader dataReader;

            SqlConnection cnn;
            cnn = new SqlConnection(CnnHelper.CnnVal(dbNameTB.Text));
            cnn.Open();

            string testQuery = "SELECT table_name FROM INFORMATION_SCHEMA.TABLES;";
            SqlCommand cmd = new SqlCommand(testQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    tableNames = tableNames + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tableNames;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
