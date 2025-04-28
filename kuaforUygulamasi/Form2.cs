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

namespace NesneyeDayalıProgramlamaProje
{
    public partial class Form2 : Form
    {
        private List<Randevu> randevular = new List<Randevu>();
        private int siradakiRandevu = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form2'den Form1'e geri dön
            Form1 form1 = (Form1)this.Owner; // Form1'e erişim

            form1.Show(); // Form1'i göster
            this.Hide(); // Form2'yi gizle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string ad = adTextBox.Text;
            string soyad = soyadTextBox.Text;
            string telefonNo = telefonNoTextBox.Text;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(telefonNo))
            {
                MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Randevu randevu = new Randevu
                {
                    Ad = ad,
                    Soyad = soyad,
                    TelefonNo = telefonNo,
                    Sira = RandevuVeritabani.Randevular.Count + 1
                };

                RandevuVeritabani.Randevular.Add(randevu);
                MessageBox.Show("Randevu oluşturuldu.");

                adTextBox.Clear();
                soyadTextBox.Clear();
                telefonNoTextBox.Clear();
            }

        }
    }
}
