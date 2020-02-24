using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            using(StreamReader jsonFile = File.OpenText(jsonPath))
            using (JsonTextReader reader = new JsonTextReader(jsonFile))
            {
                JObject o = (JObject)JToken.ReadFrom(reader);
                return o;
            }
        }
    }
}
