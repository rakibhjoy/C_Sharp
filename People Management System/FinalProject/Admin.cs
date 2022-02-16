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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-5HVBVLO\MSSQLSERVER01;Initial Catalog=People management system;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sc.Open();
            string query = "Select Count (*) from AdminTbl Where Username = '" + txtUser.Text.Trim() + "' and Password = '" + txtPass.Text.Trim() + "'";
            SqlDataAdapter sd = new SqlDataAdapter(query, sc);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            sc.Close();

            if (dt.Rows.Count == 1)
            {
                HomePage h3 = new HomePage();
                this.Hide();
                h3.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password!!");
            }

        }
    }
}
