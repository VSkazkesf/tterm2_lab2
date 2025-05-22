using System;
using System.Linq;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form7 : Form
    {
        private Form1 _form1;

        public Form7(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Заполняем список выданных книг
            foreach (var book in _form1._library.Books.Where(b => !b.IsAvailable))
            {
                // Находим кто взял книгу
                var borrower = _form1._library.Members
                    .FirstOrDefault(m => m.LoanedBooks.Any(b => b.Isbn == book.Isbn));

                cmbLoanedBooks.Items.Add(
                    $"{book.Title} (ID: {book.Isbn}) | Взял: {borrower?.Name ?? "неизвестно"}");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbLoanedBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите книгу для возврата!");
                    return;
                }

                // Извлекаем ISBN книги из строки
                string selected = cmbLoanedBooks.SelectedItem.ToString();
                int start = selected.IndexOf("ID: ") + 4;
                int end = selected.IndexOf(")", start);
                Guid bookId = Guid.Parse(selected.Substring(start, end - start));

                // Находим книгу
                var book = _form1._library.Books.FirstOrDefault(b => b.Isbn == bookId);
                if (book == null)
                {
                    MessageBox.Show("Книга не найдена!");
                    return;
                }

                // Возвращаем книгу
                _form1._library.ReturnBook(book);
                MessageBox.Show("Книга успешно возвращена в библиотеку!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}