using System;
using System.Collections.Generic;
using System.Text;

namespace Papiku.BusinessLogic
{

    public class Menu
    {  
        // TODO: implement methods that generate id and idex
        public string? description { get;  set; }
        protected string _id { get; } 
        protected string index { get; set; } //set public ?
    }
}
