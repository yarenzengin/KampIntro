using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //tüm kredilerde operasyonların yapılması zorunlu tutulsun diye interface yaptık
    //birisi bu interface i kullanırsa  burdaki metotları içermek zorunda 
    //imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda interface ol.oluştururuz
    interface IKrediManager//şablon görevi - operasyonlarda kullanılır
    {
        void Hesapla();//imza
        void BiSeyYap();
    }
}
