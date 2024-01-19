using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Оплата_ЖКХ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<string> GetAddresses()
        {
            List<string> addresses = new List<string>();

            for (int row = 0; row < tableApartments.Rows.Count; row++)
            {
                addresses.Add(tableApartments.Rows[row].Cells[0].Value.ToString());
            }

            addresses.Add("");

            return addresses;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.квартирыTableAdapter.Fill(this.оплата_ЖКХDataSet.Квартиры);
        }

        private void addApartment_Click(object sender, EventArgs e)
        {
            EditApartmentsForm editApartmentsForm = new EditApartmentsForm();
            editApartmentsForm.ShowDialog();

            if (editApartmentsForm.result == true)
            {
                string address = editApartmentsForm.textBoxAddress.Text;
                double area = Convert.ToDouble(editApartmentsForm.textBoxArea.Text);
                int ownersCount = Convert.ToInt32(editApartmentsForm.textBoxOwnersCount.Text);
                bool benefit = editApartmentsForm.checkBoxBenefit.Checked;

                this.квартирыTableAdapter.Insert(address, area, ownersCount, benefit);
                this.квартирыTableAdapter.Fill(this.оплата_ЖКХDataSet.Квартиры);
            }
        }

        private void changeApartment_Click(object sender, EventArgs e)
        {
            if (tableApartments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите изменить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tableApartments.SelectedRows[0].Index;

                    string oldAddress = tableApartments.Rows[currentRowIndex].Cells[0].Value.ToString();
                    string oldArea = tableApartments.Rows[currentRowIndex].Cells[1].Value.ToString();
                    string oldOwnersCount = tableApartments.Rows[currentRowIndex].Cells[2].Value.ToString();
                    bool oldBenefit = Convert.ToBoolean(tableApartments.Rows[currentRowIndex].Cells[3].Value);

                    EditApartmentsForm editApartmentsForm = new EditApartmentsForm();

                    editApartmentsForm.textBoxAddress.Text = oldAddress;
                    editApartmentsForm.textBoxArea.Text = oldArea;
                    editApartmentsForm.textBoxOwnersCount.Text = oldOwnersCount;
                    editApartmentsForm.checkBoxBenefit.Checked = oldBenefit;

                    editApartmentsForm.ShowDialog();

                    if (editApartmentsForm.result == true)
                    {
                        string address = editApartmentsForm.textBoxAddress.Text;
                        decimal area = Convert.ToDecimal(editApartmentsForm.textBoxArea.Text);
                        int ownersCount = Convert.ToInt32(editApartmentsForm.textBoxOwnersCount.Text);
                        bool benefit = editApartmentsForm.checkBoxBenefit.Checked;

                        this.квартирыTableAdapter.Update(address, area, ownersCount, benefit, oldAddress);
                        this.квартирыTableAdapter.Fill(this.оплата_ЖКХDataSet.Квартиры);
                    }
                }
            }
        }

        private void deleteApartment_Click(object sender, EventArgs e)
        {
            if (tableApartments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tableApartments.SelectedRows[0].Index;

                    string address = tableApartments.Rows[currentRowIndex].Cells[0].Value.ToString();

                    this.квартирыTableAdapter.Delete(address);
                    this.квартирыTableAdapter.Fill(this.оплата_ЖКХDataSet.Квартиры);
                }
            }
        }

        private void addOwner_Click(object sender, EventArgs e)
        {
            EditOwnersForm editOwnersForm = new EditOwnersForm();
            editOwnersForm.comboBoxAddress.DataSource = GetAddresses();
            if (tableApartments.SelectedRows.Count == 0)
            {
                editOwnersForm.comboBoxAddress.Text = "";
            }
            else
            {
                int index = tableApartments.SelectedRows[0].Index;
                editOwnersForm.comboBoxAddress.Text = tableApartments.Rows[index].Cells[0].Value.ToString();
            }
            editOwnersForm.ShowDialog();

            if (editOwnersForm.result == true)
            {
                int ownerCode = Convert.ToInt32(editOwnersForm.textBoxOwnerCode.Text);
                string address = editOwnersForm.comboBoxAddress.Text;
                string ownerName = editOwnersForm.textBoxOwnerName.Text;
                string passportData = editOwnersForm.textBoxPassportData.Text;
                string date = editOwnersForm.dateTimePickerBirthday.Value.ToString();
                date = date.Substring(0, date.IndexOf(' '));
                DateTime birthday = DateTime.Parse(date);

                this.проживающиеTableAdapter.Insert(ownerCode, address, ownerName, passportData, birthday);
                SortByAddress();
            }
        }

        private void changeOwner_Click(object sender, EventArgs e)
        {
            if (tableOwners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите изменить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tableOwners.SelectedRows[0].Index;

                    string oldOwnerCode = tableOwners.Rows[currentRowIndex].Cells[0].Value.ToString();
                    string oldAddress = tableOwners.Rows[currentRowIndex].Cells[1].Value.ToString();
                    string oldOwnerName = tableOwners.Rows[currentRowIndex].Cells[2].Value.ToString();
                    string oldPassportData = tableOwners.Rows[currentRowIndex].Cells[3].Value.ToString();
                    DateTime oldBirthday = DateTime.Parse(tableOwners.Rows[currentRowIndex].Cells[4].Value.ToString());

                    EditOwnersForm editOwnersForm = new EditOwnersForm();

                    editOwnersForm.comboBoxAddress.DataSource = GetAddresses();
                    editOwnersForm.textBoxOwnerCode.Text = oldOwnerCode;
                    editOwnersForm.comboBoxAddress.Text = oldAddress;
                    editOwnersForm.textBoxOwnerName.Text = oldOwnerName;
                    editOwnersForm.textBoxPassportData.Text = oldPassportData;
                    editOwnersForm.dateTimePickerBirthday.Value = oldBirthday;

                    editOwnersForm.ShowDialog();

                    if (editOwnersForm.result == true)
                    {
                        int ownerCode = Convert.ToInt32(editOwnersForm.textBoxOwnerCode.Text);
                        string address = editOwnersForm.comboBoxAddress.Text;
                        string ownerName = editOwnersForm.textBoxOwnerName.Text;
                        string passportData = editOwnersForm.textBoxPassportData.Text;
                        string date = editOwnersForm.dateTimePickerBirthday.Value.ToString();
                        date = date.Substring(0, date.IndexOf(' '));
                        DateTime birthday = DateTime.Parse(date);

                        this.проживающиеTableAdapter.Update(ownerCode, address, ownerName, passportData, birthday, Convert.ToInt32(oldOwnerCode));
                        SortByAddress();
                    }
                }
            }
        }

        private void deleteOwner_Click(object sender, EventArgs e)
        {
            if (tableOwners.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tableOwners.SelectedRows[0].Index;

                    int ownerCode = Convert.ToInt32(tableOwners.Rows[currentRowIndex].Cells[0].Value.ToString());

                    this.проживающиеTableAdapter.Delete(ownerCode);
                    SortByAddress();
                }
            }
        }

        private void addPayment_Click(object sender, EventArgs e)
        {
            EditPaymentsForm editPaymentsForm = new EditPaymentsForm();
            editPaymentsForm.comboBoxAddress.DataSource = GetAddresses();
            if (tableApartments.SelectedRows.Count == 0)
            {
                editPaymentsForm.comboBoxAddress.Text = "";
            }
            else
            {
                int index = tableApartments.SelectedRows[0].Index;
                editPaymentsForm.comboBoxAddress.Text = tableApartments.Rows[index].Cells[0].Value.ToString();
            }
            editPaymentsForm.ShowDialog();

            if (editPaymentsForm.result == true)
            {
                string personalAccount = editPaymentsForm.textBoxPersonalAccount.Text;
                string address = editPaymentsForm.comboBoxAddress.Text;
                string period = editPaymentsForm.comboBoxPeriod.Text;
                double price = Convert.ToDouble(editPaymentsForm.textBoxPrice.Text);
                double duty = Convert.ToDouble(editPaymentsForm.textBoxDuty.Text);
                string date = editPaymentsForm.dateTimePickerPaymentDate.Value.ToString();
                date = date.Substring(0, date.IndexOf(' '));
                DateTime paymentDate = DateTime.Parse(date);
                double paymentSum = Convert.ToDouble(editPaymentsForm.textBoxPaymentSum.Text);

                this.оплатаTableAdapter.Insert(personalAccount, address, period, price, duty, paymentDate, paymentSum);
                SortByAddress();
            }
        }

        private void changePayment_Click(object sender, EventArgs e)
        {
            if (tablePayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите изменить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tablePayments.SelectedRows[0].Index;

                    string oldPersonalAccount = tablePayments.Rows[currentRowIndex].Cells[0].Value.ToString();
                    string oldAddress = tablePayments.Rows[currentRowIndex].Cells[1].Value.ToString();
                    string oldPeriod = tablePayments.Rows[currentRowIndex].Cells[2].Value.ToString();
                    string oldPrice = tablePayments.Rows[currentRowIndex].Cells[3].Value.ToString();
                    string oldDuty = tablePayments.Rows[currentRowIndex].Cells[4].Value.ToString();
                    DateTime oldPaymentDate = DateTime.Parse(tablePayments.Rows[currentRowIndex].Cells[5].Value.ToString());
                    string oldPaymentSum = tablePayments.Rows[currentRowIndex].Cells[6].Value.ToString();

                    EditPaymentsForm editPaymentsForm = new EditPaymentsForm();

                    editPaymentsForm.comboBoxAddress.DataSource = GetAddresses();
                    editPaymentsForm.textBoxPersonalAccount.Text = oldPersonalAccount;
                    editPaymentsForm.comboBoxAddress.Text = oldAddress;
                    editPaymentsForm.comboBoxPeriod.Text = oldPeriod;
                    editPaymentsForm.textBoxPrice.Text = oldPrice;
                    editPaymentsForm.textBoxDuty.Text = oldDuty;
                    editPaymentsForm.dateTimePickerPaymentDate.Value = oldPaymentDate;
                    editPaymentsForm.textBoxPaymentSum.Text = oldPaymentSum;

                    editPaymentsForm.ShowDialog();

                    if (editPaymentsForm.result == true)
                    {
                        string personalAccount = editPaymentsForm.textBoxPersonalAccount.Text;
                        string address = editPaymentsForm.comboBoxAddress.Text;
                        string period = editPaymentsForm.comboBoxPeriod.Text;
                        decimal price = Convert.ToDecimal(editPaymentsForm.textBoxPrice.Text);
                        decimal duty = Convert.ToDecimal(editPaymentsForm.textBoxDuty.Text);
                        string date = editPaymentsForm.dateTimePickerPaymentDate.Value.ToString();
                        date = date.Substring(0, date.IndexOf(' '));
                        DateTime paymentDate = DateTime.Parse(date);
                        decimal paymentSum = Convert.ToDecimal(editPaymentsForm.textBoxPaymentSum.Text);

                        this.оплатаTableAdapter.Update(personalAccount, address, period, price, duty, paymentDate, paymentSum, oldPersonalAccount);
                        SortByAddress();
                    }
                }
            }
        }

        private void deletePayment_Click(object sender, EventArgs e)
        {
            if (tablePayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить выбранную строку?", "Внимание!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int currentRowIndex = tablePayments.SelectedRows[0].Index;

                    string personalAccount = tablePayments.Rows[currentRowIndex].Cells[0].Value.ToString();

                    this.оплатаTableAdapter.Delete(personalAccount);
                    SortByAddress();
                }
            }
        }

        private void SortByAddress()
        {
            if (tableApartments.SelectedRows.Count != 0)
            {
                int index = tableApartments.SelectedRows[0].Index;
                string address = tableApartments.Rows[index].Cells[0].Value.ToString();
                this.оплатаTableAdapter.Fill(this.оплата_ЖКХDataSet.Оплата, address);
                this.проживающиеTableAdapter.Fill(this.оплата_ЖКХDataSet.Проживающие, address);
            }
        }

        private void tableApartments_SelectionChanged(object sender, EventArgs e)
        {
            SortByAddress();
        }
    }
}