using Papiku.BusinessLogic;

namespace Papiku.Core.DataManipulation.Listing
{
    public interface ILister : IExecutor
    {
        void Execute();
        void FormatAndPrintMenu();
    }
}