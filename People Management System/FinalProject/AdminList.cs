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
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=DESKTOP-5HVBVLO\MSSQLSERVER01;Initial Catalog=People management system;Integrated Security=True");

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Open();
                SqlCommand sme = new SqlCommand("Select EmployeeID,Name,DOB,Address,Email  from AdminDetails", sc);
                SqlDataAdapter sd1 = new SqlDataAdapter(sme);
                DataSet dt = new DataSet();
                sd1.Fill(dt);
                dataGridView1.DataSource = dt.Tables[0];
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[0].HeaderText = "Employee ID";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Employee Name";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Date Of Birth";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Address";
                dataGridView1.Columns[4].Width = 250;
                dataGridView1.Columns[4].HeaderText = "Email ID";
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
