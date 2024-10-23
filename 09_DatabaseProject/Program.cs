using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ado.net 

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------"); 


            SqlConnection connection = new SqlConnection("Data Source= MSI\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            //sınıf - nesne - property //sqlconnection: sınıf, connection: nesne, ürettiklerimiz property
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //c# ile sql arasında köprü 
            DataTable dataTable = new DataTable(); //verileri geçici belleğe almak
            adapter.Fill(dataTable); //sorgu yani veriyi ram bellek üzerinden kullanıcıya gösterebilmek 

            foreach (DataRow row in dataTable.Rows) //dt nin içinden gelen verilen rowa atandı
            {
                foreach (var item in row.ItemArray) //rowdan gelen dizisi 
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            connection.Close();

            Console.Read();
        }
    }
}
