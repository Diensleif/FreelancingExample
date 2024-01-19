namespace Оплата_ЖКХ
{
    partial class EditPaymentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPersonalAccount = new System.Windows.Forms.TextBox();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDuty = new System.Windows.Forms.TextBox();
            this.textBoxPaymentSum = new System.Windows.Forms.TextBox();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лицевой счет";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчетный период";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Долг";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата оплаты";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Оплаченная сумма";
            // 
            // textBoxPersonalAccount
            // 
            this.textBoxPersonalAccount.Location = new System.Drawing.Point(12, 35);
            this.textBoxPersonalAccount.Name = "textBoxPersonalAccount";
            this.textBoxPersonalAccount.Size = new System.Drawing.Size(310, 20);
            this.textBoxPersonalAccount.TabIndex = 9;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(12, 84);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(310, 21);
            this.comboBoxAddress.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 184);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(310, 20);
            this.textBoxPrice.TabIndex = 14;
            // 
            // textBoxDuty
            // 
            this.textBoxDuty.Location = new System.Drawing.Point(12, 233);
            this.textBoxDuty.Name = "textBoxDuty";
            this.textBoxDuty.Size = new System.Drawing.Size(310, 20);
            this.textBoxDuty.TabIndex = 15;
            // 
            // textBoxPaymentSum
            // 
            this.textBoxPaymentSum.Location = new System.Drawing.Point(12, 331);
            this.textBoxPaymentSum.Name = "textBoxPaymentSum";
            this.textBoxPaymentSum.Size = new System.Drawing.Size(310, 20);
            this.textBoxPaymentSum.TabIndex = 16;
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.CustomFormat = "";
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(12, 282);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(310, 20);
            this.dateTimePickerPaymentDate.TabIndex = 17;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(12, 134);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(310, 21);
            this.comboBoxPeriod.TabIndex = 18;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 357);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(310, 23);
            this.Ok.TabIndex = 19;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 386);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(310, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 436);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.dateTimePickerPaymentDate);
            this.Controls.Add(this.textBoxPaymentSum);
            this.Controls.Add(this.textBoxDuty);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.textBoxPersonalAccount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPaymentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение/добавление оплат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxPersonalAccount;
        public System.Windows.Forms.ComboBox comboBoxAddress;
        public System.Windows.Forms.TextBox textBoxPrice;
        public System.Windows.Forms.TextBox textBoxDuty;
        public System.Windows.Forms.TextBox textBoxPaymentSum;
        public System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        public System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}