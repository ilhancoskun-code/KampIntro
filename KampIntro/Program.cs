using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirsiYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değşişmedi butonu");
            }


            if (sistemeGirsiYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
