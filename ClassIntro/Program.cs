using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.IzlenmeOrani = 25;
            kurs1.KursAdi = "C# Temelleri";
            kurs1.Egitmen = "Emincan Şöhret";

            Kurs kurs2 = new Kurs();

            kurs2.IzlenmeOrani = 12;
            kurs2.KursAdi = "C# Temelleri 2";
            kurs2.Egitmen = "Emincan Şöhret";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kursAdi in kurslar)
            {
                Console.WriteLine(kursAdi.KursAdi);
            }

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.IzlenmeOrani);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}