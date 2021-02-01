﻿using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "yaren";
            int yas = 36;

            //classlarda bir kurs değişkeni tanımlamak istiyorsan böyle yazmalısın
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "yaren zengin ";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "phyton";
            kurs3.Egitmen = "eray";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2,kurs3};

            foreach (var kurs in kurslar)//kurs takma isim
            {
                Console.WriteLine(kurs.KursAdi);
            }









            Console.WriteLine("Hello World!");
        }

        class Kurs
        {
            //kursun özellikleri
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }



        }



    }
}
