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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.quickDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.step2GroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.effectivePriceCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.originalPriceCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.step1GroupBox.SuspendLayout();
            this.step2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectivePriceCurrencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPriceCurrencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // step1GroupBox
            // 
            this.step1GroupBox.Controls.Add(this.label5);
            this.step1GroupBox.Controls.Add(this.label4);
            this.step1GroupBox.Controls.Add(this.label3);
            this.step1GroupBox.Controls.Add(this.label2);
            this.step1GroupBox.Controls.Add(this.nextButton);
            this.step1GroupBox.Controls.Add(this.additionalInfoTextBox);
            this.step1GroupBox.Controls.Add(this.quickDescriptionTextBox);
            this.step1GroupBox.Controls.Add(this.effectivePriceCurrencyNumericUpDown);
            this.step1GroupBox.Controls.Add(this.originalPriceCurrencyNumericUpDown);
            this.step1GroupBox.Controls.Add(this.label1);
            this.step1GroupBox.Controls.Add(this.currencyComboBox);
            this.step1GroupBox.Location = new System.Drawing.Point(13, 13);
            this.step1GroupBox.Name = "step1GroupBox";
            this.step1GroupBox.Size = new System.Drawing.Size(325, 346);
            this.step1GroupBox.TabIndex = 0;
            this.step1GroupBox.TabStop = false;
            this.step1GroupBox.Text = "Step 1 / 2 (Value + Description)";
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
            this.nextButton.Location = new System.Drawing.Point(6, 314);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(313, 23);
            this.nextButton.TabIndex = 7;
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
            this.additionalInfoTextBox.TabIndex = 6;
            // 
            // quickDescriptionTextBox
            // 
            this.quickDescriptionTextBox.Location = new System.Drawing.Point(98, 111);
            this.quickDescriptionTextBox.Name = "quickDescriptionTextBox";
            this.quickDescriptionTextBox.Size = new System.Drawing.Size(107, 20);
            this.quickDescriptionTextBox.TabIndex = 5;
            this.quickDescriptionTextBox.TextChanged += new System.EventHandler(this.purchaseDescriptionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currency";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "DKK",
            "EUR",
            "GBP",
            "USD"});
            this.currencyComboBox.Location = new System.Drawing.Point(98, 30);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(107, 21);
            this.currencyComboBox.TabIndex = 0;
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // step2GroupBox
            // 
            this.step2GroupBox.Controls.Add(this.checkedListBox1);
            this.step2GroupBox.Controls.Add(this.backButton);
            this.step2GroupBox.Controls.Add(this.doneButton);
            this.step2GroupBox.Location = new System.Drawing.Point(344, 13);
            this.step2GroupBox.Name = "step2GroupBox";
            this.step2GroupBox.Size = new System.Drawing.Size(325, 346);
            this.step2GroupBox.TabIndex = 1;
            this.step2GroupBox.TabStop = false;
            this.step2GroupBox.Text = "Step 2 / 2 (Accounts Affected)";
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
            this.doneButton.Location = new System.Drawing.Point(6, 314);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(313, 23);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // effectivePriceCurrencyNumericUpDown
            // 
            this.effectivePriceCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.effectivePriceCurrencyNumericUpDown.Location = new System.Drawing.Point(98, 84);
            this.effectivePriceCurrencyNumericUpDown.Name = "effectivePriceCurrencyNumericUpDown";
            this.effectivePriceCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.effectivePriceCurrencyNumericUpDown.TabIndex = 4;
            // 
            // originalPriceCurrencyNumericUpDown
            // 
            this.originalPriceCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.originalPriceCurrencyNumericUpDown.Location = new System.Drawing.Point(98, 58);
            this.originalPriceCurrencyNumericUpDown.Name = "originalPriceCurrencyNumericUpDown";
            this.originalPriceCurrencyNumericUpDown.Size = new System.Drawing.Size(107, 20);
            this.originalPriceCurrencyNumericUpDown.TabIndex = 3;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(21, 60);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 14;
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 371);
            this.Controls.Add(this.step2GroupBox);
            this.Controls.Add(this.step1GroupBox);
            this.MaximizeBox = false;
            this.Name = "AddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Purchase";
            this.step1GroupBox.ResumeLayout(false);
            this.step1GroupBox.PerformLayout();
            this.step2GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.effectivePriceCurrencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPriceCurrencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox step1GroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.GroupBox step2GroupBox;
        private CustomControls.CurrencyNumericUpDown originalPriceCurrencyNumericUpDown;
        private CustomControls.CurrencyNumericUpDown effectivePriceCurrencyNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.TextBox quickDescriptionTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;

    }
}