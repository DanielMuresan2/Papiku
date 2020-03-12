using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ASPapi.Models
{
    public class CurrentMenu
    {
        public int ID { get; set; }
        public string Dessert { get; set; }
        public string MainDish { get; set; }
        public string SecondDish { get; set; }

        public ICollection<DailyMenu> DailyMenus { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}