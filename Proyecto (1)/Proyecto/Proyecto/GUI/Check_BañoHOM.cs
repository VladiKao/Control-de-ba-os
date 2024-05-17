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


namespace RegistroBaño
{
    public partial class Registro_Baño : Form
    {


              BañoHom_BO objdato = new BañoHom_BO();
        Registro_Baño_DAO objecutar = new Registro_Baño_DAO();







        public Registro_Baño()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LBL_RegistroBaño_Click(object sender, EventArgs e)
        {

        }

        private void LBL_IdBaño_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Baño_Resize(object sender, EventArgs e)
        {




        }

        private void Registro_Baño_Load(object sender, EventArgs e)
        {

            cargar_edificio();

        }

        public void cargar_edificio()
        {
            ArrayList ListaEdificio;
            ListaEdificio = objecutar.Lista_Edificio();
            Cmb_edificio.Items.Clear();
            for (int i = 0; i < ListaEdificio.Count; i++)
            {
                Cmb_edificio.Items.Add(ListaEdificio[i].ToString());
            }
        }


        private void LLenar_DatosGrid()
        {
            dataGridView1.DataSource = objecutar.Tabla_BañoHOM();

        }

        private void Btn_GuardarBaño_Click(object sender, EventArgs e)
        {



            
            objdato.Inodoros = int.Parse(TXT_NoINIDORO.Text);
            objdato.Basurero = TXT_NoPapeleras.Text;



            if (objecutar.GuardarRegistro_Baño(objdato) == 1)
            {

                MessageBox.Show("Datos Guardados", "Usuario", MessageBoxButtons.OK);
                LLenar_DatosGrid();

            }

            TXT_NoINIDORO.Clear();
            TXT_NoPapeleras.Clear();
           

        }

        private void TXT_NoINIDORO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnModificarBaño_Click(object sender, EventArgs e)
        {
            objdato.Inodoros = int.Parse(TXT_NoINIDORO.Text);
            objdato.Basurero = TXT_NoPapeleras.Text;


            if (objecutar.Atualizar_Baño(objdato) == 1)
            {

                MessageBox.Show("¡Datos Guardados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                LLenar_DatosGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Fila = e.RowIndex;

            TXT_NoINIDORO.Text = dataGridView1.Rows[Fila].Cells[0].Value.ToString();
            
        }

        private void BtnEliminarBaño_Click(object sender, EventArgs e)
        {
            objdato.Idbanio_hom = int.Parse(Txt_BuscarBaño.Text);


            if (objecutar.Eliminar_Baño(objdato) == 1)
            {

                MessageBox.Show("¡Datos Eliminados  Exitosamente!", "Usuario", MessageBoxButtons.OK);
                LLenar_DatosGrid();
            }

        }



        private void BtnBuscarBaño_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscarBaño_Click_1(object sender, EventArgs e)
        {
            LLenar_DatosGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cmb_edificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            objdato.ID_Edificio1 = int.Parse(objecutar.ID_Edificio(Cmb_edificio.Text));
        }

    }
}
