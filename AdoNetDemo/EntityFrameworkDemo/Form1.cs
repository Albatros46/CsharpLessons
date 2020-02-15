using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunYukle();
        }


        private void UrunYukle()
        {//ProductDal class içinde buluunan GetAll metodu ile veritabanındaki veriler datagridview e çekiliyor
            dgvProducts.DataSource = _productDal.GetAll();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productDal.Ekle(new Product
            {
                Name = txtName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount = Convert.ToInt32(txtStockAmount.Text)
            });
            UrunYukle();
            MessageBox.Show("Ürün EntityFramework ile eklenmiştir.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _productDal.Guncelle(new Product
            {
                Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                Name = txtNameGuncelle.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPriceGuncelle.Text),
                StockAmount = Convert.ToInt32(txtStockAmountGuncelle.Text),
            });
            UrunYukle();
            MessageBox.Show("Ürün EntityFramework ile güncellenmiştir.");
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameGuncelle.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceGuncelle.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountGuncelle.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _productDal.Sil(new Product
            {
                Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value)
            });
            UrunYukle();
            MessageBox.Show("Ürün EntityFramework ile Silinmiştir.");
        }
        private void UrunAra(string Key)
        {//buraki sorgu datagridview içindeki listeye yapılıyor.
            //productDal daki sorgu ise doğrudan veritabanına yapılmaktadır.
            var sonuc = _productDal.GetAll().Where(p => p.Name.ToLower().Contains(Key.ToLower())).ToList();
        //C# büyük küçük harf sorgusunda sıkıntı olduğu için tolower kullanılır
            dgvProducts.DataSource = sonuc;
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {//burdaki ürün arama datagridview den yapıyor
            UrunAra(txtAra.Text);
        }
        private void UrunAraVt(string Key)
        {//buraki sorgu datagridview içindeki listeye yapılıyor.
            //productDal daki sorgu ise doğrudan veritabanına yapılmaktadır.
            var sonuc = _productDal.GetByName(Key);
            dgvProducts.DataSource = sonuc;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {//burdaki ürün arama doğrudan veritabanından yapıyor
            //veri tabanında kayıt çok ise bu yöntem daha verimlidir.
            UrunAraVt(textBox1.Text);
        }

        private void txtAra_TextChanged_1(object sender, EventArgs e)
        {//burdaki ürün arama datagridview den yapıyor
            UrunAra(txtAra.Text);
        }

        private void txtIdFiltre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
