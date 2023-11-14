using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henger
{
    internal class cHenger
    {
        double magassag, sugar;
        static int szuletesSzamlalo;

        public cHenger(double sugar, double magassag)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            szuletesSzamlalo++;
        }

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public virtual double Terfogat()
            { return Math.Round(sugar * sugar * Math.PI * magassag, 2); }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat:{this.Terfogat()}; sugár:{this.sugar}; magasság:{this.magassag}";
        }
    }
}
