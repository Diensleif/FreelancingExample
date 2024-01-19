namespace Оплата_ЖКХ
{
    partial class EditApartmentsForm
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxOwnersCount = new System.Windows.Forms.TextBox();
            this.checkBoxBenefit = new System.Windows.Forms.CheckBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь квартиры";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество проживающих";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 35);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(310, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(12, 84);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(310, 20);
            this.textBoxArea.TabIndex = 4;
            // 
            // textBoxOwnersCount
            // 
            this.textBoxOwnersCount.Location = new System.Drawing.Point(12, 133);
            this.textBoxOwnersCount.Name = "textBoxOwnersCount";
            this.textBoxOwnersCount.Size = new System.Drawing.Size(310, 20);
            this.textBoxOwnersCount.TabIndex = 5;
            // 
            // checkBoxBenefit
            // 
            this.checkBoxBenefit.Location = new System.Drawing.Point(12, 159);
            this.checkBoxBenefit.Name = "checkBoxBenefit";
            this.checkBoxBenefit.Size = new System.Drawing.Size(310, 24);
            this.checkBoxBenefit.TabIndex = 6;
            this.checkBoxBenefit.Text = "Наличие льготы";
            this.checkBoxBenefit.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 189);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(310, 23);
            this.Ok.TabIndex = 7;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 218);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(310, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditApartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.checkBoxBenefit);
            this.Controls.Add(this.textBoxOwnersCount);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditApartmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение/добавление квартир";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.TextBox textBoxArea;
        public System.Windows.Forms.TextBox textBoxOwnersCount;
        public System.Windows.Forms.CheckBox checkBoxBenefit;
    }
}