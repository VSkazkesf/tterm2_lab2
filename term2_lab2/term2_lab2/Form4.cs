using laba_1_sem_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form4 : Form
    {
        private Form1 _form1;

        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Введите имя пользователя");
                    return;
                }

                _form1._library.RegisterMember(new Member(name));
                MessageBox.Show("Пользователь добавлен!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
