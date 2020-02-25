using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices.JSONServices
{
    class CurrentMenuFetcher : IDataFetching
    {
        private string jsonPath;
        public CurrentMenuFetcher(string _jsonPath)
        {
            jsonPath = _jsonPath;
        }
        public Menu Fetch()
        {
            JObject jObject= jsonPath.Convert();
            Menu res = jObject.ToObject<CurrentMenu>();
            return res;
        }
    }
}
