using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.BO;
using System.Data;
using Proyecto.GUI;


namespace Proyecto.DAO
{
    class Ciudad_DAO
    {

        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string insSQL;

    


            public int guardar_ciudad(CIUDAD_BO obj_est)
            {
                CIUDAD_BO dato = (CIUDAD_BO)obj_est;
                ejecutar.Connection = BD.servidor();
                BD.abrirBD();
                insSQL = string.Format("insert into ciudad(Nombre_Ciudad,idEstado) values('{0}', {1})", dato.Nombre_Ciudad1, dato.IdEstado);
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
            insSQL = "select ciudad.ID_Ciudad,ciudad.Nombre_Ciudad,estado.nombre_estado as idestado from ciudad inner join estado on ciudad.idestado = estado.idestado; ";
                MySqlDataAdapter adp= new MySqlDataAdapter(insSQL, BD.servidor());
                DataTable TablaVir = new DataTable();
                adp.Fill(TablaVir);
                return TablaVir;
            }



            
            public string idestado(string nombre_estado)
            {
                string IDcolonia = "";
                insSQL = string.Format("Select idestado from estado where nombre_estado = '{0}'", nombre_estado);
                MySqlCommand cmd = new MySqlCommand(insSQL, BD.servidor());
                BD.abrirBD();
                cmd.Parameters.AddWithValue("@estado", IDcolonia);
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    IDcolonia = leer["idestado"].ToString();
                }
                BD.cerrarBD();
                return IDcolonia;
            }



        public ArrayList Lista_Estado()
        {

            insSQL = "Select nombre_estado from estado";
            MySqlCommand adp = new MySqlCommand(insSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["nombre_estado"]);
            }

            BD.cerrarBD();
            return Lista;


        }


        public ArrayList Lista_Ciudad()
        {

            insSQL = "Select Nombre_Ciudad from ciudad";
            MySqlCommand adp = new MySqlCommand(insSQL, BD.servidor());
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



    }
}
