using System;
using System.Linq;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form10 : Form
    {
        private Form1 _form1;

        public Form10(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Введите название книги для поиска");
                    return;
                }

                var foundBooks = _form1._library.Books
                    .Where(b => b.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (!foundBooks.Any())
                {
                    MessageBox.Show("Книги с таким названием не найдены");
                    return;
                }

                // Очищаем предыдущие результаты
                gridFoundBooks.Rows.Clear();

                // Выводим найденные книги
                foreach (var book in foundBooks)
                {
                    string status = book.IsAvailable ? "Доступна" : "Выдана";
                    gridFoundBooks.Rows.Add(book.Title, book.Author, book.Isbn, status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}