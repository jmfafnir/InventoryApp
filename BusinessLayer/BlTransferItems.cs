using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer;
using DataLayer;
using System.Data;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class BlTransferItems
    {
        DlTransferItems dlTransferItems = new DlTransferItems();
        DlWinerie dlWinerie = new DlWinerie();

        public bool existsItemIndestinationWinery = true;
        public void UpdateInventoryRegister(bool isIncrment,int winerie_id, int item_id, uint amount)
        {
            uint currentStock = GetStock(winerie_id, item_id);
            if (existsItemIndestinationWinery)
            {
                
                if (isIncrment)
                {
                    dlTransferItems.UpdateInventoryRegister(winerie_id, item_id, amount+currentStock);
                }
                else
                {
                    dlTransferItems.UpdateInventoryRegister(winerie_id, item_id, currentStock - amount);
                }

            }
            else
            {
                Inventory inventoryData = new Inventory();
                inventoryData.winerie_id = winerie_id;
                inventoryData.item_id = item_id;
                inventoryData.stock = amount;
                dlTransferItems.InsertInventoriRegister(inventoryData);
            }
        }

        public void IncertLogRegister(LogRegister logRegister)
        {
            dlTransferItems.InsertLogRegister(logRegister);
        }

        public bool ValidateAmount(uint amount,int winerie_id, int item_id)
        {
            DataSet stockData = dlTransferItems.StockData(winerie_id, item_id);

            uint currentStock = (uint) stockData.Tables["tlStocks"].Rows[0].ItemArray[0];
            if(amount > currentStock)
            {
                return false;
            }

            return true;

        }

        public uint GetStock(int winerie_id, int item_id)
        {
            DataSet stockData = dlTransferItems.StockData(winerie_id, item_id);

            if (stockData.Tables["tlStocks"].Rows.Count > 0)
            {
                uint currentStock = (uint)stockData.Tables["tlStocks"].Rows[0].ItemArray[0];

                existsItemIndestinationWinery = true;
                return currentStock;
            }
            existsItemIndestinationWinery = false;
            return 0;
        }


        public DataSet GetWineries()
        {
            return dlWinerie.Listar();
        }

        public DataSet GetItems(int id_winerie)
        {
            return dlTransferItems.ListarItems(id_winerie);
        }

    }
}
