using Papiku.BusinessLogic;

namespace Papiku.Core.DBServices
{
    internal interface IDataFetching
    {
        public Menu Fetch<T>() where T : Menu;
    }
}