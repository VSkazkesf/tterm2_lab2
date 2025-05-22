using laba_1_sem_2;

namespace term2_lab2
{
    public partial class Form1 : Form
    {
        internal Library _library = new Library();

        public Form1()
        {
            InitializeComponent();
            Text = "Антропов Георгий Сергеевич  Б24-171-1  Вариант - 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBok_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void btnAvailableBooks_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }

        private void btnShowMembers_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.ShowDialog();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.ShowDialog();
        }

        private void btnLoanedBooks_Click(object sender, EventArgs e)
        {
            new Form8(this).ShowDialog();
        }

        private void btnAvailablebooks_Click(object sender, EventArgs e)
        {
            new Form9(this).ShowDialog();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            new Form10(this).ShowDialog();
        }

        private void btnDeleteBook_Click_1(object sender, EventArgs e)
        {
            Form11 deleteForm = new Form11(this);
            deleteForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
