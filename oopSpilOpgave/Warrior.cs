using System;

namespace oopSpilOpgave
{
    public class Warrior
    {
        
        Random random = new Random();

        public Warrior(string name, int maxHealth, int attackMax, int blockMax)
        {
            Health = maxHealth;
            Name = name;
            AttackMax = attackMax;
            BlockMax = blockMax;
            MaxHealth = maxHealth;
        }

        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackMax { get; set; }
        public int BlockMax { get; set; }
        public int MaxHealth { get; set; }

        public int Attack()
        {
            return random.Next(1, AttackMax + 1);
        }

        public int Block()
        {
            return random.Next(1, BlockMax + 1);
        }
    }
}