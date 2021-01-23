using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "001"; 
            musteri1.Adi = "Recep";
            musteri1.Soyadi = "Anık";
            musteri1.TcNo = "12356789";
            musteri1.Id = 5;
                        
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54131121";
            musteri2.SirketAdi = "Rebean";
            musteri2.VergiNo = "123";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
