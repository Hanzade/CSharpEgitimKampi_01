using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //bir yapının metod olması () dan anlaşılır. 
            //metodlar ikiye ayrılır 1- geriye değer döndürmeyen metodlar, belli işlemleri tekrar etmemek için 2- 


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");


            //}

            //CustomerList(); 


            //void Sum()
            //{
            //    int x = 1, y = 2, z=x+y;
            //    Console.WriteLine(z);

            //}
            //Sum();

            #endregion

            #region  Geriye Değer Döndürmeyen String Parametreli Metodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");



            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Hanzade Beyza", "Bahçekapılı");
            //CustomerCard("Ayşehül", "Kaya");

            #endregion


            #region  Geriye Değer Döndürmeyen İnt Parametreli Metodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 5, 6);

            #endregion


            #region  Geriye Değer Döndüren  Metodlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}
            //customerName();


            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + surname;
            //}
            //Console.WriteLine(studentCard());



            #endregion


            #region  Geriye Değer Döndüren String Parametreli Metodlar

            //string countryCard(string countryName, string Capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent " + Capital + " - Bayrak: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z)); 



            #endregion

            #region  Geriye Değer Döndüren İnt Parametreli Metodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));


            #endregion

            #region  Örnek Uygulama

            string ExamResult (string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return "Öğrenci sınavı geçti";

                }
                else
                {
                    return "Öğrenci Başarısız oldu.";
                }
            }

                Console.WriteLine(ExamResult("Ali" , 45,25, 80));

            #endregion





            Console.Read();
        }
    }
}
