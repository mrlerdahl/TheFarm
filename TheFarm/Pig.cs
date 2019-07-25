using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class Pig : FarmAnimal
    {

        public override string AnimalType { get; } = "pig";

        public override void Speak()
        {
            Console.WriteLine("\n\t*Oink Oink Oink*\n");
        }

        public override void Satisfied()
        {
            Console.WriteLine($"\n\t{this.AnimalName} oinks wildly in excitement\n");
        }
    }

}
