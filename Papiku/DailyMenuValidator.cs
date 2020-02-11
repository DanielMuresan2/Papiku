using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    class DailyMenuValidator
    {
        public static bool IsOk(DailyMenu menu)
        {
            foreach (CurrentMenu m in menu.currentMenus)
                if (!CurrentMenuValidator.IsOk(m))
                {
                        
                    return false;
                }
            WriteLine($"DailyMenuValidator");
            return true;
        }
    }
}
