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
    class Registro_Producto_DAO
    {




        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;


        public int GuardarRegistro_Producto(PRODUCTO_BO objper)
        {

            PRODUCTO_BO Dato = (PRODUCTO_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into productos(Nombre_pro) values('{0}');", Dato.Nombre_Producto1);
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

        public DataTable Tabla_Producto()
        {


            InsSQL = "Select * from productos";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir);
            return TablaVir;


        }
        public string ID_Producyo(string Registro_Producto)
        {
            string id = "";
            InsSQL = "Select idproductos from productos where productos ='" + Registro_Producto + "'";
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@productos", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idproductos"].ToString());
            }
            return id;



        }

       

        public int Atualizar_Producto(PRODUCTO_BO objpro)


        {

            PRODUCTO_BO Dato = (PRODUCTO_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = "Update productos set nombre_pro= '" + Dato.Nombre_Producto1 + "' where idproductos='" + Dato.ID_Producto1 + "'";
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();


            
            if (folio <= 0)
            {
               return 0;
            }
            return 1;
        }


        public int Eliminar_Producto(PRODUCTO_BO objpro)


        {

            PRODUCTO_BO Dato = (PRODUCTO_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("Delete from productos where idproductos= {0}", Dato.ID_Producto1);
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }



    } 
}
