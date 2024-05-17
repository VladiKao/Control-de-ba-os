using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.BO;
using Proyecto.DAO;
using MySql.Data.MySqlClient;


namespace Proyecto.GUI
{
    public partial class Reporte_Producto : Form
    {


        Registro_Producto_DAO objecutar = new Registro_Producto_DAO();
        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        string InsSQL; 




        public Reporte_Producto()
        {
            InitializeComponent();
        }

        private void Generar_Reporte()
        {

            Registro_Producto_DAO ObjReporte = new Registro_Producto_DAO();
            string InsSQL = "Select clave, estado from producto";



        }

        private void Reporte_Producto_Load(object sender, EventArgs e)
        {

        }
    }


}     
    
