using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Admin:Person,AdminUser
    {
        Branch[] ad = new Branch[400];
        Staff[] st = new Staff[400];


        public void AddBranch(Branch Ab)
        {
            int flag = 0;
            for (int i = 0; i <ad.Length; i++)
            {
                if (ad[i] == null)
                {
                    ad[i] = Ab;
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("___ Branch  Added___");
                Console.Write("Branch Name : " +Ab.BName);
                Console.Write(",Id : " +Ab.BId);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("___Can't Branch  Added___");
            }

        }
        public void Addstff(Staff Adds)
        {
            int flag = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == null)
                {
                    st[i] = Adds;
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("__Add Staff__");
                Console.Write("Staff Name : " +Adds.Name);
                Console.Write(",Id : " + Adds.Id);
                Console.Write(",Job : " + Adds.Job+"\n");
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("Can't add Staff");
            }

        }

        public bool ModifyBranch()
        {
            if (true)
            {
                Console.WriteLine("Branch has been modify");
            }
            return true;

        }
        
    }
}
