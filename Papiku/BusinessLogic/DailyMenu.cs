using System;
using System.Collections.Generic;
using System.Text;
using static Papiku.Helpers.Constants;

namespace Papiku.BusinessLogic
{
    class DailyMenu : Menu
    {
        public CurrentMenu[] currentMenus { get; } = new CurrentMenu[MENUSINADAY] { new CurrentMenu(null), new CurrentMenu(null), new CurrentMenu(null) };
    }
}
