using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palack
{
    internal class Palack
    {
        private string ital;
        private int maxUrtartalom;
        private int jelenlegiUrtartalom;

        public Palack(string ital, int maxUrtartalom, int jelenlegiUrtartalom = 1)
        {
            this.ital = ital;
            this.maxUrtartalom = maxUrtartalom;
            this.jelenlegiUrtartalom = jelenlegiUrtartalom;
        }

        //forrás: https://www.dotnetperls.com/property
        //NEM M.I.
        public int JelenlegiUrtartalom
        {
            get
            {
                return this.jelenlegiUrtartalom;
            }
            set
            {
                if (value <= 0)
                {
                    jelenlegiUrtartalom = 0;
                    ital = null;
                }
                else if (value > maxUrtartalom)
                {
                    jelenlegiUrtartalom = maxUrtartalom;
                }
                else
                {
                    jelenlegiUrtartalom = value;
                };
            }
        }

        public string Ital { get => ital; set => ital = value; }
        public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }

        public int Suly()
        {
            return maxUrtartalom / 35 + jelenlegiUrtartalom;
        }

        public override string ToString()
        {
            return $"Palack, benne levo ital: {this.ital}, jelenleg {this.jelenlegiUrtartalom} ml van benne, maximum {maxUrtartalom} fer bele.";
        }
        public override bool Equals(object obj)
        {
            var item = obj as Palack; //forrás: stack overflow, https://stackoverflow.com/questions/9317582/correct-way-to-override-equals-and-gethashcode
            return item.Ital == this.ital
                && item.JelenlegiUrtartalom == this.jelenlegiUrtartalom
                && item.MaxUrtartalom == maxUrtartalom;
        }
        public void HozzaOnt(Palack masikPalack) //nincs említve a feladatban, hogy a másik palackból fogyjon el a folyadék, úgyhogy nem csinál ilyet
        {
            this.JelenlegiUrtartalom = jelenlegiUrtartalom + masikPalack.JelenlegiUrtartalom;
            if (this.ital == null)
            {
                this.ital = masikPalack.ital;
            }
            else if (this.ital != masikPalack.Ital)
            {
                this.ital = "keverek";
            }
        }




    }
}

