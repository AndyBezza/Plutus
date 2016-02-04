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
    public partial class AddPurchase : Form
    {
        DataAccessManager _dam;

        public AddPurchase(DataAccessManager dam)
        {
            InitializeComponent();

            _dam = dam;

            SetInitialValues(); 
        }

        private void SetInitialValues()
        {
            this.Size = new Size(361, 409);
            currencyComboBox.SelectedIndex = (int) Currency.GBP;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            step2GroupBox.Left = step1GroupBox.Left;

            //foreach (Account x in _dam.accounts)
            //{
            //    if (x.)
            //}
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            step2GroupBox.Left = step1GroupBox.Left + step1GroupBox.Width + 10; 
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            originalPriceCurrencyNumericUpDown.DisplayCurrency = (Currency)currencyComboBox.SelectedIndex;
            effectivePriceCurrencyNumericUpDown.DisplayCurrency = (Currency)currencyComboBox.SelectedIndex; 
        }

        private void purchaseDescriptionChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = (quickDescriptionTextBox.Text != "");
        }
    }
}
