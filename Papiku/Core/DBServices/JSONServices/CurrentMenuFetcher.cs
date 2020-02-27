using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;
using Papiku.Core.DBServices.Exceptions;
using Papiku.Core.DBServices.Validators;
using System;

namespace Papiku.Core.DBServices.JSONServices
{
    internal class CurrentMenuFetcher : IDataFetching
    {
        private string jsonPath;

        public CurrentMenuFetcher(string _jsonPath)
        {
            jsonPath = _jsonPath;
        }

        public Menu Fetch()
        {
            Menu res = null;
            JObject jObject = jsonPath.Convert();
            if (jObject == null)
                return null;

            try
            {
                res = jObject.ToObject<CurrentMenu>();
                if (!MealValidator.IsOk(res))
                    throw new IncompleteDataException("Fetched incomplete CurrentMenu.");
            }
            catch (JsonSerializationException e)
            {
                Console.WriteLine("Fetched invalid CurrentMenu data." + e.Message);
            }

            return res;
        }
    }
}