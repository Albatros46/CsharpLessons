using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceses
{
    interface IMusteriDal
    {
        void Ekle();
        void Guncelle();
        void Sil();
    }
    class SqlServerDal : IMusteriDal
    {
        public void Ekle()
        {
            Console.WriteLine("SQL Server Eklendi");
        }

        public void Guncelle()
        {
            Console.WriteLine("SQL Server Güncellendi");
        }

        public void Sil()
        {
            Console.WriteLine("SQL Server Silindi");
        }
    }
    class OracleServerDal : IMusteriDal
    {
        public void Ekle()
        {
            Console.WriteLine("Oracle Server Eklendi");
        }

        public void Guncelle()
        {
            Console.WriteLine("Oracle Server Güncellendi");
        }

        public void Sil()
        {
            Console.WriteLine("Oracle Server Silindi");
        }
    }
    class MySqlServerDal : IMusteriDal
    {
        public void Ekle()
        {
            Console.WriteLine("MySQL Server Eklendi");
        }

        public void Guncelle()
        {
            Console.WriteLine("MySQL Server Güncellendi");
        }

        public void Sil()
        {
            Console.WriteLine("MySQL Server Silindi.");
        }
    }
    class MusteriYonetimi
    {
        public void Ekle(IMusteriDal musteriDal)
        {
            musteriDal.Ekle();
        }
    }
}
