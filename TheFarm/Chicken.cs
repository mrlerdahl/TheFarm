using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class Chicken : FarmAnimal
    {

        public override string AnimalType { get; } = "chicken";

        public override void Speak()
        {
            Console.WriteLine("\n\t*Cluck cluck cluck*\n");
        }

        public override void Satisfied()
        {
            Console.WriteLine($"\n\t{this.AnimalName} pecks your hand and runs\n");
        }
    }
}
