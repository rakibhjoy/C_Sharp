using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer_Market.Operations;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;

namespace Market_Management
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerForm sel = new SellerForm();
            sel.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EMCategory Catentity = new EMCategory();
            OMCategory OMC = new OMCategory();

            Catentity.CatId = MCIDtxt.Text;
            Catentity.CatName = MCNAMEtxt.Text;
           Catentity.CatQuantity = MCNAMEtx.Text;

            int flag= OMC.Add(Catentity);
            //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully inserted");
            }
            else 
            {
                MessageBox.Show("Not Inserted ");
            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OMCategory OMC = new OMCategory();
            SqlDataAdapter sqlDataAdapter = OMC.Show();
            //OMCategory.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            CATDGV.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EMCategory Catentity = new EMCategory();
            OMCategory OMC = new OMCategory();
            Catentity.CatId = MCIDtxt.Text;
            Catentity.CatName = MCNAMEtxt.Text;
            Catentity.CatQuantity = MCNAMEtx.Text;

            int flag = OMC.Edit(Catentity);
            //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Edited");
            }
            else
            {
                MessageBox.Show("You dont put value to edit ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMCategory Catentity = new EMCategory();
            OMCategory OMC = new OMCategory();
            Catentity.CatId = MCIDtxt.Text;
            Catentity.CatName = MCNAMEtxt.Text;
            Catentity.CatQuantity = MCNAMEtx.Text;

            int flag = OMC.Delete(Catentity);
            //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully delete");
            }
            else
            {
                MessageBox.Show("You dont put value to delete ");
            }

        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {

        }

        private void CATDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CATDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
