using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingsAccount:Account
    {
        public SavingsAccount() { }
        public SavingsAccount(string no, string name, double balance) : base(no, name, balance) { }

        public void override Withdraw(double amount)
        {
            if (Balance - amount>= 500)
            {
                Balance -= amount;
            }
        }
    }
}
