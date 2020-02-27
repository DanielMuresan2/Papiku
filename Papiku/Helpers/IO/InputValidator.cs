using System;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;
using static System.Console;

namespace Papiku.Helpers.IO
{
    internal static class InputValidator
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