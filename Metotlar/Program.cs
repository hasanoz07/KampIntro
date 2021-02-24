using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //Type Safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " +urun.Adi);
                Console.WriteLine("Ürün Fiyatı : "+urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması : "+urun.Aciklama);
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("-------------------METOTLAR----------------------");

            SepetManager sepetManager = new SepetManager();
            //encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,16);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10,15);
            sepetManager.Ekle2("Kavun", "Sarı Kavun", 8,6);



        }
    }
}


//Donr repeat yoursel - Kendini tekrar etme
//Clean Code
//Best Practice