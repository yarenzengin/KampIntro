using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //S-O-LID
    class EsnafKredisiManager : IKrediManager
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine( "esnaf kredisi hesaplandı");
        }
    }
}
