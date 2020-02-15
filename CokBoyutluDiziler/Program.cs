using System;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {//çok boyutlu diziler -> 7 satır 3 sutün gibi , türkiyedeki iller satır ilçeler sütun gibi düşünebiliriz.
            string[,] sehirler= new string[7, 3]
            {
                {"Ankara","İzmir","Trabzon" },
                {"Adana","İzmit","Giresun" },
                {"Afyon","Çorum","Diyarbakır" },
                {"Adıyaman","Kayseri","Kahramanmaraş" },
                {"Afyonkarahisar","Sivas","Mardin" },
                {"Antalya","Erzincan","Malatya" },
                {"Antakya","Erzurum","Mersin" }
            };
            for (int i = 0; i <= sehirler.GetUpperBound(0); i++)//sehirler çoklu dizininin 0 ıncı elemanına bakarak tara
            {
                for (int j = 0; j <=sehirler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(sehirler[i, j]);
                }
                Console.WriteLine("***********");
            }
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
