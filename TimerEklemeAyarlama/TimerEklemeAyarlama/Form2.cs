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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int dak = 0, san = 0, sal = 0;

        private void button2_Click(object sender, EventArgs e)
        {
             dakika.Stop(); // dakika.Enabled = false;
             saniye.Stop(); // saniye.Enabled = false;
             salise.Stop(); // salise.Enabled = false;
        }

        private void dakika_Tick(object sender, EventArgs e)
        {
            dak++;
            label4.Text = Convert.ToString(dak);
        }

        private void saniye_Tick(object sender, EventArgs e)
        {
            if (san == 60)
            {
                san = 0;
            }
            label5.Text = Convert.ToString(san);
            san++;
        }

        private void salise_Tick(object sender, EventArgs e)
        {
            if (sal == 100)
            {
                sal = 0;
            }
            label6.Text = Convert.ToString(sal);
            sal++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dakika.Enabled = true; // dakika.Start();
            saniye.Enabled = true; // saniye.Start();
            salise.Enabled = true; // salise.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //timer1=dakika isimleri değiştirildi
            //timer2=saniye isimleri değiştirildi
            //timer3=salise isimleri değiştirildi
            dakika.Interval = 60000;//dakika
            saniye.Interval = 1000;//saniye
            salise.Interval = 10;//salise
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

        }
    }
}
