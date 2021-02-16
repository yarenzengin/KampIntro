using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // customer, employee gibi bir şey görüyorsan class ta o varlıktır
    //Individual
    class GercekMusteri : Musteri //miras - inheritance
    {
        //Sadece ona ait özellikler
        public string TcNo { get; set; }
        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
