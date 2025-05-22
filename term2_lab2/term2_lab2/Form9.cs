using System;
using System.Linq;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form9 : Form
    {
        private Form1 _form1;

        public Form9(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Заполняем таблицу доступными книгами
            foreach (var book in _form1._library.GetAvailableBooks())
            {
                dataGridView1.Rows.Add(
                    book.Title,
                    book.Author,
                    book.Isbn,
                    "Да" // Доступность
                );
            }
        }
    }
}