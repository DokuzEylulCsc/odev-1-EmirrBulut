using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge[,] harita = new Bolge[16, 16];
        public Takim team; // Takimlara erisebilmek icin turetilmis bir nesne.
        public Bolge[,] Harita { get { return harita; } set { harita = value; } }
        public bool check; // Hareket sırasında hedef bolgenin dolu olup olmadıgını anlayabilmek icin kullanılan bir degisken.

        public Ermeydani(Takim t) // Bu for her bir bolgenin koordinatlarının harita uzerınde atanmasını saglıyor. Yani harita uzerındeki 16 bolgeyi belirledik.
        {
            for (int i = 0; i < 16; i++) 
            {
                for (int j = 0; j < 16; j++)
                {
                    Harita[i, j] = new Bolge(i, j);
                }
            }
            team = t;
        }

        public void BaslangıcKoordinatları() // Takımların baslangıc konumlarının belırlendıgı metot.
        {
            int i = 0, j = 0, k = 0, f = 0; // i = x , j = y
            for (i = 0; i < 3 ; i++) // Birici takimin erlerinin baslangıc pozısyonlarını gırdıgımız for.
            {
                for (j = 0; j < 2; j++)
                {
                    team.Birlik[k].Koordinat = Harita[i, j];
                    k++;
                }
            }
            team.Birlik[5].Koordinat = Harita[2, 1]; // Tegmenin baslangıc pozisyonu
            team.Birlik[6].Koordinat = Harita[1, 2]; // Yuzbasının basangıc pozısyonu

            team.Birlik2[0].Koordinat = Harita[15, 15]; // Er1 baslangıc pozisyonu
            team.Birlik2[1].Koordinat = Harita[14, 15]; // Er2 basangıc pozısyonu
            team.Birlik2[2].Koordinat = Harita[13, 15]; // Er3 baslangıc pozisyonu
            team.Birlik2[3].Koordinat = Harita[15, 14]; // Er4 basangıc pozısyonu
            team.Birlik2[4].Koordinat = Harita[14, 14]; // Er5 baslangıc pozisyon
            team.Birlik2[5].Koordinat = Harita[13, 14]; // Tegmenin baslangıc pozisyonu
            team.Birlik2[6].Koordinat = Harita[14, 13]; // Yuzbasının basangıc pozısyonu
        }

        public bool HareketKontrol(int x,Asker a)   // Askerlerin hareketi sırasında hareket etmek istedikleri yerin uygunlugunu kontrol eden metot.
        {
            
            if ( x == 1 ) // Eger gelen deger 1 ıse yukarısı bos mu dıye kontrol edecek.
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.yko - 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false; // Gıtmek ıstenen yerın dolu oldugu anlamına gelıyor.
                        return check;
                    }
                    else
                    {
                        check = true; // Gıtmek ıstenen yerın bos oldugu anlamına gelıyor.  
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.yko - 1 == b.Koordinat.yko && b.saglık!=0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 2) // Asagı gıtme islemi
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;                       
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 3) // Sola gitme islemi
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko - 1 == b.Koordinat.xko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.yko - 1 == b.Koordinat.xko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 4) // Saga gitme islemi
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 5) // Yukarı - sola gitme durumu
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko - 1 == b.Koordinat.xko && a.Koordinat.yko - 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.xko - 1 == b.Koordinat.xko && a.Koordinat.yko -1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 6) // Yukarı - saga gitme durumu
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && a.Koordinat.yko - 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && a.Koordinat.yko - 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 7) // Asagı - saga gitme islemi 
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.xko + 1 == b.Koordinat.xko && a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            else if (x == 8) // Asagı - sola gitme
            {
                foreach (Asker b in team.Birlik)
                {
                    if (a.Koordinat.xko - 1 == b.Koordinat.xko && a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false; 
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                foreach (Asker b in team.Birlik2)
                {
                    if (a.Koordinat.xko - 1 == b.Koordinat.xko && a.Koordinat.yko + 1 == b.Koordinat.yko && b.saglık != 0) 
                    {
                        check = false;
                        return check;
                    }
                    else
                    {
                        check = true;
                        
                    }
                }
                return check;
            }
            return true;
        } 
        public bool SinirKontrol(int x, Asker b) // Askerlerin hareketi sırasında harita sinirlarindan cıkıp cıkmadıklarını kontrol eden metot.
        {
            if (x == 1 && b is Er && b.Koordinat.yko == 0) // Er sınıra ulasmasına ragmen yukarı gıtmek ısterse bir sag kareye gitmeli.
            {
                if (x == 1 && b is Er && b.Koordinat.xko != 15)
                {
                    b.Koordinat.xko = b.Koordinat.xko + 1;
                    
                }
                return false;
            }
            else if (x == 2 && b is Er && b.Koordinat.yko == 15) // Er sınıra ulasmasına ragmen asagı gıtmek ısterse bir sag kareye gitmeli.
            {
                if (x == 2 && b is Er &&  b.Koordinat.xko != 0)
                {
                    b.Koordinat.xko = b.Koordinat.xko - 1;
                    
                }
                return false;
            }
            else if (x == 1 && b.Koordinat.yko == 0 && (b is Yuzbasi || b is Tegmen)) // Tegmen veya yuzbası ust sınırda olmasına ragmen yukarı gıtmek ısterse
            {
                b.Bekle();
                return false;
            }
            else if (x == 2 && b.Koordinat.yko == 15 && (b is Yuzbasi || b is Tegmen)) // Tegmen veya yuzbası alt sınırda olmasına ragmen asagı gıtmek ısterse
            {
                b.Bekle();
                return false; // Her bir durum kendine ozel oldugu ve saglanırsa false dondurup hareketet metodundan cıkıs yapmasını saglamak ıcın her bırıne return false yazdım. Eger hic bir if saglanmıyorsa en alttan true dondurecebılecek.
            }
            else if (x == 3 && b.Koordinat.xko == 0 ) // Sola gitmek isteyip sınıra takılma durumu
            {
                b.Bekle();
                return false;
            }
            else if (x == 4 && b.Koordinat.xko == 15) // Saga gitmek isteyip sınırda takılma durumu
            {
                b.Bekle();
                return false;
            }
            else if ((x == 5) && (b.Koordinat.xko == 0 || b.Koordinat.yko == 0) && b is Yuzbasi) // Sol en ust kosede ve sol carpraza gıtmek ısteme durumu
            {
                b.Bekle();
                return false;
            }
            else if ((x == 6 ) && (b.Koordinat.xko == 15 || b.Koordinat.yko == 0) && b is Yuzbasi) // Sag en ust kosede ve sag carpraza gıtme durumu
            {
                b.Bekle();
                return false;
            }
            else if ((x == 7 ) && (b.Koordinat.xko == 15 || b.Koordinat.yko == 15) && b is Yuzbasi) // Sag en alt kosede ve sag alt carpraza gitme durumu
            {
                b.Bekle();
                return false;
            }
            else if ((x == 8 ) && (b.Koordinat.xko == 0 || b.Koordinat.yko == 15) && b is Yuzbasi) // Sol en alt kosede olup sol alta gıtme ıstegı 
            {
                b.Bekle();
                return false;
            }
            return true;
        } 
        public void AtesKontrol(Asker c) // Herhangi bir asker ates ettiginde menzilinde biri olup olmadıgını kontrol eden metot.
        {
            if (c is Er && c.takim == 1) // Birinci takımdaki erlerin ates ettigi bolgede dusman askeri var mı kontrolu
            {
                foreach (Asker b in team.Birlik2)
                {
                    if ((Math.Abs(c.Koordinat.xko - b.Koordinat.xko) == 1) && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) == 1 && b.saglık != 0)
                    {
                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }
            }
            if (c is Er && c.takim == 2) // ikinci takimdaki erlerin ates ettıgı bolgede dusman askeri var mı kontrolu
            {
                foreach (Asker b in team.Birlik)
                {
                    if (Math.Abs(c.Koordinat.xko - b.Koordinat.xko) == 1 && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) == 1 && b.saglık != 0)
                    {
                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }

            }
            if (c is Tegmen && c.takim == 1) // Birinci takimdaki tegmenin ates ettıgı yerde dusman askeri var mı kontrolu
            {
                foreach (Asker b in team.Birlik2)
                {
                    if (Math.Abs(c.Koordinat.xko - b.Koordinat.xko) <= 2 && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) <= 2 && b.saglık != 0)
                    {

                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }
            }
            if (c is Tegmen && c.takim == 2) // İkinci takimdaki tegmenin ates ettıgı yerde dusman askeri var mı kontrolu
            {
                foreach (Asker b in team.Birlik)
                {
                    if (Math.Abs(c.Koordinat.xko - b.Koordinat.xko) <= 2 && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) <= 2 && b.saglık != 0)
                    {
                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }
            }
            if (c is Yuzbasi && c.takim == 1) // Birinci takımdaki yuzbasının ates ettigi alanda dusman askeri var mı kontrolu

            {
                foreach (Asker b in team.Birlik)
                {
                    if (Math.Abs(c.Koordinat.xko - b.Koordinat.xko) <= 3 && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) <= 3 && b.saglık != 0)
                    {
                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }
            }
            if (c is Yuzbasi && c.takim == 2) // ikinci takimdaki yuzbasının ates ettigi bolgede dusman askeri  var mı kontrolu
            {
                foreach (Asker b in team.Birlik2)
                {
                    if (Math.Abs(c.Koordinat.xko - b.Koordinat.xko) <= 3 && Math.Abs(c.Koordinat.yko - b.Koordinat.yko) <= 3 && b.saglık != 0)
                    {
                        b.saglık = b.saglık - c.damage;
                        if (b.saglık <= 0)
                        {
                            b.hayatta = false;
                            b.saglık = 0;
                        }
                    }
                }
            }
        } 
        public bool TakimSagligiKontrol() // Oyunun devam edip etmeyecegini ayarlayabılmek icin boyle bır metoda ıhtıyacımız var. 
        {
            int bts=0; //birinci takimin saglıgını tuttugumuz degisken
            int its=0; //ikinci takımın sagligini tuttugumuz degisken
            foreach (Asker soldier in team.Birlik2)
            {
                if (soldier.hayatta == false)
                {
                    its++;
                }
            }
            if (its == 7)
            {
                Console.WriteLine("İlk takim kazandı. OYUN BİTTİ" + bts + its);
                return false;
            }
            foreach (Asker soldier in team.Birlik)
            {
                if (soldier.hayatta == false)
                {
                    bts++;
                }
                
            }
            if (bts == 7)
            {
                Console.WriteLine("İkinci takim kazandi. OYUN BİTTİ"+bts+its);
                return false;
            }         
            return true;
        } 

    }
}
