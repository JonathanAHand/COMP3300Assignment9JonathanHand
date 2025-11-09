namespace COMP3300Assignment9JonathanHand
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            btnShowSavings = new Button();
            btnShowChecking = new Button();
            btnShowMoneyMarket = new Button();
            btnClearField = new Button();
            lstDisplay = new ListBox();
            btnShowAllAccounts = new Button();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(49, 35);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(128, 47);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnShowSavings
            // 
            btnShowSavings.Location = new Point(49, 102);
            btnShowSavings.Name = "btnShowSavings";
            btnShowSavings.Size = new Size(128, 51);
            btnShowSavings.TabIndex = 1;
            btnShowSavings.Text = "Show Savings Account";
            btnShowSavings.UseVisualStyleBackColor = true;
            btnShowSavings.Click += btnShowSavings_Click;
            // 
            // btnShowChecking
            // 
            btnShowChecking.Location = new Point(49, 177);
            btnShowChecking.Name = "btnShowChecking";
            btnShowChecking.Size = new Size(128, 53);
            btnShowChecking.TabIndex = 2;
            btnShowChecking.Text = "Show Checking Accounts";
            btnShowChecking.UseVisualStyleBackColor = true;
            btnShowChecking.Click += btnShowChecking_Click;
            // 
            // btnShowMoneyMarket
            // 
            btnShowMoneyMarket.Location = new Point(49, 254);
            btnShowMoneyMarket.Name = "btnShowMoneyMarket";
            btnShowMoneyMarket.Size = new Size(128, 50);
            btnShowMoneyMarket.TabIndex = 3;
            btnShowMoneyMarket.Text = "Show Money Market Accounts";
            btnShowMoneyMarket.UseVisualStyleBackColor = true;
            btnShowMoneyMarket.Click += btnShowMoneyMarket_Click;
            // 
            // btnClearField
            // 
            btnClearField.Location = new Point(49, 397);
            btnClearField.Name = "btnClearField";
            btnClearField.Size = new Size(128, 29);
            btnClearField.TabIndex = 4;
            btnClearField.Text = "Clear Field";
            btnClearField.UseVisualStyleBackColor = true;
            btnClearField.Click += btnClearField_Click;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.HorizontalScrollbar = true;
            lstDisplay.IntegralHeight = false;
            lstDisplay.Location = new Point(245, 35);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(846, 384);
            lstDisplay.TabIndex = 5;
            // 
            // btnShowAllAccounts
            // 
            btnShowAllAccounts.Location = new Point(49, 328);
            btnShowAllAccounts.Name = "btnShowAllAccounts";
            btnShowAllAccounts.Size = new Size(128, 48);
            btnShowAllAccounts.TabIndex = 6;
            btnShowAllAccounts.Text = "Show All Accounts";
            btnShowAllAccounts.UseVisualStyleBackColor = true;
            btnShowAllAccounts.Click += btnShowAllAccounts_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 495);
            Controls.Add(btnShowAllAccounts);
            Controls.Add(lstDisplay);
            Controls.Add(btnClearField);
            Controls.Add(btnShowMoneyMarket);
            Controls.Add(btnShowChecking);
            Controls.Add(btnShowSavings);
            Controls.Add(btnLoadFile);
            Name = "MainForm";
            Text = "Assignment 9 by Hand";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadFile;
        private Button btnShowSavings;
        private Button btnShowChecking;
        private Button btnShowMoneyMarket;
        private Button btnClearField;
        private ListBox lstDisplay;
        private Button btnShowAllAccounts;
    }
}
