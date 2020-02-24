using System;
using System.Collections.Generic;

using System.Text;

using static System.Console;
using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.Validators
{
    static class WeeklyMenuValidator
    {
        public static bool IsOk(this WeeklyMenu menu)
        {
            /*foreach (DailyMenu d in menu.DailyMenus)
                if (!d.IsOk())
                    return false;
            WriteLine("WeeklyMenuValidator");*/
            return true;
        }
    }
}
