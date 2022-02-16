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

namespace FinalProject
{
    public partial class CitizenList : Form
    {
        public CitizenList()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-5HVBVLO\MSSQLSERVER01;Initial Catalog=People management system;Integrated Security=True");

        private void btnShow_Click(object sender, EventArgs e)
        {
                try
                {
                    sc.Open();
                    SqlCommand sme = new SqlCommand("Select * from CitizenDetails order by Address", sc);
                    SqlDataAdapter sd1 = new SqlDataAdapter(sme);
                    DataSet dt = new DataSet();
                    sd1.Fill(dt);
                    dataGridView1.DataSource = dt.Tables[0];
                    dataGridView1.Columns[0].Width = 150;
                    dataGridView1.Columns[0].HeaderText = "    Name   ";
                    sc.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage h6 = new HomePage();
            this.Hide();
            h6.Show();
        }
    }
}
