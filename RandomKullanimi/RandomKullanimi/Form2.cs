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
    public partial class Form2 : Form
    {
        public int s{ get; private set; }
        public int puan = 1000;
        public Form2()
        {
            // Global değişkenler tanımlandı; her nesnenin altında çalışacak değişkenler
            int tahmin = 0;
            int s = 0;
            InitializeComponent();
                 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;// Program çalışmaya başladığında button1 pasif olacak
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random r = new Random();// r random tüm özelliği çağırıldı
            s = r.Next(100);// int degerindeki s değişkenine r random aktarıldı. 0-100 arasında rastgele sayı üretecek
            label8.Text = s.ToString();
            label5.Text = "";//Durum
            label6.Text = "0";// tahmin sayısı
            label7.Text = "1000"; // puan
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = 0,puan=1000;
            tahmin++;//Kullanıcı butana her tıkladığında, tahmin degeri 1 er 1 er artırıldı 
            if (s<tahmin)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin.ToString();
                label5.Text = "Sayıyı Küçült!";
                puan = puan - 100;
                label7.Text = puan.ToString();
                
            } else if (s>tahmin)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin.ToString();
                label5.Text = "Sayıyı Büyüt!";
                puan = puan - 100;
                label7.Text = puan.ToString();
            }
            if (tahmin == s)
            {
                label5.Text = "TEBRİKLER"+" "+ label6.Text+" "+"defada bilip"+" "+label7.Text+" "+"puan aldınız.";
                button2.Enabled = true;
                button1.Enabled = false;
                textBox1.Text = "";
            }
        }
    }
}
