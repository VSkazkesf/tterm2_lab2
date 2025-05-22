namespace term2_lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddBok = new Button();
            btnAvailableBooks = new Button();
            btnAddMember = new Button();
            btnShowMembers = new Button();
            btnLoanBook = new Button();
            btnReturnBook = new Button();
            btnLoanedBooks = new Button();
            btnAvailableabooks = new Button();
            btnSearchBook = new Button();
            btnDeleteBook = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddBok
            // 
            btnAddBok.Location = new Point(12, 12);
            btnAddBok.Name = "btnAddBok";
            btnAddBok.Size = new Size(178, 66);
            btnAddBok.TabIndex = 0;
            btnAddBok.Text = "Добавить книгу";
            btnAddBok.UseVisualStyleBackColor = true;
            btnAddBok.Click += btnAddBok_Click;
            // 
            // btnAvailableBooks
            // 
            btnAvailableBooks.Location = new Point(12, 84);
            btnAvailableBooks.Name = "btnAvailableBooks";
            btnAvailableBooks.Size = new Size(178, 66);
            btnAvailableBooks.TabIndex = 1;
            btnAvailableBooks.Text = "Узнать все книги";
            btnAvailableBooks.UseVisualStyleBackColor = true;
            btnAvailableBooks.Click += btnAvailableBooks_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(526, 12);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(178, 66);
            btnAddMember.TabIndex = 2;
            btnAddMember.Text = "Добавить пользователя";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // btnShowMembers
            // 
            btnShowMembers.Location = new Point(526, 84);
            btnShowMembers.Name = "btnShowMembers";
            btnShowMembers.Size = new Size(178, 66);
            btnShowMembers.TabIndex = 3;
            btnShowMembers.Text = "Узнать всех пользователей";
            btnShowMembers.UseVisualStyleBackColor = true;
            btnShowMembers.Click += btnShowMembers_Click;
            // 
            // btnLoanBook
            // 
            btnLoanBook.Location = new Point(12, 156);
            btnLoanBook.Name = "btnLoanBook";
            btnLoanBook.Size = new Size(178, 66);
            btnLoanBook.TabIndex = 4;
            btnLoanBook.Text = "Взять книгу";
            btnLoanBook.UseVisualStyleBackColor = true;
            btnLoanBook.Click += btnLoanBook_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(12, 228);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(178, 66);
            btnReturnBook.TabIndex = 5;
            btnReturnBook.Text = "Вернуть книгу";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnLoanedBooks
            // 
            btnLoanedBooks.Location = new Point(196, 84);
            btnLoanedBooks.Name = "btnLoanedBooks";
            btnLoanedBooks.Size = new Size(178, 66);
            btnLoanedBooks.TabIndex = 1;
            btnLoanedBooks.Text = "Недоступные книги";
            btnLoanedBooks.Click += btnLoanedBooks_Click;
            // 
            // btnAvailableabooks
            // 
            btnAvailableabooks.Location = new Point(196, 12);
            btnAvailableabooks.Name = "btnAvailableabooks";
            btnAvailableabooks.Size = new Size(178, 66);
            btnAvailableabooks.TabIndex = 0;
            btnAvailableabooks.Text = "Доступные книги";
            btnAvailableabooks.Click += btnAvailablebooks_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(196, 156);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(178, 66);
            btnSearchBook.TabIndex = 6;
            btnSearchBook.Text = "Найти книгу по названию";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(196, 228);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(178, 66);
            btnDeleteBook.TabIndex = 7;
            btnDeleteBook.Text = "Удалить книгу";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(314, 323);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 30);
            btnExit.TabIndex = 9;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 365);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnSearchBook);
            Controls.Add(btnAvailableabooks);
            Controls.Add(btnLoanedBooks);
            Controls.Add(btnReturnBook);
            Controls.Add(btnLoanBook);
            Controls.Add(btnShowMembers);
            Controls.Add(btnAddMember);
            Controls.Add(btnAvailableBooks);
            Controls.Add(btnAddBok);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Антропов Георгий Сергеевич  Б24-171-1  Вариант - 1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBok;
        private Button btnAvailableBooks;
        private Button btnAddMember;
        private Button btnShowMembers;
        private Button btnLoanBook;
        private Button btnReturnBook;
        private Button btnLoanedBooks;
        private Button btnAvailableabooks;
        private Button btnSearchBook;
        private Button btnDeleteBook;
        private Button btnExit;
    }
}
