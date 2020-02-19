using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using Papiku.BusinessLogic;
using Newtonsoft.Json.Converters;
using System.Linq;
using System.Collections;
using System.Resources;
using System.Reflection;
using Papiku.Properties;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DBServices.JSONServices
{
    class JSONService
    {
        public static void test()
        {
            /***
             * serialize => object to JSON format string
             * deserialize => JSON format string to object
             * [OnSerializing], [OnSerialized] => annotations for serialize callbacks
             * JObject.FromObject( .NET Type object) => converts from any object straight into JSON object
             * LINQ => SQL keywords for iteration through the JSON properties and more
             * parse => still a converter,but i'm not allowed to use it
             * 
             * using Papiku.Properties;
             * using static Papiku.Properties.Resources;
             * ResourceManager rm = new ResourceManager(typeof(Resx_File_Name)); => String resources just like in Kotlin
             */

            ResourceManager rm = new ResourceManager(typeof(Resources));


            string key = rm.GetString(String1);
            Menu m = new Menu();
            m.description = "asdasd";
            JObject o = JObject.FromObject(m);

             WriteLine(o[DESCRIPTION]);
            
        }
    }
}
