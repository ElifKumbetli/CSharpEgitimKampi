﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar
            // Bir yapının sonunda () 
            //mor renk küp
            //Geriye Değer Döndürmeyen Metotlar
            //Customer-->Listeleme,ekle,sil,güncelle
            //Void-->Geriye değer döndürmez.

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
            //    int x = 1;
            //    int y=2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metodlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metodlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion
            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital +
            //        "- Bayrak Rengi:  " + flagColor;
            //    return cardInfo;
            //}

            //string x, y,z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result =number1 + number2;
            //    return result;

            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));
            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimi öğrenci sınavı geçti" + "Ortalama: " + result;

                }
                else
                {
                    return student + " isimi öğrenci sınavı geçemedi" + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion

            Console.Read();
        }
    }
}
