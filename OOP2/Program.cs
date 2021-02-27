using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hasan ÖZ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "ÖZ";
            musteri1.TcNo = "123456";

            //Yazılım Dümyam
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirkerAdi = "Yazılım Dünyam";
            musteri2.VergiNo = "98765";

            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID (L)

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri3);






        }
    }
}
