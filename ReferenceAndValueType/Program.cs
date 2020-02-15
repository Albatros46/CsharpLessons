using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number1 = 30;
            Console.WriteLine(number2);
            string[] sehirler1 = new string[] {"Ankara","İstanbul","Kahramanmaraş","Samsun","İzmir"};
            string[] sehirler2 = new string[] { "Gaziantep", "Mersin", "Adana", "Antalya", "Yalova" };
            sehirler2 = sehirler1;
            Console.ReadLine();
        }
    }
}
