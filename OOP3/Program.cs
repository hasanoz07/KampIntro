using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafCreditManager();

            ILogerService smslogger = new SmsLoggerService();
            ILogerService databaselogger = new DatabaseLoggerService();
            ILogerService filelogger = new FileLoggerService();


            List<ILogerService> loggers = new List<ILogerService> { smslogger, filelogger };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);
            

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,
                tasitKrediManager,konutKrediManager};

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            //İnterface ile olsa da aynı sonucu alırdın.


        }
    }
}
