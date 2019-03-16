using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random(); // Random sınıfını kullanıp sayı uretebılmek ıcın kullanılan nesne.
            Takim dizi = new Takim();  // Takımlara erisebilmek icin tanımlanan bir nesne.
            Ermeydani meydan = new Ermeydani(dizi);
            int sayi, sayi2, sayi3; // Her bir askerin ne yapacagını belırleyebılmek icin uc sayı turettık.

            foreach (Asker a in dizi.Birlik)
            {
                a.hareketkontrol = meydan;
            }
            foreach (Asker a in dizi.Birlik2)
            {
                a.hareketkontrol = meydan;
            }
            meydan.BaslangıcKoordinatları(); // Baslangıc pozisyonlarını atadıgımız metot.
            
            while (meydan.TakimSagligiKontrol())
            {
                sayi = rastgele.Next(0, 7); //Birlikteki Hangi askerin secileceginin belirlenecegi random sayı.

                sayi2 = rastgele.Next(1,4); // Secilen askerin hangi hareketi yerine getirecegini belirledigimiz random sayı.
                if (sayi2 == 1) //uretilen sayi 1 ' e esit ise bekleyecek.
                {
                    dizi.Birlik[sayi].Bekle();
                    Console.WriteLine("İlk takimin" + "" + "("+dizi.Birlik[sayi].Koordinat.xko + "," + dizi.Birlik[sayi].Koordinat.yko + ")" + " konumundaki askeri bekledi");
                }
                else if (sayi2 == 2) // Sayi 2 ise hareket edecek.
                {
                    dizi.Birlik[sayi].HaraketEt();
                    Console.WriteLine("İlk takimin " + "" + " " + "(" + dizi.Birlik[sayi].Koordinat.xko + "," + dizi.Birlik[sayi].Koordinat.yko +")" + " konumundaki askeri hareket etti.");
                }
                else if (sayi2 == 3) // Sayi 3 ise ates edecek.
                {
                    dizi.Birlik[sayi].AtesEt();
                    Console.WriteLine("İlk takimin" + "" + "(" + dizi.Birlik[sayi].Koordinat.xko + "," + dizi.Birlik[sayi].Koordinat.yko + ")" + "konumundaki askeri ates etti");
                }
                sayi3 = rastgele.Next(1, 4); // Secilen askerin hangi hareketı yapacagını belırledıgımız random sayı
                if (sayi3 == 1)
                {
                    dizi.Birlik2[sayi].Bekle();
                    Console.WriteLine("İkinci takimin" + "" + "(" + dizi.Birlik2[sayi].Koordinat.xko + "," + dizi.Birlik2[sayi].Koordinat.yko + ")" + " konumundaki askeri bekledi");
                }
                else if (sayi3 == 2)
                {
                    dizi.Birlik2[sayi].HaraketEt();
                    Console.WriteLine("İkinci takimin " + "" + "(" + dizi.Birlik2[sayi].Koordinat.xko + "," + dizi.Birlik2[sayi].Koordinat.yko + ")" + " konumundaki askeri hareket etti.");
                }
                else if (sayi3 == 3)
                {
                    dizi.Birlik2[sayi].AtesEt();
                    Console.WriteLine("İkinci takimin" + "" + "(" + dizi.Birlik2[sayi].Koordinat.xko + "," + dizi.Birlik2[sayi].Koordinat.yko + ")" + "konumundaki askeri ates etti");
                }
            }
            Console.ReadKey();
        }
    }
}
