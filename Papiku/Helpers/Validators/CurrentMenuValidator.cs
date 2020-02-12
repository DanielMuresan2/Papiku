using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Papiku
{
    static class CurrentMenuValidator
    {
        public static bool IsOk(this CurrentMenu menu)
        {
                WriteLine($"CurrentMenuValidator");
            return true;
        }
    }
}
