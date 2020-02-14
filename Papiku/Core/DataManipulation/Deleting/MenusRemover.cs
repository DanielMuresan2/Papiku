using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation.Deleting
{
    class MenusRemover 
    {
        private static IExecutor currentMenuLister;
        private static IExecutor dailyMenuLister;
        private static IExecutor weeklytMenuLister;
        static MenusRemover()
        {
            currentMenuLister = new CurrentMenuRemover();
            dailyMenuLister = new DailyMenuRemover();
            weeklytMenuLister = new WeeklyMenuRemover();
        }
    }
}
