﻿namespace Papiku.BusinessLogic
{
    public class Menu
    {
        // TODO: implement methods that generate id and idex
        public string? description { get; set; }

        public uint index { get; set; } //set is public ?

        public Menu(uint _index)
        {
            index = _index;
        }

        public Menu(uint _index, string? _description)
        {
            index = _index;
            description = _description;
        }
    }
}