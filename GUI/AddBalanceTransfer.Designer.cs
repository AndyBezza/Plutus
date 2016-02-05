namespace Plutus.GUI
{
    partial class AddBalanceTransfer
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
            this.fromAccountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toAccountComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.additionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.quickDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.valueCurrencyNumericUpDown = new Plutus.CustomControls.CurrencyNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.valueCurrencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fromAccountComboBox
            // 
            this.fromAccountComboBox.FormattingEnabled = true;
            this.fromAccountComboBox.Location = new System.Drawing.Point(93, 24);
            this.fromAccountComboBox.Name = "fromAccountComboBox";
            this.fromAccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.fromAccountComboBox.TabIndex = 0;
            this.fromAccountComboBox.SelectedIndexChanged += new System.EventHandler(this.fromAccountComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // toAccountComboBox
            // 
            this.toAccountComboBox.FormattingEnabled = true;
            this.toAccountComboBox.Location = new System.Drawing.Point(93, 51);
            this.toAccountComboBox.Name = "toAccountComboBox";
            this.toAccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.toAccountComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Additional Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // additionalInfoTextBox
            // 
            this.additionalInfoTextBox.Location = new System.Drawing.Point(93, 131);
            this.additionalInfoTextBox.Multiline = true;
            this.additionalInfoTextBox.Name = "additionalInfoTextBox";
            this.additionalInfoTextBox.Size = new System.Drawing.Size(211, 163);
            this.additionalInfoTextBox.TabIndex = 13;
            // 
            // quickDescriptionTextBox
            // 
            this.quickDescriptionTextBox.Location = new System.Drawing.Point(93, 105);
            this.quickDescriptionTextBox.Name = "quickDescriptionTextBox";
            this.quickDescriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.quickDescriptionTextBox.TabIndex = 12;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(12, 300);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(292, 23);
            this.doneButton.TabIndex = 16;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // valueCurrencyNumericUpDown
            // 
            this.valueCurrencyNumericUpDown.DecimalPlaces = 2;
            this.valueCurrencyNumericUpDown.DisplayCurrency = Plutus.CustomClasses.Currency.GBP;
            this.valueCurrencyNumericUpDown.Location = new System.Drawing.Point(93, 79);
            this.valueCurrencyNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valueCurrencyNumericUpDown.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.valueCurrencyNumericUpDown.Name = "valueCurrencyNumericUpDown";
            this.valueCurrencyNumericUpDown.Size = new System.Drawing.Size(121, 20);
            this.valueCurrencyNumericUpDown.TabIndex = 4;
            // 
            // AddBalanceTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 341);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.additionalInfoTextBox);
            this.Controls.Add(this.quickDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueCurrencyNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toAccountComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromAccountComboBox);
            this.MaximizeBox = false;
            this.Name = "AddBalanceTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Balance Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.valueCurrencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fromAccountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toAccountComboBox;
        private CustomControls.CurrencyNumericUpDown valueCurrencyNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox additionalInfoTextBox;
        private System.Windows.Forms.TextBox quickDescriptionTextBox;
        private System.Windows.Forms.Button doneButton;


    }
}