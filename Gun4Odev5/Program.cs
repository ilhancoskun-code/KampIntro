using System;

namespace Gun4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "giriş");
            myDictionary.Add(2, "Önsöz");
            myDictionary.Add(3, "Andımız");
            myDictionary.Add(4, "İstiklal Marşı");


            for (int i = 0; i < myDictionary.Length; i++)
            {

                Console.WriteLine("sayfa "+ myDictionary.itemkey[i] + " İçerik: " +myDictionary.itemvalue[i]);
                Console.WriteLine("**********");

            }
         
                
        }
    }
}
