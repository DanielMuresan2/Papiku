using System.Collections.Generic;
using System.Linq;

namespace ASPapi.Models
{
    public class DailyMenu
    {
        public int ID { get; set; }

        public string DayName { get; set; }

        public ICollection<WeeklyMenu> WeeklyMenus { get; set; }
        public ICollection<CurrentMenu> CurrentMenus { get; set; }
    }
}