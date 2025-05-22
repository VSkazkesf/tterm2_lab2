namespace term2_lab2
{
    partial class Form11
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
            cmbBooks = new ComboBox();
            label1 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(245, 14);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(401, 29);
            cmbBooks.TabIndex = 0;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 1;
            label1.Text = "Выберите книгу для удаления:";
            label1.Click += label1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 221);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(cmbBooks);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBooks;
        private Label label1;
        private Button btnDelete;
    }
}