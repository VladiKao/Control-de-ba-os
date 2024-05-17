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
    public partial class BañoHombres : Form
    {
        BañoHom_BO objdato = new BañoHom_BO();
        Registro_Baño_DAO objecutar = new Registro_Baño_DAO();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public BañoHombres()
        {
            InitializeComponent();
        }

        private void Btn_CheklisBaño_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BañoHombres_Load(object sender, EventArgs e)
        {
            dt = objecutar.Tabla_BañoHOM();
            ds.Tables.Add(dt);
            dtgv_bañohom.DataSource = dt;
            filtro_datagrid();
            LLenar_DatosGrid();
            cargar_empleado();
        }

        private void filtro_datagrid()
        {
            dtgv_bañohom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LLenar_DatosGrid()
        {
            dtgv_bañohom.DataSource = objecutar.Tabla_BañoHOM();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Matriculabanio_hom = txt_matBH.Text;
                objdato.Luz = txt_LUZ.Text;
                objdato.Agua = txt_AGUA.Text;
                objdato.Espejo = txt_ESPE.Text;
                objdato.Jabon = txt_JABON.Text;
                objdato.Gelantibacterial = txt_GEL.Text;
                objdato.Basurero = txt_BASU.Text;
                objdato.Lavabos = txt_LAV.Text;
                objdato.Papel_servilletero = txt_PAPEL.Text;
                objdato.Inodoros = int.Parse(txt_NumCubiculos.Text);
            


           

                if (objecutar.GuardarRegistro_Baño(objdato) == 1)
                {

                MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                LLenar_DatosGrid();
                }
               else
               {
                MessageBox.Show("Error Al Guardar Los Datos", "Usuario", MessageBoxButtons.OK);
               }

                   txt_matBH.Clear();
                   txt_NumCubiculos.Clear();

            }

            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
            MessageBox.Show("¿Desa cancelar?, se perderán todos los datos", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
        
        public void cargar_empleado()
        {

            ArrayList ListaEmpleado;
            ListaEmpleado = objecutar.Lista_usuarioemp();
            cmb_empleado.Items.Clear();
            for (int i = 0; i < ListaEmpleado.Count; i++)
            {
                cmb_empleado.Items.Add(ListaEmpleado[i].ToString());
            }




        }

        private void cmb_edificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {

             objdato.Idusuarioemp = int.Parse(objecutar.idusuarioemp(cmb_empleado.Text));

            }
            catch
            {


            }






            
        }

        

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Idbanio_hom = int.Parse(lbl_id.Text);
                if (objecutar.Eliminar_Baño(objdato) == 1)
                {
                    MessageBox.Show("¡Datos Eliminados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }

        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Idbanio_hom = int.Parse(lbl_id.Text);
                objdato.Matriculabanio_hom = txt_matBH.Text;
                objdato.Luz = txt_LUZ.Text;
                objdato.Agua = txt_AGUA.Text;
                objdato.Espejo = txt_ESPE.Text;
                objdato.Jabon = txt_JABON.Text;
                objdato.Gelantibacterial = txt_GEL.Text;
                objdato.Basurero = txt_BASU.Text;
                objdato.Lavabos = txt_LAV.Text;
                objdato.Papel_servilletero = txt_PAPEL.Text;
                objdato.Inodoros = int.Parse(txt_NumCubiculos.Text);

                if (objecutar.Atualizar_Baño(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar Los Datos", "Usuario", MessageBoxButtons.OK);
                }

                txt_matBH.Clear();
                txt_NumCubiculos.Clear();

            }

            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
            MessageBox.Show("¿Desa cancelar?, se perderán todos los datos", "Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        private void dtgv_bañohom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dtgv_bañohom_CellMouseClick_2(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;
            try

            {
                lbl_id.Text = dtgv_bañohom.Rows[Fila].Cells[0].Value.ToString();
                txt_matBH.Text = dtgv_bañohom.Rows[Fila].Cells[1].Value.ToString();
                txt_LUZ.Text = dtgv_bañohom.Rows[Fila].Cells[2].Value.ToString();
                txt_AGUA.Text = dtgv_bañohom.Rows[Fila].Cells[3].Value.ToString();
                txt_ESPE.Text = dtgv_bañohom.Rows[Fila].Cells[4].Value.ToString();
                txt_JABON.Text = dtgv_bañohom.Rows[Fila].Cells[5].Value.ToString();
                txt_GEL.Text = dtgv_bañohom.Rows[Fila].Cells[6].Value.ToString();
                txt_BASU.Text = dtgv_bañohom.Rows[Fila].Cells[7].Value.ToString();
                txt_LAV.Text = dtgv_bañohom.Rows[Fila].Cells[8].Value.ToString();
                txt_PAPEL.Text = dtgv_bañohom.Rows[Fila].Cells[9].Value.ToString();
                txt_NumCubiculos.Text = dtgv_bañohom.Rows[Fila].Cells[10].Value.ToString();
                cmb_empleado.Text = dtgv_bañohom.Rows[Fila].Cells[11].Value.ToString();
            }
            catch

            {

            }
        }

        private void Txt_buscarbaño_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txt_buscador_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (txt_buscador.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + txt_buscador.Text + "%'";
            }
            dtgv_bañohom.DataSource = view;
        }
    }
}
