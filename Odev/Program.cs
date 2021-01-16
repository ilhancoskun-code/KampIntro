using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Cesit = "Telefon";
            urun1.Marka = "Xiaomi";
            urun1.Model = "Note 8 Pro";
            urun1.Fiyat = 3000;

            Product urun2 = new Product();
            urun2.Cesit = "Tablet";
            urun2.Marka = "Samsung";
            urun2.Model = "Tab10";
            urun2.Fiyat = 4000;


            Product urun3 = new Product();
            urun3.Cesit = "Ayakkabı";
            urun3.Marka = "Greyder";
            urun3.Model = "WaterProof Outdoor G125";
            urun3.Fiyat = 499.99;

            Product urun4 = new Product();
            urun4.Cesit = "Televizyon";
            urun4.Marka = "LG";
            urun4.Model = "LG4255SMART";
            urun4.Fiyat = 7999.49;

            Product [] urunler = new Product[] { urun1, urun2, urun3, urun4 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Cesit + "---" + urun.Marka + "---" + urun.Model + "---" + urun.Fiyat);
            }
        }
    }

    class Product
    {
        public string Cesit { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
    }
}
