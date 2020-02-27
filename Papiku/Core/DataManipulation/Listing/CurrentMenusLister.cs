using Papiku.BusinessLogic;
using Papiku.Core.DBServices;
using Papiku.Core.DBServices.JSONServices;
using System;
using static Papiku.Helpers.Constants;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DataManipulation.Listing
{
    internal class CurrentMenuLister : ILister
    {
        private IDataFetching MenusFetcher;

        public CurrentMenuLister()
        {
            MenusFetcher = new CurrentMenuFetcher(CM1_json);
            //TODO: hardcoded; replace with path+"CM"+index+".json"
            //who choses the path aka json file? ChooseOption() along with other methods, eventually
        }

        public int option => CurrentMenuListerOption;

        public void ChooseOption()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            Menu fetch_res = MenusFetcher.Fetch();
            if (fetch_res != null)
                FormatAndPrintMenu(fetch_res);
            else
                Console.WriteLine("Fetched null. Retry?"); //TODO: retry policy
        }

        public void FormatAndPrintMenu(Menu res)
        {
            CurrentMenu cm = (CurrentMenu)res;
            Console.WriteLine($"{cm.MainDish} {cm.SecondDish} {cm.index}");
        }
    }
}