﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.BO;
using System.Data;

namespace Proyecto.DAO
{
    class Registro_Cubiculo_DAO
    {


        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL;


        public int GuardarRegistro_Cubiculo(CUBICULOS_BO objper)
        {

            CUBICULOS_BO Dato = (CUBICULOS_BO)objper;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = string.Format("insert into cubiculos(matricula_cubiculo, papelera, papel, inodoro_roto,agua, puerta) values('{0}', '{1}','{2}','{3}','{4}','{5}');", Dato.Matricula_cubiculo, Dato.Papelera, Dato.Papel,Dato.Inodoro_roto,Dato.Agua, Dato.Puerta);
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

        public DataTable Tabla_Cubiculos()
        {
            //cada uno tiene su tabala, es exclusivo de ese catalogo
            InsSQL = "Select cubiculos.idcubiculo ,cubiculos.matricula_cubiculo, cubiculos.papelera,cubiculos.papel,cubiculos.inodoro_roto,cubiculos.agua, cubiculos.puerta from cubiculos ";
            MySqlDataAdapter adp = new MySqlDataAdapter(InsSQL, BD.servidor());
            DataTable TablaVir = new DataTable();
            adp.Fill(TablaVir); //para pasar extraer los archivos
            return TablaVir;

        }

        public string idcubiculo(string Registro_Cubiculo)
        {
            string id = "";
            InsSQL = string.Format("Select idcubiculo from cubiculos where matricula_cubiculo = '{0}'", Registro_Cubiculo);
            MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            BD.abrirBD();
            adp.Parameters.AddWithValue("@cubiculo", id);
            MySqlDataReader leer = adp.ExecuteReader();
            if (leer.Read())
            {
                id = Convert.ToString(leer["idcubiculo"].ToString());
            }
            return id;



        }



        public int Atualizar_Cubiculo(CUBICULOS_BO objpro)


        {

            CUBICULOS_BO Dato = (CUBICULOS_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = "Update cubiculos set matricula_cubiculo= '" + Dato.Matricula_cubiculo + "', papelera= '" + Dato.Papelera + "', papel= '" + Dato.Papel + "', inodoro_roto= '" + Dato.Inodoro_roto + "', agua= '" + Dato.Agua + "', puerta= '" + Dato.Puerta + "' where idcubiculo='" + Dato.Idcubiculo + "' ";
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }



        public int Eliminar_Cubiculos(CUBICULOS_BO objpro)


        {

            CUBICULOS_BO Dato = (CUBICULOS_BO)objpro;
            ejecutar.Connection = BD.servidor();
            BD.abrirBD();
            InsSQL = "Delete from cubiculos Where idcubiculo='" + Dato.Idcubiculo + "'";
            ejecutar.CommandText = InsSQL;
            int folio = ejecutar.ExecuteNonQuery();
            BD.cerrarBD();



            if (folio <= 0)
            {
                return 0;
            }
            return 1;
        }


      //  public string idbanio_muje(string matriculabanio_muje)
       // {
        //   string id = "";
          //  InsSQL = string.Format("Select idbanio_muje from banio_muje where matriculabanio_muje ='{0}'", matriculabanio_muje);
          //  MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
          //  BD.abrirBD();
         //   adp.Parameters.AddWithValue("@banio_muje", id);
         //   MySqlDataReader leer = adp.ExecuteReader();
          //  if (leer.Read())
           // {
             //   id = Convert.ToString(leer["idbanio_muje"].ToString());
           // }
          //  return id;

        //}




       // public ArrayList Lista_banioMUJE()
        //{

          //  InsSQL = "Select matriculabanio_muje from  banio_muje";
          //  MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
          //  BD.abrirBD();
          //  MySqlDataReader Leer;
          //  ArrayList Lista = new ArrayList();
          //  Leer = adp.ExecuteReader();
         //   while (Leer.Read())
         //   {
           //     Lista.Add(Leer["matriculabanio_muje"]);
           // }

          //  BD.cerrarBD();
           // return Lista;
       // }






       // public string idbanio_hom(string matriculabanio_hom)
        //{
           // string id = "";
           // InsSQL = string.Format("Select idbanio_hom from banio_hom where matriculabanio_hom ='{0}'", matriculabanio_hom);
           // MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
          //  BD.abrirBD();
          //  adp.Parameters.AddWithValue("@banio_hom", id);
          //  MySqlDataReader leer = adp.ExecuteReader();
          //  if (leer.Read())
          //  {
           //     id = Convert.ToString(leer["idbanio_hom"].ToString());
          //  }
         //   return id;

       // }




       // public ArrayList Lista_banioHOM()
       // {

         //   InsSQL = "Select matriculabanio_hom from  banio_hom";
           // MySqlCommand adp = new MySqlCommand(InsSQL, BD.servidor());
            // BD.abrirBD();
           // MySqlDataReader Leer;
           // ArrayList Lista = new ArrayList();
           // Leer = adp.ExecuteReader();
           // while (Leer.Read())
           // {
             //   Lista.Add(Leer["matriculabanio_hom"]);
           // }

           // BD.cerrarBD();
           // return Lista;
       // }







    }
}
