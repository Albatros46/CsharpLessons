using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkPersonel
{
    public class PersoelDbContext: DbContext
    {
        public DbSet<Personel> personels { get; set; }
    }
}
