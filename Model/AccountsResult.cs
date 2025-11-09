using System.Collections.Generic;

namespace COMP3300Assignment9JonathanHand.Model
{
    public class AccountsResult
    {
        public List<SavingsAccount> Savings { get; set; }
        public List<CheckingAccount> Checking { get; set; }
        public List<MoneyMarketAccount> MoneyMarket { get; set; }

        public AccountsResult()
        {
            Savings = new List<SavingsAccount>();
            Checking = new List<CheckingAccount>();
            MoneyMarket = new List<MoneyMarketAccount>();
        }
    }
}