using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            Console.ReadLine();
        }
      
        static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)//i++ birer birer artırır. i=i+2 ikişer artır. i+=2 ikişer artır
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sayım Bitti");
            Console.ReadLine();
        }
        static void WhileLoop()
        {
            int sayi = 100;
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
            Console.WriteLine("Sayi {0}", sayi);
            Console.ReadLine();
        }
        static void DoWhileLoop()
        {
            int a = 50;
            do
            {
                Console.WriteLine(a);
                a--;
            } while (a >= 0);
            Console.ReadLine();
        }
        static void ForEachLoop()
        {
            string[] ogrenciler = new string[5] { "Servet", "Ahmet", "Akif", "Oğuz", "Rukiye" };
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            Console.ReadLine();
        }
    }
}
