using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud  --> create + read + update + delete 

            Console.WriteLine(" ***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("-----------------------------------------");
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security=true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); //connection ile bağladığımız tabloya gider, command ile komutu işler. tblcategory tablosunun birinci paremetresine ekler
            //command.Parameters.AddWithValue("@p1", categoryName);
            ////ekleme sırasında vs de hiyerarşik bir atama vardır. parantez sıralamalarının birbiri ile eşleşmesi gerekir
            //command.ExecuteNonQuery(); //hiç bir istisna olmadan sorguyu çalıştır. sorgu çalışınca değişiklikler db ye yansır
            //connection.Close();

            //Console.WriteLine("kategori başarıyla eklendi. ");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true; ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice,@productStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true); //dışarıdan alınmıyor direkt geliyor
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("ürün eklemesi başarılı");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true; ");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection); //product ı göstermek için, bağlantı ile ilişkilendirildi
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //veriler çekilirken bir körpü görevi gören adapter nesnesi oluşturuldu içine de command gönderildi. sqlden verileri c sharpın içine çeken köprü görevi görür
            ////verileri hafıyazaya alabilmek için db sınıfından nesne üretilecek
            //DataTable dataTable = new DataTable(); //bellekte bir tablonun tutulmasını sağlar (ram)
            ////içini doldurma işlemi
            //adapter.Fill(dataTable); //datattable dan gelen değer
            ////bu verileri kullanıcıya göstermek için bir döngü kullanacağız

            //foreach (DataRow row in dataTable.Rows) //
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close(); 

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek ürün id giriniz: ");
            //int productId=int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true; ");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("silme işlemi yapıldı.");

            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek ürün id: ");
            int productId=int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek ürün adı:");
            string productName=Console.ReadLine();
            Console.Write("Güncellenecek ürün fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security= true; ");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            


            connection.Close();

            Console.WriteLine("Güncelleme Başarılı");

            #endregion 


            Console.Read();
            
        }
    }
}
