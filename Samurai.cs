using System;
using System.Collections.Generic;
namespace WNS
{
        // Define Samurai Class of Humans
        class Samurai : Human
        {
            public Samurai (string name, int strength, int intelligence, int dexterity) : base ()
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                Health = 200;
            }
             // Build Samurai Attack method
            public override int Attack(Human target)
            {
                if (target.Health < 50)
                {
                    target.Health = 0;
                }
                else
                {
                    base.Attack(target);
                }
                System.Console.WriteLine($"{target.Name} was attacked by {Name}. {target.Name} has {target.Health} remaining.");
                return target.Health;
            }
            public int Meditate(Human target)
        {
            Health = 100;
            System.Console.WriteLine($"{Name} is meditating. {Name} has restored thier health to {Health}.");
            return Health;
        }
        }
}