using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro();
            string tanitim = "Ben Kahramanmaraşlıyım";
            var harf = tanitim.Length;//tanitim değişkeninin kaç karakterden oluştuğunu yazacak
            Console.WriteLine(harf);
            var klon = tanitim.Clone();//tanitim değişkeninin içeriğini kopyalayacak
            Console.WriteLine(klon);

            bool sonuc1 = tanitim.EndsWith("m");//tanitim değişkeni m (kelimede yazılabilir) harfi ile mi bitiyor
            bool sonuc2 = tanitim.StartsWith("B");//tanitim değişkeni B (kelimede yazılabilir) harfi ile mi başlıyor
            var sonuc3 = tanitim.IndexOf("Kahramanmaraşlıyım");//Kahramanmaraşlıyım kelimesi kaçıncı karakterde başlıyor. aramaya baştan başlar
            var sonuc4 = tanitim.LastIndexOf(" ");//boşluğu tanitim değişkeninde arayacak ve aramaya sondan başlayacak
            var sonuc5 = tanitim.Insert(4,"Maraşta havalar çok güzel");//tanıtım değişkenin 4. karakterinden sonra araya cümle ekleyecek
            var sonuc6 = tanitim.Substring(7,5);//tanitim değişkenin 7.karakterden itibaren parçala.7.karakterden itibaren 5 karakter alarak parçala
            var sonuc7 = tanitim.ToLower();//tanitim değişkenindeki tüm karakterleri küçük yazdırır.
            var sonuc8 = tanitim.ToUpper();//tanitim değişkenindeki tüm karakterleri BÜYÜK yazdırır.
            var sonuc9 = tanitim.Replace(" ", "***");//karaktleri değişrtirmek için kullanılır. boşluk yerine *** koyacak
            var sonuc10 = tanitim.Remove(5,3);//tanitim değişkeninde 5. karakterden sonra 3 karakter siler
            Console.WriteLine(sonuc10);
            Console.WriteLine(sonuc9);
            Console.WriteLine(sonuc8);
            Console.WriteLine(sonuc7);
            Console.WriteLine(sonuc6);
            Console.WriteLine(sonuc5);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc3);
            Console.ReadLine();
        }
        static void intro()
        {
            string sehirler = "Kahramanamras";
            Console.WriteLine(sehirler);
            foreach (var karakter in sehirler)
            {
                Console.WriteLine(karakter);
            }
            string sehirler2 = "İstanbul";
            Console.WriteLine(String.Format("{0} {1}", sehirler, sehirler2));
            Console.ReadLine();
        }
    }
}
