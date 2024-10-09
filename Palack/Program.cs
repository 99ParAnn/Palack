using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisszavalthatoPalack egyik = new VisszavalthatoPalack("ceklale", 500, 50);
            Palack masik = new Palack("aaaa", 500, 500);
            egyik.JelenlegiUrtartalom = 0;
            Console.WriteLine(egyik);
            egyik.HozzaOnt(masik);
            Console.WriteLine(egyik);

            Rekesz rekesz = new Rekesz(5000);
            rekesz.UjPalack(masik);
            rekesz.UjPalack(egyik);
        }
    }
}
