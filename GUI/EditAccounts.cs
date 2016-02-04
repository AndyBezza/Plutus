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

namespace Plutus.GUI
{
    public partial class EditAccounts : Form
    {
        DataAccessManager _dam;
        bool _finishedLoadingAccount = false;
        bool _unsavedChanges = false;

        public EditAccounts(DataAccessManager dam)
        {
            InitializeComponent();

            _dam = dam;

            DisplayAccounts(false);
        }

        public void DisplayAccounts(object sender, EventArgs e)
        {
            DisplayAccounts(false);
        }

        private void DisableDetailsBox()
        {
            detailsGroupBox.Enabled = false;
            _finishedLoadingAccount = false;
            accountsListBox.ClearSelected(); 

            idTextBox.Text = "n/a";
            creationDateTextBox.Text = "n/a";
            activeCheckBox.CheckState = CheckState.Indeterminate;
            nameTextBox.Text = "n/a";
            descriptionTextBox.Text = "n/a";
            cashCheckBox.CheckState = CheckState.Indeterminate;
            startingBalanceCurrencyNumericUpDown.Value = 0M;
            startingBalanceCurrencyNumericUpDown.DisplayCurrency = Currency.GBP;
            creditLimitNumericUpDown.Value = 0M;
            creditLimitNumericUpDown.DisplayCurrency = Currency.GBP;
            currencyComboBox.Text = "n/a";
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewAccountMenuItem_Click(object sender, EventArgs e)
        {
            _dam.CreateNewAccount();
            DisplayAccounts(false);
        }

        private void PerformSave(object sender, EventArgs e)
        {
            _dam.SaveAccounts();
            _unsavedChanges = false;
        }

        private void EditAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_unsavedChanges)
            {
                DialogResult result = MessageBox.Show("Do you wish to save the changes made to your accounts?",
                                                        "Plutus: Unsaved Account Changes",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PerformSave(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else //result == DialogResult.No
                {
                    //donothing
                }
            }
        }

        private void accountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountsListBox.SelectedIndex != -1)
            { 
                SelectedAccount(accountsListBox.Items[accountsListBox.SelectedIndex].ToString()); 
            }
        }

        private void SelectedAccount(string selectedAccountName)
        {
            _finishedLoadingAccount = false;

            foreach (Account acc in _dam.accounts)
            {
                if (acc._name.CompareTo(selectedAccountName) == 0)
                {
                    detailsGroupBox.Enabled = true;

                    idTextBox.Text = acc._iD.ToString();
                    creationDateTextBox.Text = acc._creationDateTime.ToString();
                    activeCheckBox.Checked = acc._isActive;
                    activeCheckBox.CheckState = acc._isActive ? CheckState.Checked : CheckState.Unchecked;
                    nameTextBox.Text = acc._name;
                    descriptionTextBox.Text = acc._description;
                    cashCheckBox.Checked = acc._isCash;
                    cashCheckBox.CheckState = acc._isCash ? CheckState.Checked : CheckState.Unchecked;
                    startingBalanceCurrencyNumericUpDown.Value = acc._startingBalance;
                    startingBalanceCurrencyNumericUpDown.DisplayCurrency = acc._currency;
                    creditLimitNumericUpDown.Value = acc._isCash ? 0.0M : acc._creditLimit;
                    creditLimitNumericUpDown.Enabled = !acc._isCash;
                    creditLimitNumericUpDown.DisplayCurrency = acc._currency;

                    currencyComboBox.SelectedIndex = (int)acc._currency;

                    nameTextBox.Focus();
                    nameTextBox.SelectionStart = nameTextBox.Text.Length;

                    _finishedLoadingAccount = true;
                }
            }
        }

        private void ChangeMadeToDetail(object sender, EventArgs e)
        {
            if (_finishedLoadingAccount)
            {
                Account acc = _dam.FindAccountByName(accountsListBox.Items[accountsListBox.SelectedIndex].ToString());
                if (acc != null)
                {
                    acc._description = descriptionTextBox.Text;
                    acc._startingBalance = startingBalanceCurrencyNumericUpDown.Value;
                    acc._creditLimit = creditLimitNumericUpDown.Value;
                    acc._currency = (Currency)currencyComboBox.SelectedIndex;
                    startingBalanceCurrencyNumericUpDown.DisplayCurrency = acc._currency;
                    creditLimitNumericUpDown.DisplayCurrency = acc._currency; 

                    _unsavedChanges = true;
                }
            }
        }

        private void DisplayAccounts(bool assigningIndexElsewhere)
        {
            accountsListBox.Items.Clear();

            foreach (Account acc in _dam.accounts)
            {
                if (ShowInactiveAccountsMenuItem.Checked || acc._isActive)
                {
                    accountsListBox.Items.Add(acc._name);
                    accountsListBox.SetItemColor(accountsListBox.Items.Count - 1, acc._isActive ? Color.Black : Color.Red);                  
                }
            }

            if (accountsListBox.Items.Count > 0)
            {
                detailsGroupBox.Enabled = true;
                if (!assigningIndexElsewhere)
                {
                    accountsListBox.SelectedIndex = 0;
                }
            }
            else
            {
                DisableDetailsBox();
            }
        }

        private void ChangeMadeToName(object sender, EventArgs e)
        {
            if (_finishedLoadingAccount)
            {
                if (_dam.FindAccountByName(nameTextBox.Text) == null)
                {
                    Account acc = _dam.FindAccountByName(accountsListBox.Items[accountsListBox.SelectedIndex].ToString());
                    if (acc != null)
                    {
                        acc._name = nameTextBox.Text;

                        _unsavedChanges = true;

                        DisplayAccounts(accountsListBox.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Duplicate account name '" + nameTextBox.Text + "' found, added '1' to avoid clash", "Plutus: Duplicate Account Name");                    
                    nameTextBox.Text = nameTextBox.Text + "1";
                }
            }
        }

        private void DisplayAccounts(int selectedIndex)
        {
            DisplayAccounts(true);
            accountsListBox.SelectedIndex = selectedIndex;
            nameTextBox.Focus();
            nameTextBox.SelectionStart = nameTextBox.Text.Length;
        }

        private void ChangeMadeToActive(object sender, EventArgs e)
        {
            if (_finishedLoadingAccount)
            {
                Account acc = _dam.FindAccountByName(accountsListBox.Items[accountsListBox.SelectedIndex].ToString());

                if (acc != null)
                {
                    acc._isActive = activeCheckBox.Checked;

                    _unsavedChanges = true;

                    if (!acc._isActive && !ShowInactiveAccountsMenuItem.Checked)
                    {
                        DisplayAccounts(false);
                    }
                    else
                    {
                        DisplayAccounts(accountsListBox.SelectedIndex);      
                    }
                }
            }
        }

        private void ChangeMadeToIsCash(object sender, EventArgs e)
        {
            if (_finishedLoadingAccount)
            {
                Account acc = _dam.FindAccountByName(accountsListBox.Items[accountsListBox.SelectedIndex].ToString());

                if (acc != null)
                {
                    acc._isCash = cashCheckBox.Checked;
                    creditLimitNumericUpDown.Value = acc._isCash ? 0.0M : acc._creditLimit;
                    creditLimitNumericUpDown.Enabled = !acc._isCash;

                    _unsavedChanges = true;
                }
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            _dam.SaveAccounts(); 
        }
    }
}
