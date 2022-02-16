using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Market.Entities
{
  public   class EMCategory
    {
        private string catId;
        private string catName;
        private string catQuantity;
  

        public string CatId { get; set; }
        public string CatName { get; set; }
        public string CatQuantity { get; set; }
       
    }
}
