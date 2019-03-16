using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Er : Asker 
    {
        public override void Bekle()  
        {
            //Bekle metodu hıc bır sey degistirmeyecegi icin burası bos.
        }

        public override void HaraketEt()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 2); // Bu sayi askerin hangi yone hareket edecegını rastgele sececek olan sayı.
            if (sayi == 1) //Yukarı gıdecek
            {
                if (hareketkontrol.SinirKontrol(1,this)) // Hareket edıp edemeyecegının sınır kontrol testı.
                {
                    if (hareketkontrol.HareketKontrol(1,this)) // Eger sınır kontrolden gecebilirse haritanın ıc kısmında hareket edıp edemeyecegının testi yapılacak.
                    {
                        Koordinat.yko = Koordinat.yko - 1;
                    }   
                }               
            }
            else if (sayi == 2) // Assagı gıdecek
            {
                if (hareketkontrol.SinirKontrol(2,this)) // Hareket edıp edemeyecegının sınır kontrol testı.
                {
                    if (hareketkontrol.HareketKontrol(2, this)) // Eger sınır kontrolden gecebilirse haritanın ıc kısmında hareket edıp edemeyecegının testi yapılacak.
                    {
                        Koordinat.yko = Koordinat.yko + 1;
                    }
                }
            }          
        }
        public override void AtesEt()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 3); // Bu sayi ates ettiginde verecegi hasarı belırleyecek.
            switch (sayi)
            {
                case 1: 
                    damage = 5;
                    break;
                case 2:
                    damage = 10;
                    break;
                case 3: 
                    damage = 15;
                    break;      
            }
            hareketkontrol.AtesKontrol(this);
        }
    }
}
