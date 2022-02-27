using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class DlWinerieStock
    {

        string CadenaConexion = "Server=localhost;User=jmramirez;Password=manuel.jose23;Port=3306;database=inventoryapp;";

        
        public DataSet GetWinerieStock(int id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlDataAdapter adapter;

            string query = "select wineries.name as 'name_bodega',items.name as 'name_item',items.description,inventory.stock " +
                "from wineries join inventory on wineries.id = inventory.winerie_id join items on items.id = inventory.item_id " +
                "where wineries.id = @id; ";

            MySqlCommand mySqlCommand = new MySqlCommand(query,mySqlConnection);
            mySqlCommand.Parameters.AddWithValue("@id", id);

            DataSet dataSet = new DataSet();

            adapter = new MySqlDataAdapter(mySqlCommand);
            adapter.Fill(dataSet, "tlbWinerieStock");

            return dataSet;




        }

    }
}
