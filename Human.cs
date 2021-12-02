using System;
using System.Collections.Generic;

namespace WNS
{
    public class Human
{
        public string Name {get; set; }
        public int Strength {get; set; }

        public int Intelligence {get; set; }
        public int Dexterity {get; set; }

        // private int health;

         
        // add a public "getter" property to access health
        public int Health {get; set; }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        public override string ToString()
        {
            return @$"
            Name:         {Name}
            Strength:     {Strength}
            Intelligence: {Intelligence}
            Dexterity:    {Dexterity}
            Health:       {Health}
            ";
        }
        // Add a constructor to assign custom values to all fields
        public Human () { }
        public Human (string name, int strength, int intelligence, int dexterity)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = 100;
        }
        public Human (string name, int strength, int dexterity)
        {
            Name = name;
            Strength = strength;
            Intelligence = 25;
            Dexterity = dexterity;
            Health = 50;
        }
        // public Human (string name, int strength, int intelligence)
        // {
        //     Name = name;
        //     Strength = strength;
        //     Intelligence = intelligence;
        //     Dexterity = 175;
        //     Health = 100;
        // }
        // public Human (string name, int strength, int intelligence, int dexterity)
        // {
        //     Name = name;
        //     Strength = strength;
        //     Intelligence = intelligence;
        //     Dexterity = dexterity;
        //     Health = 200;
        // }
        
        // Build Attack method
        public virtual int Attack(Human target)
        {
            target.Health -= (Strength * 5);
            System.Console.WriteLine($"{target.Name} was attacked by {Name} for {Strength * 5}. {target.Name} has {target.Health} remaining.");
            return target.Health;
        }
    }
}

