using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hasan");
            Console.WriteLine(isimler.Lenght);
            isimler.Add("Beyza");
            Console.WriteLine(isimler.Lenght);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
