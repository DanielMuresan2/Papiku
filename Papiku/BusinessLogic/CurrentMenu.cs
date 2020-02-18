using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.BusinessLogic
{
    class CurrentMenu : Menu
    {
        private List<Food> food = new List<Food>();
        public CurrentMenu(List<Food> f)
        {
            food = f;
        }
    }
}
