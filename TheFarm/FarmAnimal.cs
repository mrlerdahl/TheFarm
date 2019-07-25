using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public abstract class FarmAnimal
    {
        protected static Random random = new Random();
        public string AnimalName { get; set; }
        public virtual string AnimalType { get; }

        // Allows animals to speak, by calling the method with no arguments
        public virtual void Speak()
        {
            Console.WriteLine("*Animal Noise*");
        }

        public virtual void Satisfied()
        {
            Console.WriteLine("*  Animal acts excited*");
        }


        // User can feed the animal by calling the method with no arguments
        public void Moves()
        {
            if (random.NextDouble() < .34)
            {
                Console.WriteLine($"\t{this.AnimalName} Runs away from you");
            }
            else if (random.NextDouble() > .66)
            {
                Console.WriteLine($"\t{this.AnimalName} Stands still for you");
            }
            else
            {
                Console.WriteLine($"\t{this.AnimalName} trys to bite you");
            }


        }

        public void Stare()
        {
            Console.WriteLine($"\n\t{this.AnimalName} gazes into your eyes");
        }
    }
}

