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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //-----------ListView Nedir?
        //Satır satır TextView ismi verilen öğeleri kendinde barındıran ve kayıtların listelenmesini sağlayan bir yapıdır.
        //Her ne kadar ListBox nesnesine benzer yapıda olsa da çok daha kullanışlıdır.Columns yani sütun isimleri ve genişlikleri 
        //kolaylıkla ayarlanır ve kayıtlar düzenli bir şekilde görüntülenebilir. 
        //--- ListView Kolon Ekleme
        //ListView nesnesine kolon eklemek için Properties panelindeki özellikler veya nesnenin üst kısmındaki play simgesine
        //tıklandığında karşımıza çıkan özellikler kullanılabilir.Ancak bu işlemi kodla yapmak isteyenler için aşağıdaki 
        //yöntem kullanılır.
        //listView1.Columns.Add("TC KİMLİK NO", 150);
        //listView1.Columns.Add("ADI SOYADI", 200);
        //listView1.Columns.Add("YAŞI", 50);
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Tc Kimlik No", 150); // süton adı ve süton boyutu 
            listView1.Columns.Add("Adı Soyadı", 200); // süton adı ve süton boyutu 
            listView1.Columns.Add("Mezuniyet", 150);        // süton adı ve süton boyutu 
            listView1.Columns.Add("Doğum Yeri", 125); // süton adı ve süton boyutu 
            listView1.Columns.Add("Yaş", 50); // süton adı ve süton boyutu 
            listView1.Columns.Add("Cinsiyet", 80);// süton adı ve süton boyutu 
            listView1.Columns.Add("Telefon Nu", 130);// süton adı ve süton boyutu 
            // sütunların görünmesi için listview seçili iken properties den views seçeneğinden details seçiniz.
            string[] mezuniyet = { "İlköğretim", "Ortaöğretim", "Lise", "Önlisans", "Lisans",
                "Yüksek Lisans", "Doktora" };// mezuniyet adında dizi oluşturuldu
            comboBox1.Items.AddRange(mezuniyet);// mezuniyet dizinini combobox a ekledik.
            kayityaz();//metot çağırıldı.

        }
        private void kayityaz()// kayıt sayısını göstermek için metot yazıldı
        {
            int kayitsayisi = listView1.Items.Count;
            label8.Text = Convert.ToString(kayitsayisi);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Properties den checboxes özelliği true yapıldı.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc = "", adsoyad = "", yas = "", mezun = "", dogumyeri = "", cins = "", tlf = "";//string türünde değişkenler tanımlandı
            tc = textBox1.Text; adsoyad = textBox2.Text; yas = textBox3.Text; // değişkenler nesnelerle eşleştirildi.
            dogumyeri = textBox4.Text; tlf = textBox5.Text; mezun = comboBox1.Text;
            if (radioButton1.Checked == true)
                cins = radioButton1.Text;
            else if (radioButton2.Checked == true)
                cins = radioButton2.Text;
            string[] bilgiler = { tc, adsoyad, mezun, dogumyeri, yas, cins, tlf };
            bool aranankayitkontrolu = false;// kayıt girilirken girilen kayıtta tc girilmesini önlemek için
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    aranankayitkontrolu = true;
                    MessageBox.Show(textBox1.Text + " " + "Tc Kimlik Numarası Kayıtlarıda Mevcut!");
                }
            }
            if (aranankayitkontrolu == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (tc != "" && adsoyad != "" && yas != "" && mezun != "" && cins != "" && tlf != "" && dogumyeri != "")
                {
                    listView1.Items.Add(lst);
                }
                else MessageBox.Show("Kayıt Bilgilerinde eksiklik var.");
            }
            kayityaz();//metod çağırıldı
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilenkayit = listView1.CheckedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.CheckedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(secilenkayit.ToString()+" Adet Kayıt Silinmiştir."); kayityaz();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilenkayit = listView1.SelectedItems.Count;
            foreach (ListViewItem secilikayitbilgisi in listView1.SelectedItems)
            {
                secilikayitbilgisi.Remove();
            }
            MessageBox.Show(secilenkayit.ToString() + " Adet Kayıt Silinmiştir.");kayityaz();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            kayityaz();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool aranankayitdegeri = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text==textBox1.Text)
                {
                    aranankayitdegeri = true;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    comboBox1.Text = listView1.Items[i].SubItems[3].Text;
                    if (listView1.Items[i].SubItems[4].Text=="Bay")
                    {
                        radioButton1.Checked = true;
                    }else if (listView1.Items[i].SubItems[4].Text == "Bayan")
                    {
                        radioButton2.Checked = true;
                    }
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    textBox5.Text = listView1.Items[i].SubItems[6].Text;
                    textBox2.Enabled = false; textBox4.Enabled = false;
                    textBox3.Enabled = false; textBox5.Enabled = false;
                    comboBox1.Enabled = false; groupBox1.Enabled = false;

                }
            }if (aranankayitdegeri == false)
            {
                MessageBox.Show(textBox1.Text+" TC Numaralı Kayıt Bulunamadı.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true; textBox4.Enabled = true;
            textBox3.Enabled = true; textBox5.Enabled = true;
            comboBox1.Enabled = true; groupBox1.Enabled = true;
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
            textBox4.Text = ""; textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(); // 2.Form açılıp 1.form gizlenmesini sağlıyor
            f2.Show();
            this.Hide();
        }
    }
}
