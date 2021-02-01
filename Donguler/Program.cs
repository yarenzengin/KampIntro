using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //array- dizi
            string[] kurslar = new string[]
            {"yazılım geliştirici kampı " , "programlamaya başlangıç",
            "java" };
            // kaç tane kurs olacağını bilemezsin o yüzden kurslar.length dedik böylece kurslar dizisindeki tüm elemanları çağırabildim.
            
            for (int i = 0; i <kurslar.Length ; i= i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)//dizi temelli yapıları tek tek dönmeye yarıyor.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");




        }
    }
}
