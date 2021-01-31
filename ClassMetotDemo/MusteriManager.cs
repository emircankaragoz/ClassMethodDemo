using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " adlı müşteri eklendi. \n");
            
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " adlı müşteri silindi.");
        }
        public void Listele(List<Musteri> musteri)
        {
            foreach (Musteri m in musteri)
            {
                Console.WriteLine("Müşteri Adı: "+ m.MusteriAd);
                Console.WriteLine("Müşteri Soyad: " + m.MusteriSoyad);
                Console.WriteLine("---------------------------------");
            }
        }

    }
}
