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
using Proyecto.GUI;
using Integrador_Baños.GUI;





namespace Proyecto.GUI
{
    public partial class Registro_Cubiculo : Form
    {

        CUBICULOS_BO objdato = new CUBICULOS_BO();
        Registro_Cubiculo_DAO objecutar = new Registro_Cubiculo_DAO();

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        
        


        public Registro_Cubiculo()
        {
            InitializeComponent();
        }

        private void LBL_IdBaño_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
           try
            { 
                objdato.Matricula_cubiculo =txt_mat.Text;
            objdato.Papelera = txt_papelera.Text;
            objdato.Papel = txt_papel.Text;
            objdato.Inodoro_roto = txt_roto.Text;
            objdato.Agua = txt_agua.Text;
            objdato.Puerta = txt_puerta.Text;

            
                if (objecutar.GuardarRegistro_Cubiculo(objdato) == 1)
                {

                    MessageBox.Show("Datos Guardados", "Usuario", MessageBoxButtons.OK);
                    LLenar_DatosGrid();
                }
                else
                {
                    MessageBox.Show("Error Al Guardar Los Datos", "Usuario", MessageBoxButtons.OK);
                }
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
            
        }
    


        private void LLenar_DatosGrid()
        {
            dtgv_CUB.DataSource = objecutar.Tabla_Cubiculos();

        }

        private void Registro_Cubiculo_Load(object sender, EventArgs e)
        {
            dt = objecutar.Tabla_Cubiculos();
            ds.Tables.Add(dt);
            dtgv_CUB.DataSource = dt;
            filtro_datagrid();
            LLenar_DatosGrid();
           // cargar_bañohom();
            //cargar_bañomuje();
        }

        private void filtro_datagrid()
        {
            dtgv_CUB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                objdato.Idcubiculo=int.Parse(txt_ID.Text);
                if (objecutar.Eliminar_Cubiculos(objdato) == 1)
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

    

        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                LLenar_DatosGrid();
                Txt_BuscarProducto.Clear();
            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }

        }

        private void BtnModificarEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_modificardatoscubiculo_Click(object sender, EventArgs e)
        {

           try
           {
                objdato.Idcubiculo = int.Parse(txt_ID.Text);
                objdato.Matricula_cubiculo = txt_mat.Text;
                objdato.Papelera = txt_papelera.Text;
                objdato.Papel = txt_papel.Text;
                objdato.Inodoro_roto = txt_roto.Text;
                objdato.Agua = txt_agua.Text;
                objdato.Puerta = txt_puerta.Text;   
                if (objecutar.Atualizar_Cubiculo(objdato) == 1)
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

       
        
        
        
        
        
        
        
        
        
        
        //botones que se borraron del diseño estan con "//"
        
        
        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

            




                
       // }

       // private void groupBox2_Enter(object sender, EventArgs e)
       // {
           
        //}

      //  private void groupBox3_Enter(object sender, EventArgs e)
       // {
           
       // }

       // private void groupBox4_Enter(object sender, EventArgs e)
       //{
           
       // }

      //  private void groupBox5_Enter(object sender, EventArgs e)
      //  {
            
       // }


       // public void cargar_bañohom()
       // {
        //    ArrayList ListaBH;
         //   ListaBH = objecutar.Lista_banioHOM();
         //   cmb_bañohombre.Items.Clear();
        //    for (int i = 0; i < ListaBH.Count; i++)
         //   {
            //    cmb_bañohombre.Items.Add(ListaBH[i].ToString());
          //  }
       // }

       // public void cargar_bañomuje()
      //  {

          //  ArrayList ListaBM;
           // ListaBM = objecutar.Lista_banioMUJE();
           // cmb_bañomujer.Items.Clear();
           // for (int i = 0; i < ListaBM.Count; i++)
            //{
            //    cmb_bañomujer.Items.Add(ListaBM[i].ToString());
            //}




       //}

       // private void cmb_bañohombre_SelectedIndexChanged(object sender, EventArgs e)
        //{
          //  objdato.Idbanio_hom = int.Parse(objecutar.idbanio_hom(cmb_bañohombre.Text));
       // }

       // private void cmb_bañomujer_SelectedIndexChanged(object sender, EventArgs e)
        //{
          //  objdato.Idbanio_muje = int.Parse(objecutar.idbanio_muje(cmb_bañomujer.Text));
        //}

        private void dtgv_CUB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;


            try

            {
                txt_ID.Text = dtgv_CUB.Rows[Fila].Cells[0].Value.ToString();
            txt_mat.Text = dtgv_CUB.Rows[Fila].Cells[1].Value.ToString();
            txt_papelera.Text = dtgv_CUB.Rows[Fila].Cells[2].Value.ToString();
            txt_papel.Text = dtgv_CUB.Rows[Fila].Cells[3].Value.ToString();
            txt_roto.Text = dtgv_CUB.Rows[Fila].Cells[4].Value.ToString();
            txt_agua.Text = dtgv_CUB.Rows[Fila].Cells[5].Value.ToString();
            txt_puerta.Text = dtgv_CUB.Rows[Fila].Cells[6].Value.ToString();
            }
            catch

            {

            }
        }

        private void chk_PAPELERA_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void chk_PAPEL_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chk_INODOROROTO_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chk_AGUA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chk_PUERTA_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (Txt_BuscarProducto.Text != string.Empty)
            {
                view.RowFilter = fieldName + " LIKE '%" + Txt_BuscarProducto.Text + "%'";
            }
            dtgv_CUB.DataSource = view;
        }

        // private void radioButton1_CheckedChanged(object sender, EventArgs e)
        // {


        // }

        // private void radioButton3_CheckedChanged(object sender, EventArgs e)
        // {

        // }

        // private void radioButton5_CheckedChanged(object sender, EventArgs e)
        //  {

        // }

        //private void radioButton7_CheckedChanged(object sender, EventArgs e)
        //  {

        // }

        // private void radioButton9_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
