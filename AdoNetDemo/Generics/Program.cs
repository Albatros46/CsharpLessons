using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> sonuc = utilities.BuildList<string>("Ankara","İstanbul","Kahramanmaraş");
            foreach (var item in sonuc)
            {
                Console.WriteLine(item);
            }
            List<Customer> sonuc2 = utilities.BuildList<Customer>(new Customer{AdiSoyadi="Servet AKÇADAĞ"},new Customer { AdiSoyadi = "Cemal Çorbacı" });
            foreach (var item2 in sonuc2)
            {
                Console.WriteLine(item2.AdiSoyadi);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    class Customer
    {
        public string AdiSoyadi { get; set; }
    }
    interface IProductDal: IRepository<Product>
    {
      
    }
    interface ICustomerDal:IRepository<Customer>
    {
       
    }
    interface IRepository<T>//Generic kullanım tektek nesnelerin içine yazmaktansa, nesneler buradan çağıracaklar
    {
        List<T> GetAll();
        T Get(int id);
        void Ekle(T entity);
        void Sil(T entity);
        void Guncelle(T entity);
    }
    class ProductDal : IProductDal//Implemet edildiğinde otomatik olarak çekilmektedir.
    {
        public void Ekle(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Sil(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal //Implemet edildiğinde otomatik olarak çekilmektedir.
    {
        public void Ekle(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Sil(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
