using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.BO;
using System.Data;


namespace Proyecto.DAO
{
    class Registro_BañoMuj_DAO
    {

        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;


        public int GuardarRegistro_BañoMuj(BañoMuje_BO objper)
        {

            BañoMuje_BO Dato = (BañoMuje_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into banio_muje(matriculabanio_muje,luz,agua,espejo,jabon,gelantibacterial,basurero,lavabos,papel_servilletero,inodoros,idusuarioemp) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10});", Dato.Matriculabanio_muje, Dato.Luz, Dato.Agua, Dato.Espejo, Dato.Jabon, Dato.Gelantibacterial, Dato.Basurero, Dato.Lavabos, Dato.Papel_servilletero, Dato.Inodoros,  Dato.Idusuarioemp);
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




        public DataTable Tabla_BañoMUJ()
        {


            InsSQL = "Select banio_muje.idbanio_muje, banio_muje.matriculabanio_muje,banio_muje.luz,banio_muje.agua,banio_muje.espejo,banio_muje.jabon,banio_muje.gelantibacterial,banio_muje.basurero,banio_muje.lavabos,banio_muje.papel_servilletero,banio_muje.inodoros,  usuarioemp.nombre_usuarioemp as empleado from banio_muje  inner join usuarioemp on banio_muje.idusuarioemp=usuarioemp.idusuarioemp";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;


        }

        public string ID_BañoMUJE(string matriculabanio_muje)
        {
            string id = "";
            InsSQL = string.Format("Select idbanio_muje from banio_muje where matriculabanio_muje = '{0}'", matriculabanio_muje);
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@banio_muje", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idbanio_muje"].ToString());
            }
            return id;






        }


       // public int Atualizar_BañoMUJE(string matriculabanio_muje,BañoMuje_BO objpro)
       // {

          //  BañoMuje_BO Dato = (BañoMuje_BO)objpro;
           // ejecutar.Connection = BD.servidor();
           // BD.abrirBD();
           // InsSQL = string.Format("Update banio_muje set( matriculabanio_muje,luz,agua,espejo,jabon,gelantibacterial,basurero,lavabos,papel_servilletero,inodoros,IDEdificio,idusuarioemp) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11} ) where matriculabanio_muje='" + matriculabanio_muje + "';", Dato.Matriculabanio_muje, Dato.Luz, Dato.Agua, Dato.Espejo, Dato.Jabon, Dato.Gelantibacterial, Dato.Basurero, Dato.Lavabos, Dato.Papel_servilletero, Dato.Inodoros, Dato.IDEdificio1, Dato.Idusuarioemp);
           // ejecutar.CommandText = InsSQL;
           // int folio = ejecutar.ExecuteNonQuery();
           // BD.cerrarBD();
          //  if (folio <= 0)
          //  {
            //    return 0;
          //  }
         //   return 1;
        //}

        public int ActualizarBañoMuje(BañoMuje_BO objper)
        {
            BañoMuje_BO datos = (BañoMuje_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = "Update banio_muje set matriculabanio_muje= '" + datos.Matriculabanio_muje + "' ,luz='" + datos.Luz + "' ,agua='" + datos.Agua + "' ,espejo='" + datos.Espejo + "' ,jabon='" + datos.Jabon + "' ,gelantibacterial='" + datos.Gelantibacterial + "' ,basurero='" + datos.Basurero + "', lavabos='" + datos.Lavabos + "' , papel_servilletero='" + datos.Papel_servilletero + "' , inodoros='" + datos.Inodoros + "' , IDEdificio= '" + datos.IDEdificio1 + "' , idusuarioemp= '" + datos.Idusuarioemp + "'  where idbanio_muje='" + datos.Idbanio_muje + "'";
            ejecutar.CommandText = InsSQL; 
            int valor = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }









        public int Eliminar_BañoMUJE(BañoMuje_BO objpro)
        {

            BañoMuje_BO Dato = (BañoMuje_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("Delete from banio_muje where idbanio_muje= '{0}'", Dato.Idbanio_muje);
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }


        public string ID_Edificio(string letra_Edificio)
        {
            string ID = "";
            InsSQL = string.Format("Select ID_Edificio from edificio where letra_Edificio ='{0}'", letra_Edificio);
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@_Edificio", ID);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                ID = Convert.ToString(leer["ID_Edificio"].ToString());
            }
            return ID;

        }




        public ArrayList Lista_EdificioMUJE()
        {

            InsSQL = "Select letra_Edificio from  edificio";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["letra_Edificio"]);
            }

            BD.cerrarBD();
            return Lista;
        }


        public string idusuarioemp(string nombre_usuarioemp)
        {
            string id = "";
            InsSQL = string.Format("Select idusuarioemp from usuarioemp where nombre_usuarioemp ='{0}'", nombre_usuarioemp);
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




        public ArrayList Lista_usuarioempMUJE()
        {

            InsSQL = "Select nombre_usuarioemp from  usuarioemp";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            MySqlDataReader Leer;
            ArrayList Lista = new ArrayList();
            Leer = adp.ExecuteReader();
            while (Leer.Read())
            {
                Lista.Add(Leer["nombre_usuarioemp"]);
            }

            BD.cerrarBD();
            return Lista;
        }













    }
}
