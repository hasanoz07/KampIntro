using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Hasan ÖZ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Hasan ÖZ";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Hasan ÖZ";
            kurs3.IzlenmeOranı = 95;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Ruby";
            kurs4.Egitmen = "Hasan ÖZ";
            kurs4.IzlenmeOranı = 37;


            //Console.WriteLine(kurs1.KursAdi+" - "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " - " + kurs.IzlenmeOranı);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }

    
}
