using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer_Market.Entities;
using DataAccessLayer_Market.Operations;
using System.Data.SqlClient;


namespace Market_Management
{
    public partial class Form1 : Form
    {
        public OMForm1 OMF = new OMForm1();
        public EMForm1 EMF = new EMForm1();
        //Datatable dt = new Datatable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            //EMF.UserPhone = textID.Text;
            //EMF.UserPass = textPass.Text;
            //EMF.UserCategory = CatCB.SelectedItem.ToString();
          

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader dr;


            if (textID.Text != null && textPass.Text != null && (CatCB.SelectedItem.ToString())!= null)

            {
                try
                {

                    if (CatCB.SelectedItem.ToString() == "ADMIN")
                    {



                        string phone = Convert.ToString(textID.Text);
                        string password = Convert.ToString(textPass.Text);
                        if (phone == "1111")
                        {
                            if (password == "admin")
                            {
                                SellerForm sel = new SellerForm();
                                sel.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(" Password is incorrect");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This username is not registered");

                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("In valid your Info!!!!! \nTry again \n IF you are a new customer please log in" + ex);
                }
                try
                {
                    if (CatCB.SelectedItem.ToString() == "SELLER")
                    {


                        string phone = Convert.ToString(textID.Text);
                        string password = Convert.ToString(textPass.Text);

                        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K6R0H57;Initial Catalog=Database[Project];Integrated Security=True");
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("select * from Logintbl where  UserPhone='" + phone + "'and UserPass='" + password + "'", connection);


                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            SellingForm se = new SellingForm();
                            se.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Don't Create Account");

                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("In valid your Info!!!!! \nTry again \n IF you are a new customer please log in" + ex);
                }
                try
                {
                    if (CatCB.SelectedItem.ToString() == "CUSTOMER")
                    {

                        string phone = Convert.ToString(textID.Text);
                        string password = Convert.ToString(textPass.Text);

                        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-K6R0H57;Initial Catalog=Database[Project];Integrated Security=True");
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("select * from Logintbl where  UserPhone='" + phone + "'and UserPass='" + password + "'", connection);


                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            OrderForm or = new OrderForm();
                            or.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Don't Create Account");

                        }
                        connection.Close();




                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("In valid your Info!!!!! \nTry again \n IF you are a new customer please log in" + ex);
                }
            }
            else { MessageBox.Show("In valid your Info!!!!! \nTry again \n IF you are a new customer please log in" ); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUpForm sg = new SignUpForm();
            sg.Show();
            this.Hide();


        }
    }
}









