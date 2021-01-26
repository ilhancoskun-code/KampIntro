using System;

namespace Ocak20Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Giriş");
            myDictionary.Add(2, "Önsöz");
            myDictionary.Add(3, "Andımız");
            myDictionary.Add(4, "İstiklal Marşı");


            for (int i = 0; i < myDictionary.Length; i++)
            {

                Console.WriteLine("sayfa " + myDictionary.itemkey[i] + " İçerik: " + myDictionary.itemvalue[i]);
                Console.WriteLine("**********");

            }

        }
    }
}
