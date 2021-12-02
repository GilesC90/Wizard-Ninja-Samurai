using System;
using System.Collections.Generic;

namespace WNS
{
        // Define Ninja Class of Humans
        class Ninja : Human
        {
            public Ninja (string name, int strength, int intelligence) : base ()
            {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = 175;
            Health = 100;
            }
            // Build Ninja Attack method
            public override int Attack(Human target)
            {
                target.Health -= (Dexterity * 5);
                Random rand = new Random();
                var temp = rand.Next(0,5);
                if(temp == 3)
                {
                    target.Health -= 10;
                }
                System.Console.WriteLine($"{target.Name} was attacked by {Name} for {Dexterity * 5}. {target.Name} has {target.Health} remaining.");
                return target.Dexterity;
            }
            public (int,int) Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            System.Console.WriteLine($"{Name} was used Steal against {target.Name}. {target.Name} has had their health decreased to {target.Health} and {Name} has a new health total of {Health}.");
            return (target.Health, Health);
        }
    }
}