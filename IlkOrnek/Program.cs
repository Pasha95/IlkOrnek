using System;

namespace IlkOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int sayi = 3200;
            double dolarbugun = 7.44;
            double dolardun = 7.30;

            bool sistemegiris = true;
            if (dolardun > dolarbugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolardun < dolarbugun)
            {
                Console.WriteLine("Artış");                
            }           
            else
            {
                Console.WriteLine("Aynı");
            }
            
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
