using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using -> kullanacağımız kodlara ait kütüphaneleri tutar. 

namespace _01_TemelKonular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //yazdırma komutları 

            //Console.WriteLine("Hanzade Beyza Bahcekapili"); //imleci alt satıra indirir. 
            //Console.Write("Hanzade Beyza Öztürk");

            //Console.WriteLine(" ***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine(" ***** Yemek Kategorileri *****");

            #endregion

            #region StringDegiskenler

            //string
            //Degisken_türü degisken_adi;

            //string name;
            //name = "Murat";
            //Console.WriteLine(name);

            #endregion


            #region intDegiskenler

            //int tam sayı türlerindeki değişkenlerdir

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + " tl");
            Console.WriteLine("----Pizza Fiyatı: " + pizzaPrice + " tl");
            Console.WriteLine("----Su Fitayı " + waterPrice + " tl");

            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------" );
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice+ " tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " tl");
            Console.WriteLine("Kola Tutarı: " + totalFriesPrice + " tl");
            Console.WriteLine("Su tutarı: " + totalWaterPrice + " tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " tl");

            Console.WriteLine();

            int totalPrice = totalLemonadePrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: "  + totalPrice + " tl");




            #endregion

            #region



            #endregion


            Console.Read();
        }
    }
}





