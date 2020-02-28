﻿using Papiku.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DBServices.JSONServices.JSONLister
{
    internal class JsonCurrentMenuLister
    {
        private IDataFetching MenusFetcher; //it is assigned and it's checked for null
        private bool FetcherReady = false;
        private string[] JsonFiles;
        private int FileNumber = 0;

        public void Execute()
        {
            while (FileNumber != -1)
            {
                FetchJsonFileNames();
                ChooseOption();
            }
        }

        public void ChooseOption()
        {
            if (FileNumber == -1)
                return;

            Console.WriteLine("Choose a file to read from");
            FileNumber = ReadInteger();
            string Path = JSON_CurrentMenus + "CM" + FileNumber + ".json";
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

        private int ReadInteger()
        {
            throw new NotImplementedException();
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

        private void FetchJsonFileNames()
        {
            JsonFiles = Directory.GetFiles(JSON_CurrentMenus);
            PrintJsonFileNames();
        }

        public void FormatAndPrintMenu(Menu res)
        {
            CurrentMenu cm = (CurrentMenu)res;
            Console.WriteLine($"{cm.MainDish} {cm.SecondDish} {cm.index}\n");
        }

        public void PrintJsonFileNames()
        {
            Console.WriteLine("JSON Files for Current Menu");
            foreach (string file in JsonFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}