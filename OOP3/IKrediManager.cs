using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır
    interface IKrediManager  //İşlemin(imzanın) aynı olduğu,içerisindeki işlemlerin farklı olduğu durumlarda interface kullanılır
    {
       void Hesapla();
        void BişeyYap();
    }
}
