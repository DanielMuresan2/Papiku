using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ASPapi.Models
{
    internal class CurrentMenu : Menu
    {
        public string Dessert { get; set; }
        public string MainDish { get; set; }
        public string SecondDish { get; set; }
    }
}