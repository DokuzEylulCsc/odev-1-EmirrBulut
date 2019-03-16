using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        
        public override void Bekle()
        {
            // Bekle komutu bır sey yapmayacak o nedenle burası bos.
        }

        public override void HaraketEt()
        {

            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 5); // Bu sayi askerin hangi yone hareket edecegını rastgele sececek olan sayı.
            switch (sayi) 
            {
                case 1: // Yukarı hareket etme durumu.
                    if (hareketkontrol.SinirKontrol(1,this))
                    {
                        if (hareketkontrol.HareketKontrol(1, this))
                        {
                            Koordinat.yko = Koordinat.yko - 1;
                        }
                    }
                    break;
                case 2: // Asagı hareket etme durumu
                    if (hareketkontrol.SinirKontrol(2, this))
                    {
                        if (hareketkontrol.HareketKontrol(2, this))
                        {
                            Koordinat.yko = Koordinat.yko + 1;
                        }
                    }
                    break;
                case 3: // Sola hareket etme durumu
                    if (hareketkontrol.SinirKontrol(3,this))
                    {
                        if (hareketkontrol.HareketKontrol(3, this))
                        {
                            Koordinat.xko = Koordinat.xko - 1;
                        }
                    }                   
                    break;
                case 4: // Saga hareket etme durumu
                    if (hareketkontrol.SinirKontrol(4,this))
                    {
                        if (hareketkontrol.HareketKontrol(4,this))
                        {
                            Koordinat.xko = Koordinat.xko + 1;
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
                    damage = 10;
                    break;
                case 2: 
                    damage = 20;
                    break;
                case 3: 
                    damage = 25;
                    break;
            }
            hareketkontrol.AtesKontrol(this);
        }

    }
}
