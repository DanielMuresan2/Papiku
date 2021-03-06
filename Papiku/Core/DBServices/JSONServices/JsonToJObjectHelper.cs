﻿using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Papiku.Helpers.Logger;
using System;
using System.IO;

namespace Papiku.Core.DBServices.JSONServices
{
    internal class JsonToJObjectHelper
    {
        private static ILogger logger = LoggerHelper.DefaultLogger<JsonToJObjectHelper>();

        public static JObject Convert(string jsonPath)
        {
            string AbsolutePath = Path.GetFullPath(jsonPath);
            //no longer extension method because
            //I couldn't give static class as type to the DefaultLogger method
            JObject o = null;
            try
            {
                using (StreamReader jsonFile = File.OpenText(jsonPath)) //FileNotFound
                {
                    Console.WriteLine("\nOpening " + AbsolutePath);
                    using (JsonTextReader reader = new JsonTextReader(jsonFile)) //JsonReaderException
                    {
                        Console.WriteLine("\nReading from" + AbsolutePath);
                        o = (JObject)JToken.ReadFrom(reader);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                logger.LogError("Error when opening {0}. File not found!", AbsolutePath);
            }
            catch (JsonReaderException e)
            {
                logger.LogError(e.Message + " " + e.InnerException);
            }
            catch (InvalidCastException e)
            {
                logger.LogError("Warning! JSON file Corrupted: {0}\n", AbsolutePath);
            }
            return o;
        }
    }
}