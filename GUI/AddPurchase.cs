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
        
        Color colour1 = Color.LightSalmon;
        Color colour2 = Color.LightPink; 
        
        int verticalMargin = 0;
        int verticalOffset = 30;
        int horizontalMargin = 20;
        int horizontalOffset = 100;

        Graphics g;

        public AddPurchase(DataAccessManager dam)
        {
            InitializeComponent();

            _dam = dam;
            g = availableAccountsPanel.CreateGraphics();
            SetInitialValues(); 
        }

        private void SetInitialValues()
        {
            this.Size = new Size(361, 423);
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

/*
            int numberOfPaddingAccounts = 13;
            _currencyNumericUpDowns = new CurrencyNumericUpDown[_availableAccounts.Count + numberOfPaddingAccounts];
            _accountNames = new Label[_availableAccounts.Count + numberOfPaddingAccounts];

            for (int i = 0; i < numberOfPaddingAccounts; i++ )
            {
                _availableAccounts.Add(_availableAccounts[0]);
            }
*/

            for (int i = 0; i < _availableAccounts.Count; i++)
            {
                Brush backgroundBrush = (i % 2 == 0) ? new SolidBrush(colour1) : new SolidBrush(colour2);
                g.FillRectangle(backgroundBrush, new Rectangle(0, verticalMargin + (i * verticalOffset), availableAccountsPanel.Width, verticalOffset));

                _accountNames[i] = new Label();
                _accountNames[i].Text = _availableAccounts[i]._name;

                _currencyNumericUpDowns[i] = new CurrencyNumericUpDown();
                _currencyNumericUpDowns[i].DisplayCurrency = (Currency)effectiveCurrencyComboBox.SelectedIndex;

                availableAccountsPanel.Controls.Add(_accountNames[i]);
                _accountNames[i].Top = (int)(((i + 0.5) * verticalOffset) + verticalMargin - (int)(g.MeasureString(_accountNames[i].Text, _accountNames[i].Font).Height / 2));
                _accountNames[i].Height = (int)g.MeasureString(_accountNames[i].Text, _accountNames[i].Font).Height;
                _accountNames[i].BackColor = (i % 2 == 0) ? colour1 : colour2; 
                _accountNames[i].Left = horizontalMargin;

                availableAccountsPanel.Controls.Add(_currencyNumericUpDowns[i]);
                _currencyNumericUpDowns[i].Top = (int)(((i + 0.5) * verticalOffset) + verticalMargin - (_currencyNumericUpDowns[i].Height / 2));
                _currencyNumericUpDowns[i].Left = horizontalOffset + horizontalMargin;
                _currencyNumericUpDowns[i].ValueChanged += new System.EventHandler(this.changeMadeToAccountValue);
            }

            DrawAccountsRectangles();

            targetValueCurrencyNumericUpDown.DisplayCurrency = currentValueCurrencyNumericUpDown.DisplayCurrency = (Currency)effectiveCurrencyComboBox.SelectedIndex;
            targetValueCurrencyNumericUpDown.Value = effectivePriceCurrencyNumericUpDown.Value;

            changeMadeToAccountValue(this, null); 
        }

        private void DrawAccountsRectangles()
        {
            int yOffset = availableAccountsPanel.VerticalScroll.Value;

            g.FillRectangle(new SolidBrush(colour2), new Rectangle(0, -yOffset, availableAccountsPanel.Width, availableAccountsPanel.Height));
            for (int i = 0; i < _availableAccounts.Count; i++)
            {
                Brush backgroundBrush = (i % 2 == 0) ? new SolidBrush(colour1) : new SolidBrush(colour2);
                g.FillRectangle(backgroundBrush, new Rectangle(0, verticalMargin + (i * verticalOffset) - yOffset, availableAccountsPanel.Width, verticalOffset));
            }
            g.FillRectangle(_availableAccounts.Count % 2 == 0 ? new SolidBrush(colour1) : new SolidBrush(colour2), new Rectangle(0, verticalMargin + (_availableAccounts.Count * verticalOffset) - yOffset, availableAccountsPanel.Width, availableAccountsPanel.Height));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            step2GroupBox.Left = step1GroupBox.Left + step1GroupBox.Width + 10;
            availableAccountsPanel.Controls.Clear();
            availableAccountsPanel.Refresh(); 
            _availableAccounts.Clear();
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

        private void availableAccountsPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawAccountsRectangles();
        }

        private void changeMadeToAccountValue(object sender, EventArgs e)
        {
            decimal totalAccountedFor = 0.0M;
            for (int i = 0; i < _currencyNumericUpDowns.Count(); i++)
            {
                totalAccountedFor += _currencyNumericUpDowns[i].Value;
            }

            currentValueCurrencyNumericUpDown.Value = totalAccountedFor;

            currentValueCurrencyNumericUpDown.BackColor = targetValueCurrencyNumericUpDown.BackColor = (totalAccountedFor == targetValueCurrencyNumericUpDown.Value) ? Color.LightGreen : SystemColors.Window;

            doneButton.Enabled = (totalAccountedFor == targetValueCurrencyNumericUpDown.Value);
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            decimal     originalPrice = originalPriceCurrencyNumericUpDown.Value;
            Currency    originalCurrency = (Currency)originalCurrencyComboBox.SelectedIndex;
            decimal     effectivePrice = effectivePriceCurrencyNumericUpDown.Value;
            Currency    effectiveCurrency = (Currency)effectiveCurrencyComboBox.SelectedIndex;
            string      quickDescription = quickDescriptionTextBox.Text;
            string      additionalInformation = additionalInfoTextBox.Text;
            bool        spreadOverMonth = spreadOverMonthCheckBox.Checked; 
            
            List<AccountChange> accountChanges = new List<AccountChange>();
            for (int i = 0; i<_availableAccounts.Count(); i++)
            {
                accountChanges.Add(new AccountChange(_availableAccounts[i]._iD, _currencyNumericUpDowns[i].Value));
            }

            int id = _dam.CreateNewPurchase(originalPrice, originalCurrency, effectivePrice, effectiveCurrency, quickDescription, additionalInformation, spreadOverMonth, accountChanges);

            MessageBox.Show("Purchase created succesfully with ID: " + id.ToString(),
                                   "Plutus: Purchase Created");

            Close(); 
        }
    }
}
