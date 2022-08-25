using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterfacelerde,o interface i implumente eden classın referansını tutabilir.Aşağıdaki gibi.
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
                                                                                                    //instance oluşturdum.
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService(),fileLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);
            //basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);  //23 ve 24. satırları BasvuruManagerdaki ILoggerService i List şeklinde VERMESEYDİK kullanıcaktık
            //basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
            basvuruManager.KrediOnBiligilendirmesiYap(krediler);
        
        }
    }
}
