using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;


namespace DataAccessLayer_Market.Operations
{
   public  class OMProduct
    {
        
       SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Add(EMProduct add)
        { 
            Con.Open();
            
            SqlCommand cmd = new SqlCommand("Insert into ProductTable(ProdID,ProdName,ProdPrice,ProdQuantity,ProdCategoy) values('" + add.ProdId + "','" + add.ProdName + "','" + add.ProdPrice + "','" + add.ProdQuantity + "','" + add.ProdCategory + "')", Con);

            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public SqlDataAdapter Show()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from ProductTable", Con);
            return sqlDataAdapter;
        }
        
        public int Edit(EMProduct edit)
        {
            // Con.Open();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();

            //SqlCommand cmd = new SqlCommand("UPDATE ProductTable SET ProdName ='" + edit.ProdName + "', ProdQuantity ='" + edit.ProdQuantity + "',ProdPrice= '" + edit.ProdPrice + "',ProdCategory= '" + edit.ProdCategory + "' WHERE ProdID ='" + edit.ProdId + "';", Con); 
            SqlCommand cmd = new SqlCommand("UPDATE ProductTable SET ProdName ='" + edit.ProdName + "', ProdQuantity ='" + edit.ProdQuantity + "',ProdPrice= '" + edit.ProdPrice + " '  WHERE ProdID ='" + edit.ProdId + "';", Con);

            // SqlCommand cmd = new SqlCommand ("UPDATE CategoryTbl SET CatName ='" +edit.CatName +"',  CatDesc ='"+ edit.CatQuantity+ "' WHERE Catd ='" +edit.CatId  +"';", Con);  

            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public int Delete(EMProduct dlt)
        {
            // Con.Open();
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE ProductTable  WHERE ProdID ='" + dlt.ProdId + "';", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
    }
}

