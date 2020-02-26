﻿using System;
using System.Collections.Generic;
using System.Text;
using Papiku.Core.DataManipulation.Listing;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;
using static Papiku.Helpers.IO.InputValidator;


namespace Papiku.Core.DataManipulation
{
    class ModifyMealsSection 
    {
        public static ModifyMealsSection Instance { get; } = new ModifyMealsSection();
        private IList<IDataManipulationService> services = new List<IDataManipulationService>();
        private int option;
        private ModifyMealsSection(){}
        public void AddFunctionality(IDataManipulationService service)
        {
            if(!services.Contains(service))
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
            PrintModifyMenu();
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
                option = ReadIntegerAndValidate(option);
                Execute();
            }
        }
        private void Execute()
        {
            services[option - 1].Execute();
        }
    }
}
