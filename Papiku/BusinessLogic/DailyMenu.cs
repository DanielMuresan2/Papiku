using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.BusinessLogic
{
    class DailyMenu : Menu
    {
        public CurrentMenu[] currentMenus { get; } = new CurrentMenu[3] { new CurrentMenu(), new CurrentMenu(), new CurrentMenu() };
    }
}
