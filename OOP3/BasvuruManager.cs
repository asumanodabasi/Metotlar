using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggers)  //İstediğin krediye göre hesaplama yapman için interface i parametre olarak verdik.Çünkü program.cs de IKrediManager diğer kredilerin referansını tutuyor.
                                                                                         //List i kullanarak burda birden fazla logglama işlemi kullanacağımızı söyledik.
        {
            krediManager.Hesapla();
            foreach (var logg in loggers)
            {
                logg.Log();   //Burda da yukarda oluşturduğumuz loggersları çalıştırdık.
            }
        }
    public void KrediOnBiligilendirmesiYap(List<IKrediManager> krediler) //burda bize birden fazla krediyi listeliycek
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    
    
    }

}
