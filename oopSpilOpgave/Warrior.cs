using System;

namespace oopSpilOpgave
{
    public class Warrior
    {
        

        public Warrior(string name, int maxHealth, int attackMax, int blockMax)
        {
            Health = maxHealth;
            Name = name;
            AttackMax = attackMax;
            BlockMax = blockMax;
            MaxHealth = maxHealth;
        }

        public double Health { get; set; }
        public string Name { get; set; }
        public int AttackMax { get; set; }
        public int BlockMax { get; set; }
        public double MaxHealth { get; set; }

        public int Attack()
        {
            Random random = new Random();
            return random.Next(1, AttackMax + 1);
        }

        public int Block()
        {
            Random random = new Random();
            return random.Next(1, BlockMax + 1);
        }
    }
}