using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructors //Yapıcı Bloklar
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();
            Product product = new Product { Id = 01, Name = "Laptop" };
            Product product1 = new Product(02, "Bulaşık Makinesi"); //contructur kullanımı

            EmployeeManager employeeManager = new EmployeeManager(new DataBaseLogger());
            
            employeeManager.Add();
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Teacher.Numara = 10; //Static class lar kullanımı
            Utilities.Validate();

            Manager.DoSomething(); //static nesne olduğu için bu şekilde çağıldı
            Manager manager = new Manager();//dosomething2 static tanımlanmadığı için
            manager.DoSomething2();         //bu şekilde çağıldı.
            Console.WriteLine(product.Name);
            Console.WriteLine(product1.Id);
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _sayim; //private bir değişken alt çizgi ile tanımlanır.
        public CustomerManager(int sayim)
        {
            _sayim = sayim;
        }

        public CustomerManager()
        {
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _sayim);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product()
        {

        }
        private int _Id;
        private string _Name;
        public Product(int Id, string Name)
        {
            _Id = Id;
            _Name = Name;
        }

    }
    interface ILogger
    {
        void Log();
    }
    class DataBaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to DataBase");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        private ILogger _Logger;

        public EmployeeManager()
        {
        }

        public EmployeeManager(ILogger logger)
        {
            _Logger = logger;
        }
        public ILogger Logger { get; set; }
        public void Add()
        {
            _Logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClas //Bütün kullanılacak class larda ortak özellikleri buraya yazıyoruz
    {
        private string _Entity;
        public BaseClas (string entity)
        {
            _Entity = entity;
        }
        public void Message()
        {
            Console.WriteLine(" {0} message",_Entity);
        }
    }
    class PersonManager:BaseClas
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Veri tabanına eklendi");
            Message();
        }
    }
    static class Teacher //class static ise içinde bulunan nesneler ve değişkenlerde static tanımlanmalıdır.
    {//static nesneler ortak nesnelerdir her yerde kullanılacak nesneler static tanımlanmalıdır.
        public static int Numara { get; set; }
    }
    static class Utilities
    {
        static Utilities()
            {

            }
        public static void Validate()
        {
            Console.WriteLine("Doğrulama(Validation) yapılmıştır.");
        }
    }
    class Manager //Eğer sınıf static olursa içinde tanımlanan herşey static tanımlanmalıdır.
    {
        public static void DoSomething()//sınıf static değilse bile içinde static tanımlama yapılabilir.
        {
            Console.WriteLine("Done 1.");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2.");
        }
    }
}
