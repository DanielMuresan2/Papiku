using System.Collections.Generic;

namespace Papiku.BusinessLogic
{
    internal class DailyMenu : Menu
    {
        public List<CurrentMenu> currentMenus { get; }

        public DailyMenu(uint index, List<CurrentMenu> cm)
            : base(index)
        {
            currentMenus = cm;
        }

        public DailyMenu(string id, uint index, string description, List<CurrentMenu> cm)
            : base(index, description)
        {
            currentMenus = cm;
        }
    }
}