namespace term2_lab2
{
    partial class Form5
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
            columnName = new DataGridViewTextBoxColumn();
            columnMemberId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnName, columnMemberId });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 53;
            dataGridView1.Size = new Size(499, 426);
            dataGridView1.TabIndex = 0;
            // 
            // columnName
            // 
            columnName.HeaderText = "Имя";
            columnName.MinimumWidth = 7;
            columnName.Name = "columnName";
            columnName.Width = 130;
            // 
            // columnMemberId
            // 
            columnMemberId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            columnMemberId.HeaderText = "Member ID";
            columnMemberId.MinimumWidth = 7;
            columnMemberId.Name = "columnMemberId";
            columnMemberId.ReadOnly = true;
            columnMemberId.Width = 25;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnMemberId;
    }
}