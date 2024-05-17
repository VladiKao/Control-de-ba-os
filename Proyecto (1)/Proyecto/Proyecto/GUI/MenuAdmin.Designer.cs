namespace Proyecto.GUI
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.PanelContenedor = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelReportes = new System.Windows.Forms.Panel();
            this.SubBtnReporteCubiculos = new Guna.UI.WinForms.GunaGradientButton();
            this.SubBtnReporteBaños = new Guna.UI.WinForms.GunaGradientButton();
            this.SubBtnReporteProduc = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnReportes = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelCubiculos = new System.Windows.Forms.Panel();
            this.SubBtnResgistroCubiculos = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnCubiculos = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelBaños = new System.Windows.Forms.Panel();
            this.SubBtnRegistroBaños = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnBaños = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelProductos = new System.Windows.Forms.Panel();
            this.BtnProductosEmpleados = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnProductos = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelEmpleado = new Guna.UI.WinForms.GunaPanel();
            this.SubBtnRegistroEmpleado = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnEmpleados = new Guna.UI.WinForms.GunaGradientButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.Pct_LogoLetras = new System.Windows.Forms.PictureBox();
            this.Ptb_LogoS = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SideBar.SuspendLayout();
            this.PanelReportes.SuspendLayout();
            this.PanelCubiculos.SuspendLayout();
            this.PanelBaños.SuspendLayout();
            this.PanelProductos.SuspendLayout();
            this.PanelEmpleado.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_LogoLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_LogoS)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContenedor.BackgroundImage")));
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContenedor.Controls.Add(this.pictureBox2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.GradientBottomLeft = System.Drawing.Color.CornflowerBlue;
            this.PanelContenedor.GradientBottomRight = System.Drawing.Color.AliceBlue;
            this.PanelContenedor.GradientTopLeft = System.Drawing.Color.Indigo;
            this.PanelContenedor.GradientTopRight = System.Drawing.Color.Empty;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Quality = 10;
            this.PanelContenedor.Size = new System.Drawing.Size(698, 600);
            this.PanelContenedor.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(660, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.PanelReportes);
            this.SideBar.Controls.Add(this.BtnReportes);
            this.SideBar.Controls.Add(this.PanelCubiculos);
            this.SideBar.Controls.Add(this.BtnCubiculos);
            this.SideBar.Controls.Add(this.PanelBaños);
            this.SideBar.Controls.Add(this.BtnBaños);
            this.SideBar.Controls.Add(this.PanelProductos);
            this.SideBar.Controls.Add(this.BtnProductos);
            this.SideBar.Controls.Add(this.PanelEmpleado);
            this.SideBar.Controls.Add(this.BtnEmpleados);
            this.SideBar.Controls.Add(this.PanelLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GradientBottomLeft = System.Drawing.Color.Indigo;
            this.SideBar.GradientBottomRight = System.Drawing.Color.LightSkyBlue;
            this.SideBar.GradientTopLeft = System.Drawing.Color.Indigo;
            this.SideBar.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(200, 600);
            this.SideBar.TabIndex = 0;
            // 
            // PanelReportes
            // 
            this.PanelReportes.BackColor = System.Drawing.Color.Transparent;
            this.PanelReportes.Controls.Add(this.SubBtnReporteCubiculos);
            this.PanelReportes.Controls.Add(this.SubBtnReporteBaños);
            this.PanelReportes.Controls.Add(this.SubBtnReporteProduc);
            this.PanelReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelReportes.Location = new System.Drawing.Point(0, 479);
            this.PanelReportes.Name = "PanelReportes";
            this.PanelReportes.Size = new System.Drawing.Size(200, 121);
            this.PanelReportes.TabIndex = 9;
            // 
            // SubBtnReporteCubiculos
            // 
            this.SubBtnReporteCubiculos.AnimationHoverSpeed = 0.07F;
            this.SubBtnReporteCubiculos.AnimationSpeed = 0.03F;
            this.SubBtnReporteCubiculos.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnReporteCubiculos.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnReporteCubiculos.BorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteCubiculos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnReporteCubiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnReporteCubiculos.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnReporteCubiculos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnReporteCubiculos.ForeColor = System.Drawing.Color.White;
            this.SubBtnReporteCubiculos.Image = global::Proyecto.Properties.Resources.cleaning_door_knob_object_hygiene_icon_1336491;
            this.SubBtnReporteCubiculos.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnReporteCubiculos.Location = new System.Drawing.Point(0, 84);
            this.SubBtnReporteCubiculos.Name = "SubBtnReporteCubiculos";
            this.SubBtnReporteCubiculos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnReporteCubiculos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnReporteCubiculos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteCubiculos.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnReporteCubiculos.OnHoverImage = null;
            this.SubBtnReporteCubiculos.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnReporteCubiculos.Size = new System.Drawing.Size(200, 42);
            this.SubBtnReporteCubiculos.TabIndex = 4;
            this.SubBtnReporteCubiculos.Text = "Reporte Cubiculos";
            this.SubBtnReporteCubiculos.Click += new System.EventHandler(this.SubBtnReporteCubiculos_Click);
            // 
            // SubBtnReporteBaños
            // 
            this.SubBtnReporteBaños.AnimationHoverSpeed = 0.07F;
            this.SubBtnReporteBaños.AnimationSpeed = 0.03F;
            this.SubBtnReporteBaños.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnReporteBaños.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnReporteBaños.BorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteBaños.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnReporteBaños.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnReporteBaños.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnReporteBaños.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnReporteBaños.ForeColor = System.Drawing.Color.White;
            this.SubBtnReporteBaños.Image = global::Proyecto.Properties.Resources.house_sink_icon_icons_com_74378;
            this.SubBtnReporteBaños.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnReporteBaños.Location = new System.Drawing.Point(0, 42);
            this.SubBtnReporteBaños.Name = "SubBtnReporteBaños";
            this.SubBtnReporteBaños.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnReporteBaños.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnReporteBaños.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteBaños.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnReporteBaños.OnHoverImage = null;
            this.SubBtnReporteBaños.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnReporteBaños.Size = new System.Drawing.Size(200, 42);
            this.SubBtnReporteBaños.TabIndex = 3;
            this.SubBtnReporteBaños.Text = "Reporte Baños";
            this.SubBtnReporteBaños.Click += new System.EventHandler(this.SubBtnReporteBaños_Click);
            // 
            // SubBtnReporteProduc
            // 
            this.SubBtnReporteProduc.AnimationHoverSpeed = 0.07F;
            this.SubBtnReporteProduc.AnimationSpeed = 0.03F;
            this.SubBtnReporteProduc.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnReporteProduc.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnReporteProduc.BorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteProduc.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnReporteProduc.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnReporteProduc.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnReporteProduc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnReporteProduc.ForeColor = System.Drawing.Color.White;
            this.SubBtnReporteProduc.Image = global::Proyecto.Properties.Resources.household_chores_task_cleaning_bathroom_toilet_pump_icon_133345;
            this.SubBtnReporteProduc.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnReporteProduc.Location = new System.Drawing.Point(0, 0);
            this.SubBtnReporteProduc.Name = "SubBtnReporteProduc";
            this.SubBtnReporteProduc.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnReporteProduc.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnReporteProduc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnReporteProduc.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnReporteProduc.OnHoverImage = null;
            this.SubBtnReporteProduc.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnReporteProduc.Size = new System.Drawing.Size(200, 42);
            this.SubBtnReporteProduc.TabIndex = 2;
            this.SubBtnReporteProduc.Text = "Reporte Productos";
            this.SubBtnReporteProduc.Click += new System.EventHandler(this.SubBtnReporteProduc_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.AnimationHoverSpeed = 0.07F;
            this.BtnReportes.AnimationSpeed = 0.03F;
            this.BtnReportes.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnReportes.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnReportes.BorderColor = System.Drawing.Color.Black;
            this.BtnReportes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FocusedColor = System.Drawing.Color.Empty;
            this.BtnReportes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Image = global::Proyecto.Properties.Resources.business_ordering_pencil_table_2333;
            this.BtnReportes.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnReportes.Location = new System.Drawing.Point(0, 437);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnReportes.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnReportes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnReportes.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnReportes.OnHoverImage = null;
            this.BtnReportes.OnPressedColor = System.Drawing.Color.Black;
            this.BtnReportes.Size = new System.Drawing.Size(200, 42);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "REPORTES";
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // PanelCubiculos
            // 
            this.PanelCubiculos.BackColor = System.Drawing.Color.Transparent;
            this.PanelCubiculos.Controls.Add(this.SubBtnResgistroCubiculos);
            this.PanelCubiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCubiculos.Location = new System.Drawing.Point(0, 395);
            this.PanelCubiculos.Name = "PanelCubiculos";
            this.PanelCubiculos.Size = new System.Drawing.Size(200, 42);
            this.PanelCubiculos.TabIndex = 7;
            // 
            // SubBtnResgistroCubiculos
            // 
            this.SubBtnResgistroCubiculos.AnimationHoverSpeed = 0.07F;
            this.SubBtnResgistroCubiculos.AnimationSpeed = 0.03F;
            this.SubBtnResgistroCubiculos.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnResgistroCubiculos.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnResgistroCubiculos.BorderColor = System.Drawing.Color.Black;
            this.SubBtnResgistroCubiculos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnResgistroCubiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnResgistroCubiculos.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnResgistroCubiculos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnResgistroCubiculos.ForeColor = System.Drawing.Color.White;
            this.SubBtnResgistroCubiculos.Image = global::Proyecto.Properties.Resources.medical_06_icon_icons_com_73937;
            this.SubBtnResgistroCubiculos.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnResgistroCubiculos.Location = new System.Drawing.Point(0, 0);
            this.SubBtnResgistroCubiculos.Name = "SubBtnResgistroCubiculos";
            this.SubBtnResgistroCubiculos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnResgistroCubiculos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnResgistroCubiculos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnResgistroCubiculos.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnResgistroCubiculos.OnHoverImage = null;
            this.SubBtnResgistroCubiculos.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnResgistroCubiculos.Size = new System.Drawing.Size(200, 42);
            this.SubBtnResgistroCubiculos.TabIndex = 2;
            this.SubBtnResgistroCubiculos.Text = "Registro Cubiculos";
            this.SubBtnResgistroCubiculos.Click += new System.EventHandler(this.SubBtnResgistroCubiculos_Click);
            // 
            // BtnCubiculos
            // 
            this.BtnCubiculos.AnimationHoverSpeed = 0.07F;
            this.BtnCubiculos.AnimationSpeed = 0.03F;
            this.BtnCubiculos.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnCubiculos.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnCubiculos.BorderColor = System.Drawing.Color.Black;
            this.BtnCubiculos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCubiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCubiculos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCubiculos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCubiculos.ForeColor = System.Drawing.Color.White;
            this.BtnCubiculos.Image = global::Proyecto.Properties.Resources.door_icon_icons_com_63566__1_;
            this.BtnCubiculos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCubiculos.Location = new System.Drawing.Point(0, 353);
            this.BtnCubiculos.Name = "BtnCubiculos";
            this.BtnCubiculos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnCubiculos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnCubiculos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCubiculos.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCubiculos.OnHoverImage = null;
            this.BtnCubiculos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCubiculos.Size = new System.Drawing.Size(200, 42);
            this.BtnCubiculos.TabIndex = 6;
            this.BtnCubiculos.Text = "CUBICULOS";
            this.BtnCubiculos.Click += new System.EventHandler(this.BtnCubiculos_Click);
            // 
            // PanelBaños
            // 
            this.PanelBaños.BackColor = System.Drawing.Color.Transparent;
            this.PanelBaños.Controls.Add(this.SubBtnRegistroBaños);
            this.PanelBaños.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBaños.Location = new System.Drawing.Point(0, 311);
            this.PanelBaños.Name = "PanelBaños";
            this.PanelBaños.Size = new System.Drawing.Size(200, 42);
            this.PanelBaños.TabIndex = 5;
            // 
            // SubBtnRegistroBaños
            // 
            this.SubBtnRegistroBaños.AnimationHoverSpeed = 0.07F;
            this.SubBtnRegistroBaños.AnimationSpeed = 0.03F;
            this.SubBtnRegistroBaños.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnRegistroBaños.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnRegistroBaños.BorderColor = System.Drawing.Color.Black;
            this.SubBtnRegistroBaños.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnRegistroBaños.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnRegistroBaños.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnRegistroBaños.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnRegistroBaños.ForeColor = System.Drawing.Color.White;
            this.SubBtnRegistroBaños.Image = global::Proyecto.Properties.Resources.reminders_task_list_19177;
            this.SubBtnRegistroBaños.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnRegistroBaños.Location = new System.Drawing.Point(0, 0);
            this.SubBtnRegistroBaños.Name = "SubBtnRegistroBaños";
            this.SubBtnRegistroBaños.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnRegistroBaños.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnRegistroBaños.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnRegistroBaños.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnRegistroBaños.OnHoverImage = null;
            this.SubBtnRegistroBaños.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnRegistroBaños.Size = new System.Drawing.Size(200, 42);
            this.SubBtnRegistroBaños.TabIndex = 2;
            this.SubBtnRegistroBaños.Text = "Registro Baños";
            this.SubBtnRegistroBaños.Click += new System.EventHandler(this.SubBtnRegistroBaños_Click);
            // 
            // BtnBaños
            // 
            this.BtnBaños.AnimationHoverSpeed = 0.07F;
            this.BtnBaños.AnimationSpeed = 0.03F;
            this.BtnBaños.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnBaños.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnBaños.BorderColor = System.Drawing.Color.Black;
            this.BtnBaños.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnBaños.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBaños.FocusedColor = System.Drawing.Color.Empty;
            this.BtnBaños.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBaños.ForeColor = System.Drawing.Color.White;
            this.BtnBaños.Image = global::Proyecto.Properties.Resources.house_toilet_icon_icons_com_74375;
            this.BtnBaños.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnBaños.Location = new System.Drawing.Point(0, 269);
            this.BtnBaños.Name = "BtnBaños";
            this.BtnBaños.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnBaños.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnBaños.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBaños.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBaños.OnHoverImage = null;
            this.BtnBaños.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBaños.Size = new System.Drawing.Size(200, 42);
            this.BtnBaños.TabIndex = 4;
            this.BtnBaños.Text = "BAÑOS";
            this.BtnBaños.Click += new System.EventHandler(this.BtnBaños_Click);
            // 
            // PanelProductos
            // 
            this.PanelProductos.BackColor = System.Drawing.Color.Transparent;
            this.PanelProductos.Controls.Add(this.BtnProductosEmpleados);
            this.PanelProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProductos.Location = new System.Drawing.Point(0, 227);
            this.PanelProductos.Name = "PanelProductos";
            this.PanelProductos.Size = new System.Drawing.Size(200, 42);
            this.PanelProductos.TabIndex = 0;
            // 
            // BtnProductosEmpleados
            // 
            this.BtnProductosEmpleados.AnimationHoverSpeed = 0.07F;
            this.BtnProductosEmpleados.AnimationSpeed = 0.03F;
            this.BtnProductosEmpleados.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnProductosEmpleados.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnProductosEmpleados.BorderColor = System.Drawing.Color.Black;
            this.BtnProductosEmpleados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProductosEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductosEmpleados.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProductosEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnProductosEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnProductosEmpleados.Image = global::Proyecto.Properties.Resources.korganizer_task_tasks_list_9500;
            this.BtnProductosEmpleados.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnProductosEmpleados.Location = new System.Drawing.Point(0, 0);
            this.BtnProductosEmpleados.Name = "BtnProductosEmpleados";
            this.BtnProductosEmpleados.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnProductosEmpleados.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnProductosEmpleados.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnProductosEmpleados.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnProductosEmpleados.OnHoverImage = null;
            this.BtnProductosEmpleados.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProductosEmpleados.Size = new System.Drawing.Size(200, 42);
            this.BtnProductosEmpleados.TabIndex = 2;
            this.BtnProductosEmpleados.Text = "Registro Productos";
            this.BtnProductosEmpleados.Click += new System.EventHandler(this.BtnProductosEmpleados_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.AnimationHoverSpeed = 0.07F;
            this.BtnProductos.AnimationSpeed = 0.03F;
            this.BtnProductos.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnProductos.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnProductos.BorderColor = System.Drawing.Color.Black;
            this.BtnProductos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProductos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Image = global::Proyecto.Properties.Resources.cleaning_168132;
            this.BtnProductos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnProductos.Location = new System.Drawing.Point(0, 185);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnProductos.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnProductos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnProductos.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnProductos.OnHoverImage = null;
            this.BtnProductos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProductos.Size = new System.Drawing.Size(200, 42);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "PRODUCTOS";
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // PanelEmpleado
            // 
            this.PanelEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.PanelEmpleado.Controls.Add(this.SubBtnRegistroEmpleado);
            this.PanelEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEmpleado.Location = new System.Drawing.Point(0, 142);
            this.PanelEmpleado.Name = "PanelEmpleado";
            this.PanelEmpleado.Size = new System.Drawing.Size(200, 43);
            this.PanelEmpleado.TabIndex = 0;
            // 
            // SubBtnRegistroEmpleado
            // 
            this.SubBtnRegistroEmpleado.AnimationHoverSpeed = 0.07F;
            this.SubBtnRegistroEmpleado.AnimationSpeed = 0.03F;
            this.SubBtnRegistroEmpleado.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnRegistroEmpleado.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnRegistroEmpleado.BorderColor = System.Drawing.Color.Black;
            this.SubBtnRegistroEmpleado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnRegistroEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnRegistroEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnRegistroEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnRegistroEmpleado.ForeColor = System.Drawing.Color.White;
            this.SubBtnRegistroEmpleado.Image = global::Proyecto.Properties.Resources.new_add_user_16734;
            this.SubBtnRegistroEmpleado.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnRegistroEmpleado.Location = new System.Drawing.Point(0, 0);
            this.SubBtnRegistroEmpleado.Name = "SubBtnRegistroEmpleado";
            this.SubBtnRegistroEmpleado.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnRegistroEmpleado.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnRegistroEmpleado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnRegistroEmpleado.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnRegistroEmpleado.OnHoverImage = null;
            this.SubBtnRegistroEmpleado.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnRegistroEmpleado.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.SubBtnRegistroEmpleado.Size = new System.Drawing.Size(200, 43);
            this.SubBtnRegistroEmpleado.TabIndex = 1;
            this.SubBtnRegistroEmpleado.Text = "Registro Empleados";
            this.SubBtnRegistroEmpleado.Click += new System.EventHandler(this.SubBtnRegistroEmpleado_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.AnimationHoverSpeed = 0.07F;
            this.BtnEmpleados.AnimationSpeed = 0.03F;
            this.BtnEmpleados.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnEmpleados.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnEmpleados.BorderColor = System.Drawing.Color.Black;
            this.BtnEmpleados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Image = global::Proyecto.Properties.Resources.users_clients_group_16774;
            this.BtnEmpleados.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 100);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEmpleados.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnEmpleados.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEmpleados.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.OnHoverImage = null;
            this.BtnEmpleados.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEmpleados.Size = new System.Drawing.Size(200, 42);
            this.BtnEmpleados.TabIndex = 0;
            this.BtnEmpleados.Text = "EMPLEADOS";
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelLogo.Controls.Add(this.Pct_LogoLetras);
            this.PanelLogo.Controls.Add(this.Ptb_LogoS);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 100);
            this.PanelLogo.TabIndex = 2;
            // 
            // Pct_LogoLetras
            // 
            this.Pct_LogoLetras.BackColor = System.Drawing.Color.Transparent;
            this.Pct_LogoLetras.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pct_LogoLetras.Image = global::Proyecto.Properties.Resources.LogoLetras;
            this.Pct_LogoLetras.Location = new System.Drawing.Point(63, 0);
            this.Pct_LogoLetras.Name = "Pct_LogoLetras";
            this.Pct_LogoLetras.Size = new System.Drawing.Size(137, 100);
            this.Pct_LogoLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pct_LogoLetras.TabIndex = 2;
            this.Pct_LogoLetras.TabStop = false;
            // 
            // Ptb_LogoS
            // 
            this.Ptb_LogoS.Image = global::Proyecto.Properties.Resources.LogoS;
            this.Ptb_LogoS.Location = new System.Drawing.Point(0, 0);
            this.Ptb_LogoS.Name = "Ptb_LogoS";
            this.Ptb_LogoS.Size = new System.Drawing.Size(63, 100);
            this.Ptb_LogoS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_LogoS.TabIndex = 1;
            this.Ptb_LogoS.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelContenedor;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Ptb_LogoS;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.Pct_LogoLetras;
            this.bunifuDragControl3.Vertical = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 600);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.PanelReportes.ResumeLayout(false);
            this.PanelCubiculos.ResumeLayout(false);
            this.PanelBaños.ResumeLayout(false);
            this.PanelProductos.ResumeLayout(false);
            this.PanelEmpleado.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_LogoLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_LogoS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox Ptb_LogoS;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelContenedor;
        private System.Windows.Forms.PictureBox Pct_LogoLetras;
        private Guna.UI.WinForms.GunaPanel PanelEmpleado;
        private Guna.UI.WinForms.GunaGradientButton SubBtnRegistroEmpleado;
        private Guna.UI.WinForms.GunaGradientButton BtnEmpleados;
        private Guna.UI.WinForms.GunaGradientButton BtnProductos;
        private System.Windows.Forms.Panel PanelProductos;
        private Guna.UI.WinForms.GunaGradientButton BtnProductosEmpleados;
        private System.Windows.Forms.Panel PanelBaños;
        private Guna.UI.WinForms.GunaGradientButton SubBtnRegistroBaños;
        private Guna.UI.WinForms.GunaGradientButton BtnBaños;
        private System.Windows.Forms.Panel PanelCubiculos;
        private Guna.UI.WinForms.GunaGradientButton SubBtnResgistroCubiculos;
        private Guna.UI.WinForms.GunaGradientButton BtnCubiculos;
        private System.Windows.Forms.Panel PanelReportes;
        private Guna.UI.WinForms.GunaGradientButton SubBtnReporteProduc;
        private Guna.UI.WinForms.GunaGradientButton BtnReportes;
        private Guna.UI.WinForms.GunaGradientButton SubBtnReporteBaños;
        private Guna.UI.WinForms.GunaGradientButton SubBtnReporteCubiculos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}