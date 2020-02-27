using static System.Console;

namespace Papiku.Helpers.PrinterWizard
{
    internal static class SimplePrinter
    {
        public static void PrintModifyMenu()
        {
            PrintChooseOptionText();
            WriteLine("1. List your meals");
            WriteLine("2. Add a new meal");
            WriteLine("3. Edit an existing meal");
            WriteLine("4. Delete an existing meal");
            WriteLine("9. Go back\n");
            PrintYourOptionText();
        }

        public static void PrintWelcomeMessage()
        {
            WriteLine("Welcome to Papiku!");
            WriteLine("What are we going to cook for the kids?\n");
        }

        public static void PrintMainMenu()
        {
            PrintChooseOptionText();
            WriteLine("1. Modify the meals (add,edit,delete,show)");
            WriteLine("2. Get Recommended meals");
            WriteLine("9. Exit Papiku\n");
        }

        public static void PrintInvalidInput()
        {
            WriteLine("Invalid input, please choose one option from the ones available");
        }

        public static void PrintChooseOptionText()
        {
            WriteLine("Please choose an option from below:\n");
        }

        public static void PrintYourOptionText()
        {
            WriteLine("\nYou option is: ");
        }
    }
}