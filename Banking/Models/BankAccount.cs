using System;
using System.Collections.Generic;

namespace Banking.Models
{
    class BankAccount
    {
        #region fields
        private readonly IList<Transaction> _transactions = new List<Transaction>();
        #endregion

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = Decimal.Zero;
        }

        public string AccountNumber { get; }

        public decimal Balance { get; set; }

        public int NumberOfTransactions => _transactions.Count;

        public void Deposit(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            Balance += amount;
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            if (from == null && till == null) return _transactions;
            if (from is null) from = DateTime.MinValue;
            if (!till.HasValue) till = DateTime.MaxValue;

            IList<Transaction> transFiltered = new List<Transaction>();
            foreach(Transaction t in _transactions)
            {
                if(t.DateOfTrans >= from && t.DateOfTrans <= till)
                {
                    transFiltered.Add(t);
                }
            }
            return transFiltered;
        }

        public void Withdraw(decimal amount)
        {
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            Balance -= amount;
        }
    }
}
