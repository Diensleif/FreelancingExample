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
    public partial class EditApartmentsForm : Form
    {
        public EditApartmentsForm()
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
            if (textBoxAddress.Text == "")
            {
                MessageBox.Show("Поле 'Адрес' пустое!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsDouble(textBoxArea.Text))
            {
                MessageBox.Show("В поле 'Площадь квартиры' должно быть вещественное число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToDouble(textBoxArea.Text) <= 0)
            {
                MessageBox.Show("Площадь квартиры должна быть больше нуля!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (!IsInteger(textBoxOwnersCount.Text))
            {
                MessageBox.Show("В поле 'Количество проживающих' должно быть целое число!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(textBoxOwnersCount.Text) < 0)
            {
                MessageBox.Show("В квартире не может быть отрицательное количество жильцов!", "Ошибка!", MessageBoxButtons.OK);
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
