namespace Оплата_ЖКХ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableApartments = new System.Windows.Forms.DataGridView();
            this.addApartment = new System.Windows.Forms.Button();
            this.changeApartment = new System.Windows.Forms.Button();
            this.deleteApartment = new System.Windows.Forms.Button();
            this.tableOwners = new System.Windows.Forms.DataGridView();
            this.addOwner = new System.Windows.Forms.Button();
            this.changeOwner = new System.Windows.Forms.Button();
            this.deleteOwner = new System.Windows.Forms.Button();
            this.tablePayments = new System.Windows.Forms.DataGridView();
            this.addPayment = new System.Windows.Forms.Button();
            this.changePayment = new System.Windows.Forms.Button();
            this.deletePayment = new System.Windows.Forms.Button();
            this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оплата_ЖКХDataSet = new Оплата_ЖКХ.Оплата_ЖКХDataSet();
            this.проживающиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квартирыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.квартирыTableAdapter = new Оплата_ЖКХ.Оплата_ЖКХDataSetTableAdapters.КвартирыTableAdapter();
            this.проживающиеTableAdapter = new Оплата_ЖКХ.Оплата_ЖКХDataSetTableAdapters.ПроживающиеTableAdapter();
            this.оплатаTableAdapter = new Оплата_ЖКХ.Оплата_ЖКХDataSetTableAdapters.ОплатаTableAdapter();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьКвартирыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПроживающихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеЛьготыDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.кодПроживающегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПроживающегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лицевойСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчетныйПериодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.долгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплаченнаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableApartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплата_ЖКХDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проживающиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableApartments
            // 
            this.tableApartments.AllowUserToAddRows = false;
            this.tableApartments.AllowUserToDeleteRows = false;
            this.tableApartments.AllowUserToResizeColumns = false;
            this.tableApartments.AllowUserToResizeRows = false;
            this.tableApartments.AutoGenerateColumns = false;
            this.tableApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableApartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.адресDataGridViewTextBoxColumn,
            this.площадьКвартирыDataGridViewTextBoxColumn,
            this.количествоПроживающихDataGridViewTextBoxColumn,
            this.наличиеЛьготыDataGridViewCheckBoxColumn});
            this.tableApartments.DataSource = this.квартирыBindingSource;
            this.tableApartments.Location = new System.Drawing.Point(12, 12);
            this.tableApartments.Name = "tableApartments";
            this.tableApartments.ReadOnly = true;
            this.tableApartments.Size = new System.Drawing.Size(900, 150);
            this.tableApartments.TabIndex = 0;
            this.tableApartments.SelectionChanged += new System.EventHandler(this.tableApartments_SelectionChanged);
            // 
            // addApartment
            // 
            this.addApartment.Location = new System.Drawing.Point(918, 12);
            this.addApartment.Name = "addApartment";
            this.addApartment.Size = new System.Drawing.Size(334, 23);
            this.addApartment.TabIndex = 1;
            this.addApartment.Text = "Добавить";
            this.addApartment.UseVisualStyleBackColor = true;
            this.addApartment.Click += new System.EventHandler(this.addApartment_Click);
            // 
            // changeApartment
            // 
            this.changeApartment.Location = new System.Drawing.Point(918, 41);
            this.changeApartment.Name = "changeApartment";
            this.changeApartment.Size = new System.Drawing.Size(334, 23);
            this.changeApartment.TabIndex = 2;
            this.changeApartment.Text = "Изменить";
            this.changeApartment.UseVisualStyleBackColor = true;
            this.changeApartment.Click += new System.EventHandler(this.changeApartment_Click);
            // 
            // deleteApartment
            // 
            this.deleteApartment.Location = new System.Drawing.Point(918, 70);
            this.deleteApartment.Name = "deleteApartment";
            this.deleteApartment.Size = new System.Drawing.Size(334, 23);
            this.deleteApartment.TabIndex = 3;
            this.deleteApartment.Text = "Удалить";
            this.deleteApartment.UseVisualStyleBackColor = true;
            this.deleteApartment.Click += new System.EventHandler(this.deleteApartment_Click);
            // 
            // tableOwners
            // 
            this.tableOwners.AllowUserToAddRows = false;
            this.tableOwners.AllowUserToDeleteRows = false;
            this.tableOwners.AllowUserToResizeColumns = false;
            this.tableOwners.AllowUserToResizeRows = false;
            this.tableOwners.AutoGenerateColumns = false;
            this.tableOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПроживающегоDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn1,
            this.фИОПроживающегоDataGridViewTextBoxColumn,
            this.паспортныеДанныеDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn});
            this.tableOwners.DataSource = this.проживающиеBindingSource;
            this.tableOwners.Location = new System.Drawing.Point(12, 168);
            this.tableOwners.Name = "tableOwners";
            this.tableOwners.ReadOnly = true;
            this.tableOwners.Size = new System.Drawing.Size(900, 150);
            this.tableOwners.TabIndex = 4;
            // 
            // addOwner
            // 
            this.addOwner.Location = new System.Drawing.Point(918, 168);
            this.addOwner.Name = "addOwner";
            this.addOwner.Size = new System.Drawing.Size(334, 23);
            this.addOwner.TabIndex = 5;
            this.addOwner.Text = "Добавить";
            this.addOwner.UseVisualStyleBackColor = true;
            this.addOwner.Click += new System.EventHandler(this.addOwner_Click);
            // 
            // changeOwner
            // 
            this.changeOwner.Location = new System.Drawing.Point(918, 197);
            this.changeOwner.Name = "changeOwner";
            this.changeOwner.Size = new System.Drawing.Size(334, 23);
            this.changeOwner.TabIndex = 6;
            this.changeOwner.Text = "Изменить";
            this.changeOwner.UseVisualStyleBackColor = true;
            this.changeOwner.Click += new System.EventHandler(this.changeOwner_Click);
            // 
            // deleteOwner
            // 
            this.deleteOwner.Location = new System.Drawing.Point(918, 226);
            this.deleteOwner.Name = "deleteOwner";
            this.deleteOwner.Size = new System.Drawing.Size(334, 23);
            this.deleteOwner.TabIndex = 7;
            this.deleteOwner.Text = "Удалить";
            this.deleteOwner.UseVisualStyleBackColor = true;
            this.deleteOwner.Click += new System.EventHandler(this.deleteOwner_Click);
            // 
            // tablePayments
            // 
            this.tablePayments.AllowUserToAddRows = false;
            this.tablePayments.AllowUserToDeleteRows = false;
            this.tablePayments.AllowUserToResizeColumns = false;
            this.tablePayments.AllowUserToResizeRows = false;
            this.tablePayments.AutoGenerateColumns = false;
            this.tablePayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.лицевойСчетDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn2,
            this.отчетныйПериодDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.долгDataGridViewTextBoxColumn,
            this.датаОплатыDataGridViewTextBoxColumn,
            this.оплаченнаяСуммаDataGridViewTextBoxColumn});
            this.tablePayments.DataSource = this.оплатаBindingSource;
            this.tablePayments.Location = new System.Drawing.Point(12, 324);
            this.tablePayments.Name = "tablePayments";
            this.tablePayments.ReadOnly = true;
            this.tablePayments.Size = new System.Drawing.Size(900, 150);
            this.tablePayments.TabIndex = 8;
            // 
            // addPayment
            // 
            this.addPayment.Location = new System.Drawing.Point(918, 324);
            this.addPayment.Name = "addPayment";
            this.addPayment.Size = new System.Drawing.Size(334, 23);
            this.addPayment.TabIndex = 9;
            this.addPayment.Text = "Добавить";
            this.addPayment.UseVisualStyleBackColor = true;
            this.addPayment.Click += new System.EventHandler(this.addPayment_Click);
            // 
            // changePayment
            // 
            this.changePayment.Location = new System.Drawing.Point(918, 353);
            this.changePayment.Name = "changePayment";
            this.changePayment.Size = new System.Drawing.Size(334, 23);
            this.changePayment.TabIndex = 10;
            this.changePayment.Text = "Изменить";
            this.changePayment.UseVisualStyleBackColor = true;
            this.changePayment.Click += new System.EventHandler(this.changePayment_Click);
            // 
            // deletePayment
            // 
            this.deletePayment.Location = new System.Drawing.Point(918, 382);
            this.deletePayment.Name = "deletePayment";
            this.deletePayment.Size = new System.Drawing.Size(334, 23);
            this.deletePayment.TabIndex = 11;
            this.deletePayment.Text = "Удалить";
            this.deletePayment.UseVisualStyleBackColor = true;
            this.deletePayment.Click += new System.EventHandler(this.deletePayment_Click);
            // 
            // оплатаBindingSource
            // 
            this.оплатаBindingSource.DataMember = "Оплата";
            this.оплатаBindingSource.DataSource = this.оплата_ЖКХDataSet;
            // 
            // оплата_ЖКХDataSet
            // 
            this.оплата_ЖКХDataSet.DataSetName = "Оплата_ЖКХDataSet";
            this.оплата_ЖКХDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // проживающиеBindingSource
            // 
            this.проживающиеBindingSource.DataMember = "Проживающие";
            this.проживающиеBindingSource.DataSource = this.оплата_ЖКХDataSet;
            // 
            // квартирыBindingSource
            // 
            this.квартирыBindingSource.DataMember = "Квартиры";
            this.квартирыBindingSource.DataSource = this.оплата_ЖКХDataSet;
            // 
            // квартирыTableAdapter
            // 
            this.квартирыTableAdapter.ClearBeforeFill = true;
            // 
            // проживающиеTableAdapter
            // 
            this.проживающиеTableAdapter.ClearBeforeFill = true;
            // 
            // оплатаTableAdapter
            // 
            this.оплатаTableAdapter.ClearBeforeFill = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // площадьКвартирыDataGridViewTextBoxColumn
            // 
            this.площадьКвартирыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.площадьКвартирыDataGridViewTextBoxColumn.DataPropertyName = "Площадь квартиры";
            this.площадьКвартирыDataGridViewTextBoxColumn.HeaderText = "Площадь квартиры";
            this.площадьКвартирыDataGridViewTextBoxColumn.Name = "площадьКвартирыDataGridViewTextBoxColumn";
            this.площадьКвартирыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоПроживающихDataGridViewTextBoxColumn
            // 
            this.количествоПроживающихDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоПроживающихDataGridViewTextBoxColumn.DataPropertyName = "Количество проживающих";
            this.количествоПроживающихDataGridViewTextBoxColumn.HeaderText = "Количество проживающих";
            this.количествоПроживающихDataGridViewTextBoxColumn.Name = "количествоПроживающихDataGridViewTextBoxColumn";
            this.количествоПроживающихDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наличиеЛьготыDataGridViewCheckBoxColumn
            // 
            this.наличиеЛьготыDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наличиеЛьготыDataGridViewCheckBoxColumn.DataPropertyName = "Наличие льготы";
            this.наличиеЛьготыDataGridViewCheckBoxColumn.HeaderText = "Наличие льготы";
            this.наличиеЛьготыDataGridViewCheckBoxColumn.Name = "наличиеЛьготыDataGridViewCheckBoxColumn";
            this.наличиеЛьготыDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // кодПроживающегоDataGridViewTextBoxColumn
            // 
            this.кодПроживающегоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.кодПроживающегоDataGridViewTextBoxColumn.DataPropertyName = "Код проживающего";
            this.кодПроживающегоDataGridViewTextBoxColumn.HeaderText = "Код проживающего";
            this.кодПроживающегоDataGridViewTextBoxColumn.Name = "кодПроживающегоDataGridViewTextBoxColumn";
            this.кодПроживающегоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn1
            // 
            this.адресDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресDataGridViewTextBoxColumn1.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn1.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn1.Name = "адресDataGridViewTextBoxColumn1";
            this.адресDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // фИОПроживающегоDataGridViewTextBoxColumn
            // 
            this.фИОПроживающегоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.фИОПроживающегоDataGridViewTextBoxColumn.DataPropertyName = "ФИО проживающего";
            this.фИОПроживающегоDataGridViewTextBoxColumn.HeaderText = "ФИО проживающего";
            this.фИОПроживающегоDataGridViewTextBoxColumn.Name = "фИОПроживающегоDataGridViewTextBoxColumn";
            this.фИОПроживающегоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // паспортныеДанныеDataGridViewTextBoxColumn
            // 
            this.паспортныеДанныеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.паспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.Name = "паспортныеДанныеDataGridViewTextBoxColumn";
            this.паспортныеДанныеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // лицевойСчетDataGridViewTextBoxColumn
            // 
            this.лицевойСчетDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.лицевойСчетDataGridViewTextBoxColumn.DataPropertyName = "Лицевой счет";
            this.лицевойСчетDataGridViewTextBoxColumn.HeaderText = "Лицевой счет";
            this.лицевойСчетDataGridViewTextBoxColumn.Name = "лицевойСчетDataGridViewTextBoxColumn";
            this.лицевойСчетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn2
            // 
            this.адресDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.адресDataGridViewTextBoxColumn2.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn2.Name = "адресDataGridViewTextBoxColumn2";
            this.адресDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // отчетныйПериодDataGridViewTextBoxColumn
            // 
            this.отчетныйПериодDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.отчетныйПериодDataGridViewTextBoxColumn.DataPropertyName = "Отчетный период";
            this.отчетныйПериодDataGridViewTextBoxColumn.HeaderText = "Отчетный период";
            this.отчетныйПериодDataGridViewTextBoxColumn.Name = "отчетныйПериодDataGridViewTextBoxColumn";
            this.отчетныйПериодDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // долгDataGridViewTextBoxColumn
            // 
            this.долгDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.долгDataGridViewTextBoxColumn.DataPropertyName = "Долг";
            this.долгDataGridViewTextBoxColumn.HeaderText = "Долг";
            this.долгDataGridViewTextBoxColumn.Name = "долгDataGridViewTextBoxColumn";
            this.долгDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОплатыDataGridViewTextBoxColumn
            // 
            this.датаОплатыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаОплатыDataGridViewTextBoxColumn.DataPropertyName = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.датаОплатыDataGridViewTextBoxColumn.Name = "датаОплатыDataGridViewTextBoxColumn";
            this.датаОплатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // оплаченнаяСуммаDataGridViewTextBoxColumn
            // 
            this.оплаченнаяСуммаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.оплаченнаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Оплаченная сумма";
            this.оплаченнаяСуммаDataGridViewTextBoxColumn.HeaderText = "Оплаченная сумма";
            this.оплаченнаяСуммаDataGridViewTextBoxColumn.Name = "оплаченнаяСуммаDataGridViewTextBoxColumn";
            this.оплаченнаяСуммаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.deletePayment);
            this.Controls.Add(this.changePayment);
            this.Controls.Add(this.addPayment);
            this.Controls.Add(this.tablePayments);
            this.Controls.Add(this.deleteOwner);
            this.Controls.Add(this.changeOwner);
            this.Controls.Add(this.addOwner);
            this.Controls.Add(this.tableOwners);
            this.Controls.Add(this.deleteApartment);
            this.Controls.Add(this.changeApartment);
            this.Controls.Add(this.addApartment);
            this.Controls.Add(this.tableApartments);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата ЖКХ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableApartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплата_ЖКХDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проживающиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.квартирыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableApartments;
        private System.Windows.Forms.Button addApartment;
        private System.Windows.Forms.Button changeApartment;
        private System.Windows.Forms.Button deleteApartment;
        private Оплата_ЖКХDataSet оплата_ЖКХDataSet;
        private System.Windows.Forms.BindingSource квартирыBindingSource;
        private Оплата_ЖКХDataSetTableAdapters.КвартирыTableAdapter квартирыTableAdapter;
        private System.Windows.Forms.DataGridView tableOwners;
        private System.Windows.Forms.BindingSource проживающиеBindingSource;
        private Оплата_ЖКХDataSetTableAdapters.ПроживающиеTableAdapter проживающиеTableAdapter;
        private System.Windows.Forms.Button addOwner;
        private System.Windows.Forms.Button changeOwner;
        private System.Windows.Forms.Button deleteOwner;
        private System.Windows.Forms.DataGridView tablePayments;
        private System.Windows.Forms.BindingSource оплатаBindingSource;
        private Оплата_ЖКХDataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
        private System.Windows.Forms.Button addPayment;
        private System.Windows.Forms.Button changePayment;
        private System.Windows.Forms.Button deletePayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьКвартирыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПроживающихDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наличиеЛьготыDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПроживающегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПроживающегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеДанныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn лицевойСчетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчетныйПериодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn долгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплаченнаяСуммаDataGridViewTextBoxColumn;
    }
}

