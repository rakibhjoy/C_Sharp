using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class TermDepositAccount : Account() { }
    {
    int tenureyear;
    DateTime creationTime;
        public TermDepositAccount() { }
        public TermDepositAccount(string no, string name, double balance, int year,DateTime ct)
        : base(no, name, balance)
    {
       this.tenureyear = tenureyear;
        creationTime = ct;
    }
    public override void Withdraw(double amount)
    {
        DateTime now = DateTime.Now;
        int c_year = now.Year;
        int acop_year = creationTime.Year;
        if (c_year= acop_year>= tenureyear)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("your acc is not matued");
        }
    }
    public override void show ()
    {
        base.Show();
        Console.WriteLine("tenure year:" + tenureyear);
    }
  }
}
