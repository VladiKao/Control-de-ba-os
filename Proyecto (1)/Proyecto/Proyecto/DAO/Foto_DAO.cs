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
    class Foto_DAO
    {

        //Instancia a la clase Conexion (Conertar, Abrir y Cerrar)
        CONEXION_DAO BD= new CONEXION_DAO();

        //Comando para ejecutar (Insertar, Eliminar y Actualizar)
        MySqlCommand Ejecutar = new MySqlCommand();

        //Creamos una variable de instrucción para  eliminar, actualizar e Insertar
        string sentencia;


        //Método para Guardar Datos en la BD. 
        public int GuardarDatos(FOTO_BO ObjFoto)
        {
            FOTO_BO datos = (FOTO_BO)ObjFoto;
            Ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            sentencia = "Insert into fotos (nombrefoto) values ('" + datos.Nombrefoto + "')";
            Ejecutar.CommandText = sentencia;
            int acuse = Ejecutar.ExecuteNonQuery(); //Verifica si se llevo acabo
            BD.cerrarBD();
            if (acuse <= 0)
            {
                return 0;
            }
            return 1;

        }


        public DataTable TablaFoto()
        {
            sentencia = "Select * from fotos";
            MySqlDataAdapter adp = new MySqlDataAdapter(sentencia, BD.servidor());
            DataTable TablaVirtual = new DataTable();
            adp.Fill(TablaVirtual);
            return TablaVirtual;
        }








    }
}
