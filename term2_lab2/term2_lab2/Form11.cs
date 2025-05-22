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
    public partial class Form11 : Form
    {
        private Form1 _form1;

        public Form11(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            RefreshBookList();
        }

        private void RefreshBookList()
        {
            cmbBooks.Items.Clear();
            foreach (var book in _form1._library.Books)
            {
                cmbBooks.Items.Add($"{book.Title} (ID: {book.Isbn})");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooks.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите книгу для удаления!");
                    return;
                }

                // Извлекаем ISBN из строки
                string selected = cmbBooks.SelectedItem.ToString();
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

                // Проверяем, не выдана ли книга
                if (!book.IsAvailable)
                {
                    MessageBox.Show("Нельзя удалить выданную книгу!");
                    return;
                }

                // Подтверждение удаления
                var confirmResult = MessageBox.Show(
                    $"Удалить книгу '{book.Title}'?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    _form1._library.RemoveBook(book);
                    MessageBox.Show("Книга успешно удалена!");
                    RefreshBookList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
