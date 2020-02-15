using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new OracleServer();
            dataBase.Add();
            dataBase.Delete();

            DataBase dataBase2 = new OracleServer();
            dataBase2.Add();
            dataBase2.Delete();
            Console.ReadLine();
        }
        abstract class DataBase
        {
            public void Add()
            {
                Console.WriteLine("Add by default");
            }
            public abstract void Delete();//içi dolu olmayan abstract class dır. nerede implament edilir ise oraya göre kod yazılır.
        }
        class SqlServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by SQL");
            }
        }
        class OracleServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }
    }
}
