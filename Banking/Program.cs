using Banking.Models;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankapp = new BankAccount("123-abc") { Balance = 200M };
            Console.WriteLine(bankapp.Balance);
            bankapp.Deposit(500M);
            Console.WriteLine(bankapp.Balance);
        }
    }
}
