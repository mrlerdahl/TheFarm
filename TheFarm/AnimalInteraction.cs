using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class AnimalInteraction
    {
        public static void PetAnimal(List<FarmAnimal> animal, string animalName)
        {
            for (int i = 0; i < animal.Count; i++)
            {
                if (animalName == animal[i].AnimalName)
                {
                    Console.WriteLine($"\n\tYou try and pet {animal[i].AnimalName}");
                    animal[i].Moves();
                }
            }
        }

        public static void FeedAnimal(List<FarmAnimal> animal, string animalName)
        {
            for (int i = 0; i < animal.Count; i++)
            {
                if (animalName == animal[i].AnimalName)
                {
                    Console.WriteLine($"\n\tYou feed {animal[i].AnimalName}");
                    animal[i].Satisfied();
                }
            }
        }

        public static void ListenToAnimals(List<FarmAnimal> animal, string animalName)
        {
            for (int i = 0; i < animal.Count; i++)
            {
                if (animalName == animal[i].AnimalName)
                {
                    Console.WriteLine($"\n\tYou listen to {animal[i].AnimalName}");
                    animal[i].Speak();
                }
            }
        }

        public static void StareAtAnimal(List<FarmAnimal> animal, string animalName)
        {
            for (int i = 0; i < animal.Count; i++)
            {
                if (animalName == animal[i].AnimalName)
                {
                    Console.WriteLine($"\n\tYou stare at {animal[i].AnimalName}");
                    animal[i].Stare();
                }
            }
        }
    }
}

