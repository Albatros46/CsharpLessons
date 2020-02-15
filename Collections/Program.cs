using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Sehirler = new ArrayList();
            Sehirler.Add("Kahramanmaraş"); 
            Sehirler.Add("Adana"); 
            foreach (var sehir in Sehirler)
            {
                Console.WriteLine(sehir);
            }
            Sehirler.Add("Ankara");
            Console.WriteLine(Sehirler[2]);
            Console.ReadLine();
        }
    }
}
