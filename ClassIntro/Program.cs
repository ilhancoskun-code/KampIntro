using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kapmı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 65;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kursalar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kursalar)
            {
                Console.WriteLine(kurs.KursAdi + "--" + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
