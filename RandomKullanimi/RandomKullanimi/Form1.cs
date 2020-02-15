using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();// Random sınıfının tüm özelliklerini taşıyan nesne üretildi.
            int rastgele = rnd.Next();// integer tanımlı rastgele değişkenini random sayıdan çektik.
                                      //butona her basıldığında integer aralığında sayı üretir
                                      // parantez içine aralık girilir ise girilen aralıkta sayaı üretecektir.
                                      //int rastgele = rnd.Next(100) 0 ile 100 arasınra sayı üretir
                                      //int rastgele = rnd.Next(1,49) 1 ile 49 arasında sayı üretir
            label1.Text = Convert.ToString(rastgele);// int tanımlı değişkeni string e çevirerek label e yazdırdık.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();// random sınıfının tüm özellikleri çağırıldı.
            //---Sayılar üretildi----
            int sayi1 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            int sayi2 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            int sayi3 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            int sayi4 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            int sayi5 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            int sayi6 = ran.Next(1, 49);// 1 ile 49 arasında üretilecek sayı
            //---Sayıları convert ederek LABEL içine yazdıralım.
            label2.Text = Convert.ToString(sayi1);//1. sayı convert edildi ve label2 ye yazdırıldı.
            label3.Text = Convert.ToString(sayi2);//2. sayı convert edildi ve label3 ye yazdırıldı.
            label4.Text = Convert.ToString(sayi3);//3. sayı convert edildi ve label4 ye yazdırıldı.
            label5.Text = Convert.ToString(sayi4);//4. sayı convert edildi ve label5 ye yazdırıldı.
            label6.Text = Convert.ToString(sayi5);//5. sayı convert edildi ve label6 ye yazdırıldı.
            label7.Text = Convert.ToString(sayi6);//6. sayı convert edildi ve label7 ye yazdırıldı.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form arkaplanı random olarak değişecek
            //Color olarak renkler dizini tanımlandı (8 adet renk Color renkleri çağırıldı. ve Renkler dizinine saklandı.)
            Color[] renkler = new Color[8] {Color.Red,Color.Blue,Color.White,Color.Yellow,Color.Orange,Color.Gray,Color.Green,Color.Brown };
            Random x = new Random(); // random özellikleri tümüyle çağrıldı
            int dizi = x.Next(0, 7); // x random degeri dizi değişkenine atandı
            this.BackColor = renkler[dizi]; // dizi elemanı renkler değişkenine atandı ve arkaplan değiştirildi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // 2.Form açılıp 1.form gizlenmesini sağlıyor
            f2.Show();
            this.Hide();
        }
    }
}
