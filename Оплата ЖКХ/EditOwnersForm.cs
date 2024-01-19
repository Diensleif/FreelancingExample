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
    public partial class EditOwnersForm : Form
    {
        public EditOwnersForm()
        {
            InitializeComponent();
        }

        public bool result = false;

        private bool IsInteger(string text)
        {
            try
            {
                Convert.ToInt32(text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool IsDouble(string text)
        {
            try
            {
                Convert.ToDouble(text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (!IsInteger(textBoxOwnerCode.Text))
            {
                MessageBox.Show("В поле 'Код проживающего' должно быть целое число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(textBoxOwnerCode.Text) < 0)
            {
                MessageBox.Show("Код проживающего не должен быть отрицательным числом", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (comboBoxAddress.Text == "")
            {
                MessageBox.Show("Поле 'Адрес' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (textBoxOwnerName.Text == "")
            {
                MessageBox.Show("Поле 'ФИО проживающего' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            string[] passportData = textBoxPassportData.Text.Split(' ');
            if (passportData.Length != 2)
            {
                MessageBox.Show("Заполните поле 'Паспортные данные' в формате '#### ######',\nгде '#' — любая цифра!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (passportData[0].Length != 4)
            {
                MessageBox.Show("Серия паспорта должна состоять из 4 цифр!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (passportData[1].Length != 6)
            {
                MessageBox.Show("Номер паспорта должен состоять из 6 цифр!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsInteger(passportData[0]) || !IsInteger(passportData[1]))
            {
                MessageBox.Show("Паспортные данные должны содержать только цифры!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (dateTimePickerBirthday.Value > DateTime.Now)
            {
                MessageBox.Show("Дата рождения проживающего не может находиться в будушем!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            result = true;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
        }
    }
}
