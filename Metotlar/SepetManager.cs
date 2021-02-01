using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        //parametre = ben sepete eklicem ama ne eklicem? bu yüzden parametrelere ihtiyaç duyarız
        public void Ekle(Urun urun)//imza
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urun.Adi);


        }
        //bir class ın içinde birden fazla metot olabilir
        public void Ekle2(string urunAdi, string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urunAdi);
        }

    }
}
