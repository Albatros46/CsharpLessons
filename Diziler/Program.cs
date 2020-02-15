using System;
using System.Text;
using System.Linq;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler iki şekilde kullanılır 1.ogrenciler örneği
            string[] ogrenciler = new string[5];//{"SErvet","AHmet","Akif","Oğuz","Rukiye"} //bu şekilde de kullanılır
            ogrenciler[0] = "Servet";
            ogrenciler[1] = "Ahmet";
            ogrenciler[2] = "Akif";
            ogrenciler[3] = "Oğuz";
            ogrenciler[4] = "Rukiye";
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine("Öğrenci" + " " + ogrenci);
            }
            //2.Kullanım şekli ise ogretmenler örneğindeki gibidir.
            string[] ogretmenler = new[] { "Mustafa", "Kemal", "Fatih", "Mehmet", "Yavuz" };
          //  string[] ogretmenler =  { "Mustafa", "Kemal", "Fatih", "Mehmet", "Yavuz" }; //bu şekilde de kullanılır
            foreach (var ogretmen in ogretmenler)
            {
                Console.WriteLine("Öğretmen" + " " + ogretmen);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
