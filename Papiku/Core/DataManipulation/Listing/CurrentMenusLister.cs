using Papiku.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation.Listing
{
    class CurrentMenuLister : ILister
    {
        //voi sti care serviciu specializat imi va onora cerea? Nu ar trebui..
        public void Execute()
        {
            /***
             * call data fetch service; once you get it, print it
             * different method for printing format
             * */

            //Aplicatia momentan nu are nevoie de business logic. Se poate face cam totul doar folosing stringuri + JSON objects
            throw new NotImplementedException();
        }

       public void FormatAndPrintMenu()
        {
            throw new NotImplementedException();
        }
    }
}
