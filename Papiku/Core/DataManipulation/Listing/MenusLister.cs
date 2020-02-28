using System.Collections.Generic;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;
using static System.Console;

namespace Papiku.Core.DataManipulation.Listing
{
    internal class MenusLister : InteractiveComponent, IDataManipulationService
    {
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

        private void SortListers()
        {
            ((List<ILister>)menuListers).Sort(delegate (ILister x, ILister y)
            {
                if (x.option > y.option)
                    return 1;
                else return -1;
            });
        }

        protected override void PrintOptions()
        {
            WriteLine("\n\nPlease choose an option from below:\n");
            WriteLine("1. List a particular meal");
            WriteLine("2. List the meals for a particular day");
            WriteLine("3. List the meals for a particular week\n");
        }

        protected override void ExecuteOption()
        {
            if (option <= menuListers.Count)
                menuListers[option - 1].Execute(); //orice lister stie ce optiune este in meniu
            else
                PrintInvalidInput();
        }
    }
}