using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizileri genişletemiyoruz 
            //stack            /7heap adresi aldı
            //string[] isimler = new string[] {"yaren" , "halil","eray", "büşra" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//new dediğin için yeni bir adres oluşturdu yani 5 elemanlı yeni bir dizi oluşturdu o yüzden; 
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// yeni bir dizi oluşturduğu için bunu ekrana yazdırmaz çünkü içi boş 
            // o yüzden koleksiyonlar kullanıyoruz.

            //koleksiyonlar diziler gibi
            List<string> isimler2 = new List<string> { "yaren","halil " , "eray","büşra"};
            //isimler2.Add("yaren");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
