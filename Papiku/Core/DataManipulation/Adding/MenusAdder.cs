using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation.Adding
{
    class MenusAdder 
    {
        private static IExecutor currentMenuAdder;
        private static IExecutor dailyMenuAdder;
        private static IExecutor weeklytMenuAdder;


        static MenusAdder()
        {
            currentMenuAdder = new CurrentMenuAdder();
            dailyMenuAdder = new DailyMenuAdder();
            weeklytMenuAdder = new WeeklyMenuAdder();
        }
    }
}
