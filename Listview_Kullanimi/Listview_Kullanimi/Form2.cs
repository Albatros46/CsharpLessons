using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listview_Kullanimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        double v1 = 0, v2 = 0, f = 0;
        double ort = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] bolum = {"Bilgisayar Yazılım","Web Tasarım","Web Programlama","Otomasyon","Elektrik Elektronik","3D Tasarım",
                "Network Ağ Güvenliği","CNC Otomasyon","Elektrik","Makine","Mobilya Dekorasyon" };
            comboBox1.Items.AddRange(bolum);
            listView1.Columns.Add("TC KİMLİK NU", 150);
            listView1.Columns.Add("ADI SOYADI", 150);
            listView1.Columns.Add("ÖĞRENCİ NU", 100);
            listView1.Columns.Add("BÖLÜMÜ", 150);
            listView1.Columns.Add("1.VİZE", 65);
            listView1.Columns.Add("2.VİZE",65);
            listView1.Columns.Add("FİNAL", 50);
            listView1.Columns.Add("ORTALAMA", 100);
            listView1.Columns.Add("DURUMU", 100);
            double v1 = 0, v2 = 0, f = 0;
            double ort = (v1 + v2) * 0.4 + f * 0.6;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox4.Text = Convert.ToString(v1);
            textBox5.Text = Convert.ToString(v2);
            textBox6.Text = Convert.ToString(f);
            
            ort = (v1 + v2) * 0.4 + f * 0.6;
            textBox7.Text = Convert.ToString(ort);
        }
    }
}
