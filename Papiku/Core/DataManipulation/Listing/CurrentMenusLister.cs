using Papiku.BusinessLogic;
using Papiku.Core.DBServices;
using Papiku.Core.DBServices.JSONServices;
using Papiku.Core.DBServices.JSONServices.JSONLister;
using System;
using System.IO;
using static Papiku.Helpers.Constants;
using static Papiku.Helpers.IO.InputValidator;
using static Papiku.Properties.Resources;

namespace Papiku.Core.DataManipulation.Listing
{
    internal class CurrentMenuLister : ILister
    {
        public int option => CurrentMenuListerOption;

        public CurrentMenuLister()
        {
        }

        public void FormatAndPrintMenu(Menu res)
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            IDataBaseService l;
            if (PapikuEntryPoint.Instance.SelectedService == typeof(JSONServices))
            {
                l = new JsonCurrentMenuLister();
            }
            else return;

            l.Execute();
        }
    }
}