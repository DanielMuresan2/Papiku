using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Papiku.BusinessLogic;
using System;

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
            var jObject= jsonPath.Convert();
            var index =jObject.Value<string>("index"); //TODO: resource!!
            var md = jObject.Value<string>("Main dish");
            var sd = jObject.Value<string>("Second dish");
            Menu res = new CurrentMenu(md, sd, null, Convert.ToUInt32(index));
            Console.WriteLine(index + md + sd);
            return res;
        }


    }
}
