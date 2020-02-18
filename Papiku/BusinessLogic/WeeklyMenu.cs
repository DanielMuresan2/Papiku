using System;
using System.Collections.Generic;
using System.Text;
using static Papiku.Helpers.Constants;

namespace Papiku.BusinessLogic
{
    class WeeklyMenu : Menu
    {

        public DailyMenu[] DailyMenus { get; set; } = new DailyMenu[DAILYMENUSINAWEEK]{
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu()};

    }
}
