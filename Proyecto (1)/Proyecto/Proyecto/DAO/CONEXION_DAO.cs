using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto.DAO
{
    class CONEXION_DAO
    {

        MySqlConnection conex;


        public MySqlConnection servidor()
        {
            string cadena = "server=localhost; port=3306; user=root; pwd=elnumero1; database=proyectomex";
            conex = new MySqlConnection(cadena);
            return conex;
        }

        public void abrirBD()
        {
            conex.Open();
        }


        public void cerrarBD()
        {
            conex.Close();
        }



    }
}
