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
    public partial class BañoMujeres : Form
    {

        BañoMuje_BO objdato = new BañoMuje_BO();
        Registro_BañoMuj_DAO objecutar = new Registro_BañoMuj_DAO();
        CONEXION_DAO objecutardao = new CONEXION_DAO();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();




        public BañoMujeres()
        {
            InitializeComponent();
        }
        private void Mostrar_Datos()
        {

            dt = objecutar.Tabla_BañoMUJ();
            ds.Tables.Add(dt);
            dtgv_bañomuje.DataSource = dt;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BañoMujeres_Load(object sender, EventArgs e)
        {


            cargar_empleado();
            LLenar_DatosGrid();


        }




        public void cargar_empleado()
        {

            ArrayList ListaEmpleado;
            ListaEmpleado = objecutar.Lista_usuarioempMUJE();
            cmb_empleado.Items.Clear();
            for (int i = 0; i < ListaEmpleado.Count; i++)
            {
                cmb_empleado.Items.Add(ListaEmpleado[i].ToString());
            }




        }

        private void LLenar_DatosGrid()
        {
            dtgv_bañomuje.DataSource = objecutar.Tabla_BañoMUJ();

        }

        private void Tbx_buscarchecklistbaño_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            { 
            objdato.Matriculabanio_muje = txt_matBMUJ.Text;

            objdato.Luz = txt_luz.Text;
            objdato.Agua = txt_agua.Text;
            objdato.Espejo = txt_espejo.Text;
            objdato.Jabon = txt_jabon.Text;
            objdato.Gelantibacterial = txt_gel.Text;
            objdato.Basurero = txt_basurero.Text;
            objdato.Lavabos = txt_basurero.Text;
            objdato.Papel_servilletero = txt_papel.Text;
            objdato.Inodoros = int.Parse(txt_NumCubiculos.Text);

           
                if (objecutar.GuardarRegistro_BañoMuj(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar Los Datos", "Usuario", MessageBoxButtons.OK);
                }

                txt_matBMUJ.Clear();
                txt_luz.Clear();
                txt_agua.Clear();
                txt_espejo.Clear();
                txt_jabon.Clear();
                txt_gel.Clear();
                txt_basurero.Clear();
                txt_lav.Clear();
                txt_papel.Clear();
                txt_NumCubiculos.Clear();

                cmb_empleado.Text = "";

            }


            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
           
        }



        private void btn_edificio_Click(object sender, EventArgs e)
        {
            AgregarEdificio abrir = new AgregarEdificio();
            abrir.Show();
        }

        private void dtgv_bañomuje_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int Fila = e.RowIndex;

                txt_ID.Text = dtgv_bañomuje.Rows[Fila].Cells[0].Value.ToString();
                txt_matBMUJ.Text = dtgv_bañomuje.Rows[Fila].Cells[1].Value.ToString();

                txt_luz.Text = dtgv_bañomuje.Rows[Fila].Cells[2].Value.ToString();
                txt_agua.Text = dtgv_bañomuje.Rows[Fila].Cells[3].Value.ToString();
                txt_espejo.Text = dtgv_bañomuje.Rows[Fila].Cells[4].Value.ToString();
                txt_jabon.Text = dtgv_bañomuje.Rows[Fila].Cells[5].Value.ToString();
                txt_gel.Text = dtgv_bañomuje.Rows[Fila].Cells[6].Value.ToString();
                txt_basurero.Text = dtgv_bañomuje.Rows[Fila].Cells[7].Value.ToString();
                txt_lav.Text = dtgv_bañomuje.Rows[Fila].Cells[8].Value.ToString();
                txt_papel.Text = dtgv_bañomuje.Rows[Fila].Cells[9].Value.ToString();
                txt_NumCubiculos.Text = dtgv_bañomuje.Rows[Fila].Cells[10].Value.ToString();

                cmb_empleado.Text = dtgv_bañomuje.Rows[Fila].Cells[11].Value.ToString();


            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

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

        private void chk_LUZSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_LUZNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_AGUASI_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_AGUANO_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_ESPSI_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_ESPNO_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_JABONSI_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_JABONNO_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void chk_GELSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_GELNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_BASUREROSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_BASURERONO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_LAVSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_LAVNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_PAPELSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_PAPELNO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminarBM_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Idbanio_muje = int.Parse(txt_ID.Text);
                if (objecutar.Eliminar_BañoMUJE(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Eliminados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }

            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
            
            {

            }


        }

        private void BtnModificarBM_Click(object sender, EventArgs e)
        {
            try
            {
            objdato.Matriculabanio_muje = txt_matBMUJ.Text;

            objdato.Luz = txt_luz.Text;
            objdato.Agua = txt_agua.Text;
            objdato.Espejo = txt_espejo.Text;
            objdato.Jabon = txt_jabon.Text;
            objdato.Gelantibacterial = txt_gel.Text;
            objdato.Basurero = txt_basurero.Text;
            objdato.Lavabos = txt_lav.Text;
            objdato.Papel_servilletero = txt_papel.Text;

            
                if (objecutar.ActualizarBañoMuje(objdato) == 1)
                {
                    LLenar_DatosGrid();
                    MessageBox.Show("Datos actualizados correctamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar datos");
                }
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
            { 

            }
        }

        private void btnBuscarBañoM_Click(object sender, EventArgs e)
        {
            try
            {
                LLenar_DatosGrid();
                txt_matBMUJ.Clear();
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
