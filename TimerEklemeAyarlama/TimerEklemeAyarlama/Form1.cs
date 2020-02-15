using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEklemeAyarlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---->TIMER OZELLIGI
        //Interval: Mili saniye cinsinden Timer’ın çalışacağı zaman periyodudur.
        //Örneğin; Interval özelliği 5.000 olarak belirlenirse her 5 saniyede bir istenilen kod çalışır.
        //Timer nesnesinin interval değeri int değişken türünün alabileceği değer aralığındadır. 1-2.147.483.647 arasında değer alabilir.
        //Yaklaşık 25 günde bir çalışabilecek bir işlem Timer ile oluşturulabilir.
        //Enabled: Varsayılan olarak Timer kontrolünün Enabled özelliği false’dir ve program çalıştığı anda Timer çalışmaya başlamaz. 
        //Timer’ı çalıştırmak için bu özellik true, Timer’ı durdurmak için bu özellik false olarak ayarlanmalıdır. 
        //Timer nesnesini aktif yada pasif yapmak için Start() ve Stop() metodlarından da faydalanılabilir. 
        //Timer.Start() komutu ile Timer nesnesi aktif edilirken, Timer.Stop() komutu ile pasif edilir yani durdurulur.
        //Tick Olayı: Timer kontrolünün Interval özelliği ile belirtilen süre içerisinde periyodik olarak bu olay meydana gelir. 
        //Interval özelliği düşük olan Timer’lerde bu olay içerisine yazılacak kodun hızlı olması gerekir.
        //Tick olayına yazdığınız kodun tamamı çalıştırılmadan yeni Tick olayı meydana gelmez.
        //---->TIMER KULLANIM ALANLARI
        // Belirli zaman aralıklarında değişen resim galerisi oluşturma
        // Bilgisayardan yönetilebilen otomatik sulama sistemi otomasyonu
        // Bilgi yarışması uygulamalarında her soru için belirli bir zaman belirleme
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;// 1 saniye de çalışacak
            timer1.Enabled = true;//label de saat ve tarih için yazıldı
            //--- resim galerisi için
            timer2.Interval = 1000;
            timer2.Enabled = true;
            pictureBox1.Image = ımageList1.Images[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();//label 1 de tarih ve saati yazdırdık zaman sayısal değer olduğu için tostring ile string ifadeye çevirdik.
        }
        int i = 0;//global değişken olarak i tanımladık ve sıfırladık

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;// timer ile i degerini artırdık her saniyede arttı
            if (i == 6)// eğer i 6 ya eşit olursa başa dönsün
            {
                i = 0;
            }
            pictureBox1.Image = ımageList1.Images[i];// i yi imagelist e aktardık
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // 2.Form açılıp 1.form gizlenmesini sağlıyor
            f2.Show();
            this.Hide();
        }
    }
}
