using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes14C
{

    interface IPelda
    {
        void Kiir();
    }
    interface IPelda1
    {
        void Kiir();
    }
    abstract class Alakzat
    {
        public abstract void Rajzol();
    }
    class Negyzet : Alakzat
    {
        public override void Rajzol()
        {
            throw new NotImplementedException();
        }
    }
    class Allat:IPelda,IPelda1
    {
        protected string hely;
        protected string beszed;
        public Allat(string hely)
        {
            this.hely = hely;
        }

        public override string ToString()
        {
            return ($"Az állat mondja: {beszed}");
        }

        public virtual void Beszel()
        {
            beszed = "";
        }

        public string Mitmond() 
        { return beszed; }

        public void Kiir()
        {
            Console.WriteLine("Állat");
        }
    }
    
    class Kutya : Allat
    {

        protected string gazdi;
        public Kutya(string hely,string gazdi):base(hely)
        {
            this.gazdi = gazdi;
        }

        public sealed override void Beszel()//Továbbiakban nem módosítható
        {
            beszed = "WAU";
        }

        public override string ToString()
        {
            return ($"A kutya mondja: {beszed}");
        }
        public void Kiir()
        {
            Console.WriteLine("Kutya");
        }
    }

    class KisKutya : Kutya
    {
        public KisKutya(string hely, string gazdi) : base(hely, gazdi)
        {

        }
    }

    class Macska : Allat
    {
        public Macska(string hely) : base(hely)
        {
            beszed = "Miau";
        }

        public override string ToString()
        {
            return ($"A macska mondja: {beszed}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Allat a = new Allat("Miskolc");
            Kutya kutya = new Kutya("Érd", "Géza");
            Macska macska = new Macska("Taktaharkány");
            Allat KutyaAllat = new Kutya("asd","Béla");
            Allat MacskaAllat = new Macska("Kandó");
            Negyzet ne = new Negyzet();

            a.Beszel();a.Kiir();
            kutya.Beszel();
            macska.Beszel();
            IPelda ip = a;
            IPelda1 ip1 = a;
            ip1.Kiir();
            ip.Kiir();
            KutyaAllat.Beszel();
            MacskaAllat.Beszel();
            ne.Rajzol();


            Console.WriteLine(a);//a.ToString 
            Console.WriteLine(kutya);
            Console.WriteLine(KutyaAllat);
            Console.WriteLine(MacskaAllat);




        }
    }
}
