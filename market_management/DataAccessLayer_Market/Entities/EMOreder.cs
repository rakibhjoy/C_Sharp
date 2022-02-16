using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Operations;


namespace DataAccessLayer_Market.Entities
{
   public  class EMOreder
    {
        private string product_name;
        private string product_id;
        private double product_quantity;
        private int product_price;
        private string product_category;

        public string Prduct_name { get; set; }
        public string Product_id { get; set; }
        public double Product_quantity { get; set; }
        public int Product_price { get; set; }
        public string Product_category { get; set; }
    }
}
