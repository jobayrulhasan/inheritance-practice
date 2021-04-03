using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sav = new SavingAccount();
            sav.CustomerName = "Hamidur Rahman";
            sav.AccountNo = "SV-0123";
            sav.Interest = 500.33;
            sav.Deposit(1000.23);
            sav.Withdraw(200.15);
            double balance = sav.Balance;
            CeckingAccount seack = new CeckingAccount();
            seack.CustomerName = "Masudur Rahman";
            seack.AccountNo = "Current-456";
            seack.ServiceCharge = 50.33;
            seack.Deposit(800.12);
            seack.Withdraw(560.22);
            double balance1 = seack.Balance;
            Console.WriteLine("Saving account balance: {0}",balance);
            Console.WriteLine("Cecking account balance: {0}", balance1);
            Console.ReadKey();
        }
    }
}
