using System;
using System.Collections.Generic;
using static System.Console;

namespace Papiku
{
    class WeeklyMenuValidator
    {
        public static bool IsOk(WeeklyMenu menu)
        {
            foreach (DailyMenu d in menu.DailyMenus)
                if (!DailyMenuValidator.IsOk(d))
                    return false;
            WriteLine("WeeklyMenuValidator");
            return true;
        }
    }
}
