using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class Cso : cHenger
    {
        double falVastagsag;


        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }
        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falVastagsag = 1;
        }
        public double FalVastagsag { get => falVastagsag; }

        public override double Terfogat()
        {
            double terfogat1 = Math.Round(Math.PI * base.GetSugar * base.GetSugar * base.GetMagassag, 2);
            double terfogat2 = Math.Round(Math.PI * Math.Pow(base.GetSugar - this.falVastagsag, 2) * base.GetMagassag, 2);
            return Math.Round(terfogat1-terfogat2, 2);
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{this.Terfogat()}; sugár:{this.GetSugar}; magasság:{this.GetMagassag}; falvastagság: {this.falVastagsag}";
        }

    }
}
