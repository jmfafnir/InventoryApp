using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class Inventory
    {
        public int id { get; set; }
        public uint stock { get; set; }
        public int winerie_id { get; set; }
        public int item_id { get; set; }
    }
}
