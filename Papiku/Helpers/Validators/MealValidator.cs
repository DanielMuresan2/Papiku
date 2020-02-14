using System;
using System.Collections.Generic;
using System.Text;
using Papiku.BusinessLogic;

namespace Papiku.Helpers.Validator
{
    static class MealValidator
    {
        public static bool IsOk(this Menu menu)
        {
            switch (menu)
            {
                case WeeklyMenu w: return w.IsOk();
                case DailyMenu d: return d.IsOk();
                case CurrentMenu c: return c.IsOk();
                default: return false;
            }
            
        }
    }
}
