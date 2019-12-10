using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojuhelnik2
{
    class Trojuhelnik
    {
        public double[] bod1 = new double[2];
        public double[] bod2 = new double[2];
        public double[] bod3 = new double[2];
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double obsah = 0;
        public double obvod = 0;
        public bool pravouhlost = false;

        /**
        * Konstruktor třídy Trojuhelnik.
        */
        public Trojuhelnik(double b1x, double b1y, double b2x, double b2y, double b3x, double b3y)
        {
            this.bod1[0] = b1x;
            this.bod1[1] = b1y;
            this.bod2[0] = b2x;
            this.bod2[1] = b2y;
            this.bod3[0] = b3x;
            this.bod3[1] = b3y;
        }

        /**
        * Metoda pro zjištění sestrojitelnosti trojuhelníku.
        * Funkce: Součet dvou stran musí být větší než strana třetí.
        */
        public bool jeSestrojitelny()
        {
            bool JeSestrojitelny = true;
            if ((bod1[0] == bod2[0] && bod1[0] == bod3[0]) || (bod1[1] == bod2[1] && bod1[1] == bod3[1]))
            {
                JeSestrojitelny = false;
            }
            return JeSestrojitelny;
        }

        /**
        * Metoda pro zjištění velikosti přepony trojuhelníku.
        * Funkce: Využití Pythagorovy věty.
        */
        public double delkaS(double x1, double y1, double x2, double y2)
        {
            double x = x1 - x2;
            double y = y1 - y2;
            double s = Math.Sqrt(x * x + y * y);
            return s;
        }

        /**
        * Metoda pro vypočet velikosti stran trojuhelníku.
        * Funkce: Převede body na délku.
        */
        public void vypocitejStrany()
        {
            this.a = this.delkaS(this.bod1[0], this.bod1[1], this.bod2[0], this.bod2[1]);
            this.b = this.delkaS(this.bod2[0], this.bod2[1], this.bod3[0], this.bod3[1]);
            this.c = this.delkaS(this.bod1[0], this.bod1[1], this.bod3[0], this.bod3[1]);

        }

        /**
        * Metoda pro vypočet obvodu trojuhelníku.
        * Funkce: Využití vzorce a + b + c
        */
        public void vypocitejObvod(double a, double b, double c)
        {
            this.obvod = (a + b + c);
        }

        /**
        * UnitTest na zkoušku funkčnosti motedy pro výpočet obvodu.
        * Funkce: Porovná natvrdo zadaný výsledek s výsledkem metody pro výpočet obvodu.
        */
        public bool UnitTestObvod()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            int vysledek1 = 9;
            vypocitejObvod(a, b, c);

            if (vysledek1 == this.obvod)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
        * Metoda pro vypočet obsahu trojuhelníku.
        * Funkce: využití Heronova vzorce.
        */
        public void vypocitejObsah(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            this.obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        /**
        * Metoda pro výpočet pravoúhlosti trojuhelníku.
        * Funkce: využití Pythagorovy věty.
        */
        public void jePravouhly()
        {
            if (a > b && a > c)
            {
                if (c * c + b * b == Math.Round(a * a, 1))
                {
                    this.pravouhlost = true;
                }

            }
            else if (b > a && b > c)
            {
                if (c * c + a * a == Math.Round(b * b, 1))
                {
                    this.pravouhlost = true;
                }

            }
            else if (c > b && c > a)
            {
                if (a * a + b * b == Math.Round(c * c, 1))
                {
                    this.pravouhlost = true;
                }
            }
        }
    }
}
