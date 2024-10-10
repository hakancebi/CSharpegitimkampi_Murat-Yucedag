using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Merhaba Hakan");

            //Console.WriteLine("*****Yemek Kategorileri******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");

            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Salatalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Katagorileri******");

            #endregion

            #region String Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;

            //name = "Hakan";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 00 00";
            //customerEmail = "deneme@gmail.com";
            //district = "Araklı";
            //city = "Trabzon";

            //Console.WriteLine("****Rezervasyon Kartı*****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname );
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");
            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***Restoran menü fiyatı*****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("------Pizza : " + pizzaPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***Restoran menü fiyatı*****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalcokePrice;
            int totalwaterPrice;
            int totalfriesPrice;
            int totalpizzaPrice;
            int totallemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokePrice = cokeCount * cokePrice;
            totalwaterPrice = waterCount * waterPrice;
            totalfriesPrice = friesCount * friesPrice;
            totalpizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalpizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalfriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalcokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totallemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalwaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalcokePrice + totalwaterPrice + totalfriesPrice + totalHamburgerPrice + totalpizzaPrice + totallemonadePrice;

            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + " TL");
            #endregion

            Console.Read();

        }
    }
}

//Yazdırma Komutları
