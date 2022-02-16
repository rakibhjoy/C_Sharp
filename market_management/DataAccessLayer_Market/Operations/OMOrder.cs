using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;

namespace DataAccessLayer_Market.Operations
{
  
    public class OMOrder
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Order(EMOreder add)
        {
            Con.Open();  
            SqlCommand cmd = new SqlCommand("Insert into ORDERTbl(Product_id,Prduct_name,Product_quantity,Product_price,Product_category) values('" + add.Product_id + "','" + add.Prduct_name + "','" + add.Product_quantity + "','" + add.Product_price +"','"+add.Product_category + "')", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
        public SqlDataAdapter Show()
        {
            Con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select ProdID,ProdName,ProdPrice from ProductTable", Con);
            return sqlDataAdapter;
        }
    }

}

