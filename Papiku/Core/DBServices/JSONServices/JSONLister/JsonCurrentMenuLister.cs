using Papiku.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DBServices.JSONServices.JSONLister
{
    internal class JsonCurrentMenuLister : InteractiveComponent, IDataBaseService
    {
        private IDataFetching MenusFetcher; //it is assigned and it's checked for null
        private bool FetcherReady = false;
        private string[] JsonFiles;

        protected override void PrintOptions()
        {
            JsonFiles = Directory.GetFiles(JSON_CurrentMenus);
            Console.WriteLine("JSON Files for Current Menu");
            foreach (string file in JsonFiles)
            {
                Console.WriteLine(file);
            }
        }

        protected override void ExecuteOption()
        {
            string Path = JSON_CurrentMenus + "CM" + option + ".json";
            try
            {
                MenusFetcher = new MenuFetcher(Path); //TODO: so many instances...MenuFetcher should take the JsonCurrentMenuFetcher singleton and set the path here
                FetcherReady = true; //variable not mandatory, but it helps the user know what went wrong
                FetchAndPrintMenu();
            }
            catch (Exception e)
            {
                FetcherReady = false;
                Console.WriteLine(e.StackTrace);
            }
        }

        private void FetchAndPrintMenu()
        {
            Menu fetch_res;
            if (FetcherReady)
                fetch_res = MenusFetcher.Fetch<CurrentMenu>();
            else
            {
                Console.WriteLine("Fetcher not ready. Try again?");
                return;
            }
            if (fetch_res != null)
                FormatAndPrintMenu(fetch_res);
            else
                Console.WriteLine("Fetched null. Retry?");
        }

        public void FormatAndPrintMenu(Menu res)
        {
            CurrentMenu cm = (CurrentMenu)res;
            Console.WriteLine($"{cm.MainDish} {cm.SecondDish} {cm.index}\n");
        }
    }
}