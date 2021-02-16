using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate

    class TuzelMusteri : Musteri//miras - inheritance : Müşteride olan her şey tüzel müşt. de de kabul edilir
    {
        
        public string SirketAdi { get; set; }
        //long yerine string yazdık çünkü sen sayısal bir işlem yapmıyorsan yani sayı görevi vermiyorsan bunlar metinsel olarak alınırsa daha iyi sonuç alırız 

        public string VergiNo { get; set; }

    }
}
