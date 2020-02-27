using System.Collections.Generic;
using static Papiku.Helpers.IO.InputValidator;
using static System.Console;

namespace Papiku.Core.DataManipulation.Listing
{
    internal class MenusLister : IDataManipulationService
    {
        private int option;
        public IList<ILister> menuListers { get; } = new List<ILister>();
        public static MenusLister Instance { get; } = new MenusLister();
        int IDataManipulationService.option => 1;

        private MenusLister()
        {
            AddLister(new WeeklyMenusLister());
            AddLister(new CurrentMenuLister());
            AddLister(new DailyMenusLister());
        }

        public void AddLister(ILister lister)
        {
            if (!menuListers.Contains(lister))
            {
                menuListers.Add(lister);
                SortListers();
            }
            else WriteLine("Lister already present");
        }

        public void RemoveLister(ILister lister)
        {
            if (menuListers.Contains(lister))
            {
                menuListers.Remove(lister);
                SortListers();
            }
        }

        public void Execute()
        {
            ReadFromKeyboardAndExecute();
        }

        private void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                PrintListerMenu();
                option = ReadIntegerAndValidate();
                menuListers[option - 1].Execute(); //orice lister stie ce optiune este in meniu
            }
        }

        private static void PrintListerMenu()
        {
            WriteLine("\n\nPlease choose an option from below:\n");
            WriteLine("1. List a particular meal");
            WriteLine("2. List the meals for a particular day");
            WriteLine("3. List the meals for a particular week\n");
        }

        private void SortListers()
        {
            ((List<ILister>)menuListers).Sort(delegate (ILister x, ILister y)
            {
                if (x.option > y.option)
                    return 1;
                else return -1;
            });
        }

        //private ILister currentMenusLister;
        //private ILister dailyMenusLister;
        //private ILister weeklyMenusLister;
        //evident, pentur ca un lister stie ce optiune este in meniu, aici nu pot exista listere cu aceeasi optiune
        /*public MenusLister(params ILister[] listers)
        {
        }
        public MenusLister(IList<ILister> listers)
        {
        }*/
        //un ILister sa stie el ce optiune este in meniu
        /* switch(Instance.option)
         {
            case 1: Instance.currentMenusLister.Execute(); break;
            case 2: Instance.dailyMenusLister.Execute(); break;
            case 3: Instance.weeklyMenusLister.Execute(); break;
             default: break;
         }*/
    }
}