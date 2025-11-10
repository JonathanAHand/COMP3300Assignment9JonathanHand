namespace COMP3300Assignment9JonathanHand.Model
{
    /// <summary>
    /// Represents a generic bank account that stores common account information 
    /// such as owner name, balance, month opened, account type, and monthly interest rate.
    /// Serves as the base class for all specific account types (Checking, Savings, and Money Market).
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Gets or sets the name of the account owner.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public double CurrentBalance { get; set; }

        /// <summary>
        /// Gets or sets the month in which the account was opened.
        /// </summary>
        public string MonthOpened { get; set; }

        /// <summary>
        /// Gets or sets the type of bank account (e.g., Savings, Checking, Money Market).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the monthly interest rate associated with the account.
        /// </summary>
        public double MonthlyInterestRate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BankAccount"/> class
        /// with the specified account details.
        /// </summary>
        /// <param name="ownerName">The name of the account holder.</param>
        /// <param name="currentBalance">The current balance of the account.</param>
        /// <param name="monthOpened">The month the account was opened.</param>
        /// <param name="type">The type of account.</param>
        /// <param name="monthlyInterestRate">The monthly interest rate applied to the account.</param>
        public BankAccount(string ownerName, double currentBalance, string monthOpened, string type, double monthlyInterestRate)
        {
            OwnerName = ownerName;
            CurrentBalance = currentBalance;
            MonthOpened = monthOpened;
            Type = type;
            MonthlyInterestRate = monthlyInterestRate;
        }

        /// <summary>
        /// Calculates the minimum balance fee for the account.
        /// A 7.3% fee is applied if the current balance is below $1,200.00.
        /// </summary>
        /// <returns>The calculated minimum balance fee, or 0.0 if no fee applies.</returns>
        public virtual double CalculateMinimumBalanceFee()
        {
            if (CurrentBalance < 1200.00)
            {
                return CurrentBalance * 0.073;
            }
            return 0.0;
        }

        /// <summary>
        /// Returns a formatted string containing the key details of the account,
        /// including owner name, balance, month opened, and interest rate.
        /// </summary>
        /// <returns>A string representation of the account details.</returns>
        public virtual string ToStringData()
        {
            return $"Name: {OwnerName}, Balance: {CurrentBalance}, Month Opened: {MonthOpened}, Monthly Interest Rate: {MonthlyInterestRate}";
        }
    }
}