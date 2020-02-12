using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    class ModifyMealsSection
    {
        private int option;
        public static ModifyMealsSection Instance { get; } = new ModifyMealsSection(); //singleton; no set => no modifications

        private ModifyMealsSection() { }

        public void begin()
        {
            PrintModifyMenu();
            ReadFromKeyboardAndExecute();
        }
        private void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                while (!Int32.TryParse(ReadLine(), out option))
                {
                    PrintInvalidInput();
                    option = 0;
                }
                WriteLine($"You entered {option}");
                ExecuteOption();
            }
        }

        private void ExecuteOption()
        {
            switch (option)
            {
                case 1: MenusLister.Instance.Begin(); break;
                case 2: RecommendedMeals.Insance.Begin(); break;
            }
        }
        private void PrintInvalidInput()
        {
            WriteLine("Invalid input, please choose one option from the ones available");
        }
        private static void PrintModifyMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. List your meals");
            WriteLine("2. Add a new meal");
            WriteLine("3. Edit an existing meal");
            WriteLine("4. Delete an existing meal");
            WriteLine("9. Go back\n");
            WriteLine("You option is: ");
        }
    }
}
