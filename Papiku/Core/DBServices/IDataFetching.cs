using System;
using System.Collections.Generic;
using System.Text;
using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices
{
    interface IDataFetching
    {
        public Menu Fetch();
    }
}
