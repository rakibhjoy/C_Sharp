using System;

namespace Account
{
    class Account
    {
        private string accName;
        private string acid;
        private double balance;

        public Account(string accName, string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void SetAccountName(string accName)
        {
            this.accName = accName;
        }
        public void SetAccountId(string acid)
        {
            this.acid = acid;
        }
        public void SetBalance(int balance)
        {
            this.balance = balance;
        }
      
        public string GetAccountName()
        {
            return accName;
        }
        public string GetAccountId()
        {
            return acid;

        }
        public double GetBalance()
        {
            return balance;
        }


        public void Deposite(int amount)
        {
            Console.WriteLine("DEPOSITE AMOUNT : " + amount);
        }
        public string AccName { get; set; }
        public string Aid{ get; set; }
        public int Balance { get; set; }
        
        

        public void Withdraw(int amount)
        {
            Console.WriteLine("WITHDRAW AMOUNT : " + amount);
        }

        public void ShowInfo()
        {
            Console.WriteLine("ACCOUNT NAME  : " + GetAccountName());
            Console.WriteLine("ACCOUNT ID : " + GetAccountId());
            Console.WriteLine("ACCOUNT BALANCE : " + GetBalance());

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Account A1 = new Account("fatema", "6677", 5666900);
            
            A1.Deposite(7000);
            A1.Withdraw(60000);
            A1.ShowInfo();

            Account A2 = new Account("fatema", "6677", 5666900);

            A2.AccName = "C#";
            A2.Aid = "3232";
            A2.Balance = 3;
            Console.WriteLine(A2.AccName);
            Console.WriteLine(A2.Aid);
            Console.WriteLine(A2.Balance);
            A2.ShowInfo();
            Console.WriteLine("  ");
        }
       
    }
}
