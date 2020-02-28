using System;
using System.Collections.Generic;
using System.Text;
using static Papiku.Helpers.IO.InputValidator;

namespace Papiku.Core
{
    internal abstract class InteractiveComponent
    {
        protected int option = 0;

        public void Execute()
        {
            while (option != -1)
            {
                PrintOptions();
                option = ReadInteger();
                if (option != -1)
                    ExecuteOption();
            }
        }

        abstract protected void PrintOptions();

        abstract protected void ExecuteOption();
    }
}