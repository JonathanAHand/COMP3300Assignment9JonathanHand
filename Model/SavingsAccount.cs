using System;

namespace COMP3300Assignment9JonathanHand.Model
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        public override double CalculateMinimumBalanceFee()
        {
            double fee = base.CalculateMinimumBalanceFee();

            if (CurrentBalance < 500.00)
            {
                fee += 5.00;
            }
            return fee;
        }

        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}