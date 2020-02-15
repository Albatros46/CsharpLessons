using System;

namespace switchDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var i = 50;
            switch (i)
            {
                case 10:
                    Console.WriteLine("Sayi 10 a eşittir");
                    break;
                case 20:
                    Console.WriteLine("Sayi 20 ye eşittir");
                    break;
                default:
                    Console.WriteLine("Sayi 10 ve 20 den farklıdır");
                    break;
            }
            Console.ReadLine();
        }
    }
}
