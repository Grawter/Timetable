using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTUCI_Clock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool autification; 

        public bool check_password(TextBox t)
        {
            string password = "Volna";
            if (t.Text == password)
                return true;
            else if (t.Text == "")
            {
                MessageBox.Show("Получена пустая строка. Введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Введён неправильный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            autification = check_password(textBox1); // проверка правильности пароля

            this.Close(); // закрытие окна пароля
        }
    }
}
