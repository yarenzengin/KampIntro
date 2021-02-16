using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "222222";

            //şirket adı benimle alakalı bir şey değil zamanla bireysel müşterilerle karıştırılıyor
            //gerçek müşteri - tüzel müşteri nesne>> birbirine benziyor diye birbirinin yerine kullanılamazlar
            //SO-L-ID
            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678910";

            //neden kalıtım yapıyoruz ? 

            //Musteri class ı hem gercekM. ref. ini tutuyor hem de tuzelM. ref ini tutuyor
            Musteri musteri3 = new GercekMusteri();// new varsa referans no 
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
