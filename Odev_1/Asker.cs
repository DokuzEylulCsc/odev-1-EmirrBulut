using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }
        public Ermeydani hareketkontrol; // Kontrol metotlarını her asker ıcın kullanabılmek ıcın askerlerin ortak ozellıgı olan ermaydanı classından bır nesne turettık.
        public int saglık = 100; // Baslangıcta her takımdakı her bır askerın canı 100.
        public int damage; // Her bir askerin ates ettıgınde (eger verirse) verecegi hasarı belirleyecek degısken.
        public int takim; // Askerlerın kendı takım arkadasını vurmalarını onlemek ıcın takımları ayırmayı sagladık bu degıskenle.
        public bool hayatta = true; // Askerlerın hayatta olup olmadıklarını kontrol eden degisken.

        
        public abstract void HaraketEt();

        public abstract void Bekle();

        public abstract void AtesEt();

      
       

    }
}
