using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yaren";
            musteri1.Soyad = "Zengin";

            Musteri musteri2= new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Şevval";
            musteri2.Soyad = "Dönmez";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Elif";
            musteri3.Soyad = "Akyol ";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Nejdet";
            musteri4.Soyad = "Yılmaz ";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri4);


            Console.WriteLine("-------Müşteri Listesi--------");
            musteriManager.Listeleme(musteri1);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri2);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri3);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri4);
            Console.WriteLine("---------------------------");

            musteriManager.MusteriSilme(musteri3);

        }
    //    using System;

    //         namespace ClassIntro nun Kodları
    //         {
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            string adi = "yaren";
    //            int yas = 36;

    //            //classlarda bir kurs değişkeni tanımlamak istiyorsan böyle yazmalısın
    //            Kurs kurs1 = new Kurs();
    //            kurs1.KursAdi = "C#";
    //            kurs1.Egitmen = "engin demiroğ";
    //            kurs1.IzlenmeOrani = 68;

    //            Kurs kurs2 = new Kurs();
    //            kurs2.KursAdi = "java";
    //            kurs2.Egitmen = "yaren zengin ";
    //            kurs2.IzlenmeOrani = 64;

    //            Kurs kurs3 = new Kurs();
    //            kurs3.KursAdi = "phyton";
    //            kurs3.Egitmen = "eray";
    //            kurs3.IzlenmeOrani = 80;

    //            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

    //            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

    //            foreach (var kurs in kurslar)//kurs takma isim
    //            {
    //                Console.WriteLine(kurs.KursAdi);
    //            }









    //            Console.WriteLine("Hello World!");
    //        }

    //        class Kurs
    //        {
    //            //kursun özellikleri
    //            public string KursAdi { get; set; }
    //            public string Egitmen { get; set; }
    //            public int IzlenmeOrani { get; set; }



    //        }



    //    }
    //}



}
}
