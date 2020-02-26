using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;

namespace Papiku.Helpers.IO
{
    static class InputValidator
    {
        public static int ReadIntegerAndValidate(int option)
        {
            PrintYourOptionText();
            while (!Int32.TryParse(ReadLine(), out option))
                {
                    PrintInvalidInput();
                }
            WriteLine($"You entered {option}");
            return option;
        }
    }
}
