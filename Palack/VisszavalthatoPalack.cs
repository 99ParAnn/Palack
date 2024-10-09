using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palack
{
    internal class VisszavalthatoPalack : Palack
    {
        private int palackdij;
        public VisszavalthatoPalack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1, int palackdij = 25) : base(ital, maxUrtartalom, jelenlegiUrtartalom)
        {
            this.palackdij = palackdij;
        }

        public int Palackdij { get => palackdij; set => palackdij = value; }

        public override string ToString()
        {
            return "Visszavalthato" + base.ToString();
        }
    }
}
