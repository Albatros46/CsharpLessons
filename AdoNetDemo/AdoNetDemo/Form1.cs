using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
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
        {
            dgvProducts.DataSource = _productDal.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _productDal.Ekle(new Product //ProductDal class da Ekle metodu çağırıldı ve formdaki textboxlar veri tabanı ile eşlendi
            {
                Name=txtName.Text,
                UnitPrice=Convert.ToDecimal(txtUnitPrice.Text),
                StockAmount=Convert.ToInt32(txtStockAmount.Text)
            });
            UrunYukle();
            MessageBox.Show("Ürün Eklendi!");
            
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Hücreye tıklandığında hücre içindeki değerler textbox içlerine aktarılacak
            txtNameGuncelle.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceGuncelle.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountGuncelle.Text= dgvProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {//Textbox lara çekilen bilgiler içi değiştirilerek tekrar productdal a gönderildi.
            Product product = new Product
            {
                Id=Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                Name= txtNameGuncelle.Text,
                UnitPrice=Convert.ToDecimal(txtUnitPriceGuncelle.Text),
                StockAmount=Convert.ToInt32(txtStockAmountGuncelle.Text),
            };
            _productDal.Guncelle(product);
            UrunYukle();
            MessageBox.Show("Ürün Güncellendi...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value);
            _productDal.Sil(id);
            UrunYukle();
            MessageBox.Show("Ürün Silindi...");
        }
    }
}
