using System;
using System.Linq;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Hesaplama();
        }
        static void Hesaplama()
        {
            Console.WriteLine("Hesaplama İşlemine Hoşgeldiniz");
            var result = Toplama(10, 60);
            var result2 = Carpma(5, 6);
            Console.WriteLine(result2);
            Console.WriteLine(result);
            Console.WriteLine(Para(5, 6, 1, 2));
            Console.ReadLine();
        }
        static int Toplama(int sayi1, int sayi2)
        {
            //void git şu işlemi yap anlamıda olduğu için void yerine int kullanırız
            return sayi1 + sayi2;
        }
        static int Carpma(int a, int b)
        {
            return a * b;
        }
        static int Para (params int [] sayilar)
        {//params keyword ile dizi rotasyonu gibi birden fazla girdi işlemi yapılabilir
            //sum ile dizideki tüm sayıları toplayacak
            return sayilar.Sum();
        }
    }
}
