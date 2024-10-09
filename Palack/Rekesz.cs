using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palack
{
    internal class Rekesz
    {
        private int maxTeherbiras;
        private List<Palack> palackok;

        public Rekesz(int maxTeherbiras)
        {
            this.maxTeherbiras = maxTeherbiras;
            this.palackok = new List<Palack>();
        }
        public int Suly()
        {
            int eredmeny = 0;
            foreach (var item in palackok)
            {
                eredmeny += item.Suly();
            }
            return eredmeny;
        }
        public void UjPalack(Palack uj)
        {
            if (this.Suly() + uj.Suly() <= maxTeherbiras)
            {
                palackok.Add(uj);
            }
        }

        public int OsszesPenz()
        {
            int result = 0;
            foreach (var item in palackok)
            {
                
            }
                return 0;
        }
        //Nem tudok rájönni, hogy ezt a függvényt hogy oldjam meg. Később visszatérek rá.*/

    }
}
