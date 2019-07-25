using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class Horse : FarmAnimal
    {

        public override string AnimalType { get; } = "horse";
        public override void Speak()
        {
            Console.WriteLine($"\n\t{this.AnimalName} goes *Neeigh Neeeigh*\n");
        }

        public override void Satisfied()
        {
            Console.WriteLine($"\n\t{this.AnimalName}'s tail swishes with excitment, then proceeds to lick you\n");
        }
    }
}
