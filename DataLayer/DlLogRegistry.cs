using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer
{
    public class DlLogRegistry
    {
        string CadenaConexion = "Server=localhost;User=jmramirez;Password=manuel.jose23;Port=3306;database=inventoryapp;";
        public DataSet ListLogRegistries()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlDataAdapter adapter;

            string query = "select origin_winery.name as Origin_Winery , destination_winery.name " +
                "as Destination_Winery, items.name as Item, log.date as Date, log.amount as Amount " +
                "from log join wineries as origin_winery on origin_winery.id = log.origin_winerie " +
                "join wineries as destination_winery on destination_winery.id = log.destination_winerie " +
                "join items on items.id = log.item_id;";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            

            DataSet dataSet = new DataSet();

            adapter = new MySqlDataAdapter(mySqlCommand);
            adapter.Fill(dataSet, "tlbLogRegistries");
            mySqlConnection.Close();

            return dataSet;




        }
    }
}
