using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Market.Entities
{
    public class EMSelling
    {

        private string bill_no;
        private int sell_Quantity;
        private string sell_date;
        private string prod_name;
        private  double  price;
        private double total_Amount;

        public string Bill_no { get; set; }
        public int Sell_Quantity { get; set; }
        public string Sell_date { get; set; }
        public string Prod_name { get; set; }
        public double Prod_Price { get; set; }
        public double Total_Amount { get ; set ; }
        

    }
}
