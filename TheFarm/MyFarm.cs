using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    class MyFarm
    {
        int horseCount = 0, chickenCount = 0, pigCount = 0, cowCount = 0;
        private List<FarmAnimal> myHorses = new List<FarmAnimal>();
        private List<FarmAnimal> myChickens = new List<FarmAnimal>();
        private List<FarmAnimal> myPigs = new List<FarmAnimal>();
        private List<FarmAnimal> myCows = new List<FarmAnimal>();

        // This will create a list of animals based off the selection from MenuOptions
        // Selection 1 will be a horse
        // Selection 2 will be a Chicken
        // Selection 3 will be a Pig
        // Selection 4 will be a Cow
        // The loop is to create multiple animals of one type
        public void CreateAnimal()
        {
            int[] animalSelectionAndQty = MenuOptions.Menu();
            //add serperate counter for when adding another animal of this class so it doesnt over write
            if (animalSelectionAndQty[0] == 1)
            {
                for (int i = 0; i < animalSelectionAndQty[1]; i++)
                {
                    myHorses.Add(new Horse());
                    Console.Write($"  Enter horse {horseCount + 1} name: ");
                    myHorses[horseCount].AnimalName = UserInput.GetUserString();
                    horseCount++;
                }
                countAnimals(myHorses);
            }
            if (animalSelectionAndQty[0] == 2)
            {
                for (int i = 0; i < animalSelectionAndQty[1]; i++)
                {
                    myChickens.Add(new Chicken());
                    Console.Write($"  Enter chicken {chickenCount + 1} name: ");
                    myChickens[chickenCount].AnimalName = UserInput.GetUserString();
                    chickenCount++;
                }
                countAnimals(myChickens);
            }
            if (animalSelectionAndQty[0] == 3)
            {
                for (int i = 0; i < animalSelectionAndQty[1]; i++)
                {
                    myPigs.Add(new Pig());
                    Console.Write($"  Enter pig {pigCount + 1} name: ");
                    myPigs[pigCount].AnimalName = UserInput.GetUserString();
                    pigCount++;
                }
                countAnimals(myPigs);
            }
            if (animalSelectionAndQty[0] == 4)
            {
                for (int i = 0; i < animalSelectionAndQty[1]; i++)
                {
                    myCows.Add(new Cow());
                    Console.Write($"  Enter cow {cowCount + 1} name: ");
                    myCows[cowCount].AnimalName = UserInput.GetUserString();
                    cowCount++;
                }
                countAnimals(myCows);
            }
            countAnimals(myHorses, myChickens, myPigs, myCows);
        }

        // Used to display the number the specific animal created, and what the user named the animal
        private void countAnimals(List<FarmAnimal> animals)
        {
            Console.WriteLine($"\n\tYou created {animals.Count} {animals[0].AnimalType}(s) named:");
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"\t{animals[i].AnimalName}");
            }
        }

        private void countAnimals(List<FarmAnimal> horse, List<FarmAnimal> chicken, List<FarmAnimal> pig, List<FarmAnimal> cow)
        {
            Console.WriteLine($"\n\t{horse.Count} horse(s) created");
            Console.WriteLine($"\t{chicken.Count} chicken(s) created");
            Console.WriteLine($"\t{pig.Count} pig(s) created");
            Console.WriteLine($"\t{cow.Count} cow(s) created");
        }



        public void InteractWithAnimal(int interactionSelection)
        {
            if (interactionSelection == 1)
            {
                AnimalInteraction.PetAnimal(SelectAnimalType(), SelectAnimalName());
            }

            if (interactionSelection == 2)
            {
                AnimalInteraction.FeedAnimal(SelectAnimalType(), SelectAnimalName());
            }

            if (interactionSelection == 3)
            {
                AnimalInteraction.ListenToAnimals(SelectAnimalType(), SelectAnimalName());
            }
            if (interactionSelection == 4)
            {
                AnimalInteraction.StareAtAnimal(SelectAnimalType(), SelectAnimalName());
            }
        }

        public List<FarmAnimal> SelectAnimalType()
        {
            int animalSelectionType = MenuOptions.SelectAnimal();

            if (animalSelectionType == 1)
            {
                ListAnimalNames(myHorses);
                return myHorses;
            }
            if (animalSelectionType == 2)
            {
                ListAnimalNames(myChickens);
                return myChickens;
            }
            if (animalSelectionType == 3)
            {
                ListAnimalNames(myPigs);
                return myPigs;
            }

            ListAnimalNames(myCows);
            return myCows;
        }

        private void ListAnimalNames(List<FarmAnimal> animal)
        {
            Console.WriteLine($"\n\tYou have {animal.Count} horse(s) named:");
            for (int i = 0; i < animal.Count; i++)
            {

                Console.WriteLine($"\t{animal[i].AnimalName}");
            }
            Console.WriteLine("");

        }
        public string SelectAnimalName(string animalName = "Bob")
        {

            Console.Write("  Enter animal name: ");
            animalName = UserInput.GetUserString();

            return animalName;
        }

        public void Test()
        {
            AnimalInteraction.PetAnimal(myHorses, "Mitch");
        }
    }
}
