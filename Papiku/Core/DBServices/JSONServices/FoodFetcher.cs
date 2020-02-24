using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.JSONServices
{
    class FoodFetcher 
    {
        private string jsonPath;
        public FoodFetcher(string _jsonPath)
        {
            jsonPath = _jsonPath;
        }
       /* public Food[] Fetch()
        {
            var JArray = jsonPath.Convert();
            var jmenus = JArray.ToObject<JObject[]>();
            Food[] menus = new Food[];

            return menus;
        }*/
    }
}
