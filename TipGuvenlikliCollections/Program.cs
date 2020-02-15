using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipGuvenlikliCollections
{
    class Program
    {
        static void Main(string[] args)
        {//ArrayList den farklı olarak listelenecek değişkenin tipi belirtilir ve sadece o tip veri eklenebilir.
            // ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Kitap", "Book"); //bir anahtar ile değere ulaşılmak isteniyorsa kullanılır.
            dictionary.Add("Masa", "Table");
            dictionary.Add("Kalem", "Pencil");
            Console.WriteLine(dictionary["Kitap"]); //anahtarı kitap olan deger nedir?
            foreach (var item in dictionary)
            {
                Console.WriteLine(item); //anahtar kelime ve karşılığını yazacaktır
                Console.WriteLine(item.Key);//anahtarı verir
                Console.WriteLine(item.Value);//anahtar kelimenin value değerini verir
            }
            Console.WriteLine(dictionary.ContainsKey("tahta"));//tahta key var mı listede olmadığı için False dönecektir.
            Console.WriteLine(dictionary.ContainsKey("Kalem"));//true dönecektir.
            Console.ReadLine();
        }
        private static void List()
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara"); sehirler.Add("Kahramanmaraş");
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine(sehirler.Contains("Kahramanmaraş")); //şehirlerin içinde kahramanmaraş varsa true degerini döndürecek
            //------------------------------------------------------------------------------------
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Servet", LastName = "Akçadağ" });
            customers.Add(new Customer { Id = 2, FirstName = "Ahmet", LastName = "Akçadağ" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
            }
            //-------------------------------------------------------------------
            var count = customers.Count;//customers in eleman sayısını verir
            var customer2 = new Customer()
            {
                Id = 3,
                FirstName = "Bekir",
                LastName = "Karaman"
            };

            customers.Add(customer2);
            customers.Insert(0, customer2);//elemanlar arasına ekleme yaparmak için kullanılır
            customers.Remove(customer2);//elemanı bulur bulmaz siler ve aramayı keser. tekrar tekrar yazılıp kullanılabilir.
            customers.RemoveAll(c => c.FirstName == "Servet");//müşterilerden Servet olanı bul ve sil.

            //-------------------------------------------------------
            var index = customers.IndexOf(customer2);//elemanın listede kaçıncı sırada olduğunu bulur arama baştan başlar
            Console.WriteLine("Index :{0}", index);

            //------------------------AddRange kullanımı---------------
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id = 5, FirstName = "Can", LastName = "Canan" },
                new Customer{ Id = 6, FirstName = "Cemile", LastName = "Cemali" },
            }
            );
            var index1 = customers.LastIndexOf(customer2);//elemanın listede kaçıncı sırada olduğunu bulur arama sondan başlar
            Console.WriteLine("Index :{0}", index1);
            //------------------------------------------------------------------------------------
            List<Urunler> urunlers = new List<Urunler> //list ub şekilde de kullanılabilir.
            {
                new Urunler{Id=1,StokKodu=123456,UrunAdi="Televizyon"},
                new Urunler{Id=2,StokKodu=987654,UrunAdi="Telefon"}
            };
            foreach (var urun in urunlers)
            {
                Console.WriteLine(urun.UrunAdi);
            }

            //-------------------------------------------------------------------------------------
            Console.WriteLine("count {0}", count);
            customers.Clear();//Listeyi temizler
        }
        public static void ArrayList()
        {//ArrayList tanımlarken değişkken tipi tanımlanamadığı için her türlü veri eklenebilir
            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("Kahramanmaraş");
            Sehirler.Add("Adana");//string değişken
            Sehirler.Add(1);//integer değişken
            foreach (var sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }
            Sehirler.Add("Ankara");
            Console.WriteLine(Sehirler[2]);

        }
    }
    class Customer //buradaki Customer sınıfını main kısmında list olarak tanımlayıp customer içeriğinde veri girişi yapılabilir.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Urunler
    {
        public int Id { get; set; }
        public int StokKodu { get; set; }
        public string UrunAdi { get; set; }
    }
}
