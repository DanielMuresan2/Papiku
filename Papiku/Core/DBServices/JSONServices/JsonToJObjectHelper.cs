using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Papiku.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Papiku.Core.DBServices.JSONServices
{
    static class JsonToJObjectHelper
    {
        public static JObject Convert(this string jsonPath)
        {
            //TODO: exception handling
            using (StreamReader jsonFile = File.OpenText(jsonPath)) 

            using (JsonTextReader reader = new JsonTextReader(jsonFile))
            {
                JToken o = JToken.ReadFrom(reader);
                CurrentMenu cm = (CurrentMenu)o;
               Console.WriteLine(cm.SecondDish);
                return null;
            }
        }
    }
}
