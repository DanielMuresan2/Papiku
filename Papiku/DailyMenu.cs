﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku
{
    class DailyMenu : Menu
    {
        public CurrentMenu[] currentMenus { get; set; } = new CurrentMenu[3] { new CurrentMenu(), new CurrentMenu(), new CurrentMenu() };
    }
}
