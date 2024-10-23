using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDöngüsü

            ////For(x;y;z)
            //// x: döngünün başlangıç değeri
            ////y: bitiş
            ////z: artış ya da azalış değeri


            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C eğitim kampı ");
            //}


            //for (int i = 3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Ekrana yazılmasını istediğiniz adedi giriniz:");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region ForDongusuIleKararYapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //    Console.WriteLine(i + " " + totalValue);
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0; //1 ile 20 arasındaki çift sayıların 
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}
            //Console.WriteLine(totalValue);

            //1 ile 50 arasında 7 ye tam bölünen kaç sayı var 

            //int i = 0;
            //int count = 0;
            //for (i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine(count);

            //bir bakteri türü her saatin sonunda kendini 2ye bölerek üremektedir. //1-2-4-8-16 //her gelen de bölünüyor

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda " + bacterium);

            //}
            #endregion

            #region WhileDöngüsü

            //şart sağlandığı müddetçe

            //While(Şart)
            //{
            //İşlemler
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler..");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region ÖrnekSınavSorusu

            //klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //356 = 356 / 100 bölüm: 3 kalan 56 / 10: bölüm 5, kalan 6

            //benim yaptığım:

            Console.WriteLine("lütfen 3 basamaklı bir sayı giriniz: "); //356 
            int number = int.Parse(Console.ReadLine());
            int yüzler, onlar, birler;
            int kalan = 0;

            yüzler = number / 100; //yüzler 3 
            number = number % 100; //56
            onlar = number / 10; //5 //number 56 
            kalan = number - (onlar * 10);
            birler = kalan;

            Console.WriteLine(yüzler + onlar + birler);




            Console.Write("sayıyı giriniz:");

            int number1 = int.Parse(Console.ReadLine());
            int ones, tens, hundres;
            int sum;

            ones = number1 % 10; //birler
            tens = (number1 % 100) / 10;
            hundres = number1 / 100; // yüzler


            sum = ones + hundres + tens;
            Console.WriteLine(sum);









            #endregion

            Console.Read();
        }
    }
}
