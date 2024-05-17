namespace Proyecto.GUI
{
    partial class Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Panel_Inicio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LinkLbl_RecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.Btn_Entrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Tbx_Contraseña = new System.Windows.Forms.TextBox();
            this.Pict_Logo = new System.Windows.Forms.PictureBox();
            this.Lbl_Login = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tbx_Usuario = new System.Windows.Forms.TextBox();
            this.Panel_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3861, 195);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(229, 10);
            this.bunifuSeparator2.TabIndex = 1;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Panel_Inicio
            // 
            this.Panel_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Inicio.BackgroundImage")));
            this.Panel_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Inicio.Controls.Add(this.pictureBox1);
            this.Panel_Inicio.Controls.Add(this.LinkLbl_RecuperarContraseña);
            this.Panel_Inicio.Controls.Add(this.Btn_Entrar);
            this.Panel_Inicio.Controls.Add(this.Tbx_Contraseña);
            this.Panel_Inicio.Controls.Add(this.Pict_Logo);
            this.Panel_Inicio.Controls.Add(this.Lbl_Login);
            this.Panel_Inicio.Controls.Add(this.Tbx_Usuario);
            this.Panel_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Inicio.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Inicio.GradientBottomLeft = System.Drawing.Color.CornflowerBlue;
            this.Panel_Inicio.GradientBottomRight = System.Drawing.Color.AliceBlue;
            this.Panel_Inicio.GradientTopLeft = System.Drawing.Color.Indigo;
            this.Panel_Inicio.GradientTopRight = System.Drawing.Color.LightSkyBlue;
            this.Panel_Inicio.Location = new System.Drawing.Point(0, 0);
            this.Panel_Inicio.Name = "Panel_Inicio";
            this.Panel_Inicio.Quality = 10;
            this.Panel_Inicio.Size = new System.Drawing.Size(342, 447);
            this.Panel_Inicio.TabIndex = 0;
            this.Panel_Inicio.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Inicio_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.cancellationbutton_exitneartheaction_botondecancelacion_salida_6335;
            this.pictureBox1.Location = new System.Drawing.Point(321, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // LinkLbl_RecuperarContraseña
            // 
            this.LinkLbl_RecuperarContraseña.AutoSize = true;
            this.LinkLbl_RecuperarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LinkLbl_RecuperarContraseña.Location = new System.Drawing.Point(124, 256);
            this.LinkLbl_RecuperarContraseña.Name = "LinkLbl_RecuperarContraseña";
            this.LinkLbl_RecuperarContraseña.Size = new System.Drawing.Size(114, 13);
            this.LinkLbl_RecuperarContraseña.TabIndex = 0;
            this.LinkLbl_RecuperarContraseña.TabStop = true;
            this.LinkLbl_RecuperarContraseña.Text = "Recuperar Contraseña";
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.ActiveBorderThickness = 1;
            this.Btn_Entrar.ActiveCornerRadius = 20;
            this.Btn_Entrar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar.ActiveForecolor = System.Drawing.Color.Blue;
            this.Btn_Entrar.ActiveLineColor = System.Drawing.Color.Black;
            this.Btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Entrar.BackgroundImage")));
            this.Btn_Entrar.ButtonText = "ENTRAR";
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Entrar.IdleBorderThickness = 1;
            this.Btn_Entrar.IdleCornerRadius = 20;
            this.Btn_Entrar.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar.IdleForecolor = System.Drawing.Color.Black;
            this.Btn_Entrar.IdleLineColor = System.Drawing.Color.Black;
            this.Btn_Entrar.Location = new System.Drawing.Point(107, 307);
            this.Btn_Entrar.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(131, 41);
            this.Btn_Entrar.TabIndex = 3;
            this.Btn_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Tbx_Contraseña
            // 
            this.Tbx_Contraseña.BackColor = System.Drawing.Color.LightCyan;
            this.Tbx_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Contraseña.Location = new System.Drawing.Point(57, 233);
            this.Tbx_Contraseña.Name = "Tbx_Contraseña";
            this.Tbx_Contraseña.Size = new System.Drawing.Size(229, 21);
            this.Tbx_Contraseña.TabIndex = 2;
            this.Tbx_Contraseña.Text = "CONTRASEÑA";
            this.Tbx_Contraseña.Enter += new System.EventHandler(this.Tbx_Contraseña_Enter);
            this.Tbx_Contraseña.Leave += new System.EventHandler(this.Tbx_Contraseña_Leave);
            // 
            // Pict_Logo
            // 
            this.Pict_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pict_Logo.Image = global::Proyecto.Properties.Resources.Businessman_48px1;
            this.Pict_Logo.Location = new System.Drawing.Point(0, 0);
            this.Pict_Logo.Name = "Pict_Logo";
            this.Pict_Logo.Size = new System.Drawing.Size(342, 139);
            this.Pict_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pict_Logo.TabIndex = 8;
            this.Pict_Logo.TabStop = false;
            this.Pict_Logo.Click += new System.EventHandler(this.Pict_Logo_Click);
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Login.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Login.Location = new System.Drawing.Point(132, 142);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(79, 25);
            this.Lbl_Login.TabIndex = 7;
            this.Lbl_Login.Text = "LOGIN";
            // 
            // Tbx_Usuario
            // 
            this.Tbx_Usuario.BackColor = System.Drawing.Color.LightCyan;
            this.Tbx_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbx_Usuario.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Usuario.ForeColor = System.Drawing.Color.Black;
            this.Tbx_Usuario.Location = new System.Drawing.Point(57, 195);
            this.Tbx_Usuario.Name = "Tbx_Usuario";
            this.Tbx_Usuario.Size = new System.Drawing.Size(229, 20);
            this.Tbx_Usuario.TabIndex = 1;
            this.Tbx_Usuario.Text = "USUARIO";
            this.Tbx_Usuario.TextChanged += new System.EventHandler(this.Tbx_Usuario_TextChanged);
            this.Tbx_Usuario.Enter += new System.EventHandler(this.Tbx_Usuario_Enter);
            this.Tbx_Usuario.Leave += new System.EventHandler(this.Tbx_Usuario_Leave);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(342, 447);
            this.Controls.Add(this.Panel_Inicio);
            this.Controls.Add(this.bunifuSeparator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio_Sesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio_Sesion";
            this.Load += new System.EventHandler(this.Inicio_Sesion_Load);
            this.Panel_Inicio.ResumeLayout(false);
            this.Panel_Inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel Panel_Inicio;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox Tbx_Contraseña;
        private System.Windows.Forms.TextBox Tbx_Usuario;
        private System.Windows.Forms.PictureBox Pict_Logo;
        private Bunifu.Framework.UI.BunifuCustomLabel Lbl_Login;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Entrar;
        private System.Windows.Forms.LinkLabel LinkLbl_RecuperarContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}