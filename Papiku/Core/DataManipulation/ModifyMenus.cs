using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.Core.DataManipulation
{
    abstract class ModifyMenus
    {
        protected ModifyMenus Instance { get; }
        protected IExecutor currentMenuLister;
        protected IExecutor dailyMenuLister;
        protected IExecutor weeklytMenuLister;

        protected ModifyMenus(ModifyMenus m)
        {
            Instance 
        }
    }
}y
