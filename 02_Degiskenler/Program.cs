using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler

            double number;
            number = 4.85;
            Console.WriteLine(number);

            //kod tarafında nokta olarak girilen konsol ekranında virgül olarak gözükür. 

            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;


            Console.WriteLine("Elma Birim Fiyatı: " + applePrice + " tl");
            Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " tl");
            Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " tl");
            Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + " tl");
            Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + " tl");

            double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawGram = 0.750;
            potatoGram = 4.879;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("-------------------------- Hesap ------------");

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " -Gramaj " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " -Gramaj " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " -Gramaj " + strawGram + " - Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " -Gramaj " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " -Gramaj " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);


            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " tl");



            #endregion


            #region CharDegiskenler

            //ABCDEGH -
           // DEF... 
           // TOPLANTI SAAT 20:00 DE

            char symbol;
            symbol = 'a';


            #endregion

            #region KlavyedenVeriGirisleriString

            Console.WriteLine("**** CSHarp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();



            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İlçe Bilgisi:");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcıu TC: ");
            passengerIdentityNumber = Console.ReadLine();




            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("Yolcu Tc: " + passengerIdentityNumber + "  " + "Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " ");



            #endregion


            #region KlavyedenTamSayiGirisleriveDonusumler

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.WriteLine("Lütfen Aldığınız ayakkabı Sayısını Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine()); //parse metodu int i 32 bit olarak dönüştürür 

            Console.WriteLine("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Aldığınız TV Sayısını Girimiz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);



            #endregion

            #region KlavyedenOndalikliSayiIslemleri

            double exam1, exam2, exam3, result;

            Console.WriteLine("Lütfen 1. sınav notunu giriniz");
            exam1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sınav notunu giriniz");
            exam2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 3. sınav notunu giriniz");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion


            #region KlavyedenKarakterGirisleri


            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz");
            gender=char.Parse(Console.ReadLine()); //tam bir karakter girmemiz gerekiyor aksi takdirde char olarak tuttuğumuz için hata verir. 

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion

            Console.Read();
        }
    }
}
