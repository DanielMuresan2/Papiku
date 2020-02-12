using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
     static class PapikuEntryPoint
    {
        static private int option;
        static PapikuEntryPoint() => option = 0;
        public static void Start()
        {
            PrintWelcomeMessage();
            PrintMainMenu();
            ReadFromKeyboardAndExecute();
        }
        static void ReadFromKeyboardAndExecute()
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

        static void ExecuteOption()
        {
            switch (option)
            {
                case 1:
                    ModifyMealsSection.Instance.begin();    
                    break;
                case 2: 
                    RecommendedMeals.Insance.Begin();
                    break;
            }
        }

        static void PrintInvalidInput()
        {
            WriteLine("Invalid input, please choose one option from the ones available");
        }
        static void PrintWelcomeMessage()
        {
            WriteLine("Welcome to Papiku!");
            WriteLine("What are we going to cook for the kids?\n");
        }
        static void PrintMainMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. Modify the meals (add,edit,delete,show)");
            WriteLine("2. Get Recommended meals");
            WriteLine("9. Exit Papiku\n");
            WriteLine("You option is: ");
        }
    }
}
