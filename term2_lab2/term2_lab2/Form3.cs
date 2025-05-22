using laba_1_sem_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term2_lab2
{
    public partial class Form3 : Form
    {
        private Form1 _form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            foreach (Book i in _form1._library.Books)
            {
                var t = "Нет";
                if (i.IsAvailable) t = "Да";
                gridWithBooks.Rows.Add(i.Author, i.Title, i.Isbn, t);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void gridWithBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
