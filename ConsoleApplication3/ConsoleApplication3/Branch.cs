using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Branch
    {
        string bname;
        string id;
        

        public Branch() { }

        public Branch(string bname, string id)
        {
            this.bname = bname;
            this.id= id;

        }
        public string BName
        {
            set
            {
                this.bname = value;
            }
            get
            {
                return this.bname;
            }
        }
        public string BId
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
    }
}
