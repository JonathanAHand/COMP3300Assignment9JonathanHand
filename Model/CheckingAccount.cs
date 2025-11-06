using System;

namespace COMP3300Assignment9JonathanHand.Model
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        public override double CalculateMinimumBalanceFee()
        {
            return CurrentBalance < 1200.00 ? 10.00 : 0.00;
        }

        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}