using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Proyecto.BO;
using Proyecto.GUI;

namespace Proyecto.DAO
{
    class Colonia_DAO
    {

        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;

        public int Guardar_Colonia(COLONIA_BO objcol)
        {

            COLONIA_BO Dato = (COLONIA_BO)objcol;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into colonia(Nombre_Colonia,ID_Ciudad) values('{0}', {1})", Dato.Nombre_Colonia1, Dato.IdCiudad);
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();
            if (folio <= 0)
            {
                return 0;
            }
            return 1;



        }

        public DataTable Tabla_colonia()
        {


            InsSQL = "select colonia.ID_Colonia,colonia.Nombre_Colonia,ciudad.Nombre_Ciudad as ID_Ciudad from colonia inner join ciudad on colonia.ID_Ciudad = ciudad.ID_Ciudad;";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;


        }

        //instancia de colonia (llaves foraneas)
       


        // Para la FK

        public ArrayList Lista_Ciudad()
        {

            InsSQL = "Select Nombre_Ciudad from ciudad";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["Nombre_Ciudad"]);
            }

            BD.cerrarBD();
            return Lista;


        }



        public string ID_Ciudad(string Nombre_Ciudad)
        {
            string IDciudad = "";
            InsSQL = string.Format("Select ID_Ciudad from ciudad where Nombre_Ciudad = '{0}'", Nombre_Ciudad);
            MySqlCommand cmd = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            cmd.Parameters.AddWithValue("@ciudad", IDciudad);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                IDciudad = leer["ID_Ciudad"].ToString();
            }
            BD.cerrarBD();
            return IDciudad;
        }



        public string ID_colonia(string Nombre_Colonia)
        {
            string IDcolonia = "";
            InsSQL = string.Format("Select ID_Colonia from colonia where Nombre_Colonia = '{0}'", Nombre_Colonia);
            MySqlCommand cmd = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            cmd.Parameters.AddWithValue("@colonia", IDcolonia);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                IDcolonia = leer["ID_Colonia"].ToString();
            }
            BD.cerrarBD();
            return IDcolonia;
        }


    }
}
