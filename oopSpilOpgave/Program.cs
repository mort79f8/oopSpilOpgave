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
            //                               Name        HP  Att. Blk.
            //Warrior spiderman = new Warrior("Spiderman", 200, 120, 40);
            //Warrior batman = new Warrior("Batman", 200, 120, 40);

            Warrior warrior1 = new Warrior("temp", 200, 120, 40);
            Warrior warrior2 = new Warrior("temp", 200, 120, 40);

            Console.WriteLine("Indtast navn på den første kriger:");
            warrior1.Name = Console.ReadLine();
            Console.WriteLine("Indtast navn på den anden kriger:");
            warrior2.Name = Console.ReadLine();


            Battle.StartFight(warrior1, warrior2);

            
            Console.ReadLine();

        }
    }

}
