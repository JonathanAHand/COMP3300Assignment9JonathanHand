using COMP3300Assignment9JonathanHand.Model;
using COMP3300Assignment9JonathanHand.Utility;

namespace COMP3300Assignment9JonathanHand.View
{
    /// <summary>
    /// The MainForm class provides the user interface for displaying and managing
    /// bank account data. It allows the user to load data from a JSON file and 
    /// display account information by type (Savings, Checking, Money Market), 
    /// or view all accounts combined.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Holds the collection of loaded bank account data separated by account type.
        /// </summary>
        private AccountsResult _accounts = new();

        /// <summary>
        /// Initializes a new instance of the MainForm class and sets up the GUI components.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the ListBox display area and refreshes the control to ensure the
        /// contents are fully cleared from the screen.
        /// </summary>
        private void btnClearField_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Refresh();
        }

        /// <summary>
        /// Loads account data from the JSON file using JsonAccountReader.
        /// Displays a message to confirm successful loading or to report an error.
        /// </summary> 
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            try
            {
                var reader = new JsonAccountReader();
                _accounts = reader.LoadFromFile("Account-Data.json");
                MessageBox.Show("Accounts loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load accounts.\n{ex.Message}", "Load Error");
                _accounts = new AccountsResult();
            }
        }

        /// <summary>
        /// Displays all SavingsAccount objects in the ListBox.
        /// Prompts the user to load data first if accounts are not available.
        /// </summary>
        private void btnShowSavings_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.Savings);
        }

        /// <summary>
        /// Displays all CheckingAccount objects in the ListBox.
        /// Prompts the user to load data first if accounts are not available.
        /// </summary>
        private void btnShowChecking_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.Checking);
        }

        /// <summary>
        /// Displays all MoneyMarketAccount objects in the ListBox.
        /// Prompts the user to load data first if accounts are not available.
        /// </summary>
        private void btnShowMoneyMarket_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.MoneyMarket);
        }

        /// <summary>
        /// Displays all accounts of every type (Savings, Checking, and Money Market)
        /// sorted alphabetically by owner name.
        /// </summary>
        private void btnShowAllAccounts_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }

            var allAccounts = new List<BankAccount>();
            allAccounts.AddRange(_accounts.Savings);
            allAccounts.AddRange(_accounts.Checking);
            allAccounts.AddRange(_accounts.MoneyMarket);

            var sortedAccounts = allAccounts.OrderBy(a => a.OwnerName);

            DisplayAccounts(sortedAccounts);
        }

        /// <summary>
        /// Handles the form load event. Currently unused, but reserved
        /// for any setup or initialization logic needed when the form loads.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event data for the load event.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Displays the string data for a provided list of BankAccount objects 
        /// within the ListBox. Used by all display buttons to show formatted output.
        /// </summary>
        /// <typeparam name="T">A derived class of BankAccount (Savings, Checking, or MoneyMarket).</typeparam>
        /// <param name="accounts">The collection of accounts to display.</param>
        private void DisplayAccounts<T>(IEnumerable<T> accounts) where T : BankAccount
        {
            lstDisplay.Items.Clear();

            if (accounts == null)
            {
                lstDisplay.Items.Add("No accounts to display.");
                return;
            }

            foreach (var acct in accounts)
            {
                lstDisplay.Items.Add(acct.ToStringData());
            }
        }
    }
}
