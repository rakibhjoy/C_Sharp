using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Operations;
namespace DataAccessLayer_Market.Entities
{
   public  class EMForm1
    {
        private string userPhone;
        private string userName;
        private string userPass;
        private string userCategory;
        public string UserPhone { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserCategory { get; set; }
    }
}
