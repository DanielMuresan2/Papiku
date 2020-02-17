using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static Papiku.Helpers.IOValidator.InputValidator;

namespace Papiku.Core.DataManipulation.Listing
{
    class MenusLister : IDataManipulationService
    {
        private int option;
        private ILister currentMenusLister;
        private ILister dailyMenusLister;
        private ILister weeklyMenusLister;
        public static MenusLister Instance { get; } = new MenusLister();
        private MenusLister()
        {
            currentMenusLister = new CurrentMenuLister();
            dailyMenusLister = new DailyMenusLister();
            weeklyMenusLister = new WeeklyMenusLister();
        }
         public void Execute()
        {
            PrintListerMenu();
            ReadFromKeyboardAndExecute();
        }
        private void ReadFromKeyboardAndExecute()
        {
            while (Instance.option != 9)
            {
                Instance.option = ReadIntegerAndValidate();
                ExecuteOption();
            }
        }

        private static void ExecuteOption()
        {
            switch(Instance.option)
            {
               case 1: Instance.currentMenusLister.Execute(); break;
               case 2: Instance.dailyMenusLister.Execute(); break;
               case 3: Instance.weeklyMenusLister.Execute(); break;
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
