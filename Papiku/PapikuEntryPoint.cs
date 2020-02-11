using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    class PapikuEntryPoint
    {
        private int option;
        public void start()
        {
            PrintWelcomeMessage();
            PrintMainMenu();
            ReadFromKeyboard();
            
        }

        private void ExecuteOption()
        {
            switch(option)
            {
                case 1: break;
                case 2: break;
                case 9: break;
                default: break;
            }
        }

        private void ReadFromKeyboard()
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

        private void PrintInvalidInput()
        {
            WriteLine("Invalid input, please choose one option from the ones available");
        }

        private void PrintWelcomeMessage()
        {
            WriteLine("Welcome to Papiku!");
            WriteLine("What are we going to cook for the kids?\n");
        }
        private void PrintMainMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. Modify the meals (add,edit,delete,show)");
            WriteLine("2. Get Recommended meals");
            WriteLine("9. Exit Papiku\n");
            WriteLine("You option is: ");
        }
    }
}
