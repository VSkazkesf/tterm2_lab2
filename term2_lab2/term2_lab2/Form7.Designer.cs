namespace term2_lab2
{
    partial class Form7
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
            cmbLoanedBooks = new ComboBox();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // cmbLoanedBooks
            // 
            cmbLoanedBooks.FormattingEnabled = true;
            cmbLoanedBooks.Location = new Point(12, 12);
            cmbLoanedBooks.Name = "cmbLoanedBooks";
            cmbLoanedBooks.Size = new Size(798, 29);
            cmbLoanedBooks.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(355, 208);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(98, 30);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Вернуть";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 250);
            Controls.Add(btnReturn);
            Controls.Add(cmbLoanedBooks);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbLoanedBooks;
        private Button btnReturn;
    }
}