using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class MenuOptions
    {
        public static int[] Menu()
        {
            int[] selection = new int[2];

            Console.WriteLine("\n  Select an animal to create");
            Console.WriteLine("  1. Horse");
            Console.WriteLine("  2. Chicken");
            Console.WriteLine("  3. Pig");
            Console.WriteLine("  4. Cow");
            Console.WriteLine("  5. Quit");
            Console.Write("  Enter selection: ");
            selection[0] = UserInput.GetUserNumber();
            //formatexception
            if (selection[0] == 5)
            {
                Environment.Exit(0);
            }
            Console.Write("  Enter quantity: ");
            selection[1] = UserInput.GetUserNumber();
            //FormatException
            if (selection[0] == 5)
            {
                Environment.Exit(0);
            }
            return selection;
        }

        public static int InteractionMenu(int selection = 1)
        {

            Console.WriteLine("\n  Select an interaction");
            Console.WriteLine("  1. Pet");
            Console.WriteLine("  2. Feed");
            Console.WriteLine("  3. Listen");
            Console.WriteLine("  4. Stare");
            Console.WriteLine("  5. quit");
            Console.Write("  Enter selection: ");
            selection = UserInput.GetUserNumber();

            if (selection == 5)
            {
                Environment.Exit(0);
            }
            return selection;
        }

        public static int SelectAnimal(int selection = 1)
        {

            Console.WriteLine("\n  Select an Animal");
            Console.WriteLine("  1. Horse");
            Console.WriteLine("  2. Chicken");
            Console.WriteLine("  3. Pig");
            Console.WriteLine("  4. Cow");
            Console.Write("  Enter selection: ");
            selection = UserInput.GetUserNumber();

            return selection;
        }

    }
}
