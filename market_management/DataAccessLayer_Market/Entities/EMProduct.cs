using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Market.Entities
{
   public  class EMProduct
    {
        private string prodId;
        private string prodName;
        private string prodQuantity;
        private string prodPrice;
        private string prodCategory;

        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdQuantity { get; set; }
        public string ProdPrice { get; set; }
        public string ProdCategory { get; set; }
    }
}
