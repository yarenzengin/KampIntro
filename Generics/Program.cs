using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("istanbul");
            Console.WriteLine(sehirler.Count);//prop
            //hangi tipi verirsen ona dönüşüyor
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("ankara");
            Console.WriteLine(sehirler2.Count);
            //count elemanları sayıyor

        }
    }
    class MyList<T>//generic class 
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)//hangi tip verirsem o 
        {
            //Array bazlı  , arka planda bir array yönetiyor
            //eleman sayısını nasıl eklicez
            _tempArray = _array;//tA arrayin referansını tutuyor
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
            //ne eklersek onu eklemiş olduk

        }
        //private int _count;

        public int Count
        {
            get { return _array.Length; }
           // get { return _count; }
           //mylist in count ını çağırırsam o array in eleman sayısını verir
            
        }

    }
}
