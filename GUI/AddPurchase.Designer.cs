namespace Plutus.GUI
{
    partial class AddPurchase
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
            this.step1GroupBox = new System.Windows.Forms.GroupBox();
            this.effectiveCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.quickDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.originalCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.step2GroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.availableAccountsPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.spreadOverMonthCheckBox = new System.Windows.Forms.CheckBox();
            this.targetValueCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.currentValueCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.effectivePriceCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.originalPriceCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.step1GroupBox.SuspendLayout();
            this.step2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetValueCurrencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentValueCurrencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectivePriceCurrencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPriceCurrencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // step1GroupBox
            // 
            this.step1GroupBox.Controls.Add(this.spreadOverMonthCheckBox);
            this.step1GroupBox.Controls.Add(this.effectiveCurrencyComboBox);
            this.step1GroupBox.Controls.Add(this.label5);
            this.step1GroupBox.Controls.Add(this.label4);
            this.step1GroupBox.Controls.Add(this.label3);
            this.step1GroupBox.Controls.Add(this.label2);
            this.step1GroupBox.Controls.Add(this.nextButton);
            this.step1GroupBox.Controls.Add(this.additionalInfoTextBox);
            this.step1GroupBox.Controls.Add(this.quickDescriptionTextBox);
            this.step1GroupBox.Controls.Add(this.effectivePriceCurrencyNumericUpDown);
            this.step1GroupBox.Controls.Add(this.originalPriceCurrencyNumericUpDown);
            this.step1GroupBox.Controls.Add(this.originalCurrencyComboBox);
            this.step1GroupBox.Location = new System.Drawing.Point(13, 13);
            this.step1GroupBox.Name = "step1GroupBox";
            this.step1GroupBox.Size = new System.Drawing.Size(325, 367);
            this.step1GroupBox.TabIndex = 0;
            this.step1GroupBox.TabStop = false;
            this.step1GroupBox.Text = "Step 1 / 2 (Value + Description)";
            // 
            // effectiveCurrencyComboBox
            // 
            this.effectiveCurrencyComboBox.FormattingEnabled = true;
            this.effectiveCurrencyComboBox.Items.AddRange(new object[] {
            "DKK",
            "EUR",
            "GBP",
            "USD"});
            this.effectiveCurrencyComboBox.Location = new System.Drawing.Point(211, 84);
            this.effectiveCurrencyComboBox.Name = "effectiveCurrencyComboBox";
            this.effectiveCurrencyComboBox.Size = new System.Drawing.Size(98, 21);
            this.effectiveCurrencyComboBox.TabIndex = 12;
            this.effectiveCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Additional Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Effective Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Original Amount";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(6, 333);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(313, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(98, 138);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(211, 163);
            this.additionalInfoTextBox.TabIndex = 3;
            // 
            // quickDescriptionTextBox
            // 
            this.quickDescriptionTextBox.Location = new System.Drawing.Point(98, 111);
            this.quickDescriptionTextBox.Name = "quickDescriptionTextBox";
            this.quickDescriptionTextBox.Size = new System.Drawing.Size(107, 20);
            this.quickDescriptionTextBox.TabIndex = 2;
            this.quickDescriptionTextBox.TextChanged += new System.EventHandler(this.purchaseDescriptionChanged);
            // 
            // originalCurrencyComboBox
            // 
            this.originalCurrencyComboBox.FormattingEnabled = true;
            this.originalCurrencyComboBox.Items.AddRange(new object[] {
            "DKK",
            "EUR",
            "GBP",
            "USD"});
            this.originalCurrencyComboBox.Location = new System.Drawing.Point(211, 57);
            this.originalCurrencyComboBox.Name = "originalCurrencyComboBox";
            this.originalCurrencyComboBox.Size = new System.Drawing.Size(98, 21);
            this.originalCurrencyComboBox.TabIndex = 0;
            this.originalCurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // step2GroupBox
            // 
            this.step2GroupBox.Controls.Add(this.label6);
            this.step2GroupBox.Controls.Add(this.label1);
            this.step2GroupBox.Controls.Add(this.targetValueCurrencyNumericUpDown);
            this.step2GroupBox.Controls.Add(this.currentValueCurrencyNumericUpDown);
            this.step2GroupBox.Controls.Add(this.availableAccountsPanel);
            this.step2GroupBox.Controls.Add(this.backButton);
            this.step2GroupBox.Controls.Add(this.doneButton);
            this.step2GroupBox.Location = new System.Drawing.Point(344, 13);
            this.step2GroupBox.Name = "step2GroupBox";
            this.step2GroupBox.Size = new System.Drawing.Size(325, 367);
            this.step2GroupBox.TabIndex = 1;
            this.step2GroupBox.TabStop = false;
            this.step2GroupBox.Text = "Step 2 / 2 (Accounts Affected)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Target value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Current value acconted for\r\n";
            // 
            // availableAccountsPanel
            // 
            this.availableAccountsPanel.AutoScroll = true;
            this.availableAccountsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableAccountsPanel.Location = new System.Drawing.Point(6, 57);
            this.availableAccountsPanel.Name = "availableAccountsPanel";
            this.availableAccountsPanel.Size = new System.Drawing.Size(313, 218);
            this.availableAccountsPanel.TabIndex = 0;
            this.availableAccountsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.availableAccountsPanel_Paint);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(313, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(6, 333);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(313, 23);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // spreadOverMonthCheckBox
            // 
            this.spreadOverMonthCheckBox.AutoSize = true;
            this.spreadOverMonthCheckBox.Location = new System.Drawing.Point(190, 307);
            this.spreadOverMonthCheckBox.Name = "spreadOverMonthCheckBox";
            this.spreadOverMonthCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spreadOverMonthCheckBox.Size = new System.Drawing.Size(119, 17);
            this.spreadOverMonthCheckBox.TabIndex = 13;
            this.spreadOverMonthCheckBox.Text = "Spread Over Month";
            this.spreadOverMonthCheckBox.UseVisualStyleBackColor = true;
            // 
            // targetValueCurrencyNumericUpDown
            // 
            this.targetValueCurrencyNumericUpDown.DecimalPlaces = 2;
            this.targetValueCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.targetValueCurrencyNumericUpDown.Enabled = false;
            this.targetValueCurrencyNumericUpDown.Location = new System.Drawing.Point(212, 307);
            this.targetValueCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.targetValueCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.targetValueCurrencyNumericUpDown.Name = "targetValueCurrencyNumericUpDown";
            this.targetValueCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.targetValueCurrencyNumericUpDown.TabIndex = 14;
            // 
            // currentValueCurrencyNumericUpDown
            // 
            this.currentValueCurrencyNumericUpDown.DecimalPlaces = 2;
            this.currentValueCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.currentValueCurrencyNumericUpDown.Enabled = false;
            this.currentValueCurrencyNumericUpDown.Location = new System.Drawing.Point(212, 281);
            this.currentValueCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.currentValueCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.currentValueCurrencyNumericUpDown.Name = "currentValueCurrencyNumericUpDown";
            this.currentValueCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.currentValueCurrencyNumericUpDown.TabIndex = 13;
            // 
            // effectivePriceCurrencyNumericUpDown
            // 
            this.effectivePriceCurrencyNumericUpDown.DecimalPlaces = 2;
            this.effectivePriceCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.effectivePriceCurrencyNumericUpDown.Location = new System.Drawing.Point(98, 84);
            this.effectivePriceCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.effectivePriceCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.effectivePriceCurrencyNumericUpDown.Name = "effectivePriceCurrencyNumericUpDown";
            this.effectivePriceCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.effectivePriceCurrencyNumericUpDown.TabIndex = 1;
            // 
            // originalPriceCurrencyNumericUpDown
            // 
            this.originalPriceCurrencyNumericUpDown.DecimalPlaces = 2;
            this.originalPriceCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.originalPriceCurrencyNumericUpDown.Location = new System.Drawing.Point(98, 58);
            this.originalPriceCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.originalPriceCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.originalPriceCurrencyNumericUpDown.Name = "originalPriceCurrencyNumericUpDown";
            this.originalPriceCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.originalPriceCurrencyNumericUpDown.TabIndex = 0;
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.Add(this.step2GroupBox);
            this.Controls.Add(this.step1GroupBox);
            this.MaximizeBox = false;
            this.Name = "AddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Purchase";
            this.step1GroupBox.ResumeLayout(false);
            this.step1GroupBox.PerformLayout();
            this.step2GroupBox.ResumeLayout(false);
            this.step2GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetValueCurrencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentValueCurrencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectivePriceCurrencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPriceCurrencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox step1GroupBox;
        private System.Windows.Forms.ComboBox originalCurrencyComboBox;
        private System.Windows.Forms.GroupBox step2GroupBox;
        private CustomControls.CurrencyNumericUpDown originalPriceCurrencyNumericUpDown;
        private CustomControls.CurrencyNumericUpDown effectivePriceCurrencyNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox additionalInfoTextBox;        private System.Windows.Forms.TextBox quickDescriptionTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.ComboBox effectiveCurrencyComboBox;
        private System.Windows.Forms.Panel availableAccountsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CustomControls.CurrencyNumericUpDown targetValueCurrencyNumericUpDown;
        private CustomControls.CurrencyNumericUpDown currentValueCurrencyNumericUpDown;
        private System.Windows.Forms.CheckBox spreadOverMonthCheckBox;

    }
}