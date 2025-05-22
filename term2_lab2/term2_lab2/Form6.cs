using System;
using System.Linq;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form6 : Form
    {
        private Form1 _form1;

        public Form6(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            // Заполняем список доступных книг
            foreach (var book in _form1._library.Books.Where(b => b.IsAvailable))
            {
                cmbBooks.Items.Add($"{book.Title} (ID: {book.Isbn})");
            }

            // Заполняем список пользователей
            foreach (var member in _form1._library.Members)
            {
                cmbMembers.Items.Add($"{member.Name} (ID: {member.MemberId})");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooks.SelectedIndex == -1 || cmbMembers.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите книгу и пользователя!");
                    return;
                }

                // Получаем выбранные ID
                Guid bookId = ExtractGuidFromCombo(cmbBooks.SelectedItem.ToString());
                Guid memberId = ExtractGuidFromCombo(cmbMembers.SelectedItem.ToString());

                // Находим книгу и пользователя
                var book = _form1._library.Books.FirstOrDefault(b => b.Isbn == bookId);
                var member = _form1._library.Members.FirstOrDefault(m => m.MemberId == memberId);

                if (book == null || member == null)
                {
                    MessageBox.Show("Ошибка: книга или пользователь не найдены!");
                    return;
                }

                // Выдаем книгу
                _form1._library.LoanBook(book, member);
                MessageBox.Show("Книга успешно выдана!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private Guid ExtractGuidFromCombo(string comboText)
        {
            int start = comboText.IndexOf("ID: ") + 4;
            int end = comboText.IndexOf(")", start);
            string guidStr = comboText.Substring(start, end - start);
            return Guid.Parse(guidStr);
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}