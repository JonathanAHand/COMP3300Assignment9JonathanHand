using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using COMP3300Assignment9JonathanHand.Model;

namespace COMP3300Assignment9JonathanHand.Utility
{
    public class JsonAccountReader
    {
        public AccountsResult LoadFromFile(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                List<BankAccount> allAccounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonString, options);

                var result = new AccountsResult();

                if (allAccounts != null)
                {
                    foreach (var account in allAccounts)
                    {
                        string type = account.Type?.ToLower();

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
