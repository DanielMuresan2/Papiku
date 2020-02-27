using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.Validators
{
    internal static class MealValidator
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