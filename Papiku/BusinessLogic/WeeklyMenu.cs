using System;
using System.Collections.Generic;
using System.Text;
using static Papiku.Helpers.Constants;

namespace Papiku.BusinessLogic
{
    class WeeklyMenu : Menu
    {
        public List<DailyMenu> dailyMenus { get; set; }
        public WeeklyMenu( uint index, List<DailyMenu> dm)
            : base( index)
        {
            dailyMenus = dm;
        }
        public WeeklyMenu(uint index,string description, List<DailyMenu> dm)
            : base( index, description)
        {
            dailyMenus = dm;
        }
    }
}
