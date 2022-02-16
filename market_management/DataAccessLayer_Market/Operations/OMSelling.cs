using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer_Market.Entities;
//using DataAccessLayer_Market.Entities;



namespace DataAccessLayer_Market.Operations
{
     public class OMSelling
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
         public int Add(EMSelling add)
         {
             
             Con.Open();
            double a = add.Prod_Price;
            double b = Convert.ToDouble(add.Sell_Quantity);
            add.Total_Amount = a * b;
             //SqlCommand cmd = new SqlCommand("Insert into BillTbl(Bill_no, Quantity, bill_date) values('" + add.Bill_no + "','" + add.Sell_Quantity + "','" + add.Sell_date + "')", Con);
              SqlCommand cmd = new SqlCommand("Insert into BillTbl (Bill_No, Product_Name,price,Sell_quantity,Total_Amount,Bill_date) values('" + add.Bill_no + "','" + add.Prod_name + "','" + add.Prod_Price + "','" + add.Sell_Quantity + "','" + (a*b) + "','" + add.Sell_date + "')", Con);

            int flag = cmd.ExecuteNonQuery();
             Con.Close();
             return flag;
         }

        public SqlDataAdapter Show()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProdName ,Prodprice  from ProductTable ", Con);
            return sqlDataAdapter;
        }
        public SqlDataAdapter ShowSelling()
        { EMSelling show = new EMSelling();
            Con.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProdName from ProductTable where ProdName='"+ show.Prod_name + "';", Con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Product_Name,Sell_quantity,price,Bill_date FROM BillTbl RIGHT JOIN ProductTable ON BillTbl. Product_Name = ProductTable.ProdName; ", Con);


            return sqlDataAdapter;
        }
        public SqlDataAdapter counting()
        {
            EMSelling show = new EMSelling();
            Con.Open();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProdName from ProductTable where ProdName='"+ show.Prod_name + "';", Con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT SUM(Total_Amount) FROM BillTbl; ", Con);


            return sqlDataAdapter;
        }
    }
}
