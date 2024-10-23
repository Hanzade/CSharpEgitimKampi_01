﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElse

            Console.Write("Lütfen Şifreyi Giriniz: ");
            string password;
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru");
            }
            else
            {
                Console.WriteLine("Şifre yanlış");
            }


            string capital, country;
            Console.Write("Başkenti giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniiz: ");
            country = Console.ReadLine();

            if (capital == "ankara" && country == "türkiye")
            {
                Console.Write("veriler doğrulandı.");
            }
            else
            {
                Console.Write("hatalı bilgi");
            }


            int sayi;
            Console.Write("Sayiyi giriniz: ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi == 5)
            {
                Console.WriteLine("sayi doğru ");
            }
            else
            {
                Console.WriteLine("sayi hatalı ");
            }

            int exam1, exam2, exam3, average;
            string result = "Hata!";

            Console.Write("Sınav1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması:" + average);


            if (average > 0 & average <= 50)
            {
                result = "sonuç vasat";
            }
            if (average > 50 & average <= 70)
            {
                result = "sonuç orta";
            }
            if (average > 70 & average <= 85)
            {
                result = "sonuç iyi";
            }
            if (average > 84)
            {
                result = "sonuç çok iyi";
            }

            Console.WriteLine(result); //165 - girilmeyen bir sonuç olursa resultı nasıl yazacağını bilmediğinden bu hatayı veriyor, bundan dolayı başlangıçta resulta değer atadık. 

            string city;
            Console.Write("Lütfen Şehir girişi yapınız: ");
            city = Console.ReadLine();

            if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            {
                Console.WriteLine("Şehir Mevcut");
            }
            else
            {
                Console.WriteLine("şehir mevcut değil");
            }


            Console.Write("Lütfen Kullanıcı Adınızı Giriniz:");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.WriteLine("bu kullanıcı kabul edilemez.");
            }
            else
            {
                Console.WriteLine("hoş geldiniz");
            }

            #endregion


            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int sonuc = number % 5;
            //Console.WriteLine(sonuc);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());


            //int result = number1 % number2;
            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("sayi çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayi tektir. ");
            //}
            #endregion

            #region CharDegiskenler

            char team;
            Console.Write("Lütfen takım sembolünü giriniz: ");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("galatasaray");
            }

            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("fenerbahçe");
            }

            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
            #endregion

            #region OrnekProjeUygulamasi

            Console.WriteLine("*** c# Eğitim Kampı Restoran ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            string menuItem;
            Console.Write("Lütfen Detayını Görmek istediğiniz menü seçiniz: ");
            menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("**** Ana Yemekler ****");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Kızartma Tabağı");
                Console.WriteLine("3- Fasulye Pilav");
                Console.WriteLine("4-Fırında Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine("**** Ana Yemekler ****");

                Console.WriteLine();

            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("**** Çorbalar ****");
                Console.WriteLine();
                Console.WriteLine("1- Mercimek Çorbası");
                Console.WriteLine("2- Ezogelin Çorbası");
                Console.WriteLine("**** Çorbalar ****");

                Console.WriteLine();

            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("**** Pizzalar ****");
                Console.WriteLine();
                Console.WriteLine("1- Akdeniz Pizza");
                Console.WriteLine("2- Margarita");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("**** Pizzalar ****");

                Console.WriteLine();

            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("**** İçecekler ****");
                Console.WriteLine();
                Console.WriteLine("1- Kola");
                Console.WriteLine("2- Ayran");
                Console.WriteLine("3- Su");
                Console.WriteLine("**** İçecekler ****");

                Console.WriteLine();

            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("**** Tatlılar ****");
                Console.WriteLine();
                Console.WriteLine("1- Trileçe");
                Console.WriteLine("2- Kazandibi");
                Console.WriteLine("3- Sütlaç");
                Console.WriteLine("**** Tatlılar ****");

                Console.WriteLine();

            }


            #endregion


            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("hatalı veri girişi");
            //        break;

            //}

            #endregion


            #region HesapMakinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz:");
            //symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2; break;
            //    case '-':
            //        result = number1 - number2; break;
            //    case '*':
            //        result = number1 * number2; break;
            //    case '/':
            //        result = number1 / number2; break;

            #endregion
        }

    }
}