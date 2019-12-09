using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojuhelnik2
{
    class Program
    {
        class Trojuhelnik {


            public double[] bod1 = new double[2];
            public double[] bod2 = new double[2];
            public double[] bod3 = new double[2];
            public double a = 0;
            public double b = 0;
            public double c = 0;
            public double obsah = 0;
            public double obvod = 0;
            public bool pravouhlost = false;
            public Trojuhelnik(double b1x, double b1y, double b2x, double b2y, double b3x, double b3y) {
                this.bod1[0] = b1x;
                this.bod1[1] = b1y;
                this.bod2[0] = b2x;
                this.bod2[1] = b2y;
                this.bod3[0] = b3x;
                this.bod3[1] = b3y;
            }
            public bool jeSestrojitelny() {
                bool JeSestrojitelny = true;
                if ((bod1[0] == bod2[0] && bod1[0] == bod3[0]) || (bod1[1] == bod2[1] && bod1[1] == bod3[1])) {
                    JeSestrojitelny = false;
                }
                return JeSestrojitelny;
            }

            public double delkaS(double x1, double y1, double x2, double y2)
            {
                double x = x1 - x2;
                double y = y1 - y2;
                double s = Math.Sqrt(x * x + y * y);
                return s;
            }

            public void vypocitejStrany() {
                this.a = this.delkaS(this.bod1[0], this.bod1[1], this.bod2[0], this.bod2[1]);
                this.b = this.delkaS(this.bod2[0], this.bod2[1], this.bod3[0], this.bod3[1]);
                this.c = this.delkaS(this.bod1[0], this.bod1[1], this.bod3[0], this.bod3[1]);

            }

            public void vypocitejObvod(double a, double b, double c) {
                this.obvod = (a + b + c);
            }

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
            public void vypocitejObsah(double a, double b, double c) {
                double s = (a + b + c) / 2;
                this.obsah = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }

            public void jePravouhly()
            {
                if(a>b && a > c)
                {
                    if (c * c + b * b == Math.Round(a * a,1))
                    {
                        this.pravouhlost = true;
                    }
                    
                }else if (b > a && b > c)
                {
                    if (c * c + a * a == Math.Round(b * b,1))
                    {
                        this.pravouhlost = true;
                    }

                }else if  (c > b && c > a)
                {
                    if (a * a + b * b == Math.Round(c * c,1))
                    {
                        this.pravouhlost = true;
                    }
                }           
            }

        }
        static void Main(string[] args)
        {
            Trojuhelnik t1 = new Trojuhelnik(0, 0, 2, 0, 0, 2);
            if (t1.jeSestrojitelny() == true)
            {
                Console.WriteLine("Jde sestrojit");
            }
            else {
                Console.WriteLine("Nejde sestrojit");
            }
            t1.vypocitejStrany();
            t1.vypocitejObvod(t1.a, t1.b, t1.c);
            t1.vypocitejObsah(t1.a, t1.b, t1.c);
            t1.jePravouhly(); 

            Console.WriteLine($"delka a: {Math.Round(t1.a, 2)}, delka b: {Math.Round(t1.b, 2)}, delka c: {Math.Round(t1.c, 2)}");
            Console.WriteLine($"obsah = {Math.Round(t1.obsah,2)}, obvod: {Math.Round(t1.obvod, 2)}");
            if (t1.pravouhlost == true)
            {
                Console.WriteLine("Je pravoúhlý");
            }
            else {
                Console.WriteLine("Není pravoúhlý");
            }

            if (t1.UnitTestObvod() == true)
            {
                Console.WriteLine("Unit test proběhl v pořádku.");
            }
            else
            {
                Console.WriteLine("Unit test neproběhl v pořádku.");
            }

            
            Console.ReadLine();
            

            


        }
    }
}
