using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Sezen";
            musteri1.Soyad = "Aksu";
            musteri1.Id = 1234;
            musteri1.Kimlikno = 12345678901;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Müslüm";
            musteri2.Soyad = "Gürses";
            musteri2.Id = 1235;
            musteri2.Kimlikno = 12345678902;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ferdi";
            musteri3.Soyad = "Tayfur";
            musteri3.Id = 1236;
            musteri3.Kimlikno = 12345678903;

            


            MusteriManager mm = new MusteriManager();

            mm.Liste1(musteri2, musteri3);

            mm.Ekle(musteri1);

            mm.Listele(musteri1, musteri2, musteri3);

            mm.Sil(musteri3);

           



        }
    }
}
