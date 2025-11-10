namespace COMP3300Assignment9JonathanHand.Model
{
    /// <summary>
    /// Represents a savings account that inherits from the <see cref="BankAccount"/> base class.
    /// Provides custom logic for calculating minimum balance fees specific to savings accounts.
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavingsAccount"/> class
        /// with the specified owner name, balance, month opened, account type, and interest rate.
        /// </summary>
        /// <param name="ownerName">The name of the account holder.</param>
        /// <param name="currentBalance">The current balance of the savings account.</param>
        /// <param name="monthOpened">The month the account was opened.</param>
        /// <param name="type">The type of account (in this case, "Savings").</param>
        /// <param name="monthlyInterestRate">The monthly interest rate applied to the account.</param>
        public SavingsAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
            : base(ownerName, currentBalance, monthOpened, type, monthlyInterestRate)
        {
        }

        /// <summary>
        /// Calculates the minimum balance fee for the savings account.
        /// Applies the base class fee logic, and adds another $5.00 fee
        /// if the current balance falls below $500.00.
        /// </summary>
        public override double CalculateMinimumBalanceFee()
        {
            double fee = base.CalculateMinimumBalanceFee();

            if (CurrentBalance < 500.00)
            {
                fee += 5.00;
            }
            return fee;
        }

        /// <summary>
        /// Returns a formatted string containing the account type and inherited account details.
        /// </summary>
        /// <returns>A string representation of the savings account data.</returns>
        public override string ToStringData()
        {
            return $"Account Type: {Type}, " + base.ToStringData();
        }
    }
}