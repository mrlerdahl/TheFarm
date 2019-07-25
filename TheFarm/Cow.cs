using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class Cow : FarmAnimal
    {
        public override string AnimalType { get; } = "cow";

        public override void Speak()
        {
            Console.WriteLine("\n\t*Mooooo*\n");
        }

        public override void Satisfied()
        {
            Console.WriteLine($"\n\t{this.AnimalName} just stands their smacking their teeth\n\t");
        }
    }
}
