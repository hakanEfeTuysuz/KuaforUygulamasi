using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneyeDayalıProgramlamaProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Form4'ü gizle
            Form1 form1 = new Form1(); // Yeni bir Form1 nesnesi oluştur
            form1.Show(); // Yeni Form1 nesnesini göster
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Seçilen işlemleri ve fiyatlarını depolamak için değişkenler
            List<string> secilenIslemler = new List<string>();
            double toplamTutar = 0;

            // Checkbox'ları kontrol ederek seçilen işlemleri belirle ve fiyatları hesapla
            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    // Checkbox'ın adı işlem adını, Tag özelliği ise fiyatı içerir
                    string islemAdi = checkBox.Text;
                    double fiyat = Convert.ToDouble(checkBox.Tag);

                    // Seçilen işlemi ve fiyatını listeye ekle
                    secilenIslemler.Add($"{islemAdi}: {fiyat:C}");
                    toplamTutar += fiyat;
                }            
            }

            if (checkBox11.Checked)
            {
                secilenIslemler.Add($"{"%10 İlk Müşteri İndirimi"}: {-toplamTutar/10:C}");
                toplamTutar = toplamTutar - toplamTutar / 10;
            }

            // Seçilen işlemlerin ve toplam tutarın gösterildiği bir mesaj kutusu oluştur
            string secilenIslemlerMetin = string.Join("\n", secilenIslemler);
            string hesaplamaSonucu = $"Seçilen İşlemler:\n{secilenIslemlerMetin}\n\nToplam Tutar: {toplamTutar:C}";

            MessageBox.Show(hesaplamaSonucu, "Hesaplama Sonucu");
        }
    }
}
