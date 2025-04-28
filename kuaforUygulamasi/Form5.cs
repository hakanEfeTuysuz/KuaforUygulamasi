using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NesneyeDayalıProgramlamaProje.Sınıflar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesneyeDayalıProgramlamaProje
{
    public partial class Form5 : Form
    {
        private List<Personel> personeller = new List<Personel>();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Form5'i gizle
            Form1 form1 = new Form1(); // Yeni bir Form1 nesnesi oluştur
            form1.Show(); // Yeni Form5 nesnesini göster
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string pozisyon = textBox3.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(pozisyon))
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Personel personel = new Personel
                {
                    Ad = ad,
                    Soyad = soyad,
                    Pozisyon = pozisyon,

                };

                PersonelVeriTabani.Personeller.Add(personel);
                MessageBox.Show("Personel oluşturuldu.");

                listBox1.Items.Add($"{personel.Ad} {personel.Soyad} - {personel.Pozisyon}");

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            // Personel listesinden verileri ListBox'a ekleyin
            foreach (Personel personel in PersonelVeriTabani.Personeller)
            {
                listBox1.Items.Add($"{personel.Ad}  {personel.Soyad} - {personel.Pozisyon}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                // Seçilen öğeyi listbox'tan kaldır
                listBox1.Items.RemoveAt(secim);

                // Seçilen öğenin veri kaynağından da silinmesi gerekiyor
                PersonelVeriTabani.Personeller.RemoveAt(secim);            
            }
            else
            {
                MessageBox.Show("Lütfen silinecek personeli seçiniz");
            }
        }
    }
}
