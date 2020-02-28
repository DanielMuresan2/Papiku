using Papiku.Core.DataManipulation;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku.Core
{
    internal class JSONServices : InteractiveComponent
    {
        public static JSONServices Instance { get; } = new JSONServices();

        private JSONServices()
        {
        }

        protected override void ExecuteOption()
        {
            switch (option)
            {
                case 1:
                    ModifyMealsSection.Instance.Execute();
                    break;

                case 2:
                    // RecommendedMeals.Insance.Begin();
                    break;

                default: break;
            }
        }

        protected override void PrintOptions()
        {
            WriteLine("Please choose an option from below:\n");
            WriteLine("1. Modify the meals (add,edit,delete,show)");
            WriteLine("2. Get Recommended meals");
            WriteLine("-1. Exit Papiku\n");
        }
    }
}