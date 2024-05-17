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
    public partial class LblAgregarEstado : Form
    {

        ESTADO_BO datos = new ESTADO_BO();
        Estado_DAO ejecutar = new Estado_DAO();
        string InsSQL;

        CONEXION_DAO BD = new CONEXION_DAO();

        private DataTable objdt = new DataTable();
        private DataSet objds = new DataSet();



      

        private void filtro_datagrid()
        {

            dtgv_AgEstado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void Llenar_DataGrid()
        {
            dtgv_AgEstado.DataSource = ejecutar.Tabla_Estado();
        }






        public LblAgregarEstado()
        {
            InitializeComponent();
        }

        private void BTN_AgregarEstado_Click(object sender, EventArgs e)
        {






        }

        private void AgregarEstado_Load(object sender, EventArgs e)
        {
            Llenar_DataGrid();
            objdt = ejecutar.Tabla_Estado();
            objds.Tables.Add(objdt);
            dtgv_AgEstado.DataSource = objdt;
            filtro_datagrid();


        }

        private void BtnGuardarEstado_Click(object sender, EventArgs e)
        {
            //Datos para la tabla/clase estado


         
            datos.nombre_estado1= txt_AgESTADO.Text;
          

            
            

            if (ejecutar.guardar_estado(datos) == 1)
            {
                MessageBox.Show("Datos guardados");
                Llenar_DataGrid();
                

            }
            else
            {
                MessageBox.Show("Se ha producido un error al guardar los datos");
            }








        }

        private void dtgv_AgEstado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            txt_AgESTADO.Text =dtgv_AgEstado.Rows[fila].Cells[0].Value.ToString();
          //  txt_AgESTADO.Text = dtgv_AgEstado.Rows[fila].Cells[1].Value.ToString();
        }

        private void txt_AgESTADO_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", objdt.Columns[1].ColumnName, "]");
            objdt.DefaultView.Sort = fieldName;
            DataView view = objdt.DefaultView;
            view.RowFilter = string.Empty;
            if (txt_AgESTADO.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + txt_AgESTADO.Text + "%'";
            }
            dtgv_AgEstado.DataSource = view;
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgv_AgEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
