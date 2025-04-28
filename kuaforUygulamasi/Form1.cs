using static NesneyeDayalıProgramlamaProje.Sınıflar;

namespace NesneyeDayalıProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2'yi gösterirken, Form1'i gizle
            Form2 form2 = new Form2();
            form2.Owner = this; // Form1'in sahibi olarak belirtiyoruz

            form2.Show();
            this.Hide(); // Form1'i gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
