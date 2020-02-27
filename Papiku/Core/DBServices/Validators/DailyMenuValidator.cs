using Papiku.BusinessLogic;
using static System.Console;

namespace Papiku.Core.DBServices.Validators
{
    internal static class DailyMenuValidator
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