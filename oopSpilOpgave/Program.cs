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

            
            Console.ReadLine();

        }
    }

}
