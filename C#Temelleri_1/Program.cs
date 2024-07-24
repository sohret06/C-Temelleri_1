using System;

namespace CSTemelleri_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            string kategori = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.85;
            double dolarBugun = 8.10;

            if(dolarBugun>dolarDun)
            {
                Console.WriteLine("Dolar Yükselmiştir");
            }
            else if(dolarBugun<dolarDun)
            {
                Console.WriteLine("Dolar Düşmüştür");
            }
            else
            {
                Console.WriteLine("Dolar Değişmemiştir");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Giriş Yapıldı!");
            }
            else
            {
                Console.WriteLine("Giriş Yapılmadı!");
            }

            for (int i = 0; i < 10; i+=2)
            {
                Console.Write(i+" ");
            }

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java"
            };

            for (int i = 0;i < kurslar.Length;i++)
            {
                Console.WriteLine();
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Kurslar Bitti");

            foreach (string s in kurslar)
            {
                Console.WriteLine(s);
            }
        }
    }
}
