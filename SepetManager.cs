using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Product product)  //parametre verdik.Parametre demek ne eklemek istiyorsan onu ver demek.
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi :" + product.Adi);
        }
        public void Ekle2(string urunadi,string aciklama,double fiyat,int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+urunadi);
        }
    }
}
