namespace term2_lab2
{
    partial class Form9
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
            columnAvailability = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { сolumnTitle, columnAuthor, сolumnId, columnAvailability });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(866, 195);
            dataGridView1.TabIndex = 1;
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
            // columnAvailability
            // 
            columnAvailability.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            columnAvailability.HeaderText = "Доступность";
            columnAvailability.MinimumWidth = 7;
            columnAvailability.Name = "columnAvailability";
            columnAvailability.ReadOnly = true;
            columnAvailability.Width = 133;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(890, 386);
            Controls.Add(dataGridView1);
            Name = "Form9";
            Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn сolumnTitle;
        private DataGridViewTextBoxColumn columnAuthor;
        private DataGridViewTextBoxColumn сolumnId;
        private DataGridViewTextBoxColumn columnAvailability;
    }
}