using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;


namespace DataAccessLayer_Market.Operations
{
   public  class OMCategory
    {
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Add(EMCategory add)
        {
           // Con.Open();
           // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into CategoryTbl(Catd, CatName, CatDesc) values('" + add.CatId+ "','" + add.CatName + "','" + add.CatQuantity +"')",Con); 
            int flag= cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public SqlDataAdapter Show() 
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from CategoryTbl", Con);
            return sqlDataAdapter;
        }
        public int Edit(EMCategory edit)
        {
            // Con.Open();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            //SqlCommand cmd = new SqlCommand("Update CategoryTbl set Catd=' " + edit.CatId + "'CatDesc ='" + edit.CatQuantity  + "'CatName ='" + edit.CatName + "'", Con);
            //SqlCommand cmd = new SqlCommand ("Update CategoryTbl set CatName='" + edit.CatName + "',CatDesc='" + edit.CatQuantity + "' where Catd=" + edit.CatId + "'",Con);//
             SqlCommand cmd = new SqlCommand ("UPDATE CategoryTbl SET CatName ='" +edit.CatName +"',  CatDesc ='"+ edit.CatQuantity+ "' WHERE Catd ='" +edit.CatId  +"';", Con);  
                 
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public int Delete (EMCategory dlt)
        {
            // Con.Open();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE CategoryTbl  WHERE Catd ='" + dlt.CatId + "';", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
    }
}
