using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto.BO;
using Proyecto.DAO;
using Proyecto.GUI;



namespace Proyecto.GUI
{
    public partial class Registro_Empleado : Form
    {


        EMPLEADO_BO objdato = new EMPLEADO_BO();
        Registro_Empleado_DAO objecutar = new Registro_Empleado_DAO();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();






        public Registro_Empleado()
        {
            InitializeComponent();
        }

        private void Lbl_pais_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Empleado_Load(object sender, EventArgs e)
        {
            // cargardatoscombo();

            dt = objecutar.Tabla_empleado();
            ds.Tables.Add(dt);
            Dgvt_Empleado.DataSource = dt;
            filtro_datagrid();
            cargar_colonia();
            cargar_estado();
            cargar_municipio();
            cargar_rol();
            cargar_turno();
            LLenar_DatosGrid();
        }

        private void filtro_datagrid()
        {
            Dgvt_Empleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Nombre_usuarioemp = txt_NombreEmpledo.Text;
                objdato.Apellido_paterno = txt_PrimerApellidoEMPELDO.Text;
                objdato.Apellido_materno = txt_segundoapellido.Text;
                objdato.Edad1 = int.Parse(txt_edaddeempledo.Text);
                objdato.Contrasenia = txt_CONTRA.Text;
                objdato.Calle = txt_calle.Text;
                objdato.Cruzamientos = txt_CRUZA.Text;
                objdato.Casa = int.Parse(txt_CASA.Text);


                        
            
                if (objecutar.GuardarRegistro_Empleado(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar Los Datos", "Usuario", MessageBoxButtons.OK);
                }

                txt_NombreEmpledo.Clear();
                txt_PrimerApellidoEMPELDO.Clear();
                txt_segundoapellido.Clear();
                txt_edaddeempledo.Clear();
                txt_CONTRA.Clear();
                txt_calle.Clear();
                txt_CRUZA.Clear();
                txt_CASA.Clear();
                comboBox1.Text = "";
                cmb_COl.Text = "";
                CbxEstado1.Text = "";
                cbo_tipodeempleado.Text = "";
                cmb_TURNO.Text = "";

            }

            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
           
        }




    

        private void cbo_tipodeempleado_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


