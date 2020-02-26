using System;
using System.Collections.Generic;
using System.Text;
using Papiku.Core.DataManipulation;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;


namespace Papiku.Core
{
     class PapikuEntryPoint
    {
        public static PapikuEntryPoint Instance { get; } = new PapikuEntryPoint(); 
        private int option;
        private PapikuEntryPoint(){}
        public void Start()
        {
            PrintWelcomeMessage();
            PrintMainMenu();
            ReadFromKeyboardAndExecute();
        }
        private void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                option = ReadIntegerAndValidate(option);
                ExecuteOption();
            }
        }
        private void ExecuteOption()
        {
            switch (option)
            {
                case 1:
                    ModifyMealsSection.Instance.Begin();    
                    break;
                case 2: 
                   // RecommendedMeals.Insance.Begin();
                    break;
                default: break;
            }
        }
    }
}
