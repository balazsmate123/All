using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GyakOrokles14C
{
    interface IArlap
    {
        public double mennyibeKerul();
    }

    abstract class Peksutemeny : IArlap
    {
        protected int mennyiseg;
        public double alapAr;

        protected Peksutemeny(int mennyiseg, double alapAr)
        {
            this.mennyiseg = mennyiseg;
            this.alapAr = alapAr;
        }
        public abstract void Megkostol();

        public double mennyibeKerul()
        {
            return this.alapAr*mennyiseg;
        }

        public override string ToString()
        {
            return $"X {mennyiseg} db - {mennyibeKerul()} Ft";
        }
    }

    class Pogacsa : Peksutemeny
    {
        public Pogacsa(int mennyiseg, double alapAr) : base(mennyiseg, alapAr)
        { 
        }

        public override void Megkostol()
        {
            this.mennyiseg /= 2;
        }
        public override string ToString()
        {
            return $"Pogacsa " + base.ToString();
        }
    }

    class Kave : IArlap
    {
        private bool habosE;
        const int CSESZEKAVE = 180;

        public double mennyibeKerul()
        {
            if (habosE)
            {
                return CSESZEKAVE * 1.5;
            }
            else
            {
                return CSESZEKAVE;
            }
        }
        public override string ToString()
        {
            return $"";
        }
        public Kave(bool habosE)
        {
            this.habosE = habosE;
            if (habosE )
            {
                this.
            }
        }
    }
    internal class Futtato
    {
       static List<IArlap> arlap = new List<IArlap> ();
        static void Vasarlok(string utvonal)
        {
            StreamReader sr = new StreamReader(utvonal);
            while (!sr.EndOfStream) 
            {
                string[] temp = sr.ReadToEnd().Split('\n');
                if (temp[0]=="Pogacsa")
                {
                    arlap.Add(new Pogacsa(int.Parse(temp[1], double.Parse(temp[2]))));
                }
                else
                {
                    arlap.Add(new Kave(int.Parse(temp[2], double.Parse(temp[2]))));
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
