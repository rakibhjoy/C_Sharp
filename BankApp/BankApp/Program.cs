using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new CurrentAccount("1234", "Alim", 1000);
            Account acc2 = new SavingsAccount("12345", "Jamil", 20000);
            DateTime accd = DateTime.Parse("2015-08-12");
            Account acc3 = new TermDepositAccount("12356", "Rahman", 20000,5,accd);

            acc.Withdraw(950);
            acc.Show();
            Console.WriteLine(*------------------*);
            acc2.Withdraw(19600);
            acc2.Show();
            Console.WriteLine(*------------------*);
            acc3.Withdraw(19600);
            acc3.Show();
            Console.WriteLine(*------------------*);
        }
    }
}
