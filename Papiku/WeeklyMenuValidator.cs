using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku
{
    class WeeklyMenuValidator 
    {
        private DailyMenu[] dailyMenus { get; set; } = new DailyMenu[7]{
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu()};
    }
}
