using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Eti Browni ";
            urun1.UrunTuru = " Gıda";
            urun1.UrunNo = 45;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Okul Defteri";
            urun2.UrunTuru = " Kırtasiye";
            urun2.UrunNo = 98;

            Urun urun3 = new Urun();
            urun3.UrunAdi = " Makarna ";
            urun3.UrunTuru = " Gıda";
            urun3.UrunNo = 38;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };


            Console.WriteLine("******************************************");

            for (int i = 0; i <urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + ": " + urunler[i].UrunNo);
            }
            Console.WriteLine("******************************************");
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " " + urun.UrunNo);
            }

            Console.WriteLine("******************************************");
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " " + urunler[a].UrunNo);
                a++;
            }


        }

        class Urun
        {
            //ürünün özellikleri
            public string UrunAdi { get; set; }
            public string UrunTuru { get; set; }
            public int UrunNo { get; set; }




        }
    }
    }

