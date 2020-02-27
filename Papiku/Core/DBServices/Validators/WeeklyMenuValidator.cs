using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.Validators
{
    internal static class WeeklyMenuValidator
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