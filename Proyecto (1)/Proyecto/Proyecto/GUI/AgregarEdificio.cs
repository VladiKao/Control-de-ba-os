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
    public partial class AgregarEdificio : Form
    {


        EDIFICIO_BO datos = new EDIFICIO_BO();
        Edificio_DAO ejecutar = new Edificio_DAO();
        string InsSQL;

        CONEXION_DAO BD = new CONEXION_DAO();

        private DataTable objdt = new DataTable();
        private DataSet objds = new DataSet();
        public AgregarEdificio()
        {
            InitializeComponent();
        }

        private void AgregarEdificio_Load(object sender, EventArgs e)
        {

            Llenar_DataGrid();
            objdt = ejecutar.Tabla_Edificio();
            objds.Tables.Add(objdt);
            dtgv_Edificio.DataSource = objdt;
            filtro_datagrid();

        }

        private void filtro_datagrid()
        {

            dtgv_Edificio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void Llenar_DataGrid()
        {
            dtgv_Edificio.DataSource = ejecutar.Tabla_Edificio();
        }






        private void dtgv_Edificio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
           txt_Edificio.Text = dtgv_Edificio.Rows[fila].Cells[0].Value.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {


            datos.Letra_Edificio = txt_Edificio.Text;





            if (ejecutar.guardar_edificio(datos) == 1)
            {
                MessageBox.Show("Datos guardados");
                Llenar_DataGrid();


            }
            else
            {
                MessageBox.Show("Se ha producido un error al guardar los datos");
            }






        }

        private void txt_Edificio_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", objdt.Columns[1].ColumnName, "]");
            objdt.DefaultView.Sort = fieldName;
            DataView view = objdt.DefaultView;
            view.RowFilter = string.Empty;
            if (txt_Edificio.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + txt_Edificio.Text + "%'";
            }
            dtgv_Edificio.DataSource = view;





        }

        private void ptb_Cerrrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
