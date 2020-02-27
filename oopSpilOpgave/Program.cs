using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopSpilOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            do
            {
                Console.Clear();
                Warrior warrior1 = new Warrior("", 200, 120, 40);
                Warrior warrior2 = new Warrior("", 200, 120, 40);


                while (string.IsNullOrWhiteSpace(warrior1.Name))
                {
                    Console.WriteLine("Indtast navn på den første kriger:");
                    warrior1.Name = Console.ReadLine();
                }

                while (string.IsNullOrWhiteSpace(warrior2.Name))
                {
                    Console.WriteLine("Indtast navn på den anden kriger:");
                    warrior2.Name = Console.ReadLine();
                }
            


                Battle.StartFight(warrior1, warrior2);

                Console.Clear();
                Console.WriteLine("i for at prøve igen, alt andet for at exit");
                string again = Console.ReadLine();
                if (again != "i")
                {
                    tryAgain = false;
                }

            } while (tryAgain);

        }
    }

}
