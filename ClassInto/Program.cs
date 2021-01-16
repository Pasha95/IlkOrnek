using System;

namespace ClassInto
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Recep";
            int yas = 25;

            Kurs kurs1 = new Kurs ();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Recep";
            kurs1.IzlenmeOrani = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.Egitmen = "berk";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "soner";
            kurs3.IzlenmeOrani = 20;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.IzlenmeOrani);
                Console.WriteLine("-----");
            }



            //Console.WriteLine(kurs1.KursAdi +" : "+ kurs1.Egitmen);

        }
    }

    class Kurs
    {//prop yaz tab tab
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

}
