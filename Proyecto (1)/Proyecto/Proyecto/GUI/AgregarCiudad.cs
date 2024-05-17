using System;
using System.Collections;
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
    public partial class AgregarCiudad : Form
    {

        CIUDAD_BO datos = new CIUDAD_BO();
        Ciudad_DAO ejecutar = new Ciudad_DAO();
        string InsSQL;

        CONEXION_DAO BD = new CONEXION_DAO();

        private DataTable objdt = new DataTable();
        private DataSet objds = new DataSet();



        public AgregarCiudad()
        {
            InitializeComponent();
        }

        private void AgregarCiudad_Load(object sender, EventArgs e)
        {
            Llenar_DataGrid();
            objdt = ejecutar.Tabla_Estado();
            objds.Tables.Add(objdt);
            dtgv_Agciudad.DataSource = objdt;
            filtro_datagrid();


            cargar_estado();

            //cargardatoscombo();
        }


        private void filtro_datagrid()
        {

            dtgv_Agciudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void Llenar_DataGrid()
        {
            dtgv_Agciudad.DataSource = ejecutar.Tabla_Estado();
        }



        private void btn_guardarciudad_Click(object sender, EventArgs e)
        {

            //Datos para la tabla/clase 



            datos.Nombre_Ciudad1 = txt_Agciudad.Text;




            if (ejecutar.guardar_ciudad(datos) == 1)
            {
                MessageBox.Show("Datos guardados");
                Llenar_DataGrid();

            }
            else
            {
                MessageBox.Show("Se ha producido un error al guardar los datos");
            }





        }

        private void txt_Agciudad_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", objdt.Columns[1].ColumnName, "]");
            objdt.DefaultView.Sort = fieldName;
            DataView view = objdt.DefaultView;
            view.RowFilter = string.Empty;
            if (txt_Agciudad.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + txt_Agciudad.Text + "%'";
            }
            dtgv_Agciudad.DataSource = view;
        }


        public void List_Estado()
        {
            ArrayList ListaEs;
            ListaEs = ejecutar.Lista_Estado();
            for (int i = 0; i < ListaEs.Count; i++)
            {
                comboBox2.Items.Add(ListaEs[i].ToString());

            }



        }

        private void dtgv_Agciudad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int fila = e.RowIndex;
            txt_Agciudad.Text = dtgv_Agciudad.Rows[fila].Cells[0].Value.ToString();
            txt_Agciudad.Text = dtgv_Agciudad.Rows[fila].Cells[1].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            datos.IdEstado = int.Parse(ejecutar.idestado(comboBox2.Text));


        }

        private void cargardatoscombo()
        {


            comboBox2.DataSource = ejecutar.Lista_Estado();
            comboBox2.DisplayMember = "nombre_estado ";

        }






        public void cargar_estado()
        {
            ArrayList ListaEstado;
            ListaEstado = ejecutar.Lista_Estado();
            comboBox2.Items.Clear();
            for (int i = 0; i < ListaEstado.Count; i++)
            {
                comboBox2.Items.Add(ListaEstado[i].ToString());
            }




        }

        private void dtgv_Agciudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
