using System;
using System.Collections.Generic;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen, oluşacak karışık çalma listesi için, sevdiğiniz 10 sanatçıyı ve şarkıyı giriniz:");
            CalmaListesi calmaListesi0 = new CalmaListesi();
            System.Console.WriteLine("Sanatçı ismi:");
            calmaListesi0.isim=Console.ReadLine();
            System.Console.WriteLine("Şarkı adı:");
            calmaListesi0.şarkıİsmi=Console.ReadLine();

            CalmaListesi calmaListesi1 = new CalmaListesi();
            System.Console.WriteLine("Sanatçı ismi:");
            calmaListesi1.isim=Console.ReadLine();
            System.Console.WriteLine("Şarkı adı:");
            calmaListesi1.şarkıİsmi=Console.ReadLine();

            CalmaListesi calmaListesi2 = new CalmaListesi();
            System.Console.WriteLine("Sanatçı ismi:");
            calmaListesi2.isim=Console.ReadLine();
            System.Console.WriteLine("Şarkı adı:");
            calmaListesi2.şarkıİsmi=Console.ReadLine();

            CalmaListesi calmaListesi3 = new CalmaListesi();
            System.Console.WriteLine("Sanatçı ismi:");
            calmaListesi3.isim=Console.ReadLine();
            System.Console.WriteLine("Şarkı adı:");
            calmaListesi3.şarkıİsmi=Console.ReadLine();

            CalmaListesi calmaListesi4 = new CalmaListesi();
            System.Console.WriteLine("Sanatçı ismi:");
            calmaListesi4.isim=Console.ReadLine();
            System.Console.WriteLine("Şarkı adı:");
            calmaListesi4.şarkıİsmi=Console.ReadLine();
            
            object[] dizi = new object[5];
            dizi[0]=calmaListesi4.isim;
            dizi[1]=calmaListesi2.isim;
            dizi[2]=calmaListesi3.isim;
            dizi[3]=calmaListesi1.isim;
            dizi[4]=calmaListesi0.isim;
            for(int b=0;b<=4;b++){
            System.Console.WriteLine("Çalmalisteniz:" + dizi[b]);}
        }
    }
    class CalmaListesi
    {
        public string isim {get; set;}
        public string şarkıİsmi {get; set;}
    }
}
