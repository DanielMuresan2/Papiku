using System.Collections.Generic;

namespace ASPapi.Models
{
    internal class WeeklyMenu : Menu
    {
        public List<DailyMenu> dailyMenus { get; set; }
    }
}