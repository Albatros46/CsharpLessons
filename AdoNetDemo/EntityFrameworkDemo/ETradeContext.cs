using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        //appconfig e bu kodu yazıyoruz oradan veritabanına erişip okuyacak
        /* <connectionStrings> 
    <add name="ETradeContext" connectionString=
         "server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>*/
    }
}
