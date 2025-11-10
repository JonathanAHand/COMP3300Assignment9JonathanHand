using System.Text.Json;
using COMP3300Assignment9JonathanHand.Model;

namespace COMP3300Assignment9JonathanHand.Utility
{
    /// <summary>
    /// Provides functionality for reading and deserializing JSON account data
    /// from a file into structured <see cref="BankAccount"/> objects. 
    /// Converts each deserialized account into the appropriate derived type
    /// (Savings, Checking, or Money Market) and organizes them into an <see cref="AccountsResult"/> object.
    /// </summary>
    public class JsonAccountReader
    {
        /// <summary>
        /// Loads and parses account data from the specified JSON file.
        /// The method reads all account entries, determines their type,
        /// and populates categorized lists within an <see cref="AccountsResult"/> instance.
        /// </summary>
        /// <param name="filePath">The path to the JSON file containing account data.</param>
        /// <returns>
        /// An <see cref="AccountsResult"/> object containing lists of Savings, Checking,
        /// and Money Market accounts.
        /// </returns>
        /// <exception cref="Exception">
        /// Thrown if an error occurs while reading or deserializing the JSON file.
        /// </exception>
        public AccountsResult LoadFromFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<BankAccount>? allAccounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonString, options);

                var result = new AccountsResult();

                if (allAccounts != null)
                {
                    foreach (var account in allAccounts)
                    {
                        string type = account.Type.ToLower();

                        if (type == "savings")
                        {
                            result.Savings.Add(new SavingsAccount(
                                account.OwnerName,
                                account.CurrentBalance,
                                account.MonthOpened,
                                account.Type,
                                account.MonthlyInterestRate));
                        }
                        else if (type == "checking")
                        {
                            result.Checking.Add(new CheckingAccount(
                                account.OwnerName,
                                account.CurrentBalance,
                                account.MonthOpened,
                                account.Type,
                                account.MonthlyInterestRate));
                        }
                        else if (type == "money market")
                        {
                            result.MoneyMarket.Add(new MoneyMarketAccount(
                                account.OwnerName,
                                account.CurrentBalance,
                                account.MonthOpened,
                                account.Type,
                                account.MonthlyInterestRate));
                        }
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error reading JSON file: {ex.Message}");
            }
        }
    }
}
