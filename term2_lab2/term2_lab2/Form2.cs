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
    public partial class Form2 : Form
    {
        private Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            try
            {
                string title = txtTitle.Text;
                string author = txtAuthor.Text;

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                {
                MessageBox.Show("Введите название книги и ее автора");
                return;
                }

                _form1._library.AddBook(new Book(title, author));
                MessageBox.Show("Книга добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            this.Close();
        }
    }
}
