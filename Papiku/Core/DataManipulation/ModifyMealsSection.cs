using Papiku.Core.DataManipulation.Listing;
using System.Collections.Generic;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;

namespace Papiku.Core.DataManipulation
{
    internal class ModifyMealsSection
    {
        public static ModifyMealsSection Instance { get; } = new ModifyMealsSection();
        private IList<IDataManipulationService> services = new List<IDataManipulationService>();
        private int option;

        private ModifyMealsSection()
        {
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

        public void Begin()
        {
            Init();
            ReadFromKeyboardAndExecute();
        }

        private void Init()
        {
            AddFunctionality(MenusLister.Instance);
        }

        private void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                PrintModifyMenu();
                option = ReadIntegerAndValidate();
                Execute();
            }
        }

        private void Execute()
        {
            services[option - 1].Execute();
        }
    }
}