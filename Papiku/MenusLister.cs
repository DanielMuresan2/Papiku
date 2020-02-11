using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    class MenusLister
    {
        private int option;
        public static MenusLister Instance { get; } = new MenusLister(); //singleton; no set => no modifications

        protected MenusLister() { }

        internal void Begin()
        {
            PrintListerMenu();
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
            switch(option)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                default: break;
            }
        }
        private void PrintListerMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. List a particular meal");
            WriteLine("2. List the meals for a particular day");
            WriteLine("3. List the meals for a particular week\n");
            WriteLine("You option is: ");
        }
        private void PrintInvalidInput()
        {
            WriteLine("Invalid input, please choose one option from the ones available");
        }
    }
}
