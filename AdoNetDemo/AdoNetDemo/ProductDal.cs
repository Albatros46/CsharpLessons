using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {   //SQL server e bağlanma işlemi burada yapıldığı için her class da çağırılabilir. burada tanımlama yapılırken alt çizgi kullanılır
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=True");//local olarak bağlandığımız iin integrated security=true local olmasaydı False olacak ve userId=neyse password=neyse olacak şekilde girilecekti

        //veritabanından veri çekmek için kullanılacak class
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);//sql sorgusunu connection a gönderdik
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {//reader den gelen tabo verileri dönüştürülerek product nesnesine bağlanıyor
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product); //her okuduğu elemanı ürüne ekle ve ürünü ürünler listesine ekleyerek yenile
            }
            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public DataTable GetAll2()//DataTable Kullanılarak veriler çekildi
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);//sql sorgusunu connection a gönderdik
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
        public void Ekle(Product product)//Ürün eklemek için kullanılacak metod
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            //SQL injection saldırı metodlarından korunmak için bu yöntem kullanılır.
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Guncelle(Product product)//Ürün güncellemek için kullanılacak metod
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(//where kullanılmadan aşağıdaki sql sorgusu kullanılırsa bütün ürünnleri değiştirir
                "Update Products set Name=@name, UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            //SQL injection saldırı metodlarından korunmak için bu yöntem kullanılır.
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Sil(int Id)//Ürün Silmek için kullanılacak metod
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(//where kullanılmadan aşağıdaki sql sorgusu kullanılırsa bütün ürünnleri değiştirir
                "Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id",Id);
            //SQL injection saldırı metodlarından korunmak için bu yöntem kullanılır.
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
