using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
            Console.ReadLine();
        }
    }
    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Default Ekleme işlemi yapıldı");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Default Silme işlemi yapıldı");
        }
    }
    class SqlServer : DataBase
    {
        public override void Add()
        {
            base.Add(); 
        }
    }
    class MySqlServer : DataBase
    {

    }
}
