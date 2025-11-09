using COMP3300Assignment9JonathanHand.Model;
using COMP3300Assignment9JonathanHand.Utility;

namespace COMP3300Assignment9JonathanHand
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private AccountsResult _accounts;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Refresh();
        }


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
                _accounts = null;
            }
        }

        private void btnShowSavings_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.Savings);
        }

        private void btnShowChecking_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.Checking);
        }

        private void btnShowMoneyMarket_Click(object sender, EventArgs e)
        {
            if (_accounts == null)
            {
                MessageBox.Show("Load the file first.");
                return;
            }
            DisplayAccounts(_accounts.MoneyMarket);
        }

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



        private void DisplayAccounts<T>(System.Collections.Generic.IEnumerable<T> accounts) where T : BankAccount
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
