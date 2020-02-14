using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static Papiku.Helpers.IOValidator.InputValidator;

namespace Papiku.Core.DataManipulation.Listing
{
    class MenusLister : ModifyMenus
    {
        
        private static int option;
        


        public MenusLister()
        {
            Instance = new MenusLister();
            currentMenuLister = new CurrentMenuLister();
            dailyMenuLister = new DailyMenusLister();
            weeklytMenuLister = new WeeklyMenusLister();
        }
        public static void Begin()
        {
            PrintListerMenu();
            ReadFromKeyboardAndExecute();
        }
        private static void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                option = ReadIntegerAndValidate();
                ExecuteOption();
            }
        }
        private static void ExecuteOption()
        {
            switch(option)
            {
                case 1: currentMenuLister.Execute(); break;
                case 2: dailyMenuLister.Execute(); break;
                case 3: weeklytMenuLister.Execute(); break;
                default: break;
            }
        }
        private static void PrintListerMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. List a particular meal");
            WriteLine("2. List the meals for a particular day");
            WriteLine("3. List the meals for a particular week\n");
            WriteLine("You option is: ");
        }
    }
}
