using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //Değer tutucu - alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            //Dolar durumu gösterici
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            //Dogin sonucu
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                  Console.WriteLine("Giriş Yap Butonu");
            }

            //Değişken kullanma
            Console.WriteLine(kategoriEtiketi);

            
            
        }
    }
}
