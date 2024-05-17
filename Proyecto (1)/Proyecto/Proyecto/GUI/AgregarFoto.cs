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

namespace Proyecto.GUI
{
    public partial class AgregarFoto : Form
    {

        Foto_DAO Ejecutar = new Foto_DAO();
        FOTO_BO datos = new FOTO_BO();




        public AgregarFoto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombre_imagen;
            int Fila = e.RowIndex;
            nombre_imagen = dataGridView1.Rows[Fila].Cells[0].Value.ToString();
            pbximagen.Load(Application.StartupPath + @"\Img\" + nombre_imagen);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.textBox1.Text = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pbximagen.ImageLocation = Direccion;
                pbximagen.SizeMode = PictureBoxSizeMode.StretchImage;

            }

           



        }

        private void GuardarFoto_Click(object sender, EventArgs e)
        {
            //************ Hacemos una copia de la imagen y lo enviamos a la carpeta Img del Proyecto           
            string Archivo;
            Archivo = System.IO.Path.GetFileNameWithoutExtension(textBox1.Text);
            Bitmap Picture = new Bitmap(textBox1.Text);
            //Cambiando esta Linea es como podemos cambiar el formato de la Copia.
            Picture.Save(Application.StartupPath + @"\Img\" + Archivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Se guardo la Copia correctamente");
            string NombreImagen = Archivo + ".jpg";

            datos.Nombrefoto = NombreImagen;

            if (Ejecutar.GuardarDatos(datos) == 1)
            {
                MessageBox.Show("Datos Guardados");
                RefrescarTabla();
            }
            else
            {
                MessageBox.Show("Error al Guardar Datos");
            }


        }
        public void RefrescarTabla()
        {
            dataGridView1.DataSource = Ejecutar.TablaFoto();
        }
        private void AgregarFoto_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }
    }
}

