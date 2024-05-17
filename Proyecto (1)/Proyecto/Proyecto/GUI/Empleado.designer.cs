namespace Integrador_Baños.GUI
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.SideBar = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.SubPanelCheck = new Guna.UI.WinForms.GunaPanel();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.SubBtnBaños = new Guna.UI.WinForms.GunaGradientButton();
            this.BtnRegistroEmpleado = new Guna.UI.WinForms.GunaGradientButton();
            this.Panel_Logo = new Guna.UI.WinForms.GunaPanel();
            this.Pct_LogoLetras = new System.Windows.Forms.PictureBox();
            this.Ptb_LogoS = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new Guna.UI.WinForms.GunaGradientPanel();
            this.PctSalir = new Guna.UI.WinForms.GunaPictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SideBar.SuspendLayout();
            this.SubPanelCheck.SuspendLayout();
            this.Panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pct_LogoLetras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_LogoS)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.gunaGradientButton1);
            this.SideBar.Controls.Add(this.SubPanelCheck);
            this.SideBar.Controls.Add(this.BtnRegistroEmpleado);
            this.SideBar.Controls.Add(this.Panel_Logo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.GradientColor1 = System.Drawing.Color.Indigo;
            this.SideBar.GradientColor2 = System.Drawing.Color.LightSkyBlue;
            this.SideBar.GradientColor3 = System.Drawing.Color.Purple;
            this.SideBar.GradientColor4 = System.Drawing.Color.LightSkyBlue;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 435);
            this.SideBar.TabIndex = 2;
            this.SideBar.Text = "gunaGradientPanel1";
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Purple;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(0, 370);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(200, 44);
            this.gunaGradientButton1.TabIndex = 12;
            this.gunaGradientButton1.Text = "Cerrar sesion ";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // SubPanelCheck
            // 
            this.SubPanelCheck.BackColor = System.Drawing.Color.Transparent;
            this.SubPanelCheck.Controls.Add(this.gunaGradientButton2);
            this.SubPanelCheck.Controls.Add(this.SubBtnBaños);
            this.SubPanelCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanelCheck.Location = new System.Drawing.Point(0, 151);
            this.SubPanelCheck.Name = "SubPanelCheck";
            this.SubPanelCheck.Size = new System.Drawing.Size(200, 219);
            this.SubPanelCheck.TabIndex = 3;
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.Purple;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton2.Image")));
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(0, 42);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(200, 42);
            this.gunaGradientButton2.TabIndex = 6;
            this.gunaGradientButton2.Text = "Checklist de baño mujeres";
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click);
            // 
            // SubBtnBaños
            // 
            this.SubBtnBaños.AnimationHoverSpeed = 0.07F;
            this.SubBtnBaños.AnimationSpeed = 0.03F;
            this.SubBtnBaños.BaseColor1 = System.Drawing.Color.Purple;
            this.SubBtnBaños.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.SubBtnBaños.BorderColor = System.Drawing.Color.Black;
            this.SubBtnBaños.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubBtnBaños.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnBaños.FocusedColor = System.Drawing.Color.Empty;
            this.SubBtnBaños.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubBtnBaños.ForeColor = System.Drawing.Color.White;
            this.SubBtnBaños.Image = ((System.Drawing.Image)(resources.GetObject("SubBtnBaños.Image")));
            this.SubBtnBaños.ImageSize = new System.Drawing.Size(20, 20);
            this.SubBtnBaños.Location = new System.Drawing.Point(0, 0);
            this.SubBtnBaños.Name = "SubBtnBaños";
            this.SubBtnBaños.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.SubBtnBaños.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.SubBtnBaños.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubBtnBaños.OnHoverForeColor = System.Drawing.Color.White;
            this.SubBtnBaños.OnHoverImage = null;
            this.SubBtnBaños.OnPressedColor = System.Drawing.Color.Black;
            this.SubBtnBaños.Size = new System.Drawing.Size(200, 42);
            this.SubBtnBaños.TabIndex = 5;
            this.SubBtnBaños.Text = "Checklist de baños hombres";
            this.SubBtnBaños.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // BtnRegistroEmpleado
            // 
            this.BtnRegistroEmpleado.AnimationHoverSpeed = 0.07F;
            this.BtnRegistroEmpleado.AnimationSpeed = 0.03F;
            this.BtnRegistroEmpleado.BaseColor1 = System.Drawing.Color.Purple;
            this.BtnRegistroEmpleado.BaseColor2 = System.Drawing.Color.RoyalBlue;
            this.BtnRegistroEmpleado.BorderColor = System.Drawing.Color.Black;
            this.BtnRegistroEmpleado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnRegistroEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistroEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.BtnRegistroEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroEmpleado.ForeColor = System.Drawing.Color.White;
            this.BtnRegistroEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroEmpleado.Image")));
            this.BtnRegistroEmpleado.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnRegistroEmpleado.Location = new System.Drawing.Point(0, 113);
            this.BtnRegistroEmpleado.Name = "BtnRegistroEmpleado";
            this.BtnRegistroEmpleado.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnRegistroEmpleado.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnRegistroEmpleado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnRegistroEmpleado.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnRegistroEmpleado.OnHoverImage = null;
            this.BtnRegistroEmpleado.OnPressedColor = System.Drawing.Color.Black;
            this.BtnRegistroEmpleado.Size = new System.Drawing.Size(200, 38);
            this.BtnRegistroEmpleado.TabIndex = 2;
            this.BtnRegistroEmpleado.Text = "Checklist";
            this.BtnRegistroEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnRegistroEmpleado.Click += new System.EventHandler(this.BtnRegistroEmpleado_Click);
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Logo.Controls.Add(this.Pct_LogoLetras);
            this.Panel_Logo.Controls.Add(this.Ptb_LogoS);
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(200, 113);
            this.Panel_Logo.TabIndex = 0;
            // 
            // Pct_LogoLetras
            // 
            this.Pct_LogoLetras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pct_LogoLetras.Image = global::Proyecto.Properties.Resources.LogoLetras;
            this.Pct_LogoLetras.Location = new System.Drawing.Point(63, 0);
            this.Pct_LogoLetras.Name = "Pct_LogoLetras";
            this.Pct_LogoLetras.Size = new System.Drawing.Size(137, 113);
            this.Pct_LogoLetras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pct_LogoLetras.TabIndex = 1;
            this.Pct_LogoLetras.TabStop = false;
            // 
            // Ptb_LogoS
            // 
            this.Ptb_LogoS.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ptb_LogoS.Image = global::Proyecto.Properties.Resources.LogoS;
            this.Ptb_LogoS.Location = new System.Drawing.Point(0, 0);
            this.Ptb_LogoS.Name = "Ptb_LogoS";
            this.Ptb_LogoS.Size = new System.Drawing.Size(63, 113);
            this.Ptb_LogoS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ptb_LogoS.TabIndex = 0;
            this.Ptb_LogoS.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.White;
            this.PanelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelContenedor.BackgroundImage")));
            this.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelContenedor.Controls.Add(this.PctSalir);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.GradientColor1 = System.Drawing.Color.CornflowerBlue;
            this.PanelContenedor.GradientColor2 = System.Drawing.Color.AliceBlue;
            this.PanelContenedor.GradientColor3 = System.Drawing.Color.Indigo;
            this.PanelContenedor.GradientColor4 = System.Drawing.Color.LightSkyBlue;
            this.PanelContenedor.Location = new System.Drawing.Point(200, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(614, 435);
            this.PanelContenedor.TabIndex = 3;
            // 
            // PctSalir
            // 
            this.PctSalir.BackColor = System.Drawing.Color.Transparent;
            this.PctSalir.BaseColor = System.Drawing.Color.White;
            this.PctSalir.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.PctSalir.Location = new System.Drawing.Point(586, 3);
            this.PctSalir.Name = "PctSalir";
            this.PctSalir.Size = new System.Drawing.Size(22, 22);
            this.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctSalir.TabIndex = 0;
            this.PctSalir.TabStop = false;
            this.PctSalir.Click += new System.EventHandler(this.PctSalir_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Ptb_LogoS;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Pct_LogoLetras;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.PanelContenedor;
            this.bunifuDragControl3.Vertical = true;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 435);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.SideBar.ResumeLayout(false);
            this.SubPanelCheck.ResumeLayout(false);
            this.Panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pct_LogoLetras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_LogoS)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel SideBar;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaPanel SubPanelCheck;
        private Guna.UI.WinForms.GunaGradientButton BtnRegistroEmpleado;
        private Guna.UI.WinForms.GunaPanel Panel_Logo;
        private System.Windows.Forms.PictureBox Pct_LogoLetras;
        private System.Windows.Forms.PictureBox Ptb_LogoS;
        private Guna.UI.WinForms.GunaGradientPanel PanelContenedor;
        private Guna.UI.WinForms.GunaPictureBox PctSalir;
        private Guna.UI.WinForms.GunaGradientButton SubBtnBaños;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
    }
}