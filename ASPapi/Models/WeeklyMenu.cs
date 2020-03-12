using System.Collections.Generic;
using System.Linq;

namespace ASPapi.Models
{
    public class WeeklyMenu
    {
        public int ID { get; set; }

        public int WeekNr { get; set; }
        public ICollection<DailyMenu> DailyMenus { get; set; }
    }
}