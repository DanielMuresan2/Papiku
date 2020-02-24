using Papiku.BusinessLogic;

namespace Papiku.Core.DataManipulation.Listing
{
    public interface ILister : IDataManipulationService
    {
        void FormatAndPrintMenu(Menu res);
    }
}