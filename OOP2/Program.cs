using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Asuman";
            musteri1.Soyadi = "Odabasi";
            musteri1.TcNo = "12345678910";
            musteri1.MusteriNo = "12345";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.Id = 2;
            musteri2.SirketAdi = "TurkHAS";
            musteri2.VergiNo = "1234567890";

            Müşteri müşteri3 = new GercekMusteri();
            Müşteri müşteri4 = new TuzelMusteri();
            //burda Müşeri classı GercekMusteri ve  TuzelMusteri ye kalıtım verdiği için her ikisininde referansını tutabilir.!!!!
            //
            CustomerManager manager = new CustomerManager();
            manager.Ekle(musteri1); 
            manager.Ekle(musteri2);
        }
    }
}
