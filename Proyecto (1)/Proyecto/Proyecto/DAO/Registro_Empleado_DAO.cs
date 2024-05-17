using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.BO;
using MySql.Data.MySqlClient;
using System.Data;


namespace Proyecto.DAO
{
    class Registro_Empleado_DAO
    {


        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;


        public int GuardarRegistro_Empleado(EMPLEADO_BO objper)
        {

            EMPLEADO_BO Dato = (EMPLEADO_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into usuarioemp(nombre_usuarioemp,apellido_paterno,apellido_materno,Edad,contrasenia, calle,cruzamientos,casa,ID_Ciudad,ID_Colonia,idestado,idrol,idturno) values('{0}','{1}', '{2}', {3}, '{4}', '{5}', '{6}', {7}, {8}, {9},{10}, {11},{12} );", Dato.Nombre_usuarioemp, Dato.Apellido_paterno, Dato.Apellido_materno, Dato.Edad1,Dato.Contrasenia, Dato.Calle,Dato.Cruzamientos,Dato.Casa, Dato.IDciudad1,
                Dato.ID_Col, Dato.Estado, Dato.Idrol,  Dato.Idturno);
            //para traer solo los campos que necesito, si quiero solo puedo poner 1
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();

            BD.cerrarBD();
            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }

  


        public string ID_Empleado(string nombre_usuarioemp)
        {
            string id = "";
            InsSQL = string.Format("Select idusuarioemp from empleado where nombre_usuarioemp ='{0}", nombre_usuarioemp);
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@usuarioemp", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idusuarioemp"].ToString());
            }
            return id;
        }

       // public int Atualizar_Empleado(EMPLEADO_BO objpro)


       // {

          //  EMPLEADO_BO Dato = (EMPLEADO_BO)objpro;
          //  ejecutar.Connection = BD.servidor();
           // BD.abrirBD();
           // InsSQL = string.Format("Update empleado set nombre_usuarioemp= '{0}', apellido_paterno='{1}', apellido_materno= '{2}', Edad = {3}, contrasenia='{4}',calle='{5}',cruzamientos='{6}',casa={7},ID_Ciudad={8},ID_Colonia={9},idestado={10},idrol={11},idturno={12} ", Dato.Nombre_usuarioemp, Dato.Apellido_paterno, Dato.Apellido_materno, Dato.Edad1, Dato.Contrasenia, Dato.Calle, Dato.Cruzamientos, Dato.Casa, Dato.IDciudad1, Dato.ID_Col, Dato.Estado, Dato.Idrol, Dato.Idturno);
           // ejecutar.CommandText = InsSQL;
          //  int folio = ejecutar.ExecuteNonQuery();
         //  BD.cerrarBD();



          //  if (folio <= 0)
         //   {
             //   return 0;
           // }
          //  return 1;
       // }

        public int Atualizar_empleado(EMPLEADO_BO objpro)
        {

            EMPLEADO_BO Dato = (EMPLEADO_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            InsSQL = "Update usuarioemp set nombre_usuarioemp= '" + Dato.Nombre_usuarioemp + "', apellido_paterno= '" + Dato.Apellido_paterno + "', apellido_materno= '" + Dato.Apellido_materno + "', Edad= '" + Dato.Edad1 + "', contrasenia = '" + Dato.Contrasenia + "', calle= '" + Dato.Calle + "', cruzamientos='" + Dato.Cruzamientos + "', casa='" + Dato.Casa + "',ID_Ciudad='" + Dato.IDciudad1 + "', ID_Colonia='" + Dato.ID_Col + "', idestado= '" + Dato.Estado + "', idrol='" + Dato.Idrol + "', idturno='" + Dato.Idturno +  "' where idusuarioemp='" + Dato.Idusuarioemp + "' ";
            ejecutar.CommandText = InsSQL;
            int valor = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();
            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }



        public int Eliminar_Empleado(EMPLEADO_BO objpro)


        {

            EMPLEADO_BO Dato = (EMPLEADO_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("Delete from usuarioemp where idusuarioemp= '{0}'", Dato.Idusuarioemp);
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }

        //instancia de colonia (llaves foraneas)
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

        public string idEstado(string nombre_estado)
        {
            string IDestado = "";
            InsSQL = string.Format("Select idestado from estado where nombre_estado = '{0}'", nombre_estado);
            MySqlCommand cmd = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            cmd.Parameters.AddWithValue("@estado", IDestado);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                IDestado = leer["idestado"].ToString();
            }
            BD.cerrarBD();
            return IDestado;
        }

        public string idrol(string nombre_rol)
        {
            string id = "";
            InsSQL = string.Format ("Select idrol from rol where nombre_rol ='{0}'", nombre_rol) ;
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@rol", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idrol"].ToString());
            }
            return id;
        }




        public string idturno(string nombre_turno)
        {
            string id = "";
            InsSQL = string.Format("Select idturno from turno where nombre_turno ='{0}'", nombre_turno );
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@turno", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idturno"].ToString());
            }
            return id;
        }




        public ArrayList Lista_Colonia()
        {

            InsSQL = "Select Nombre_Colonia from  colonia";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["Nombre_Colonia"]);
            }

            BD.cerrarBD();
            return Lista;


        }



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


        public ArrayList List_Estado()
        {

            InsSQL = "Select nombre_estado from estado";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
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

        public ArrayList Lista_rol()
        {

            InsSQL = "Select nombre_rol from rol";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["nombre_rol"]);
            }

            BD.cerrarBD();
            return Lista;


        }



        public ArrayList Lista_turno()
        {

            InsSQL = "Select nombre_turno from turno";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["nombre_turno"]);
            }

            BD.cerrarBD();
            return Lista;


        }







        public DataTable Tabla_empleado()
        {
            InsSQL = "select usuarioemp.idusuarioemp,usuarioemp.nombre_usuarioemp,usuarioemp.apellido_paterno,usuarioemp.apellido_materno,usuarioemp.Edad,usuarioemp.contrasenia,usuarioemp.calle,usuarioemp.cruzamientos,usuarioemp.casa,ciudad.Nombre_Ciudad as Ciudad,colonia.Nombre_Colonia as Colonia,estado.nombre_estado as Estado ,rol.nombre_rol as Rol,turno.nombre_turno as Turno   from usuarioemp  Inner join ciudad on usuarioemp.ID_Ciudad=ciudad.ID_Ciudad Inner join colonia on usuarioemp.ID_Colonia=colonia.ID_Colonia Inner join estado on usuarioemp.idestado=estado.idestado Inner join rol  on usuarioemp.idrol=rol.idrol   Inner join turno on usuarioemp.idturno = turno.idturno ;";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;


        }
         

    }
}
