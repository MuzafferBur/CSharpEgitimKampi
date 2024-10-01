using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double Degiskenler
            //double number;
            //number = 3.71;
            //Console.WriteLine(number);

            //double applePrice, orengePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 13.74;
            //orengePrice = 19.99;
            //strawberryPrice = 47;
            //potatoPrice = 8.35;
            //tomatoPrice = 7.87;

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //Console.WriteLine("----Elma BIrim Fiyati :" + applePrice + " TL");
            //Console.WriteLine("----Portakal BIrim Fiyati: " + orengePrice + " TL");
            //Console.WriteLine("----Cilek BIrim Fiyati: " + strawberryPrice + " TL");
            //Console.WriteLine("----Patates BIrim Fiyati: " + potatoPrice + " TL");
            //Console.WriteLine("----Domates BIrim Fiyati: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram = 1.245;
            //double orengeGram = 3.000;
            //double strawberryGram = 0.750;
            //double potatoGram = 2.345;
            //double tomatoGram = 1.127;

            //double appleTotalPrice, orengeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //orengeTotalPrice = orengePrice * orengeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice = potatoPrice * potatoGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;


            //Console.WriteLine("Alinan Urun: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL"); 
            //Console.WriteLine("Alinan Urun: Portakal - Birim Fiyat: " + orengePrice + " - Gramaj: " + orengeGram + " - Toplam Tutar: " + orengeTotalPrice + " TL"); 
            //Console.WriteLine("Alinan Urun: Cilek - Birim Fiyat: " + strawberryPrice + " - Gramaj: "  + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL"); 
            //Console.WriteLine("Alinan Urun: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " TL"); 
            //Console.WriteLine("Alinan Urun: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orengeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice; 
            //Console.WriteLine();
            //Console.WriteLine("Toplam Alisveris Tutari: " + shoppingTotalPrice + " TL");

            #endregion

            #region char Degiskenler

            //ABCDEF...
            //DEF...
            //'x'

            //char symbol;
            //symbol = 'x';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden String Veri Girisi

            //Console.WriteLine("**** CSharp Hava Yollari Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadi: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Ilce Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Sehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yas: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarasi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Kimlik Numarasi: "+passengerIdentityNumber+ " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " - Ilce Sehir: "+ passengerDistrict+"/"+passengerCity + " - Yolcu Yas: "+passengerAge);


            #endregion

            #region Klavyeden Int Veri Girisi ve Donusumler

            //int headphonesPrice = 1500, computerPrice = 20000, chairPrice = 5000, tvPrice = 12000;

            //int headphonesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen aldiginiz kulaklik sayisini giriniz: ");
            //headphonesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lutfen aldiginiz televizyon sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice =headphonesPrice * headphonesCount+ computerPrice * computerCount+ chairPrice * chairCount+ tvPrice*tvCount;

            //Console.WriteLine("");
            //Console.WriteLine("Faturaniz: "+ totalPrice);
            #endregion

            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1.Sinaviniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2.Sinaviniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3.Sinaviniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("");
            //Console.WriteLine("Ders Ortalamaniz: "+ result);

            #endregion

            #region Klavyeden Karakter Girisleri

            //char gender;
            //Console.Write("Lutfen cinsiyet seciniz E/K: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine("Sectiginiz Cinsiyet -> " + gender);

            #endregion

            Console.Read();
        }
    }
}
