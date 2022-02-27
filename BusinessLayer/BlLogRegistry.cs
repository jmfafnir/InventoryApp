using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer;

namespace BusinessLayer
{
    public class BlLogRegistry
    {
        DlLogRegistry dlLogRegistry = new DlLogRegistry();

        public DataSet GetLogRegistries()
        {


            return dlLogRegistry.ListLogRegistries();
        }
    }
}
