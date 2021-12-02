using System;
using System.Collections.Generic;
namespace WNS
{
        // Define Wizard Class of Humans
        class Wizard : Human
        {
            public Wizard (string name, int strength, int dexterity) : base ()
            {
                Name = name;
                Strength = strength;
                Intelligence = 25;
                Dexterity = dexterity;
                Health = 50;
            }

        // Build Wizard Attack method
        public override int Attack(Human target)
        {
            target.Health -= (Intelligence * 5);
            Health += target.Health;
            System.Console.WriteLine($"{target.Name} was attacked by {Name} for {Intelligence * 5}. {Name} has boosted their health and it is now at {Health} points. {target.Name} has {target.Health} remaining.");
            return target.Health;
        }

        public int Heal(Human target)
        {
            target.Intelligence *= 10;
            System.Console.WriteLine($"{target.Name} was healed by {Name} for {target.Intelligence}. {target.Name} has a new  total Intelligence of {target.Intelligence}.");
            return target.Intelligence;
        }
    }
}