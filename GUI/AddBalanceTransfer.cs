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
    public partial class AddBalanceTransfer : Form
    {
        DataAccessManager _dam;
        List<Account> _availableAccounts;
        Currency savedCurrency;
        bool first = true;

        Graphics g;

        public AddBalanceTransfer(DataAccessManager dam)
        {
            InitializeComponent();

            _dam = dam;

            SetInitialValues(); 
        }

        private void SetInitialValues()
        {
            _availableAccounts = _dam.ActiveAccounts;
            foreach (Account acc in _availableAccounts)
            {
                fromAccountComboBox.Items.Add(acc._name);
            }

            fromAccountComboBox.SelectedIndex = 0;
        }

        private void fromAccountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            String selectedAccountName = fromAccountComboBox.Items[fromAccountComboBox.SelectedIndex].ToString();
            Currency selectedAccountCurrency = _dam.FindAccountByName(selectedAccountName)._currency;

            toAccountComboBox.Items.Clear();
            toAccountComboBox.Text = "n/a";
            
            if ((first)||(selectedAccountCurrency != savedCurrency))
            {
                quickDescriptionTextBox.Text = "";
                additionalInfoTextBox.Text = "";
                valueCurrencyNumericUpDown.Value = 0M;
            }

            first = false;
            savedCurrency = selectedAccountCurrency;

            foreach (Account acc in _dam.FindAccountsByCurrency(selectedAccountCurrency, false))
            {
                if (acc._name.CompareTo(selectedAccountName) != 0)
                {
                    toAccountComboBox.Items.Add(acc._name);
                }
            }

            doneButton.Enabled = toAccountComboBox.Enabled = quickDescriptionTextBox.Enabled = additionalInfoTextBox.Enabled = toAccountComboBox.Items.Count > 0;
            if (toAccountComboBox.Items.Count > 0)
            {
                toAccountComboBox.SelectedIndex = 0;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            List<AccountChange> accountChanges = new List<AccountChange>(); 

            accountChanges.Add(new AccountChange(_dam.FindAccountByName(fromAccountComboBox.Items[fromAccountComboBox.SelectedIndex].ToString())._iD,valueCurrencyNumericUpDown.Value * -1));
            accountChanges.Add(new AccountChange(_dam.FindAccountByName(toAccountComboBox.Items[toAccountComboBox.SelectedIndex].ToString())._iD, valueCurrencyNumericUpDown.Value));

            int id = _dam.CreateNewPurchase(valueCurrencyNumericUpDown.Value, savedCurrency, valueCurrencyNumericUpDown.Value, savedCurrency, quickDescriptionTextBox.Text, additionalInfoTextBox.Text, false, accountChanges);

            MessageBox.Show("Balance transfer recorded successfully with ID: " + id.ToString(),
                                   "Plutus: Balance Transfer Recorded");

            Close(); 
        }
    }
}
