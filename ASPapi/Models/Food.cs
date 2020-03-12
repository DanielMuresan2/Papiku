using System.Collections.Generic;
using System.Linq;

namespace ASPapi.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal calories { get; set; }
        public short quantity { get; set; }

        public ICollection<CurrentMenu> CurrentMenus { get; set; }
    }
}