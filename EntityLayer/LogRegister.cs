using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class LogRegister
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int origin_winerie { get; set; }
        public int destination_winerie { get; set; }
        public int item_id { get; set; }
        public uint amount { get; set; }

    }
}