              objdato.Idrol = int.Parse(objecutar.idrol(cbo_tipodeempleado.Text));

            }
            catch
            {


            }





            


        }

        private void txt_municipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_colonia_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LLenar_DatosGrid()
        {
            Dgvt_Empleado.DataSource = objecutar.Tabla_empleado();

        }


        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Idusuarioemp = int.Parse(txt_ID.Text);
                objdato.Nombre_usuarioemp = txt_NombreEmpledo.Text;
                objdato.Apellido_paterno = txt_PrimerApellidoEMPELDO.Text;
                objdato.Apellido_materno = txt_segundoapellido.Text;
                objdato.Edad1 = int.Parse(txt_edaddeempledo.Text);
                objdato.Contrasenia = txt_CONTRA.Text;
                objdato.Calle = txt_calle.Text;
                objdato.Cruzamientos = txt_CRUZA.Text;
                objdato.Casa = int.Parse(txt_CASA.Text);
                if (objecutar.Atualizar_empleado(objdato) == 1)
                {

                    MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
            }

            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }


    

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
        {

            AgregarFoto frm = new AgregarFoto();
            frm.TopLevel = true;
            frm.Size = new Size(527, 324);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {

                LLenar_DatosGrid();

                Txt_BuscarEmpleado.Clear();
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
            objdato.Idusuarioemp = int.Parse(txt_ID.Text);

           

            
            if (objecutar.Eliminar_Empleado(objdato) == 1)
            {

                MessageBox.Show("¡Datos Eliminados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                LLenar_DatosGrid();
            }

            txt_NombreEmpledo.Clear();
            txt_PrimerApellidoEMPELDO.Clear();
            txt_segundoapellido.Clear();
            txt_edaddeempledo.Clear();
            Txt_BuscarEmpleado.Clear();
            txt_CONTRA.Clear();
            txt_calle.Clear();
            txt_CRUZA.Clear();
            txt_CASA.Clear();
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           try {  

                int Fila = e.RowIndex;


            


                txt_ID.Text = Dgvt_Empleado.Rows[Fila].Cells[0].Value.ToString();
            txt_NombreEmpledo.Text = Dgvt_Empleado.Rows[Fila].Cells[1].Value.ToString();
            txt_PrimerApellidoEMPELDO.Text = Dgvt_Empleado.Rows[Fila].Cells[2].Value.ToString();
            txt_segundoapellido.Text = Dgvt_Empleado.Rows[Fila].Cells[3].Value.ToString();
            txt_edaddeempledo.Text = Dgvt_Empleado.Rows[Fila].Cells[4].Value.ToString();
            txt_CONTRA.Text = Dgvt_Empleado.Rows[Fila].Cells[5].Value.ToString();
            txt_calle.Text = Dgvt_Empleado.Rows[Fila].Cells[6].Value.ToString();
            txt_CRUZA.Text = Dgvt_Empleado.Rows[Fila].Cells[7].Value.ToString();
            txt_CASA.Text = Dgvt_Empleado.Rows[Fila].Cells[8].Value.ToString();
            comboBox1.Text = Dgvt_Empleado.Rows[Fila].Cells[9].Value.ToString();
            cmb_COl.Text = Dgvt_Empleado.Rows[Fila].Cells[10].Value.ToString();

            CbxEstado1.Text = Dgvt_Empleado.Rows[Fila].Cells[11].Value.ToString();
            cbo_tipodeempleado.Text = Dgvt_Empleado.Rows[Fila].Cells[12].Value.ToString();
            cmb_TURNO.Text = Dgvt_Empleado.Rows[Fila].Cells[13].Value.ToString();


            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregarColonia_Click(object sender, EventArgs e)
        {
            AgregarColonia abrir = new AgregarColonia();
            abrir.Show();
        }

        private void cmb_COl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {




                objdato.ID_Col= int.Parse(objecutar.ID_colonia(cmb_COl.Text));
       
            
            
            }
            catch
            {

            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AgregarColonia abrir = new AgregarColonia();
            abrir.Show();
        }

        private void btn_municipio_Click(object sender, EventArgs e)
        {
            AgregarCiudad abrirc = new AgregarCiudad();
            abrirc.Show();
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            LblAgregarEstado abries = new LblAgregarEstado();
            abries.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

               objdato.IDciudad1 = int.Parse(objecutar.ID_Ciudad(comboBox1.Text));

            }
            catch
            {


            }






           
        }

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
           // objdato.Estado = int.Parse(objecutar.idEstado(CbxEstado.Text));
        }




        //Para Claves Foraneas 


        public void cargar_colonia()
        {
            ArrayList ListaColonia;
            ListaColonia = objecutar.Lista_Colonia();
            cmb_COl.Items.Clear();
            for (int i = 0; i < ListaColonia.Count; i++)
            {
                cmb_COl.Items.Add(ListaColonia[i].ToString());
            }
        }

        public void cargar_municipio()
        {
            ArrayList ListaMunicipio;
            ListaMunicipio = objecutar.Lista_Ciudad();
            comboBox1.Items.Clear();
            for (int i = 0; i < ListaMunicipio.Count; i++)
            {
                comboBox1.Items.Add(ListaMunicipio[i].ToString());
            }
        }

        public void cargar_estado()
        {
            ArrayList ListaEstado = new ArrayList();
            ListaEstado = objecutar.List_Estado();
            CbxEstado1.Items.Clear();
            for (int i = 0; i < ListaEstado.Count; i++)
            {
                CbxEstado1.Items.Add(ListaEstado[i].ToString());
            }
        }

        public void cargar_rol()
        {
            ArrayList Listarol;
            Listarol = objecutar.Lista_rol();
            cbo_tipodeempleado.Items.Clear();
            for (int i = 0; i < Listarol.Count; i++)
            {
                cbo_tipodeempleado.Items.Add(Listarol[i].ToString());
            }
        }

        public void cargar_turno()
        {

            ArrayList Listaturno;
            Listaturno = objecutar.Lista_turno();
           cmb_TURNO.Items.Clear();
            for (int i = 0; i < Listaturno.Count; i++)
            {
               cmb_TURNO.Items.Add(Listaturno[i].ToString());
            }




        }

        private void CbxEstado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objdato.Estado = int.Parse(objecutar.idEstado(CbxEstado1.Text));


            }
            catch
            {


            }

        }

        private void cmb_TURNO_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                objdato.Idturno = int.Parse(objecutar.idturno(cmb_TURNO.Text));
            }
            catch
            {


            }





            ;
        }

        private void txt_segundoapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_BuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (Txt_BuscarEmpleado.Text != string.Empty)
                {
                    view.RowFilter = fieldName + " LIKE '%" + Txt_BuscarEmpleado.Text + "%'";
                }
                Dgvt_Empleado.DataSource = view;
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
        }
    }
}
