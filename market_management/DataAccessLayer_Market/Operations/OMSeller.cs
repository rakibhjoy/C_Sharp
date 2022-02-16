using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;



namespace DataAccessLayer_Market.Operations
{
    public class OMSeller
    {
        
        
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            public int Add(EMSeller add)
            {
                // Con.Open();
                // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into sellerTable(SellerID, SellerName, SellerAge,SellerPhone) values('" + add.SellerID + "','" + add.SellerName + "','" + add.SellerAge + "','" + add.SellerPhone + "')", Con);
                int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
            public SqlDataAdapter Show()
            {
                Con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from sellerTable", Con);
                return sqlDataAdapter;
            }
            public int Edit(EMSeller edit)
            {
                // Con.Open();
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
                //SqlCommand cmd = new SqlCommand("Update CategoryTbl set Catd=' " + edit.CatId + "'CatDesc ='" + edit.CatQuantity  + "'CatName ='" + edit.CatName + "'", Con);
                //SqlCommand cmd = new SqlCommand ("Update CategoryTbl set CatName='" + edit.CatName + "',CatDesc='" + edit.CatQuantity + "' where Catd=" + edit.CatId + "'",Con);//
                SqlCommand cmd = new SqlCommand("UPDATE sellerTable SET SellerName ='" + edit.SellerName + "',  SellerAge ='" + edit.SellerAge + "',SellerPhone= '" + edit.SellerPhone  + "' WHERE SellerID ='" + edit.SellerID + "';", Con);

                int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
            public int Delete(EMSeller dlt)
            {
                // Con.Open();
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE sellerTable WHERE SellerID ='" + dlt.SellerID +"'", Con);
                int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
        }

    }

