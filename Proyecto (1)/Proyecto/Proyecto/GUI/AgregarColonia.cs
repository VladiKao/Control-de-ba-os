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
    public partial class AgregarColonia : Form
    {
        COLONIA_BO datos = new COLONIA_BO();
        Colonia_DAO ejecutar = new Colonia_DAO();
        string InsSQL;

        CONEXION_DAO BD = new CONEXION_DAO();




        private DataTable objdt = new DataTable();
        private DataSet objds = new DataSet();




        public AgregarColonia()
        {
            InitializeComponent();
        }

        private void txt_AgCol_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", objdt.Columns[1].ColumnName, "]");
            objdt.DefaultView.Sort = fieldName;
            DataView view = objdt.DefaultView;
            view.RowFilter = string.Empty;
            if (txt_AgCol.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + txt_AgCol.Text + "%'";
            }
            dataGridView1.DataSource = view;
        }

        private void AgregarColonia_Load(object sender, EventArgs e)
        {

            Llenar_DataGrid();
            objdt = ejecutar.Tabla_colonia();
            objds.Tables.Add(objdt);
            dataGridView1.DataSource = objdt;
            filtro_datagrid();


            cargar_municipio();


        }

        private void filtro_datagrid()
        {

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Llenar_DataGrid()
        {
            dataGridView1.DataSource = ejecutar.Tabla_colonia();
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

        private void dtgv_AgCol_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_AgCol.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
            txt_AgCol.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            //Datos para la tabla/clase colonia



            datos.Nombre_Colonia1 = txt_AgCol.Text;




            if (ejecutar.Guardar_Colonia(datos) == 1)
            {
                MessageBox.Show("Datos guardados");
                Llenar_DataGrid();

            }
            else
            {
                MessageBox.Show("Se ha producido un error al guardar los datos");
            }





        }

        private void dtgv_AgCol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.IdCiudad= int.Parse(ejecutar.ID_Ciudad(CbxCiudad.Text));
           
        }


        public void Lista_Ciu()
        {
            ArrayList ListaEs;
            ListaEs = ejecutar.Lista_Ciudad();
            for (int i = 0; i < ListaEs.Count; i++)
            {
                CbxCiudad.Items.Add(ListaEs[i].ToString());

            }






        }


        public void cargar_municipio()
        {
            ArrayList ListaMunicipio;
            ListaMunicipio = ejecutar.Lista_Ciudad();
            CbxCiudad.Items.Clear();
            for (int i = 0; i < ListaMunicipio.Count; i++)
            {
                CbxCiudad.Items.Add(ListaMunicipio[i].ToString());
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;

            txt_AgCol.Text = dataGridView1.Rows[Fila].Cells[0].Value.ToString();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

            