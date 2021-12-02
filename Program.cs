using System;

namespace WNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard gilesTest = new Wizard("WizardGiles", 100, 100);
            System.Console.WriteLine(gilesTest);

            Ninja gT3 = new Ninja("NinjaGiles", 100, 82);
            System.Console.WriteLine(gT3);

            Samurai gT2 = new Samurai("SamuraiGiles", 100, 100, 83);
            System.Console.WriteLine(gT2);

            // int newHealth = gilesTest.Attack(gT3);
            // int seeThis = gT3.Attack(gT2);
            // int watchThis = gT2.Attack(gilesTest);
            int healMe = gilesTest.Heal(gT3);
            int meditateMe = gT2.Meditate(gT2);
            (int, int) thief = gT3.Steal(gT2);
        }
    }
}
