namespace Papiku.Core.DBServices.JSONServices
{
    internal class JSONService
    {
        public static void test()
        {
            /***

             * [OnSerializing], [OnSerialized] => annotations for serialize callbacks

             * LINQ => SQL keywords for iteration through the JSON properties and more
             * parse => JSON format string to JSON object
             *
             * using Papiku.Properties;
             * using static Papiku.Properties.Resources;
             * ResourceManager rm = new ResourceManager(typeof(Resx_File_Name)); => String resources just like in Kotlin
             */
            /*

            ResourceManager rm = new ResourceManager(typeof(Resources));

                    Menu m = new Menu();
                    m.description = "asdasd";
                    JObject o = JObject.FromObject(m);

                     WriteLine(o[DESCRIPTION]);
              */

            // IDataFetching test = new CurrentMenuFetcher(CM1_json);
            /* Menu[] bla = test.Fetch();
             foreach(Menu x in bla)
             {
                 WriteLine(x.description);
             }*/
        }
    }
}