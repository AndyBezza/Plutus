namespace Plutus.GUI
{
    partial class EditAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewAccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowInactiveAccountsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.cashCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.creationDateTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.creditLimitNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.startingBalanceCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.accountsListBox = new CustomControls.ColourableListBox();
            this.MenuStrip.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLimitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingBalanceCurrencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(530, 24);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAccountMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // NewAccountMenuItem
            // 
            this.NewAccountMenuItem.Name = "NewAccountMenuItem";
            this.NewAccountMenuItem.Size = new System.Drawing.Size(146, 22);
            this.NewAccountMenuItem.Text = "New Account";
            this.NewAccountMenuItem.Click += new System.EventHandler(this.NewAccountMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowInactiveAccountsMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.PerformSave);
            // 
            // ShowInactiveAccountsMenuItem
            // 
            this.ShowInactiveAccountsMenuItem.Checked = true;
            this.ShowInactiveAccountsMenuItem.CheckOnClick = true;
            this.ShowInactiveAccountsMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInactiveAccountsMenuItem.Name = "ShowInactiveAccountsMenuItem";
            this.ShowInactiveAccountsMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ShowInactiveAccountsMenuItem.Text = "Show Inactive Accounts";
            this.ShowInactiveAccountsMenuItem.Click += new System.EventHandler(this.DisplayAccounts);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.creditLimitNumericUpDown);
            this.detailsGroupBox.Controls.Add(this.label9);
            this.detailsGroupBox.Controls.Add(this.startingBalanceCurrencyNumericUpDown);
            this.detailsGroupBox.Controls.Add(this.label8);
            this.detailsGroupBox.Controls.Add(this.activeCheckBox);
            this.detailsGroupBox.Controls.Add(this.label7);
            this.detailsGroupBox.Controls.Add(this.label6);
            this.detailsGroupBox.Controls.Add(this.label3);
            this.detailsGroupBox.Controls.Add(this.label2);
            this.detailsGroupBox.Controls.Add(this.label1);
            this.detailsGroupBox.Controls.Add(this.currencyComboBox);
            this.detailsGroupBox.Controls.Add(this.cashCheckBox);
            this.detailsGroupBox.Controls.Add(this.label5);
            this.detailsGroupBox.Controls.Add(this.descriptionTextBox);
            this.detailsGroupBox.Controls.Add(this.nameTextBox);
            this.detailsGroupBox.Controls.Add(this.label4);
            this.detailsGroupBox.Controls.Add(this.creationDateTextBox);
            this.detailsGroupBox.Controls.Add(this.idTextBox);
            this.detailsGroupBox.Enabled = false;
            this.detailsGroupBox.Location = new System.Drawing.Point(252, 43);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(266, 264);
            this.detailsGroupBox.TabIndex = 4;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Account Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Credit Limit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Starting Balance";
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Checked = true;
            this.activeCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.activeCheckBox.Location = new System.Drawing.Point(100, 233);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activeCheckBox.TabIndex = 10;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.CheckedChanged += new System.EventHandler(this.ChangeMadeToActive);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Created";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "DKK",
            "EUR",
            "GBP",
            "USD"});
            this.currencyComboBox.Location = new System.Drawing.Point(100, 186);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(147, 21);
            this.currencyComboBox.TabIndex = 11;
            this.currencyComboBox.Text = "n/a";
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // cashCheckBox
            // 
            this.cashCheckBox.AutoSize = true;
            this.cashCheckBox.Checked = true;
            this.cashCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cashCheckBox.Location = new System.Drawing.Point(100, 213);
            this.cashCheckBox.Name = "cashCheckBox";
            this.cashCheckBox.Size = new System.Drawing.Size(15, 14);
            this.cashCheckBox.TabIndex = 9;
            this.cashCheckBox.UseVisualStyleBackColor = true;
            this.cashCheckBox.CheckedChanged += new System.EventHandler(this.ChangeMadeToIsCash);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(100, 106);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(147, 20);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "n/a";
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.Text = "n/a";
            this.nameTextBox.TextChanged += new System.EventHandler(this.ChangeMadeToName);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // creationDateTextBox
            // 
            this.creationDateTextBox.Enabled = false;
            this.creationDateTextBox.Location = new System.Drawing.Point(100, 54);
            this.creationDateTextBox.Name = "creationDateTextBox";
            this.creationDateTextBox.Size = new System.Drawing.Size(147, 20);
            this.creationDateTextBox.TabIndex = 8;
            this.creationDateTextBox.Text = "n/a";
            this.creationDateTextBox.TextChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(100, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(147, 20);
            this.idTextBox.TabIndex = 7;
            this.idTextBox.Text = "n/a";
            this.idTextBox.TextChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // creditLimitNumericUpDown
            // 
            this.creditLimitNumericUpDown.DecimalPlaces = 2;
            this.creditLimitNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.creditLimitNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.creditLimitNumericUpDown.Location = new System.Drawing.Point(100, 160);
            this.creditLimitNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.creditLimitNumericUpDown.Name = "creditLimitNumericUpDown";
            this.creditLimitNumericUpDown.Size = new System.Drawing.Size(147, 20);
            this.creditLimitNumericUpDown.TabIndex = 16;
            this.creditLimitNumericUpDown.ValueChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // startingBalanceCurrencyNumericUpDown
            // 
            this.startingBalanceCurrencyNumericUpDown.DecimalPlaces = 2;
            this.startingBalanceCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.startingBalanceCurrencyNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.startingBalanceCurrencyNumericUpDown.Location = new System.Drawing.Point(100, 134);
            this.startingBalanceCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startingBalanceCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.startingBalanceCurrencyNumericUpDown.Name = "startingBalanceCurrencyNumericUpDown";
            this.startingBalanceCurrencyNumericUpDown.Size = new System.Drawing.Size(147, 20);
            this.startingBalanceCurrencyNumericUpDown.TabIndex = 14;
            this.startingBalanceCurrencyNumericUpDown.ValueChanged += new System.EventHandler(this.ChangeMadeToDetail);
            // 
            // accountsListBox
            // 
            this.accountsListBox.FormattingEnabled = true;
            this.accountsListBox.Location = new System.Drawing.Point(21, 43);
            this.accountsListBox.Name = "accountsListBox";
            this.accountsListBox.ScrollAlwaysVisible = true;
            this.accountsListBox.Size = new System.Drawing.Size(205, 264);
            this.accountsListBox.TabIndex = 0;
            this.accountsListBox.SelectedIndexChanged += new System.EventHandler(this.accountsListBox_SelectedIndexChanged);
            // 
            // EditAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 319);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.accountsListBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "EditAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Accounts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAccounts_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditLimitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingBalanceCurrencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewAccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowInactiveAccountsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.CheckBox cashCheckBox;
        private System.Windows.Forms.TextBox creationDateTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private CustomControls.CurrencyNumericUpDown startingBalanceCurrencyNumericUpDown;
        private CustomControls.CurrencyNumericUpDown creditLimitNumericUpDown;
        private System.Windows.Forms.Label label9;
        private CustomControls.ColourableListBox accountsListBox;
    }
}