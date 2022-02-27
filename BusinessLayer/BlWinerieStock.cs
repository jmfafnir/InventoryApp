using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataLayer;

namespace BusinessLayer
{
    public class BlWinerieStock
    {
        DlWinerieStock dlWinerieStock = new DlWinerieStock();

        public DataSet GetWinerieStockData(int id)
        {


            return dlWinerieStock.GetWinerieStock(id);
        }
    }
}
