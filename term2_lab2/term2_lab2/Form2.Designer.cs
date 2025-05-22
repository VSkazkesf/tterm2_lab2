namespace term2_lab2
{
    partial class Form2
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
            txtAuthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(99, 50);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 29);
            txtAuthor.TabIndex = 3;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Автор:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(99, 17);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 29);
            txtTitle.TabIndex = 0;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(76, 102);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(67, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 144);
            Controls.Add(btnSubmit);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Name = "Form2";
            Text = "мдлорпа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthor;
        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private Button btnSubmit;
    }
}