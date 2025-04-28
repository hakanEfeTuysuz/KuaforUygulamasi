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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); // Form3'ü gizle
            Form1 form1 = new Form1(); // Yeni bir Form1 nesnesi oluştur
            form1.Show(); // Yeni Form1 nesnesini göster
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Tüm randevuları ListBox'a ekle
            foreach (var randevu in RandevuVeritabani.Randevular)
            {
                listBox1.Items.Add($"Sıra: {randevu.Sira}  |  Ad: {randevu.Ad}  |  Soyad: {randevu.Soyad}  |  Telefon No: {randevu.TelefonNo}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secim = listBox1.SelectedIndex;
            if (secim != -1)
            {
                // Seçilen öğeyi listbox'tan kaldır
                listBox1.Items.RemoveAt(secim);

                // Seçilen öğenin veri kaynağından da silinmesi gerekiyor
                RandevuVeritabani.Randevular.RemoveAt(secim);

                // Silinen öğeden sonraki tüm öğelerin sırasını bir azalt
                for (int i = secim; i < RandevuVeritabani.Randevular.Count; i++)
                {
                    RandevuVeritabani.Randevular[i].Sira--;
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek randevuyu seçiniz");
            }
        }
    }
}
