using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            {
                musteri1.MusteriId = 1;
                musteri1.MusteriAd = "Kemal";
                musteri1.MusteriSoyad = "A";
            }


            Musteri musteri2 = new Musteri();
            {
                musteri2.MusteriId = 2;
                musteri2.MusteriAd = "Berk";
                musteri2.MusteriSoyad = "B";    
            
            }

            List<Musteri> musteriler = new List<Musteri>() { musteri1, musteri2 };

            MusteriManager manager = new MusteriManager();

            manager.Listele(musteriler); // Listeleme
            manager.Ekle(musteri1);
            manager.Sil(musteri2);
            
        }
    }
}
