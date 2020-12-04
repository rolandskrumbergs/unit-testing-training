using System;

namespace UnitTestingTraining
{
    public class MoneyManager
    {
        private readonly IAccountService _accounts;

        public MoneyManager(IAccountService accounts)
        {
            _accounts = accounts;
        }

        public void AddMoney(int userId, decimal money)
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(int userId, decimal money)
        {
            throw new NotImplementedException();
        }

        public decimal GetBalance(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
