using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//ürünle ilgili operasyonlar var içerisinde(CRUD)
    {
        //encapsulation
        public void Add(Product product)//bana bir tane ürün ver

        {
            Console.WriteLine(product.ProductName +  " eklendi .");


        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi .");
        }
        //public int Topla(int sayi1  , int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}


    }
}
