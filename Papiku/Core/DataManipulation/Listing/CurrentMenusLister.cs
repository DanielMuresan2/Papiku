using Papiku.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using Papiku.Core.DBServices;
using Papiku.Core.DBServices.JSONServices;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DataManipulation.Listing
{
    class CurrentMenuLister : ILister
    {
        private IDataFetching MenusFetcher;
        public CurrentMenuLister()
        {
            MenusFetcher = new CurrentMenuFetcher(CM1_json); //TODO: hardcoded; replace with path+"CM"+index+".json"
        }
        
        public void Execute()
        {
            Menu fetch_res = MenusFetcher.Fetch();
            FormatAndPrintMenu(fetch_res);
        }

       public void FormatAndPrintMenu(Menu res)
        {
            Console.WriteLine("CurrentMenuLister sadasda");
        }
    }
}
