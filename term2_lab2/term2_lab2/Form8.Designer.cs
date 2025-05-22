namespace term2_lab2
{
    partial class Form8
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
            dataGridView1 = new DataGridView();
            сolumnTitle = new DataGridViewTextBoxColumn();
            columnAuthor = new DataGridViewTextBoxColumn();
            сolumnId = new DataGridViewTextBoxColumn();
            columnBorrower = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { сolumnTitle, columnAuthor, сolumnId, columnBorrower });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(860, 195);
            dataGridView1.TabIndex = 0;
            // 
            // сolumnTitle
            // 
            сolumnTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            сolumnTitle.HeaderText = "Название";
            сolumnTitle.MinimumWidth = 7;
            сolumnTitle.Name = "сolumnTitle";
            сolumnTitle.ReadOnly = true;
            сolumnTitle.Width = 110;
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
            // сolumnId
            // 
            сolumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            сolumnId.HeaderText = "ID";
            сolumnId.MinimumWidth = 7;
            сolumnId.Name = "сolumnId";
            сolumnId.ReadOnly = true;
            сolumnId.Width = 57;
            // 
            // columnBorrower
            // 
            columnBorrower.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnBorrower.HeaderText = "Заемщик";
            columnBorrower.MinimumWidth = 7;
            columnBorrower.Name = "columnBorrower";
            columnBorrower.ReadOnly = true;
            columnBorrower.Width = 108;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(885, 360);
            Controls.Add(dataGridView1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn сolumnTitle;
        private DataGridViewTextBoxColumn columnAuthor;
        private DataGridViewTextBoxColumn сolumnId;
        private DataGridViewTextBoxColumn columnBorrower;
    }
}