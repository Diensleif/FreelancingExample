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
    public partial class EditPaymentsForm : Form
    {
        public EditPaymentsForm()
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
            if (textBoxPersonalAccount.Text == "")
            {
                MessageBox.Show("Поле 'Лицевой счет' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsInteger(textBoxPersonalAccount.Text))
            {
                MessageBox.Show("Поле 'Лицевой счет' должно содержать целое число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(textBoxPersonalAccount.Text) < 0)
            {
                MessageBox.Show("Лицевой счет не может быть отрицательным!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (comboBoxAddress.Text == "")
            {
                MessageBox.Show("Поле 'Адрес' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (comboBoxPeriod.Text == "")
            {
                MessageBox.Show("Поле 'Отчетный период' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsDouble(textBoxPrice.Text))
            {
                MessageBox.Show("Поле 'Стоимость' должно содержать вещественное число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDouble(textBoxPrice.Text) <= 0)
            {
                MessageBox.Show("Стоимость не может быть меньше или равна нулю!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsDouble(textBoxDuty.Text))
            {
                MessageBox.Show("Поле 'Долг' должно содержать вещественное число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDouble(textBoxDuty.Text) < 0)
            {
                MessageBox.Show("Долг не может быть отрицательным!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (dateTimePickerPaymentDate.Value > DateTime.Now)
            {
                MessageBox.Show("Дата оплаты не может быть датой из будущего!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsDouble(textBoxPaymentSum.Text))
            {
                MessageBox.Show("Поле 'Оплаченная сумма' должно содержать вещественное число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDouble(textBoxPaymentSum.Text) <= 0)
            {
                MessageBox.Show("Оплаченная сумма не может быть меньше или равна нулю!", "Ошибка!", MessageBoxButtons.OK);
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
