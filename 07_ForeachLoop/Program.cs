using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //foreach (1;2;3;4)
            //1 değişken türü
            //değişken adı 
            //3: in
            //4: Liste, koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 52, 656, 6485, 654, 6451, 12, 356, 52 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //------

            //sadece çift sayılar sıralansın
            //int[] numbers = { 45, 52, 656, 6485, 654, 6451, 12, 356, 52 };
            //foreach (int number in numbers)
            //{
            //    if (number %2== 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //-----------------
            //toplama işlemleri
            //int[] numbers = { 45, 52, 656, 6485, 654, 6451, 12, 356, 52 };

            //int total = 0;
            //foreach (int i in numbers) //i her defasında dizideki tüm elemanları kendi üstüne alan değişken olacak. 
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<string> list = new List<string>(); //List<değişken tipi> listeAdı = new list<değişken tipi>();

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //Console.WriteLine(numbers);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ///--------------------------
            ///



            //bir kelimeyi harflerine ayıran foreach

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion


            #region Örnek Sınav Sistemi Uygulaması
            //Öğrenci sayısı alıp, bu öğrencilerin sınav notu ve not ortalamaları

            Console.WriteLine("**** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan almak 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sınıfızda kaç öğrenci var?: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            //öğrenci isimleri ve not ortalamarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();
                double totalExamResult = 0;

                //her öğrenci için 2 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. Sınav Notunu Giriniz:  ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;  //notlar toplanıyor.
                }

                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;

            }

            //sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                Console.WriteLine();
                //öğrencilerin ortalaması ve geçip kalmaları durumu 
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti. ");
                }

                if (studentExamAvg[i] < 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı. ");
                }
            }
            Console.WriteLine();



            #endregion

            Console.Read();
        }
    }
}
