using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyad = "Birinci";
            musteri1.KrediNotu = 100;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mehmet";
            musteri2.Soyad = "İkinci";
            musteri2.KrediNotu = 98;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ali";
            musteri3.Soyad = "Üçüncü";
            musteri3.KrediNotu = 95;

            Musteri[] musteriDizisi = new Musteri[] { musteri1,musteri2,musteri3};



            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine("*****************************************");

            musteriManager.MusteriListele(musteriDizisi);

            Console.WriteLine("******************************************");

            musteriManager.MusteriSilme(musteri3);
        }
    }
}
