using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneyeDayalıProgramlamaProje
{
    internal class Sınıflar
    {
        public abstract class Kişi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
        }
        public class Randevu : Kişi
        {
           
            public string TelefonNo { get; set; }
            public int Sira { get; set; }

           
        }

        public class Personel : Kişi
        {
            public string Pozisyon { get; set; }

        }

        public static class RandevuVeritabani
        {
            public static List<Randevu> Randevular { get; } = new List<Randevu>();
        }

        public static class PersonelVeriTabani
        {
            public static List<Personel> Personeller { get; } = new List<Personel>();
        }


    }
}
