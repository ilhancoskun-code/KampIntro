using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(" Sayın " +musteri.Adi+" " +musteri.Soyad + " bankamızda hesabınız oluşturuldu. Hoşgeliniz. ");
        }

        public void MusteriSilme(Musteri musteri) 
        {
            Console.WriteLine(" Sayın " + musteri.Adi + " " + musteri.Soyad + " bankamızdan hesabınız silinmiştir. En kısa sürede tekrar çalışmak dileğiyle. ");
        }

        public void MusteriListele ( Musteri[] musteridetay)
        {
            foreach (var musteri in musteridetay)
            {
                Console.WriteLine("Müşteri Hesap Numarası: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " +musteri.Adi);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşteri Kredi Notu: " + musteri.KrediNotu);
                Console.WriteLine("---------------------------------------------");

            }


        }
    }
}
