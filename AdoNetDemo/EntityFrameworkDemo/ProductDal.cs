using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {//veri tabanından verileri okumak ve listelemek için
            using (ETradeContext context = new ETradeContext())
            {//EntityFramework da tablodaki veriye ulaşma
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)//arama işlemi yapmak için veritabnında kayıt çok ise bu kullanım tercih edilir.
        {//buradaki arama işleminde sorgu direkt veritabanına yapılıyor
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal price)
        {//Fiyata göre arama sql filtreleme yapıyor
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {//iki fiyat arasında sql filtreleme veritabanına gönderiyor
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }
        public Product GetById(int id)
        {//Tek bir ürün aranıyorsa
            using (ETradeContext context = new ETradeContext())
            {
                var sonuc = context.Products.FirstOrDefault(p => p.Id == id);
                return sonuc;
            }
        }
        public void Ekle(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //var entity = context.Entry(product); //bu şekilde de ürün ekleme yapılabilir.
                //entity.State = EntityState.Added;
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Guncelle(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Sil(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
