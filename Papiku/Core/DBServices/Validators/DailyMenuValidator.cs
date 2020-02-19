using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.Validators
{
    static class DailyMenuValidator
    {
        public static bool IsOk(this DailyMenu menu)
        {
            foreach (CurrentMenu m in menu.currentMenus)
                //if (!CurrentMenuValidator.IsOk(m))
                if (!m.IsOk())
                {
                        
                    return false;
                }
            WriteLine($"DailyMenuValidator");
            return true;
        }
    }
}
