using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Plutus.DAL;
using Plutus.CustomClasses;
using Plutus.CustomControls; 

namespace Plutus.GUI
{
    public partial class AddPurchase : Form
    {
        DataAccessManager _dam;
        List<Account> _availableAccounts;
        
        CurrencyNumericUpDown[] _currencyNumericUpDowns;
        Label[] _accountNames;

        public AddPurchase(DataAccessManager dam)
        {
            InitializeComponent();

            _dam = dam;

            SetInitialValues(); 
        }

        private void SetInitialValues()
        {
            this.Size = new Size(361, 409);
            originalCurrencyComboBox.SelectedIndex = (int)Currency.GBP;
            effectiveCurrencyComboBox.SelectedIndex = (int)Currency.GBP;

            originalPriceCurrencyNumericUpDown.Select(0, 10); 
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _availableAccounts = _dam.FindAccountsByCurrency((Currency)effectiveCurrencyComboBox.SelectedIndex, false);
            
            if (_availableAccounts.Count == 0)
            {
                MessageBox.Show("No active accounts for the selected currency could be found. \r\n\r\n" + "Please set up a new account using the selected currency, or" +
                                   " reactivate an existing account of this currency. \r\n\r\nAlternatively, select a different currency for this transaction.",
                                   "Plutus: No accounts found");
                return;
            }

            step2GroupBox.Left = step1GroupBox.Left;

            _currencyNumericUpDowns = new CurrencyNumericUpDown[_availableAccounts.Count];
            _accountNames = new Label[_availableAccounts.Count];

            int verticalMargin = 20;
            int verticalOffset = 210; 
            int horizontalMargin = 20;
            int horizontalOffset = 100;

            for (int i = 0; i < _availableAccounts.Count; i++)
            {
                _accountNames[i] = new Label();
                _accountNames[i].Text = _availableAccounts[i]._name;

                _currencyNumericUpDowns[i] = new CurrencyNumericUpDown();
                _currencyNumericUpDowns[i].DisplayCurrency = (Currency)effectiveCurrencyComboBox.SelectedIndex;

                availableAccountsPanel.Controls.Add(_accountNames[i]);
                _accountNames[i].Top = (i * verticalOffset) + verticalMargin;
                _accountNames[i].Left = horizontalMargin;

                availableAccountsPanel.Controls.Add(_currencyNumericUpDowns[i]);
                _currencyNumericUpDowns[i].Top = (i * verticalOffset) + verticalMargin;
                _currencyNumericUpDowns[i].Left = horizontalOffset + horizontalMargin; 
            }            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            step2GroupBox.Left = step1GroupBox.Left + step1GroupBox.Width + 10; 
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalPriceCurrencyNumericUpDown.DisplayCurrency = (Currency)originalCurrencyComboBox.SelectedIndex;
            effectivePriceCurrencyNumericUpDown.DisplayCurrency = (Currency)effectiveCurrencyComboBox.SelectedIndex; 
        }

        private void purchaseDescriptionChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = (quickDescriptionTextBox.Text != "");
        }

        private void doneButton_Click(object sender, EventArgs e)
        {

        }
    }
}
