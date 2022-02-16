using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    class Mobile
    {
        string mobileOwnerName;
        string mobileNumber;
        int mobileBalance;
        string mobileOsName;
        bool Lock ;
        public Mobile() { }
        public Mobile(string mobileOwnerName, string mobileNumber, int mobileBalance, string mobileOsName, bool Lock)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.mobileBalance = mobileBalance;
            this.mobileOsName = mobileOsName;
            this.Lock = Lock;
        }
        public void setMobileOwnerName(string mobileOwnerName)
        {
            this.mobileOwnerName = mobileOwnerName;
        }
        public void setMobileNumber(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }
        public void setMobileBalance(int mobileBalance)
        {
            this.mobileBalance = mobileBalance;
        }
        public void setMobileOsName(string mobileOsName)
        {
            this.mobileOsName = mobileOsName;
        }
        public void setLock(bool Lock)
        {
            this.Lock = Lock;
        }
        public string getMobileOwnerName()
        {
            return mobileOwnerName;
        }
        public string getMobileNumber()
        {
            return mobileNumber;
        }
        public int getMobileBalance()
        {
            return mobileBalance;
        }
        public string getMobileOsName()
        {
            return mobileOsName;
        }
        public void ShowInfo()
        {
            Console.WriteLine("MobileOwnerName :" + getMobileOwnerName());
            Console.WriteLine("MobileNumber :" + getMobileNumber());
            Console.WriteLine("MobileBalance:" + getMobileBalance());
            Console.WriteLine("MobileOsName:" + getMobileOsName());
           
        }
        public string MobileOwnerName { get; set; }
        public string MobileNumber { get; set; }
        public int MobileBalance { get; set; }
        public string MobileOsName { get; set; }

        public void Recharge(int amount)
        {
            if(this.Lock)
            {
                Console.WriteLine("Lock,Can't call,recharge");

            }
            else
            {
                
                Console.WriteLine("Phone is Unlock, you can call,recharge");
                mobileBalance = mobileBalance + amount;
                Console.WriteLine("recharge amount: " + amount);
                Console.WriteLine("After rechaege balance: " + mobileBalance);

            }
        }
        public void CallSomeone(int timeDuration)
        {
                           
                if (timeDuration >= 1)
                {
                    mobileBalance = mobileBalance - timeDuration;
                    Console.WriteLine("time " + timeDuration+" min");
                    Console.WriteLine("Balance "+mobileBalance);

                }
                else
                {
                    Console.WriteLine("Less then 1 min");
                }
        }

        static void Main(string[] args)
        {
            Mobile m1 = new Mobile("jhon","096512345678",40,"ff",false);
            m1.ShowInfo();
            m1.Recharge(43);
            m1.CallSomeone(4);
            Console.ReadKey();

            
        }
    }
}
