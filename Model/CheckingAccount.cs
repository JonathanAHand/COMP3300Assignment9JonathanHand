namespace COMP3300Assignment9JonathanHand.Model
{
    /// <summary>
    /// Represents a checking account that inherits from the <see cref="BankAccount"/> base class.
    /// Provides specific behavior for calculating minimum balance fees and formatting account data.
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the CheckingAccount class.
        /// </summary>
        /// <param name="ownerName">The name of the account holder.</param>
        /// <param name="currentBalance">The current balance of the checking account.</param>
        /// <param name="monthOpened">The month the account was opened.</param>
        /// <param name="type">The type of account (in this case, "checking").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate applied to the account.</param>
        public CheckingAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculates the minimum balance fee for the checking account.
        /// A flat fee of $10.00 is applied if the current balance is below $1,200.00.
        /// </summary>
        public override double CalculateMinimumBalanceFee()
        {
            return CurrentBalance < 1200.00 ? 10.00 : 0.00;
        }

        /// <summary>
        /// Returns a formatted string that includes the account type and inherited account data.
        /// </summary>
        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}