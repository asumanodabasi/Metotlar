using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Elması";
            product1.Fİyati = 15;

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fİyati = 80;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fİyati);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("--------Metotlar-------------");
            // instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil", 18,5);
        }
    }
}
