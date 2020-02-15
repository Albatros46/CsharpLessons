using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPersonel
{
    public class PersonelDal
    {
        public List<Personel> GetAll()
        {
            using (PersoelDbContext context =new PersoelDbContext())
            {//PErsoneldb den veriler çağırıldı
                return context.personels.ToList();
            }
        }
        public void Ekle(Personel personel)
        {
            using (PersoelDbContext context = new PersoelDbContext())
            {
                var entity = context.Entry(personel); //bu şekilde de ürün ekleme yapılabilir.
                entity.State = EntityState.Added;
                //context.personels.Add(personel);
                context.SaveChanges();
            }
        }
    }
}
