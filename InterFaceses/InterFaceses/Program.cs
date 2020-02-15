using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceses
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            manager.Ekle(new Musteri { Id = 1, Adi = "Oğuz", Soyadi = "Akçadağ", Adres = "Karamanlı Mah." });
            Personel personel = new Personel
            { Adi = "Selim", Soyadi = "Kazan", CepTlf = 5369741568, Maas = 5000, Id = 05 };
            manager.Ekle(personel);
            //Demo();
            IMusteriDal[] musteriDals = new IMusteriDal[3] { //IMusteriDal interfacesi dizi haline getirildi diznin elemanalrı ise o interfacenin class ları
            new SqlServerDal(),new OracleServerDal(),new MySqlServerDal()
            };
            foreach (var musteri in musteriDals) //foreach ile musteri değişkeni musteriDals içinde aranarak musteri.Ekle olayı çalıştırıldı.
            {
                musteri.Ekle();
            }
            Console.ReadLine();
        }
        static void Demo()
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.Ekle(new OracleServerDal());
            musteriYonetimi.Ekle(new MySqlServerDal());
        }
    }
    interface IKisi //Soyut nesne. Soyut nesneler tek başına bir anlam ifade etmez
    {
        int Id { get; set; }
        string Adi { get; set; }
        string Soyadi { get; set; }
    }
    class Musteri : IKisi //somut nesne
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        //-------------------------------------------
        public string Adres { get; set; }
    }
    class Personel : IKisi //somut nesne
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        //--------------------------------------------
        public Int64 CepTlf { get; set; }
        public int Maas { get; set; }
        /*Bir kaç sınıfta ortak olan değişkenler interface olarak tanımlanır ve oradan 
         kullanılacak olan class lara çekilebilir.*/
    }
    class PersonManager
    {
        public void Ekle(IKisi kisi)
        {
            Console.WriteLine(kisi.Adi);
        }
    }
}
