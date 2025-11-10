namespace COMP3300Assignment9JonathanHand.Model
{
    /// <summary>
    /// Represents a money market account that inherits from the <see cref="BankAccount"/> base class.
    /// Provides custom logic for calculating minimum balance fees specific to money market accounts.
    /// </summary>
    public class MoneyMarketAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoneyMarketAccount"/> class
        /// with the specified owner name, balance, month opened, account type, and interest rate.
        /// </summary>
        /// <param name="ownerName">The name of the account holder.</param>
        /// <param name="currentBalance">The current balance of the money market account.</param>
        /// <param name="monthOpened">The month the account was opened.</param>
        /// <param name="type">The type of account (in this case, "Money Market").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate applied to the account.</param>
        public MoneyMarketAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculates the minimum balance fee for the money market account.
        /// Applies a 5% fee on the current balance if it falls below $1,200.00.
        /// </summary>
        /// <returns>The calculated minimum balance fee, or 0.0 if the balance meets the threshold.</returns>
        public override double CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200.00)
            {
                return CurrentBalance * 0.05;
            }
            return 0.0;
        }

        /// <summary>
        /// Returns a formatted string containing the account type and inherited account details.
        /// </summary>
        /// <returns>A string representation of the money market account data.</returns>
        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}