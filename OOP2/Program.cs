using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri muster1 = new GercekMusteri();
            muster1.MusteriNo = "12345";
            muster1.Adi = "Engin";
            muster1.Soyadi = "Demiroğ";
            muster1.TcNo = "12345678901";
            muster1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";
        }
    }
}
