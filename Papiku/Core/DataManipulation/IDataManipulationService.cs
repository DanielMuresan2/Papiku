using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation
{
    public interface IDataManipulationService
    {
        int option { get; }
        void Execute();
        void ChooseOption();
    }
}
