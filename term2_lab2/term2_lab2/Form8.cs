using System;
using System.Linq;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form8 : Form
    {
        private Form1 _form1;

        public Form8(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Заполняем таблицу выданными книгами
            foreach (var book in _form1._library.GetLoans())
            {
                var borrower = _form1._library.Members
                    .FirstOrDefault(m => m.LoanedBooks.Any(b => b.Isbn == book.Isbn));

                dataGridView1.Rows.Add(
                    book.Title,
                    book.Author,
                    book.Isbn,
                    borrower?.Name ?? "неизвестно"
                );
            }
        }
    }
}