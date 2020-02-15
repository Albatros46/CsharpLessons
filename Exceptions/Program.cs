using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions//Hata yakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (KendiHataYakalamaKodumuz excep)
            {
                Console.WriteLine(excep.Message);
            }
            //Metod
            HandleException(() => /*try catch bloğunda catch artacağı durumlarda bu metod kullanılır tyr catch bloğunun işlevi ile aynıdır.*/
            {
                Find();
            });
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {//*Bu etodu kullanmanın amacı oluşacak hataları merkezi bir hata kontrol metodundan çağırmaktır.*//
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> ogrenci = new List<string> { "Ahmet", "Mehmet", "Celal", "Cemal", "Kemal" };
            if (!ogrenci.Contains("Bekir"))//eğer ogrenci içinde bekir yoksa 
            {
                throw new KendiHataYakalamaKodumuz("Kayıt Bulunamadı!");//oluşturmuş olduğumuz class çalışacak
                //throw Listede bekir yoksa hata oluştur 
            }
            else
            {
                Console.WriteLine("Kayıt Bulundu");
            }
        }

        private static void ExceptionIntro()
        {
            try
            { //Kod çalışma sırasında hata olmazsa çalışmasını istediğimiz kısım
                string[] ogrenci = new string[3] { "Servet", "Ahmet", "Akif" };
                ogrenci[3] = "Oğuz";//ogrenci dizini 3 elemanlı ve 3 elemanın yeri de dolu olduğu için hata verecek
            }
            catch (DivideByZeroException exception)// eğer aldığımız hata bu ise aşağıdaki kodu çalıştır
            {
                Console.WriteLine("DÜZGÜN KOD YAZ KARDEŞİM YA");
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception) //try bloğunda hata olduğunda hata mesajınnı exception değişkenine aktarıyor
            {//try kısmında hata olursa catch bloğundaki kod çalışsın istiyoruz

                Console.WriteLine("Hata olduğu için burası çalıştı.");
                Console.WriteLine(exception.Message);//oluşan hata programı kırmadan hata mesajını ekrana yazacak
                Console.WriteLine(exception.InnerException);//daha detaylı bilgi vermek için
                                                            //hata mesajlarını kullanıcıya göstrmek yerine başka bir class a loglayıp oradan hatamızı öğrenip kodumuzu düzeltmek gerek
            }
        }
    }
}
