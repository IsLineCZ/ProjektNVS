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
            Console.Write("Zadejte x 1. bodu: ");
            int x1 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte y 1. bodu: ");
            int y1 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte x 2. bodu: ");
            int x2 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte y 2. bodu: ");
            int y2 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte x 3. bodu: ");
            int x3 = Int32.Parse(Console.ReadLine());
            Console.Write("Zadejte y 3. bodu: ");
            int y3 = Int32.Parse(Console.ReadLine());

            Trojuhelnik t1 = new Trojuhelnik(x1, y1, x2, y2, x3, y3);
            if (t1.jeSestrojitelny() == true)
            {
                Console.WriteLine("Jde sestrojit");
            }
            else {
                Console.WriteLine("Nejde sestrojit");
            }
            t1.vypocitejStrany();
           // t1.vypocitejObvod(t1.a, t1.b, t1.c);
            t1.vypocitejObsah(t1.a, t1.b, t1.c);
            t1.jePravouhly(); 

            Console.WriteLine($"delka a: {Math.Round(t1.a, 2)}, delka b: {Math.Round(t1.b, 2)}, delka c: {Math.Round(t1.c, 2)}");
            Console.WriteLine($"obsah = {Math.Round(t1.obsah,2)}, obvod: {Math.Round(t1.vypocitejObvod(t1.a, t1.b, t1.c), 2)}");
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
