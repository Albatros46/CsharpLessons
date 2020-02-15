using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olaylara_Events_KodYaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "0";//Birim fiyat 0 olarak görünsün öncelikle
            textBox3.Text = "1";//Adet varsayılan olarak 1 görünecek
            radioButton1.Checked = true;
            textBox4.Enabled = false;// KDV pasif olacak
            textBox5.Enabled = false;// Tutar pasif olacak
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try // hata oluşması muhtemel kodlarda try-catch bloğu arasına yazılarak hata önlenebilir.
            {
            double birimfiyat = Convert.ToDouble(textBox2.Text);
            double adet = Convert.ToDouble(textBox3.Text);
            double tutar = birimfiyat * adet;
            double kdv = 0;
                if (radioButton1.Checked = true)
                {
                    kdv = tutar * 0.25;
                }else if (radioButton2.Checked = true)
                {
                    kdv = tutar * 0.18;
                }else if (radioButton3.Checked = true)
                {
                    kdv = tutar * 0.8;
                }
                tutar = tutar + kdv;
                if (checkBox1.Checked = true)
                {
                    tutar = tutar - (tutar * 0.1);
                }
                textBox4.Text = Convert.ToString(kdv);
                textBox5.Text = Convert.ToString(tutar);
            }
            catch
            {

            }
           
        }
    }
}
