using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanuloDolgozat
{
    internal class Program
    {
        public class Tanulo
        {
            private static int darab = 0;


            private double atlag;
            private int kor;
            private string nev;
            private string osztaly;
            private readonly string iskola;


            public Tanulo(double atlag, int kor, string nev, string osztaly, string iskola)
            {
                this.atlag = atlag;
                this.nev = nev;
                this.osztaly = osztaly;
                this.iskola = iskola;

                Random random = new Random();
                this.kor = random.Next(14, 20);

                darab++;
            }


            public double Atlag
            {
                get { return atlag; }
                set
                {

                    if (value >= 1.0 && value <= 5.0)
                    {
                        atlag = Math.Round(value, 2);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Az átlagnak 1.0 és 5.0 között kell lennie.");
                    }
                }
            }

            public int Kor
            {
                get { return kor; }

            }

            public string Nev
            {
                get { return nev; }
                set { nev = value; }
            }

            public string Osztaly
            {
                get { return osztaly; }
                set { osztaly = value; }
            }

            public static int Darab
            {
                get { return darab; }

            }

            public string GetNev()
            {
                return nev;
            }

            public void SetNev(string ujNev)
            {
                nev = ujNev;
            }

            public override string ToString()
            {
                return $"Név: {nev}, Kor: {kor} év, Osztály: {osztaly}, Átlaga: {atlag}";
            }

            public void Kiir()
            {
                Console.WriteLine($"Név: {nev}, Kor: {kor} év, Osztály: {osztaly}, Átlaga: {atlag}");
            }
        }




        static void Main(string[] args)
        {
            Random random = new Random();
            List<Tanulo> tanulok = new List<Tanulo>();

            string[] nevekNo = { "Anna", "Eszter", "Judit", "Márta", "Nóra", "Réka", "Katalin", "Gizella", "Hanna", "Cecília" };
            string[] nevekFerfi = { "Bence", "Dávid", "Ferenc", "Gábor", "István", "János", "László", "Márton", "Péter", "Tamás" };

            for (int i = 1; i <= 20; i++)
            {
                string nev;
                if (i <= 10)
                {
                    nev = nevekNo[random.Next(nevekNo.Length)];
                }
                else
                {
                    nev = nevekFerfi[random.Next(nevekFerfi.Length)];
                }

                double atlag = Math.Round(random.NextDouble() * (5.0 - 1.0) + 1.0, 2);
                int kor = random.Next(14, 20); 
                int evfolyam = random.Next(9, 15); 
                char osztaly = (char)('A' + random.Next(5)); 

                Tanulo tanulo = new Tanulo(atlag, kor, nev, $"{evfolyam}/{osztaly}", "Példa Iskola");
                tanulok.Add(tanulo); 
            }
            Console.WriteLine("2.feladat");
            foreach (var tanulo in tanulok)
            {
                Console.WriteLine($"Tanuló neve: {tanulo.Nev}, Átlag: {tanulo.Atlag}, Osztály: {tanulo.Osztaly}, Kor: {tanulo.Kor}");
            }
            Tanulo legokosabbDiak = tanulok[0]; 

            foreach (var tanulo in tanulok)
            {
                if (tanulo.Atlag > legokosabbDiak.Atlag)
                {
                    legokosabbDiak = tanulo; 
                }
            }
            Console.WriteLine();
            Console.WriteLine("4.feladat");
            Console.WriteLine($"Legokosabb diák: Név: {legokosabbDiak.Nev}, Átlag: {legokosabbDiak.Atlag}, Osztály: {legokosabbDiak.Osztaly}, Kor: {legokosabbDiak.Kor}");

            int nemTankotelesTanulok = 0;

            foreach (var tanulo in tanulok)
            {
                if (tanulo.Kor >= 16)
                {
                    nemTankotelesTanulok++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("5.feladat");
            Console.WriteLine($"Nem tanköteles tanulók száma: {nemTankotelesTanulok}");
            Console.WriteLine();
            Console.WriteLine("6.feladat");

            int rossz = 0;
            int gyenge = 0;
            int kozepes = 0;
            int jo = 0;
            int jeles = 0;

            foreach (var tanulo in tanulok)
            {
                if (tanulo.Atlag < 2.0)
                {
                    rossz++;
                }
                else if (tanulo.Atlag < 3.0)
                {
                    gyenge++;
                }
                else if (tanulo.Atlag < 4.0)
                {
                    kozepes++;
                }
                else if (tanulo.Atlag < 4.5)
                {
                    jo++;
                }
                else
                {
                    jeles++;
                }
            }
                Console.WriteLine($"Rossz átlagú tanulók száma: {rossz}");
                Console.WriteLine($"Gyenge átlagú tanulók száma: {gyenge}");
                Console.WriteLine($"Közepes átlagú tanulók száma: {kozepes}");
                Console.WriteLine($"Jó átlagú tanulók száma: {jo}");
                Console.WriteLine($"Jeles átlagú tanulók száma: {jeles}");
            Console.ReadLine();
        }
    }
}