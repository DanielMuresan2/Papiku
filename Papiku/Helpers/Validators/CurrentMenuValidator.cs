using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Papiku.BusinessLogic;

namespace Papiku.Helpers.Validator
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
