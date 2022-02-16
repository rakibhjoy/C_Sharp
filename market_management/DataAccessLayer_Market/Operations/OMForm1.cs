using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer_Market.Operations
{
    public class OMForm1
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Signup(EMForm1 signup) 
        
        {
            Con.Open();
            string customer = "CUSTOMER";
            SqlCommand cmd = new SqlCommand("Insert into Logintbl(UserPhone,UsreName,UserPass,UserCategory) values('" + signup.UserPhone + "','" + signup.UserName + "','" + signup.UserPass + "','"+ customer.ToString() +"')", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }

        //public void loginAdmin(EMForm1 lgina)
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("Select * form Logintbl where UserPhone='" + lgina.UserPhone +  "',UserPass='" + lgina.UserPass + "')", Con);
        //    int flag = cmd.ExecuteNonQuery();

        //    SqlDataAdapter sda = new SqlDataAdapter();

        //    Con.Close();
        //    //return flag;

        //}
        //public void loginseller(EMForm1 lgins)
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("Select * form Logintbl where UserPhone='" + lgins.UserPhone + "',UserPass='" + lgins.UserPass +  "')", Con);

        //    //int flag = cmd.ExecuteNonQuery();

        //    SqlDataAdapter sda = new SqlDataAdapter();

        //    Con.Close();
        //    //return flag;

        //}
        //public void logincustomer(EMForm1 lginc)
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("Select * form Logintbl where UserPhone='" + lginc.UserPhone + "',UserPass='" + lginc.UserPass +  "')", Con);
        //    int flag = cmd.ExecuteNonQuery();

        //     SqlDataAdapter sda = new SqlDataAdapter();
        //     Con.Close();
        //    //return flag;

        //}
    }
}
