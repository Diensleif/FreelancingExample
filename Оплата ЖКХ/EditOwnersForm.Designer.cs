namespace Оплата_ЖКХ
{
    partial class EditOwnersForm
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
            this.textBoxOwnerCode = new System.Windows.Forms.TextBox();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.textBoxPassportData = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код проживающего";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО проживающего";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Паспортные данные";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата рождения";
            // 
            // textBoxOwnerCode
            // 
            this.textBoxOwnerCode.Location = new System.Drawing.Point(12, 35);
            this.textBoxOwnerCode.Name = "textBoxOwnerCode";
            this.textBoxOwnerCode.Size = new System.Drawing.Size(310, 20);
            this.textBoxOwnerCode.TabIndex = 6;
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.Location = new System.Drawing.Point(12, 134);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new System.Drawing.Size(310, 20);
            this.textBoxOwnerName.TabIndex = 8;
            // 
            // textBoxPassportData
            // 
            this.textBoxPassportData.Location = new System.Drawing.Point(12, 183);
            this.textBoxPassportData.Name = "textBoxPassportData";
            this.textBoxPassportData.Size = new System.Drawing.Size(310, 20);
            this.textBoxPassportData.TabIndex = 9;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(12, 232);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(310, 20);
            this.dateTimePickerBirthday.TabIndex = 10;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Location = new System.Drawing.Point(12, 84);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(310, 21);
            this.comboBoxAddress.TabIndex = 11;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 258);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(310, 23);
            this.Ok.TabIndex = 12;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 287);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(310, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditOwnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.textBoxPassportData);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.textBoxOwnerCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOwnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение/добавление проживающих";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxOwnerCode;
        public System.Windows.Forms.TextBox textBoxOwnerName;
        public System.Windows.Forms.TextBox textBoxPassportData;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        public System.Windows.Forms.ComboBox comboBoxAddress;
    }
}