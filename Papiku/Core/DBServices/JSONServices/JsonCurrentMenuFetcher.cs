using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;
using Papiku.Core.DBServices.Exceptions;
using Papiku.Core.DBServices.Validators;
using System;

namespace Papiku.Core.DBServices.JSONServices
{
    internal class JsonCurrentMenuFetcher : IDataFetching
    {
        private string jsonPath;

        public JsonCurrentMenuFetcher(string _jsonPath)
        {
            jsonPath = _jsonPath;
        }

        public Menu Fetch()
        {
            Menu res = null;
            JObject jObject = JsonToJObjectHelper.Convert(jsonPath);
            if (jObject == null)
                return null;

            try
            {
                res = jObject.ToObject<CurrentMenu>();
                if (!MealValidator.IsOk(res))
                    throw new InvalidDataException("Invalid CurrentMenu found!"); //TODO: very ugly case scenario. What to do?
            }
            catch (JsonSerializationException e)
            {
                Console.WriteLine("CurrentMenu data has invalid values " + e.Message);
            }

            return res;
        }
    }
}