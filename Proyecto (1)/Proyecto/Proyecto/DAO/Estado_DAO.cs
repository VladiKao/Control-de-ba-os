using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.BO;
using System.Data;


namespace Proyecto.DAO
{
    class Estado_DAO
    {


        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string insSQL;

        public int guardar_estado(ESTADO_BO obj_est)
        {
            ESTADO_BO dato = (ESTADO_BO)obj_est;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            insSQL = string.Format("insert into estado(nombre_estado) values('{0}')", dato.nombre_estado1);
            ejecutar.CommandText = insSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();
            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable Tabla_Estado()
        {
            insSQL = "select * from estado";
            MySqlDataAdapter adp = new MySqlDataAdapter(insSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;
        }

       





    }
}
