using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7]; // birinci takim
        Asker[] birlik2 = new Asker[7]; //ikinci takim

        public Asker[] Birlik { get { return birlik; } set { birlik = value; } }
        public Asker[] Birlik2 { get { return birlik2; } set { birlik2 = value; } }


        public Takim() // Askerleri takımlara atayan constructor metot.
        {
            for (int i = 0; i < 5; i++) //Birlik 1 'in ilk 5 elamanını er yaptık.
            {
                this.Birlik[i] = new Er();
            }
            this.Birlik[5] = new Tegmen(); // Birlik 1' in 6. elemanını yuzbası 7. elemanını da tegmen yaptık.
            this.Birlik[6] = new Yuzbasi();
            foreach (Asker item in Birlik)
            {
                item.takim = 1;
            }
            for (int i = 0; i < 5; i++) //Birlik 2 'in ilk 5 elamanını er yaptık.
            {
                this.Birlik2[i] = new Er();
            }
            this.Birlik2[5] = new Tegmen(); // Birlik 2' in 6. elemanını yuzbası 7. elemanını da tegmen yaptık.
            this.Birlik2[6] = new Yuzbasi();
            foreach (Asker item in Birlik2)
            {
                item.takim = 2;
            }
        }
       
        
        

    }
}
