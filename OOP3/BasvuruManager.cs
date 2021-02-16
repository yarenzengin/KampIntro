using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
        //Method injection
    {
        public void BasvuruYap(IKrediManager krediManager ,List<ILoggerService> loggerServices)//hangi krediye göre bu başvuruyu alıcam
        {
            // burda bir tane kredinin hesabını yaptık
            //Başvuran bilgilerini değerlendirme

            //böyle yaparsak tüm başvurular konut kredisi üzerinden hesaplanır
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            /* loggerService.Log();*///hangi log layıcı seçilmişse onu logla
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();//her bir loglayıcıyı çalıştır

            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)// 0 tane de olabilir 100 tane de olabilir
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();//listedeki her bir kredinin hesabını yap

            }

        }
    }
}
