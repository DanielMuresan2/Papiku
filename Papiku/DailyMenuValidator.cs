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
            if (menu is DailyMenu)//ok
                foreach (CurrentMenu m in menu.currentMenus)
                    if (!CurrentMenuValidator.IsOk(m))
                    {
                        WriteLine($"DailyMenuValidator {menu.GetType()}");
                        return false;
                    }
            Write("It's fine");
            return true;
        }
    }
}
