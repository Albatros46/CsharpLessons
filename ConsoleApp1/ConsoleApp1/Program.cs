using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 20;
            //if bloğu tek satırda da yazılabilir
            //Console.WriteLine (i == 10 ? "Sayi 10 dur" : "Sayi 10 dan farklıdır") ;

            if (i == 10)
            {
                Console.WriteLine("Sayı 10 dur");
            }
            else if(i==20)
            {
                Console.WriteLine("Sayi 20 dir");
            }
            else
            {
                Console.WriteLine("Sayi 10 dan farklı");
            }
            Console.ReadLine();
        }
    }
}
