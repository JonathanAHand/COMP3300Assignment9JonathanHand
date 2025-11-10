namespace COMP3300Assignment9JonathanHand.Model
{
    /// <summary>
    /// Represents a container that organizes all loaded bank accounts
    /// into separate collections based on account type.
    /// </summary>
    public class AccountsResult
    {
        /// <summary>
        /// Gets or sets the list of all <see cref="SavingsAccount"/> objects.
        /// </summary>
        public List<SavingsAccount> Savings { get; set; }

        /// <summary>
        /// Gets or sets the list of all <see cref="CheckingAccount"/> objects.
        /// </summary>
        public List<CheckingAccount> Checking { get; set; }

        /// <summary>
        /// Gets or sets the list of all <see cref="MoneyMarketAccount"/> objects.
        /// </summary>
        public List<MoneyMarketAccount> MoneyMarket { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsResult"/> class.
        /// Creates empty lists for each account type category.
        /// </summary>
        public AccountsResult()
        {
            Savings = [];
            Checking = [];
            MoneyMarket = [];

        }
    }
}