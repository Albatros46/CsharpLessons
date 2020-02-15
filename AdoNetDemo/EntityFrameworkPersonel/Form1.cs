using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPersonel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelDal _personelDal = new PersonelDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelGetir();
        }
        public void PersonelGetir()
        {
            dgvPersonel.DataSource = _personelDal.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _personelDal.Ekle(new Personel
            {
                AdiSoyadi=txtAdSoyadEkle.Text,
                Birimi=txtBirimEkle.Text,
                CepTlf=txtCepTlfEkle.Text,
                EPosta=txtEPostaEkle.Text
            });
        }

        private void dgvPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
