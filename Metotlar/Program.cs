using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // metotlar tekrar tekrar kullanılabilirliği sağlıyor.
            //clean code tekniği - best practice tekniği
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();//class ın örneği
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdeti = 3;



            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.stokAdeti = 9;


            Urun[] urunler = new Urun[] { urun1,urun2};

            //tip güvenli -- type safe
            foreach (Urun urun in urunler)//soldaki veri tipi 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdeti);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("---------------Metotlar---------------");

            //instance-örnek(class örneği)
            //encapsulation (class ta yazdığın özellik hata vermez)Bir düzene sokuyorsun.
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


            sepetmanager.Ekle2(" armut ", "yeşil armut",12,2);
            


        }
    }
}
