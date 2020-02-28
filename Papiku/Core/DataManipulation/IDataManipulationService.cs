namespace Papiku.Core.DataManipulation
{
    public interface IDataManipulationService
    {
        int option { get; } //option ~= ID

        void Execute();

        // void ChooseOption();
    }
}