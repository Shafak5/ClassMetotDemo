using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            
            Console.WriteLine("Yeni müşteri eklendi : " + musteri.Ad +" "+ musteri.Soyad+ " "+ musteri.Id + " \n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + "\n");

        }

        public void Listele(Musteri musteri, Musteri musteri1, Musteri musteri2)
        {
            Console.WriteLine("Müşteriler listeleniyor : \n "+ musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " " + musteri.Kimlikno + "\n " + musteri1.Ad + " " + musteri1.Soyad + " " + musteri1.Id + " " + musteri1.Kimlikno +"\n " + musteri2.Ad + " " + musteri2.Soyad + " " + musteri2.Id + " " + musteri2.Kimlikno + "\n");
        }
        public void Liste1(Musteri musteri, Musteri musteri1)
        {
            Console.WriteLine("Müşteriler listeleniyor : \n " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Id + " " + musteri.Kimlikno + "\n " + musteri1.Ad + " " + musteri1.Soyad + " " + musteri1.Id + " " + musteri1.Kimlikno + "\n ");
        }
    }
}
