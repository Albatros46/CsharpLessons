using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Volvo");
            comboBox1.Items.Add("Audi");
            comboBox1.Items.Add("Mercedes");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Toyota")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Avensis");
                comboBox2.Items.Add("Multi");
                comboBox2.Items.Add("Touch");
            }
            else if (comboBox1.Text == "Volvo")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("XC 90");
                comboBox2.Items.Add("XC 60");
                comboBox2.Items.Add("S 90");
            }
            else if (comboBox1.Text == "Audi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A 8");
                comboBox2.Items.Add("A 7");
                comboBox2.Items.Add("A 6");
            }
            else if (comboBox1.Text == "Mercedes")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AMG");
                comboBox2.Items.Add("GLA");
                comboBox2.Items.Add("GLS");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text== "Avensis") //Toyota marka araba için yazıldı.
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.6 Dizel");
                comboBox3.Items.Add("1.6 Benzin");
            }else if (comboBox2.Text == "Multi")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Dizel");
                comboBox3.Items.Add("3.0 TFSI");
            }
            else if (comboBox2.Text == "Touch")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Life");
                comboBox3.Items.Add("1.5 Dizel Life");
            }
            if (comboBox2.Text == "S 90") //Volvo marka araba için yazıldı.
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("2.0 Dizel");
                comboBox3.Items.Add("1.6 Benzin");
            }
            else if (comboBox2.Text == "XC 90")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Benzin");
                comboBox3.Items.Add("3.0 Dizel");
            }
            else if (comboBox2.Text == "XC 60")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Life");
                comboBox3.Items.Add("1.5 Dizel Life");
            }
            if (comboBox2.Text == "A 8") //Audi marka araba için yazıldı.
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("3.0 Dizel");
                comboBox3.Items.Add("1.6 TFSI");
            }
            else if (comboBox2.Text == "A 7")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Benzin");
                comboBox3.Items.Add("3.0 Dizel");
            }
            else if (comboBox2.Text == "A 6")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 TDI");
                comboBox3.Items.Add("1.5 Benzin LPG");
            }
            if(comboBox2.Text == "AMG") //Mercedes marka araba için yazıldı.
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("3.0 Dizel");
                comboBox3.Items.Add("2.8 Benzin");
            }
            else if (comboBox2.Text == "GLS")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 Benzin");
                comboBox3.Items.Add("3.0 Dizel");
            }
            else if (comboBox2.Text == "GLA")
            {
                comboBox3.Items.Clear();// Dizi tanımlayarak combobox3 e liste eklendi.
                string[] gla_versiyon = { "1.6 Benzin", "2.8 Dizel", "3.0 TFSI" };
                comboBox3.Items.AddRange(gla_versiyon);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Marka :" + comboBox1.Text + "| Model :" + comboBox2.Text + "| Versiyon :" + comboBox3.Text);
            // String ifade birleştirirken + kullanılır 
        }
    }
}
