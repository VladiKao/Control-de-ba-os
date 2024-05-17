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
using MySql.Data;




namespace Proyecto.GUI
{
    public partial class Registro_Producto : Form
    {

        CONEXION_DAO BD = new CONEXION_DAO();
        MySqlCommand ejecutar = new MySqlCommand();
        PRODUCTO_BO objdato = new PRODUCTO_BO();
        Registro_Producto_DAO objecutar = new Registro_Producto_DAO();
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public Registro_Producto()
        {
            InitializeComponent();
        }

        private void BunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_idproducto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_registroproducto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nombreproducto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_cantidadproducto_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_descripcionproducto_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Producto_Load(object sender, EventArgs e)
        {
            dt = objecutar.Tabla_Producto();
            ds.Tables.Add(dt);
            dataGridView1.DataSource = dt;
            filtro_datagrid();
            LLenar_DatosGrid();
        }

        private void filtro_datagrid()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
           
            try

            {
            objdato.Nombre_Producto1 = txt_nombreproducto.Text;


            

                if (objecutar.GuardarRegistro_Producto(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }


                txt_nombreproducto.Clear();

            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
   




        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int Fila = e.RowIndex;
            try

            {
                txt_ID.Text=dataGridView1.Rows[Fila].Cells[0].Value.ToString();
            txt_nombreproducto.Text = dataGridView1.Rows[Fila].Cells[1].Value.ToString();


            }
            catch

            {

            }

        }

        private void LLenar_DatosGrid()
        {
            dataGridView1.DataSource = objecutar.Tabla_Producto();

        }

        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.ID_Producto1 = int.Parse(txt_ID.Text);
                objdato.Nombre_Producto1 = txt_nombreproducto.Text;
                if (objecutar.Atualizar_Producto(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }

                else
                {
                    MessageBox.Show("Error", "Usuario", MessageBoxButtons.OK);
                }
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
          


        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {

            try
            {
                objdato.ID_Producto1 = int.Parse(txt_ID.Text);
           


                
                


                if (objecutar.Eliminar_Producto(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Eliminados  Exitosamente!", "Usuario", MessageBoxButtons.OK);

                }

            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
          
        }


        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                LLenar_DatosGrid();
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }

        }

        private void Txt_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (Txt_BuscarProducto.Text != string.Empty)
                {
                    view.RowFilter = fieldName + " LIKE '%" + Txt_BuscarProducto.Text + "%'";
                }
                dataGridView1.DataSource = view;
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }

    }
}
