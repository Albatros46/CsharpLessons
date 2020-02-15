using System;

namespace DemoCokSartli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Çok Şartlı Uygulama");
            var sayi = 20;
            if (sayi >= 0 && sayi <= 100)
            {
                Console.WriteLine("Sayı 0-100 arasındadır.");
            }
            else if (sayi > 100 && sayi <= 200)
            {
                Console.WriteLine("Sayi 100-200 arasındadır.");
            }
            else if (sayi < 200 || sayi < 0) 
            {
                Console.WriteLine("Sayı 200 den büyük yada 0'dan küçük");

            }
            Console.ReadLine();
        }
    }
}
