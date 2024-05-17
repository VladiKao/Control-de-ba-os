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
    class Registro_Baño_DAO
    {


        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;


        public int GuardarRegistro_Baño(BañoHom_BO objper)
        {

            BañoHom_BO Dato = (BañoHom_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into banio_hom(matriculabanio_hom,luz,agua,espejo,jabon,gelantibacterial,basurero,lavabos,papel_servilletero,inodoros,idusuarioemp) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9},{10});", Dato.Matriculabanio_hom, Dato.Luz,Dato.Agua,Dato.Espejo,Dato.Jabon, Dato.Gelantibacterial,Dato.Basurero,Dato.Lavabos, Dato.Papel_servilletero,Dato.Inodoros,Dato.Idusuarioemp);
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

        public DataTable Tabla_BañoHOM()
        {


            InsSQL = "Select banio_hom.idbanio_hom, banio_hom.matriculabanio_hom,banio_hom.luz,banio_hom.agua,banio_hom.espejo,banio_hom.jabon,banio_hom.gelantibacterial,banio_hom.basurero,banio_hom.lavabos,banio_hom.papel_servilletero,banio_hom.inodoros, usuarioemp.nombre_usuarioemp from banio_hom  inner join usuarioemp on banio_hom.idusuarioemp=usuarioemp.idusuarioemp";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;


        }




        public string ID_BañoHOM(string matriculabanio_hom)
        {
            string id = "";
            InsSQL = string.Format("Select idbanio_hom from banio_hom where matriculabanio_hom = '{0}'", matriculabanio_hom);
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@banio_hom", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idbanio_hom"].ToString());
            }
            return id;

           




        }




        public int Atualizar_Baño(BañoHom_BO objpro)


        {

            BañoHom_BO Dato = (BañoHom_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("Update banio_hom set matriculabanio_hom= '{0}', luz='{1}',agua='{2}',espejo='{3}',jabon='{4}',gelantibacterial='{5}',basurero='{6}',lavabos='{7}',papel_servilletero='{8}',inodoros='{9}',idusuarioemp={10} where idbanio_hom = {11}", Dato.Matriculabanio_hom, Dato.Luz,Dato.Agua, Dato.Espejo, Dato.Jabon, Dato.Gelantibacterial, Dato.Basurero, Dato.Lavabos, Dato.Papel_servilletero, Dato.Inodoros, Dato.Idusuarioemp, Dato.Idbanio_hom);
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }



        public int Eliminar_Baño(BañoHom_BO objpro)
        {

            BañoHom_BO Dato = (BañoHom_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("Delete from banio_hom where idbanio_hom= {0}", Dato.Idbanio_hom);
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

      


        public ArrayList Lista_Edificio()
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




        public ArrayList Lista_usuarioemp()
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
