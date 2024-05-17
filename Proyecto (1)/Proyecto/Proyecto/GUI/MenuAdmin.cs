using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.GUI;
using Proyecto.BO;
using muc_ups_29_02_2020.GUI;
using Proyecto.DAO;
using RegistroBaño;


namespace Proyecto.GUI
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            customizedDesing();


        }

        private void customizedDesing()
        {

            PanelEmpleado.Visible = false;
            PanelProductos.Visible = false;
            PanelBaños.Visible = false;
            PanelCubiculos.Visible = false;
            PanelReportes.Visible = false;

        }


        private void hideSubMenu()
        {
            if (PanelEmpleado.Visible == true)
                PanelEmpleado.Visible = false;
            if (PanelProductos.Visible == true)
                PanelProductos.Visible = false;
            if (PanelBaños.Visible == true)
                PanelBaños.Visible = false;
            if (PanelCubiculos.Visible == true)
                PanelCubiculos.Visible = false;
            if (PanelReportes.Visible == true)
                PanelReportes.Visible = false;


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



        private void AbrirFromregisEmpelado(object Registro_Empleado)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRegEmpl = Registro_Empleado as Form;

            FormRegEmpl.TopLevel = false;
            FormRegEmpl.Dock = DockStyle.Fill;

            this.PanelContenedor.Controls.Add(FormRegEmpl);
            this.PanelContenedor.Tag = FormRegEmpl;
            FormRegEmpl.Show();


        }


      


        private void AbrirFromRegProductos(object Registro_Producto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRegProduc = Registro_Producto as Form;

            FormRegProduc.TopLevel = false;
            FormRegProduc.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormRegProduc);
            this.PanelContenedor.Tag = FormRegProduc;
            FormRegProduc.Show();


        }










        private void AbrirFromRegisBaño(object Registro_Baño)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FromRegistrobaño = Registro_Baño as Form;

            FromRegistrobaño.TopLevel = false;
            FromRegistrobaño.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FromRegistrobaño);
            this.PanelContenedor.Tag = FromRegistrobaño;

            FromRegistrobaño.Show();


        }

        private void AbrirFromRegCubiculo(object Registro_Cubiculo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRegCubi = Registro_Cubiculo as Form;

            FormRegCubi.TopLevel = false;
            FormRegCubi.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormRegCubi);
            this.PanelContenedor.Tag = FormRegCubi;
            FormRegCubi.Show();


        }




        private void AbrirFromReporteProducto(object Reporte_Producto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRepProducto = Reporte_Producto as Form;

            FormRepProducto.TopLevel = false;
            FormRepProducto.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormRepProducto);
            this.PanelContenedor.Tag = FormRepProducto;
            FormRepProducto.Show();
        }



        private void AbrirFromReporteBaños(object Reporte_Baños)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRepBaños = Reporte_Baños as Form;

            FormRepBaños.TopLevel = false;
            FormRepBaños.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(FormRepBaños);
            this.PanelContenedor.Tag = FormRepBaños;
            FormRepBaños.Show();
        }


        private void AbrirFromReporteCubiculos(object Reporte_Cubiculo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form FormRepCubiculo = Reporte_Cubiculo as Form;

            FormRepCubiculo.TopLevel = false;
            FormRepCubiculo.Dock = DockStyle.Fill;


            this.PanelContenedor.Controls.Add(FormRepCubiculo);
            this.PanelContenedor.Tag = FormRepCubiculo;
            FormRepCubiculo.Show();
        }






        private void Pct_LogoLetras_Click(object sender, EventArgs e)
        {

        }

        private void Ptb_LogoS_Click(object sender, EventArgs e)
        {

        }

        private void SubBtnReporteBaños_Click(object sender, EventArgs e)
        {
            AbrirFromReporteBaños(new Reporte_Baños());

            hideSubMenu();
        }

        private void SubBtnReporteCubiculos_Click(object sender, EventArgs e)
        {
            AbrirFromReporteCubiculos(new Reporte_Cubiculo());

            hideSubMenu();
        }

        private void SubBtnRegistroEmpleado_Click(object sender, EventArgs e)
        {

            AbrirFromregisEmpelado(new Registro_Empleado());

            hideSubMenu();
        }

        private void BtnProductosEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFromRegProductos(new Registro_Producto());
            hideSubMenu();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelEmpleado);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelProductos);
        }

        private void BtnBaños_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelBaños);
        }

        private void SubBtnRegistroBaños_Click(object sender, EventArgs e)
        {
            AbrirFromRegisBaño(new BañoHombres ());

            hideSubMenu();
        }

        private void BtnCubiculos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelCubiculos);
        }

        private void SubBtnResgistroCubiculos_Click(object sender, EventArgs e)
        {
            AbrirFromRegCubiculo(new Registro_Cubiculo());

            hideSubMenu();

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelReportes);
        }

        private void SubBtnReporteProduc_Click(object sender, EventArgs e)
        {
            AbrirFromReporteProducto(new Reporte_Producto());

            hideSubMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
