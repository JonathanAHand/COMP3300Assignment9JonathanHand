using System;

namespace COMP3300Assignment9JonathanHand.Model
{
    public class MoneyMarketAccount : BankAccount
    {
        public MoneyMarketAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        public override double CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200.00)
            {
                return CurrentBalance * 0.05;
            }
            return 0.0;
        }

        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}