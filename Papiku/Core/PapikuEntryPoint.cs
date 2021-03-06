﻿using Papiku.Core.DataManipulation;
using System;
using static System.Console;

namespace Papiku.Core
{
    internal class PapikuEntryPoint : InteractiveComponent
    {
        public static PapikuEntryPoint Instance { get; } = new PapikuEntryPoint();
        public Type SelectedService { get; set; }

        private PapikuEntryPoint()
        {
        }

        protected override void ExecuteOption()
        {
            switch (option)
            {
                case 1:
                    SelectedService = typeof(JSONServices);
                    JSONServices.Instance.Execute();

                    break;

                case 2:
                    // SQL
                    break;

                default: break;
            }
        }

        protected override void PrintOptions()
        {
            WriteLine("Please choose the database from the options from below:\n");
            WriteLine("1. JSON");
            WriteLine("2. SQL");
            WriteLine("-1. Exit Papiku\n");
        }
    }
}