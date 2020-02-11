using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku
{
    class WeeklyMenu : Menu
    {

        public DailyMenu[] DailyMenus { get; } = new DailyMenu[7]{
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu(),
        new DailyMenu()};

    }
}
