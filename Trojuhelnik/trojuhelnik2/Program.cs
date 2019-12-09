using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojuhelnik2
{
    class Program
    {
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
