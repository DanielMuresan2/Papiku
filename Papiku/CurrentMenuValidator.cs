using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    class CurrentMenuValidator
    {
        public static bool IsOk(Menu menu)
        {
            if (menu is CurrentMenu)
                WriteLine($"CurrentMenuValidator {menu.GetType()}");
            return true;
        }
    }
}
