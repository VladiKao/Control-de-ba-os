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
using Proyecto.GUI;
using Proyecto.DAO;
using Integrador_Baños.GUI;
using muc_ups_29_02_2020.GUI;


namespace Integrador_Baños.GUI
{
    public partial class Empleado : Form
    {





        public Empleado()
        {
            InitializeComponent();
            customizedDesing();
        }







        private void customizedDesing()
        {
            SubPanelCheck.Visible = false;
        }

        private void hideSubMenu()
        {
            if (SubPanelCheck.Visible == true)
                SubPanelCheck.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void AbrirFromCheckBaño(object BañoHombres)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormCheckBaño = BañoHombres as Form;

            FormCheckBaño.TopLevel = false;
            FormCheckBaño.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormCheckBaño);
            this.PanelContenedor.Tag = FormCheckBaño;
            FormCheckBaño.Show();


        }

        private void AbrirFromCheckProducto(object Registro_Producto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormCheckPro = Registro_Producto as Form;

            FormCheckPro.TopLevel = false;
            FormCheckPro.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormCheckPro);
            this.PanelContenedor.Tag = FormCheckPro;
            FormCheckPro.Show();


        }


        private void AbrirFromChecmujo(object BañoMujeres)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormCheckPro = BañoMujeres as Form;

            FormCheckPro.TopLevel = false;
            FormCheckPro.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormCheckPro);
            this.PanelContenedor.Tag = FormCheckPro;
            FormCheckPro.Show();


        }


        private void BtnRegistroEmpleado_Click(object sender, EventArgs e)
        {
            showSubMenu(SubPanelCheck);
                
                
                }

        private void SubBtnRegistroEmpleados_Click(object sender, EventArgs e)
        {
             
           
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            AbrirFromCheckBaño(new BañoHombres());
            hideSubMenu();
            
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PctSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            AbrirFromChecmujo(new BañoMujeres());
            hideSubMenu();
         }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
