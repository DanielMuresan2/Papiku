﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation.Deleting
{
    interface IRemover : IDataManipulationService
    {
        public void RemoveMenu();
    }
}
