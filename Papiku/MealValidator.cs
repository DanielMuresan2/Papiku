using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku
{
    class MealValidator
    {
        public static bool IsOk(Menu menu)
        {
            switch (menu)
            {
                //case WeeklyMenu w: return IsOk(w);
                case DailyMenu d: return DailyMenuValidator.IsOk(d);
                case CurrentMenu c: return CurrentMenuValidator.IsOk(c);
                default: return false;
            }
        }
    }
}
