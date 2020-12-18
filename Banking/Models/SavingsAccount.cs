using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class SavingsAccount: BankAccount
    {
        protected const decimal WithdrawCost = 0.25M;

        public decimal InterestRate { get; }

        public SavingsAccount(string bankAccountNumber, decimal interestRate):base(bankAccountNumber)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
            
        }

        
    }
}
