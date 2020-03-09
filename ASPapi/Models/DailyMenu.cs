using System.Collections.Generic;

namespace ASPapi.Models
{
    internal class DailyMenu : Menu
    {
        public List<CurrentMenu> currentMenus { get; set; }
    }
}