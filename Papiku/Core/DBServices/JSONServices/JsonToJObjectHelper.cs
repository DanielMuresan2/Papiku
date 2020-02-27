using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Papiku.Core.DBServices.JSONServices
{
    internal static class JsonToJObjectHelper
    {
        public static JObject Convert(this string jsonPath)
        {
            JObject o = null;
            try
            {
                using (StreamReader jsonFile = File.OpenText(jsonPath)) //FileNotFound
                {
                    Console.WriteLine("\nOpening " + jsonPath);
                    using (JsonTextReader reader = new JsonTextReader(jsonFile)) //JsonReaderException
                    {
                        Console.WriteLine("\nReading from" + jsonPath);
                        o = (JObject)JToken.ReadFrom(reader);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine(e.Message + " " + e.InnerException);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Warning! JSON file Corrupted: {0}\n", jsonPath);
            }
            return o;
        }
    }
}