using System;
using System.Collections.Generic;
using System.Text;
using Papiku.Core.DataManipulation;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;


namespace Papiku.Core
{
     static class PapikuEntryPoint
    {
        static private int option;
        static PapikuEntryPoint() => option = 0;
        public static void Start()
        {
            PrintWelcomeMessage();
            PrintMainMenu();
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
            switch (option)
            {
                case 1:
                    ModifyMealsSection.Begin();    
                    break;
                case 2: 
                   // RecommendedMeals.Insance.Begin();
                    break;
                default: break;
            }
        }
    }
}
