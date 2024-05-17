using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.BO;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto.DAO
{
    class Edificio_DAO
    {
        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string insSQL;
        public int guardar_edificio(EDIFICIO_BO obj_ed)
        {
            EDIFICIO_BO dato = (EDIFICIO_BO )obj_ed;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            insSQL = string.Format("insert into edificio(letra_Edificio) values('{0}')", dato.Letra_Edificio);
            ejecutar.CommandText = insSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();
            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }


        public DataTable Tabla_Edificio()
        {
            insSQL = "select * from edificio";
            MySqlDataAdapter adp = new MySqlDataAdapter(insSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;
        }

        public string ID_Edificio(string letra_Edificio)
        {
            string ID = "";
            insSQL = string.Format("Select ID_Edificio from edificio where letra_Edificio = '{0}'", letra_Edificio);
            MySqlCommand cmd = new MySqlCommand(insSQL, BD.servidor());
            BD.abrirBD();
            cmd.Parameters.AddWithValue("@_Edificio", ID);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                ID = leer["ID_Edificio"].ToString();
            }
            BD.cerrarBD();
            return ID;
        }




    }
}
