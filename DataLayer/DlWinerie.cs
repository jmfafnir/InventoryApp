using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DlWinerie
    {
        string CadenaConexion = "Server=localhost;User=jmramirez;Password=manuel.jose23;Port=3306;database=inventoryapp;";

        public void Conexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la conecion a la BD" + ex.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conexion Exitosa");
        }

        public DataSet Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(CadenaConexion);
            mySqlConnection.Open();
            MySqlDataAdapter adapter;

            string query = "select id,name from wineries;";

            DataSet dataSet = new DataSet();

            adapter = new MySqlDataAdapter(query,mySqlConnection);
            adapter.Fill(dataSet, "tlbWineries");
            mySqlConnection.Close();

            return dataSet;




        }
    }
}
