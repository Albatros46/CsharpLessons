using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalisanlar[] calisanlars = new ICalisanlar[3]
            {
                new Yonetici(),new Isci(),new Robot()
            };
            foreach (var calis in calisanlars)
            {
                calis.Calis();
            }
            IYemek[] yemeks = new IYemek[2]
            {
                new Yonetici(), new Isci()
            };
            foreach (var yiyecek in yemeks)
            {
                yiyecek.Yemek();
            }
            IMaas[] maas = new IMaas[2]
            {
                new Yonetici(),new Isci()
            };
            foreach (var hak in maas)
            {
                hak.Maas();
            }
            Console.ReadLine();
        }
    }
    interface ICalisanlar
    {
        void Calis();
    }
    interface IMaas
    {
        void Maas();
    }
    interface IYemek
    {
        void Yemek();
    }
    class Yonetici : ICalisanlar, IMaas, IYemek
    {
        public void Calis()
        {
            Console.WriteLine(" Yönetici için Mesai Başladı Çalışıyoruz...");
        }

        public void Maas()
        {
            Console.WriteLine(" Yönetici Maaşımızı aldık harcıyoruz.");
        }

        public void Yemek()
        {
            Console.WriteLine(" Yönetici:Öğle arasına çıktık yemek yiyeceğiz.");
        }
    }
    class Isci : ICalisanlar, IMaas, IYemek
    {
        public void Calis()
        {
            Console.WriteLine("İşçi için Mesai Başladı Çalışıyoruz...");
        }

        public void Maas()
        {
            Console.WriteLine(" İşçi  Maaşımızı aldık faturaları zor ödüyoruz.");
        }

        public void Yemek()
        {
            Console.WriteLine(" İşçi:Öğle arasına çıktık yemek yiyeceğiz.");
        }
    }
    class Robot : ICalisanlar
    {
        public void Calis()
        {
            Console.WriteLine("Robotlar için Mesai Başladı Çalışıyoruz...");
        }
    }
}
