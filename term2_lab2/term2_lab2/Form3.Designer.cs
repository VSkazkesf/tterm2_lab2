namespace term2_lab2
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            gridWithBooks = new DataGridView();
            libraryBindingSource = new BindingSource(components);
            columnAuthor = new DataGridViewTextBoxColumn();
            columnTitle = new DataGridViewTextBoxColumn();
            columnIsbn = new DataGridViewTextBoxColumn();
            columnIsAvailable = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridWithBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridWithBooks
            // 
            gridWithBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridWithBooks.Columns.AddRange(new DataGridViewColumn[] { columnAuthor, columnTitle, columnIsbn, columnIsAvailable });
            gridWithBooks.Location = new Point(12, 12);
            gridWithBooks.Name = "gridWithBooks";
            gridWithBooks.RowHeadersWidth = 53;
            gridWithBooks.Size = new Size(776, 426);
            gridWithBooks.TabIndex = 0;
            gridWithBooks.CellContentClick += gridWithBooks_CellContentClick;
            // 
            // libraryBindingSource
            // 
            libraryBindingSource.DataSource = typeof(laba_1_sem_2.Library);
            // 
            // columnAuthor
            // 
            columnAuthor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnAuthor.HeaderText = "Автор";
            columnAuthor.MinimumWidth = 7;
            columnAuthor.Name = "columnAuthor";
            columnAuthor.ReadOnly = true;
            columnAuthor.Width = 85;
            // 
            // columnTitle
            // 
            columnTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnTitle.HeaderText = "Название";
            columnTitle.MinimumWidth = 7;
            columnTitle.Name = "columnTitle";
            columnTitle.ReadOnly = true;
            columnTitle.Width = 110;
            // 
            // columnIsbn
            // 
            columnIsbn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnIsbn.HeaderText = "ID";
            columnIsbn.MinimumWidth = 7;
            columnIsbn.Name = "columnIsbn";
            columnIsbn.ReadOnly = true;
            columnIsbn.Width = 57;
            // 
            // columnIsAvailable
            // 
            columnIsAvailable.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnIsAvailable.HeaderText = "Дступна";
            columnIsAvailable.MinimumWidth = 7;
            columnIsAvailable.Name = "columnIsAvailable";
            columnIsAvailable.ReadOnly = true;
            columnIsAvailable.Width = 101;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridWithBooks);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)gridWithBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridWithBooks;
        private BindingSource libraryBindingSource;
        private DataGridViewTextBoxColumn columnAuthor;
        private DataGridViewTextBoxColumn columnTitle;
        private DataGridViewTextBoxColumn columnIsbn;
        private DataGridViewTextBoxColumn columnIsAvailable;
    }
}