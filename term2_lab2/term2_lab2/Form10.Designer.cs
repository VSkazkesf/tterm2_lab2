namespace term2_lab2
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            txtSearch = new TextBox();
            gridFoundBooks = new DataGridView();
            columnAuthor = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnIsbn = new DataGridViewTextBoxColumn();
            columnIsAvailable = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridFoundBooks).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(351, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Найти";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(204, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(130, 29);
            txtSearch.TabIndex = 2;
            // 
            // gridFoundBooks
            // 
            gridFoundBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFoundBooks.Columns.AddRange(new DataGridViewColumn[] { columnAuthor, columnTitle, columnIsbn, columnIsAvailable });
            gridFoundBooks.Location = new Point(12, 71);
            gridFoundBooks.Name = "gridFoundBooks";
            gridFoundBooks.RowHeadersWidth = 53;
            gridFoundBooks.Size = new Size(575, 426);
            gridFoundBooks.TabIndex = 3;
            // 
            // columnAuthor
            // 
            columnAuthor.HeaderText = "Автор";
            columnAuthor.MinimumWidth = 7;
            columnAuthor.Name = "columnAuthor";
            columnAuthor.ReadOnly = true;
            columnAuthor.Width = 130;
            // 
            // columnTitle
            // 
            columnTitle.HeaderText = "Название";
            columnTitle.MinimumWidth = 7;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 130;
            // 
            // columnIsbn
            // 
            columnIsbn.HeaderText = "ID";
            columnIsbn.MinimumWidth = 7;
            columnIsbn.Name = "columnIsbn";
            columnIsbn.ReadOnly = true;
            columnIsbn.Width = 130;
            // 
            // columnIsAvailable
            // 
            columnIsAvailable.HeaderText = "Дступность";
            columnIsAvailable.MinimumWidth = 7;
            columnIsAvailable.Name = "columnIsAvailable";
            columnIsAvailable.ReadOnly = true;
            columnIsAvailable.Width = 130;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 4;
            label1.Text = "Введите название книги:";
            label1.Click += label1_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 584);
            Controls.Add(label1);
            Controls.Add(gridFoundBooks);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "Form10";
            Text = "Form10";
            ((System.ComponentModel.ISupportInitialize)gridFoundBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView gridFoundBooks;
        private DataGridViewTextBoxColumn columnAuthor;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnIsbn;
        private DataGridViewTextBoxColumn columnIsAvailable;
        private Label label1;
    }
}