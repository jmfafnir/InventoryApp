using System;
using EntityLayer;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class BlWinerie
    {


        DlWinerie dlWinerie = new DlWinerie(); 

        public void PruebaMySQL()
        {
            dlWinerie.Conexion();
        }


        public DataSet GetWinerieData()
        {

           
            return dlWinerie.Listar();
        }
    }
}
