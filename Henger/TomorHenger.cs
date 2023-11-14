using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class TomorHenger : cHenger
    {
        double fajsuly;

        public TomorHenger(double sugar, double magassag) : base(sugar, magassag)
        {
            fajsuly = 7.87;
        }

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public double Fajsuly { get => fajsuly; }
        public double Suly { get => 0; }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{this.Terfogat()}; sugár:{this.GetSugar}; magasság:{this.GetMagassag}; fajsúly:{this.fajsuly}";
        }
    }
}
