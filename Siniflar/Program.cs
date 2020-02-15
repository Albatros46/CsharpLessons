using System;

namespace Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriHizmetleri musteriHizmetleri = new MusteriHizmetleri();
            musteriHizmetleri.Ekle();
            musteriHizmetleri.Guncelle();
            Urunler urunler = new Urunler();
            urunler.UrunEkle();
            urunler.UrunGuncelle();
            Personel personel = new Personel();//Personel sıfında property ile oluşturulan alanlara veri giriliyor.
            personel.Id = 01;
            personel.Adi = "Servet";
            personel.Soyadi = "Akçadağ";
            personel.Sehri = "Kahramanmaras";
            //personel sınıfına veri girmenin diğer yolu ise
            Personel personel1 = new Personel
            {
                Id = 02,Adi="Ahmet",Soyadi="Akçadağ",Sehri="Kahramanmaraş"
            };
            Console.WriteLine(personel.Adi);
            Console.ReadLine();
        }
    }
    class MusteriHizmetleri
    {
        public void Ekle()
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Guncelle()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class Urunler
    {
        public void UrunEkle()
        {
            Console.WriteLine("Urun Eklendi");
        }
        public void UrunGuncelle()
        {
            Console.WriteLine("Urun Güncellendi");
        }
    }
}
