using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
      private int Id { get; set; }//private değişkenler sadece tanımlandığı blok içerisinde kullanılabilir.
                       //protected değişkenler class seviyesinde her yerde kullanılır.Protected değişkenler inheritance edildiği sınıflarda da kullanılırlar
     public void Save()
        {

        }
      public void Delete()
        {

        }
    }
    class Student:Customer
    {
        public void Save2()
        {

        }
       
    }
    public class Course 
    {
        public string Name { get; set; }
    }
}
