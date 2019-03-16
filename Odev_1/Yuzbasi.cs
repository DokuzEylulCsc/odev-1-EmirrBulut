using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
          
        public override void Bekle()
        {
            //Bekle metodu hıc bır sey yapmayack o nedenle bos.
        }
        public override void HaraketEt()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 8);
            switch (sayi)
            {
                case 1: //Yukarı hareket etme durumu.
                    if (hareketkontrol.SinirKontrol(1,this))
                    {
                        if (hareketkontrol.HareketKontrol(1,this))
                        {
                            Koordinat.yko = Koordinat.yko - 1;
                        }
                    }
                    break;
                case 2: //Asagı hareket etme durumu
                    if (hareketkontrol.SinirKontrol(2,this))
                    {
                        if (hareketkontrol.HareketKontrol(2,this))
                        {
                            Koordinat.yko = Koordinat.yko + 1;
                        }
                    }
                    break;
                case 3: //Sola hareket etme durumu
                    if (hareketkontrol.SinirKontrol(3,this))
                    {
                        if (hareketkontrol.HareketKontrol(3,this))
                        {
                            Koordinat.xko = Koordinat.xko - 1;
                        }
                    }                   
                    break;
                case 4: //Saga hareket etme durumu
                    if (hareketkontrol.SinirKontrol(4,this))
                    {
                        if (hareketkontrol.HareketKontrol(4,this))
                        {
                            Koordinat.xko = Koordinat.xko + 1;
                        }
                    }
                    break;
                case 5: // Yukarı-sola hareket etme durumu
                    if (hareketkontrol.SinirKontrol(5,this))
                    {
                        if (hareketkontrol.HareketKontrol(5,this))
                        {
                            Koordinat.xko = Koordinat.xko - 1;
                            Koordinat.yko = Koordinat.yko - 1;
                        }
                    }                  
                    break;
                case 6: // Yukarı-saga hareket etme durumu
                    if (hareketkontrol.SinirKontrol(6,this))
                    {
                        if (hareketkontrol.HareketKontrol(6, this))
                        {
                            Koordinat.xko = Koordinat.xko + 1;
                            Koordinat.yko = Koordinat.yko - 1;
                        }

                    }                                  
                    break;
                case 7: // Asagı-saga hareket etme durumu
                    if (hareketkontrol.SinirKontrol(7,this))
                    {
                        if (hareketkontrol.HareketKontrol(7, this))
                        {
                            Koordinat.xko = Koordinat.xko + 1;
                            Koordinat.yko = Koordinat.yko + 1;
                        }
                    }     
                    break;
                case 8: // Asagı-sola hareket etme durumu
                    if (hareketkontrol.SinirKontrol(8,this))
                    {
                        if (hareketkontrol.HareketKontrol(8, this))
                        {
                            Koordinat.xko = Koordinat.xko - 1;
                            Koordinat.yko = Koordinat.yko + 1;
                        }
                    }
                    break;
            }
        }
        public override void AtesEt()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 3); // Bu sayi ates ettiginde verecegi hasarı belırleyecek.
            switch (sayi)
            {
                case 1: 
                    damage = 15;
                    break;
                case 2: 
                    damage = 25;
                    break;
                case 3: 
                    damage = 40;
                    break;
            }
            hareketkontrol.AtesKontrol(this);

        }
    }
}
