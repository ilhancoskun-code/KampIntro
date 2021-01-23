using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface referans eden kodlarını tutabilir
            IKrediManager   ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager   tasitKrediManager = new TasitKrediManager();
            IKrediManager   konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
             

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
