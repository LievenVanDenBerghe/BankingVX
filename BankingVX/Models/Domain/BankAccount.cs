using System;

namespace BankingVX.Models.Domain
{
    public class BankAccount
    {

        #region fields

        #endregion

        #region properties
        public string AccountNumber { get; }

        public decimal Balance { get; private set; }

        #endregion

        #region constructors
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
        }
        #endregion

        #region methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
