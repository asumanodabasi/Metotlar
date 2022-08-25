using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İnheritance Miras
    class TuzelMusteri:Müşteri  //TüzelMüşteri bir müşteridir demektir bu.Müşeri sınıfında olan özellikler burdada var demektir.
    {
        public string SirketAdi { get; set; }
     
        public string VergiNo { get; set; }

    }
}
