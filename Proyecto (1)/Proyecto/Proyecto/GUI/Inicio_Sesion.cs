using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.GUI;
using Proyecto.BO;
using Proyecto.DAO;
using Integrador_Baños.GUI;

namespace Proyecto.GUI
{
    public partial class Inicio_Sesion : Form
    {

        




        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {




        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tbx_Usuario_Enter(object sender, EventArgs e)
        {

            if (Tbx_Usuario.Text == "USUARIO")
            {

                Tbx_Usuario.Text = "";


            }


        }

        private void Tbx_Usuario_Leave(object sender, EventArgs e)
        {

            if (Tbx_Usuario.Text == "")

            {
                Tbx_Usuario.Text = "USUARIO";


            }




        }

        private void Tbx_Contraseña_Enter(object sender, EventArgs e)
        {

            if (Tbx_Contraseña.Text == "CONTRASEÑA")
            {

                Tbx_Contraseña.Text = "";
                Tbx_Contraseña.UseSystemPasswordChar = true;


            }


        }

        private void Tbx_Contraseña_Leave(object sender, EventArgs e)
        {


            if (Tbx_Contraseña.Text == "")

            {

                Tbx_Contraseña.Text = "CONTRASEÑA";
                Tbx_Contraseña.UseSystemPasswordChar = false;


            }

        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbx_Usuario.Text == "Admin" && Tbx_Contraseña.Text == "12")
                {
                    MenuAdmin formulario = new MenuAdmin();
                    formulario.Show();




                }

                else if (Tbx_Usuario.Text == "Admin" && Tbx_Contraseña.Text != "12")

                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta", " ", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                }


                if (Tbx_Usuario.Text == "Empleado")
                {

                    Empleado formulario = new Empleado();
                    formulario.Show();


                }
              

            }
            catch (InvalidCastException exUser)
            {
                MessageBox.Show(exUser.Message);

            }
         


        }

        private void Panel_Inicio_Paint(object sender, PaintEventArgs e)
        {








        }

        private void Tbx_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pict_Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
