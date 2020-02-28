using Papiku.Core.DataManipulation;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Helpers.PrinterWizard.SimplePrinter;

namespace Papiku.Core
{
    internal class PapikuEntryPoint
    {
        public static PapikuEntryPoint Instance { get; } = new PapikuEntryPoint();
        private int option;

        private PapikuEntryPoint()
        {
        }

        public void Start()
        {
            PrintWelcomeMessage();
            ReadFromKeyboardAndExecute();
        }

        private void ReadFromKeyboardAndExecute()
        {
            while (option != 9)
            {
                PrintMainMenu();
                option = ReadInteger();
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