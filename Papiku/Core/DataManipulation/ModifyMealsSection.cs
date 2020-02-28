using Papiku.Core.DataManipulation.Listing;
using System.Collections.Generic;
using static System.Console;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;

namespace Papiku.Core.DataManipulation
{
    internal class ModifyMealsSection : InteractiveComponent
    {
        public static ModifyMealsSection Instance { get; } = new ModifyMealsSection();
        private IList<IDataManipulationService> services = new List<IDataManipulationService>();

        private ModifyMealsSection()
        {
            AddFunctionality(MenusLister.Instance);
        }

        public void AddFunctionality(IDataManipulationService service)
        {
            if (!services.Contains(service))
            {
                services.Add(service);
                SortServices();
            }
        }

        public void RemoverFunctionality(IDataManipulationService service)
        {
            if (services.Contains(service))
            {
                services.Remove(service);
                SortServices();
            }
            SortServices();
        }

        private void SortServices()
        {
            ((List<IDataManipulationService>)services).Sort(delegate (IDataManipulationService x, IDataManipulationService y)
            {
                if (x.option > y.option)
                    return 1;
                else return -1;
            });
        }

        protected override void PrintOptions()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. List your meals");
            WriteLine("2. Add a new meal");
            WriteLine("3. Edit an existing meal");
            WriteLine("4. Delete an existing meal");
            WriteLine("-1. Go back\n");
        }

        protected override void ExecuteOption()
        {
            if (option <= services.Count && option > 0)
                services[option - 1].Execute();
            else
                PrintInvalidInput();
        }
    }
}