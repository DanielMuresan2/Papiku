﻿using static System.Console;

namespace Papiku
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            Menu d = new DailyMenu();
            MealValidator.IsOk(d);
        }
    }
}
