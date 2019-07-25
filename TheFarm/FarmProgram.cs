using System;

namespace TheFarm
{
    class FarmProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tFarm.FarmProgram.Main()\n");
            MyFarm farm = new MyFarm();

            do
            {
                farm.CreateAnimal();
                Console.Write("\n  Create more aninmls? [Y/N]: ");
            } while (Console.ReadLine().ToLower() == "y");

            do
            {
                farm.InteractWithAnimal(MenuOptions.InteractionMenu());
                Console.Write("\n  Interact with animals again? [Y/N]: ");
            } while (Console.ReadLine().ToLower() == "y");


        }
    }
}
