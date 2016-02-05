using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using Plutus.DAL;
using Plutus.CustomClasses;
using Plutus.GUI; 

namespace Plutus
{
    public partial class MainForm : Form
    {
        DataAccessManager _dam; 

        public MainForm(Decimal versionNumber)
        {
            InitializeComponent();
            Text = String.Format("Plutus (v{0})", versionNumber.ToString());

            _dam = new DataAccessManager(); //also loads all data from .XML files
        }

        private void EditAccountsMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialogForm(new EditAccounts(_dam));
            _dam.LoadAccounts(); 
        }

        private void EditBillsMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialogForm(new EditBills());
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDialogForm(Form formToShow)
        {
            Enabled = false;

            formToShow.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            formToShow.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            formToShow.MaximizeBox = false;

            formToShow.ShowDialog();

            Enabled = true;
            formToShow.Dispose();

            addNewPurchaseButton.Enabled = _dam.ActiveAccounts.Count > 0;
            addNewBalanceTransferButton.Enabled = _dam.ActiveAccounts.Count > 1; 
        }

        private void addNewPurchaseButton_Click(object sender, EventArgs e)
        {
            ShowDialogForm(new AddPurchase(_dam)); 
        }

        private void addNewBalanceTransferButton_Click(object sender, EventArgs e)
        {
            ShowDialogForm(new AddBalanceTransfer(_dam)); 
        }
    }
}
