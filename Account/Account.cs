using System;


namespace Account
{
    class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account()
        {

        }
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
            if (amount > 0)
            {

                Console.WriteLine("BEFORE DEPOSITE balance : " + balance);
                
                balance = balance + amount;
                Console.WriteLine("DEPOSITE AMOUNT : " + amount);
                Console.WriteLine("AFTER balance : " + balance);
            }
            
        }

        

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
               
                balance = balance - amount;
                Console.WriteLine("WITHDRAW AMOUNT : " + amount);
                Console.WriteLine("AFTER WITHDRAW  : " + balance);

            }
            
        }
        
        public string AccName { get; set; }
        public string Aid{ get; set; }
        public int Balance { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("ACCOUNT NAME  : " + GetAccountName());
            Console.WriteLine("ACCOUNT ID : " + GetAccountId());
            Console.WriteLine("ACCOUNT BALANCE : " + GetBalance());

           
        }
        public void transfer(int amount, Account a)
        {
            if (balance <= amount)
            {
                Console.WriteLine("Can not be Transfered");
            }
            else
            {
                Console.WriteLine("previous balance :  " + balance);
                balance = balance - amount;
                a.balance = a.balance + amount;
                Console.WriteLine("  "+amount + " taka Transferred ");
                Console.WriteLine("Current Balance :  " + GetBalance());
                Console.WriteLine("  ");
                
            }
        }
        
        static void Main(string[] args)
        {
            Account A1 = new Account();
            A1.SetAccountName("koko");
            A1.SetAccountId("1234");
            A1.SetBalance(200000);
            //A1.ShowInfo();
            Account A2 = new Account("jack", "1888", 400000);
            A1.ShowInfo();
            A2.ShowInfo();
            

            A1.transfer(2000, A2);
            A1.Deposite(5000);
            A1.Withdraw(30000);
            A1.ShowInfo();
            Console.WriteLine("  ");
            A2.Deposite(10000);
            A2.Withdraw(5000);
            //A2.transfer(2000, A1);
            A2.ShowInfo();
            
            Console.WriteLine(" \n ");

            Account A3 = new Account();
            A3.AccName = "titi";
            A3.Aid = "3232";
            A3.Balance = 3009;
            Console.WriteLine("name:"+A3.AccName );
            Console.WriteLine("ID:"+A3.Aid );
            Console.WriteLine("Balance:"+A3.Balance );
            A3.Deposite(7000);
            A3.Withdraw(6000);
            
           
            Console.ReadKey();
        }

    }
}
