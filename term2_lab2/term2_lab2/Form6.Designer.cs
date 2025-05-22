namespace term2_lab2
{
    partial class Form6
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
            cmbMembers = new ComboBox();
            cmbBooks = new ComboBox();
            btnSubmit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbMembers
            // 
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(176, 57);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(158, 29);
            cmbMembers.TabIndex = 0;
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(12, 57);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(158, 29);
            cmbBooks.TabIndex = 1;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(135, 378);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(67, 30);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 6;
            label1.Text = "Книги:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 23);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 7;
            label2.Text = "Польозователи:";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(cmbBooks);
            Controls.Add(cmbMembers);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMembers;
        private ComboBox cmbBooks;
        private Button btnSubmit;
        private Label label1;
        private Label label2;
    }
}