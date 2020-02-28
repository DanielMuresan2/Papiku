using Papiku.BusinessLogic;
using Papiku.Core.DBServices;
using Papiku.Core.DBServices.JSONServices;
using System;
using System.IO;
using static Papiku.Helpers.Constants;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DataManipulation.Listing
{
    internal class CurrentMenuLister : ILister
    {
        public int option => CurrentMenuListerOption;
        private IJsonListerService listerService;

        public CurrentMenuLister()
        {
        }

        public void FormatAndPrintMenu(Menu res)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            int option = 0;
            while (option != -1)
            {
                PrintChooseService();
                option = ReadInteger();
            }
        }

        private void PrintChooseService()
        {
            Console.WriteLine("\nPlease choose where to fetch the menus from:");
            Console.WriteLine("1. JSON");
            Console.WriteLine("2. SQL\n");
        }
    }
}