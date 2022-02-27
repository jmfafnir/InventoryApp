using EntityLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class DlTransferItems
    {
        string CadenaConexion = "Server=localhost;User=jmramirez;Password=manuel.jose23;Port=3306;database=inventoryapp;";


        public DataSet ListarItems(int id_winerei)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlDataAdapter adapter;

            string query = "select items.id,items.name from items" +
                " join inventory on inventory.item_id = items.id " +
                "where inventory.winerie_id = @winerie_id;";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@winerie_id", id_winerei);

            DataSet dataSet = new DataSet();

            adapter = new MySqlDataAdapter(mySqlCommand);
            adapter.Fill(dataSet, "tlbItems");
            mySqlConnection.Close();

            return dataSet;

        }

        public DataSet StockData(int winerie_id,int item_id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlDataAdapter adapter;

            string query = "select stock from inventory " +
                "WHERE inventory.winerie_id = @winerie_id and inventory.item_id = @item_id; ";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@winerie_id", winerie_id);
            mySqlCommand.Parameters.AddWithValue("@item_id", item_id);

            DataSet dataSet = new DataSet();

            adapter = new MySqlDataAdapter(mySqlCommand);
            adapter.Fill(dataSet, "tlStocks");
            mySqlConnection.Close();

            return dataSet;




        }


        public void UpdateInventoryRegister(int winerie_id, int item_id, uint amount)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();

            
            string query = "update inventory set inventory.stock = @amount " +
                "WHERE inventory.winerie_id = @winerie_id and inventory.item_id = @item_id;";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@amount", amount);
            mySqlCommand.Parameters.AddWithValue("@winerie_id", winerie_id);
            mySqlCommand.Parameters.AddWithValue("@item_id", item_id);



            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }


        public void InsertInventoriRegister(Inventory dataInventory)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();

            string query = "INSERT INTO inventory (stock,winerie_id,item_id )" +
                " VALUES (@stock,@winerie_id,@item_id);";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@stock", dataInventory.stock);
            mySqlCommand.Parameters.AddWithValue("@winerie_id", dataInventory.winerie_id);
            mySqlCommand.Parameters.AddWithValue("@item_id", dataInventory.item_id);



            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }

        public void InsertLogRegister(LogRegister dataLog)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();

            string query = "insert into log (origin_winerie,destination_winerie,item_id,amount) " +
                "values (@origin_winerie,@destination_winerie,@item_id,@amount);";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@origin_winerie", dataLog.origin_winerie);
            mySqlCommand.Parameters.AddWithValue("@destination_winerie", dataLog.destination_winerie);
            mySqlCommand.Parameters.AddWithValue("@item_id", dataLog.item_id);
            mySqlCommand.Parameters.AddWithValue("@amount", dataLog.amount);



            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();
        }



    }
}
