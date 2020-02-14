using System;
using System.Collections.Generic;
using System.Text;
using Papiku.Core.DataManipulation.Listing;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;
using static Papiku.Helpers.IOValidator.InputValidator;


namespace Papiku.Core.DataManipulation
{
    static class ModifyMealsSection
    {
        private static int option;
        

        static ModifyMealsSection() => option = 0;
        public static void Begin() 
        {
            PrintModifyMenu();
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
                case 1: MenusLister.Begin(); break;
                case 2:  break;
                case 3: break;
                case 4: break;
                    //case 9 does nothing
            }
        }
    }
}
