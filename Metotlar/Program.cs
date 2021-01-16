using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 5;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.stokAdedi = 4;
            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi) ;
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("------------------");
            }
            Console.WriteLine("--------Metotlar---------");

            SepetManager sepetManager = new SepetManager ();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Kaliteli Armut", 50,10);
            sepetManager.Ekle2("Elma", "Kaliteli Elma", 22,9);
            sepetManager.Ekle2("Karpuz", "Kaliteli Karpuz", 11,7);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best Practice
