using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    class Transaction
    {
        #region properties
        public decimal Amount { get; }
        public DateTime DateOfTrans { get;}
        public bool isDeposit => TransactionType == TransactionType.Deposit;
        public bool isWithdraw => TransactionType == TransactionType.Withdraw;
        public TransactionType TransactionType { get; }
        #endregion

        #region methods
        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Now;
        }
        #endregion
    }
}
