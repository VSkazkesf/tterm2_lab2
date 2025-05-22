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
    public partial class Form5 : Form
    {
        private Form1 _form1;

        public Form5(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            foreach (Member member in _form1._library.Members)
            {
                dataGridView1.Rows.Add(member.Name, member.MemberId);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


    }
}
