using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static Papiku.Helpers.IO.InputValidator;
using Papiku.Core.DBServices;
using System.Linq;

namespace Papiku.Core.DataManipulation.Listing
{
    class MenusLister : IDataManipulationService
    {
        private int option;
        private ILister currentMenusLister;
        private ILister dailyMenusLister;
        private ILister weeklyMenusLister;
        //evident, pentur ca un lister stie ce optiune este in meniu, aici nu pot exista listere cu aceeasi optiune
        public IList<ILister> menuListers { get; } = new List<ILister>();

        public static MenusLister Instance { get; } = new MenusLister();

        int IDataManipulationService.option => throw new NotImplementedException();

        private MenusLister()
        {
            menuListers.Add(new WeeklyMenusLister());
            menuListers.Add(new CurrentMenuLister());
            menuListers.Add(new DailyMenusLister());
           
            ((List<ILister>)menuListers).Sort(delegate (ILister x, ILister y) //simpler form?
            {
               
                if (x.option > y.option)
                    return 1;
                else return -1;
            });
            
            
        }
        /*public MenusLister(params ILister[] listers)
        {

        }
        public MenusLister(IList<ILister> listers)
        {

        }*/
        public void AddLister(ILister lister)
        {
            if (!menuListers.Contains(lister))
                menuListers.Add(lister);
            else WriteLine("Lister already present");
        }
        public void RemoveLister(ILister lister)
        {
            if (menuListers.Contains(lister))
                menuListers.Remove(lister);
        }

        public void Execute()
        {
            PrintListerMenu();
            ChooseOption();
        }
        private void ReadFromKeyboardAndExecute()
        {
            while (Instance.option != 9)
            {
                Instance.option = ReadIntegerAndValidate();
                ExecuteOption();
            }
        }

        private  void ExecuteOption()
        {
            menuListers[option-1].Execute();
            //un ILister sa stie el ce optiune este in meniu
            /* switch(Instance.option)
             {
                case 1: Instance.currentMenusLister.Execute(); break;
                case 2: Instance.dailyMenusLister.Execute(); break;
                case 3: Instance.weeklyMenusLister.Execute(); break;
                 default: break;
             }*/
        }
        private static void PrintListerMenu()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. List a particular meal");
            WriteLine("2. List the meals for a particular day");
            WriteLine("3. List the meals for a particular week\n");
            WriteLine("You option is: ");
        }

        public void ChooseOption()
        {
            ReadFromKeyboardAndExecute();
        }
    }
}
