using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;
using Papiku.Core.DBServices.Exceptions;
using Papiku.Core.DBServices.Validators;
using Papiku.Helpers.Logger;

namespace Papiku.Core.DBServices.JSONServices
{
    internal class MenuFetcher : IDataFetching
    {
        private string jsonPath;
        private static ILogger logger = LoggerHelper.DefaultLogger<MenuFetcher>();

        public MenuFetcher(string _jsonPath)
        {
            jsonPath = _jsonPath;
        }

        public Menu Fetch<T>() where T : Menu
        {
            Menu res = null;
            JObject jObject = JsonToJObjectHelper.Convert(jsonPath);
            if (jObject == null)
                return null;

            try
            {
                res = jObject.ToObject<T>();
                if (!MealValidator.IsOk(res))
                {
                    logger.LogError("Invalid Current Menu object found in the database!");
                    throw new InvalidDataException("Invalid Current Menu found!"); //TODO: very ugly case scenario. What to do?
                }
            }
            catch (JsonSerializationException e)
            {
                logger.LogError("Current Menu data has invalid values " + e.Message);
            }

            return res;
        }
    }
}