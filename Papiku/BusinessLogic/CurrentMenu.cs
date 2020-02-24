using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.BusinessLogic
{
    class CurrentMenu : Menu
    {
        
        public string MainDish { get; }
        public string SecondDish { get; }
        public string Dessert { get; }

        public CurrentMenu(string main, string second, string _dessert, uint index )
            :base ( index)
        {
            MainDish = main;
            SecondDish = second;
            Dessert = _dessert;
        }
        public CurrentMenu(string main, string second, string _dessert, uint index, string _description)
            : base( index, _description)
        {
            MainDish = main;
            SecondDish = second;
            Dessert = _dessert;
            description = _description;
        }
    }
}
