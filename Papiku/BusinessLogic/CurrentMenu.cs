using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Papiku.Properties.Resources;

namespace Papiku.BusinessLogic
{
    internal class CurrentMenu : Menu
    {
        public CurrentMenu(uint index, string Main_dish, string Second_dish, string _dessert)
            : base(index)
        {
            MainDish = Main_dish;
            SecondDish = Second_dish;
            Dessert = _dessert;
        }

        [JsonConstructor]
        public CurrentMenu(uint index, string Main_dish, string Second_dish, string _dessert, string _description)
            : base(index, _description)
        {
            MainDish = Main_dish;
            SecondDish = Second_dish;
            Dessert = _dessert;
            description = _description;
        }

        public string Dessert { get; }
        public string MainDish { get; }
        public string SecondDish { get; }

        public static explicit operator CurrentMenu(JToken j)
        {
            var index = j.Value<uint>(INDEX);
            var md = j.Value<string>(MAIN_DISH);
            var sd = j.Value<string>(SECOND_DISH);
            var dess = j.Value<string>(DESSERT);
            var des = j.Value<string>(DESCRIPTION);
            CurrentMenu res = new CurrentMenu(index, md, sd, dess);
            return res;
        }
    }
}