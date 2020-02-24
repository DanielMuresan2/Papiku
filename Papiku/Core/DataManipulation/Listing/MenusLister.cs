using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static Papiku.Helpers.IO.InputValidator;
using Papiku.Core.DBServices;

namespace Papiku.Core.DataManipulation.Listing
{
    class MenusLister : IDataManipulationService
    {
        private int option;
        private ILister currentMenusLister;
        private ILister dailyMenusLister;
        private ILister weeklyMenusLister;
        //evident, pentur ca un lister stie ce optiune este in meniu, aici nu pot exista listere cu aceeasi optiune
        IList<ILister> menuListers = new List<ILister>();
        public static MenusLister Instance { get; } = new MenusLister();
        private MenusLister()
        {
            currentMenusLister = new CurrentMenuLister();
            dailyMenusLister = new DailyMenusLister();
            weeklyMenusLister = new WeeklyMenusLister();
        }
        public MenusLister(params ILister[] listers)
        {

        }
        public MenusLister(IList<ILister> listers)
        {

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
            //un ILister sa stie el ce optiune este in meniu
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
