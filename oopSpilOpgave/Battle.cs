using System;

namespace oopSpilOpgave
{
    public class Battle
    {


        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            while(warrior1.Health > 0 || warrior2.Health > 0 )
            {
                Console.Clear();
                Display(warrior1, warrior2);
                if (warrior1.Health > 0 && warrior2.Health > 0)
                {
                    warrior1.Health -= GetAttackResult(warrior1, warrior2);                   
                    if (warrior1.Health <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{warrior1.Name} has died and {warrior2.Name} is victorius");
                        Console.WriteLine();
                        Console.WriteLine("GAME OVER");
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Tryk enter for næste runde");
                Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
                Display(warrior1, warrior2);
                if (warrior1.Health > 0 && warrior2.Health > 0)
                {
                    warrior2.Health -= GetAttackResult(warrior2, warrior1);                 
                    if (warrior2.Health <= 0)
                    {
                        Console.WriteLine($"{warrior2.Name} has died and {warrior1.Name} is victorius");
                        Console.WriteLine();
                        Console.WriteLine("GAME OVER");
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Tryk enter for næste runde");
                Console.ReadLine();
            }
        }

        private static int GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int attackingWarriorAttackResult = warriorB.Attack();
            int defendingWarriorDefendResult = warriorA.Block();
            int damageDealt =  attackingWarriorAttackResult - defendingWarriorDefendResult;
            if (damageDealt < 0)
            {
                damageDealt = 0;
            }

            Console.WriteLine($"{warriorB.Name} deals {attackingWarriorAttackResult} damage, {warriorA.Name} block {defendingWarriorDefendResult} of it.");
            Console.WriteLine($"{warriorB.Name} Attacks {warriorA.Name} and deals {damageDealt} damage");
            Console.WriteLine($"{warriorA.Name} has {warriorA.Health - damageDealt}");
            Console.WriteLine();
            return damageDealt;
        }

        private static string DisplayHealthBar(Warrior warrior)
        {            
            string healthDisplay = "--{";
            double healthLeftInPercent = (warrior.Health / warrior.MaxHealth) * 100;

            for (int i = 0; i < Math.Ceiling((decimal)healthLeftInPercent/10); i++)
            {
                healthDisplay += "|";
            }

            var missingDisplay = healthDisplay.Length - 3;

            for (int i = 0; i < 10- missingDisplay; i++)
            {
                healthDisplay += "-";
            }

            healthDisplay += "}--";
            
            return healthDisplay;
        }

        private static void Display(Warrior warrior1, Warrior warrior2)
        {
            Console.WriteLine(CreateStarLine());
            Console.WriteLine($"\t{warrior1.Name} \t{DisplayHealthBar(warrior1)}");
            Console.WriteLine($"\t{warrior2.Name} \t{DisplayHealthBar(warrior2)}");
            Console.WriteLine(CreateStarLine());
        }
        
        private static string CreateStarLine()
        {
            string line = "";
            for (int i = 0; i < 40; i++)
            {
                line += "*";
            }

            return line;
        }
    }
}