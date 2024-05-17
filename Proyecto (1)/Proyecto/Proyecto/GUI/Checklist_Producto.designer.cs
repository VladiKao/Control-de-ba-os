namespace muc_ups_29_02_2020.GUI
{
    partial class Checklist_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checklist_Producto));
            this.txt_OtroProduc = new System.Windows.Forms.TextBox();
            this.chk_otroproducto = new System.Windows.Forms.CheckBox();
            this.chK_Cubeta = new System.Windows.Forms.CheckBox();
            this.chk_Mechudo = new System.Windows.Forms.CheckBox();
            this.chk_Escoba = new System.Windows.Forms.CheckBox();
            this.chk_Jalador = new System.Windows.Forms.CheckBox();
            this.chk_Trapeador = new System.Windows.Forms.CheckBox();
            this.dbg_catalogoproducto = new System.Windows.Forms.DataGridView();
            this.Column_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IdBaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_AromatizantePRO = new System.Windows.Forms.CheckBox();
            this.chk_Cloro = new System.Windows.Forms.CheckBox();
            this.chk_Jabon = new System.Windows.Forms.CheckBox();
            this.chk_FabPRO = new System.Windows.Forms.CheckBox();
            this.chk_Fabuloso = new System.Windows.Forms.CheckBox();
            this.GbxSeleccCheckProducdo = new System.Windows.Forms.GroupBox();
            this.Tbx_BuscarProductoChecklist = new Bunifu.Framework.UI.BunifuTextbox();
            this.Buscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbg_catalogoproducto)).BeginInit();
            this.GbxSeleccCheckProducdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_OtroProduc
            // 
            this.txt_OtroProduc.Location = new System.Drawing.Point(484, 84);
            this.txt_OtroProduc.Name = "txt_OtroProduc";
            this.txt_OtroProduc.Size = new System.Drawing.Size(188, 20);
            this.txt_OtroProduc.TabIndex = 43;
            this.txt_OtroProduc.TextChanged += new System.EventHandler(this.txt_OtroProduc_TextChanged);
            // 
            // chk_otroproducto
            // 
            this.chk_otroproducto.AutoSize = true;
            this.chk_otroproducto.Location = new System.Drawing.Point(346, 84);
            this.chk_otroproducto.Name = "chk_otroproducto";
            this.chk_otroproducto.Size = new System.Drawing.Size(132, 17);
            this.chk_otroproducto.TabIndex = 42;
            this.chk_otroproducto.Text = "OTRO(ESPECIFICAR)";
            this.chk_otroproducto.UseVisualStyleBackColor = true;
            // 
            // chK_Cubeta
            // 
            this.chK_Cubeta.AutoSize = true;
            this.chK_Cubeta.Location = new System.Drawing.Point(215, 213);
            this.chK_Cubeta.Name = "chK_Cubeta";
            this.chK_Cubeta.Size = new System.Drawing.Size(69, 17);
            this.chK_Cubeta.TabIndex = 41;
            this.chK_Cubeta.Text = "CUBETA";
            this.chK_Cubeta.UseVisualStyleBackColor = true;
            // 
            // chk_Mechudo
            // 
            this.chk_Mechudo.AutoSize = true;
            this.chk_Mechudo.Location = new System.Drawing.Point(215, 174);
            this.chk_Mechudo.Name = "chk_Mechudo";
            this.chk_Mechudo.Size = new System.Drawing.Size(81, 17);
            this.chk_Mechudo.TabIndex = 40;
            this.chk_Mechudo.Text = "MECHUDO";
            this.chk_Mechudo.UseVisualStyleBackColor = true;
            // 
            // chk_Escoba
            // 
            this.chk_Escoba.AutoSize = true;
            this.chk_Escoba.Location = new System.Drawing.Point(215, 132);
            this.chk_Escoba.Name = "chk_Escoba";
            this.chk_Escoba.Size = new System.Drawing.Size(69, 17);
            this.chk_Escoba.TabIndex = 39;
            this.chk_Escoba.Text = "ESCOBA";
            this.chk_Escoba.UseVisualStyleBackColor = true;
            // 
            // chk_Jalador
            // 
            this.chk_Jalador.AutoSize = true;
            this.chk_Jalador.Location = new System.Drawing.Point(215, 86);
            this.chk_Jalador.Name = "chk_Jalador";
            this.chk_Jalador.Size = new System.Drawing.Size(75, 17);
            this.chk_Jalador.TabIndex = 38;
            this.chk_Jalador.Text = "JALADOR";
            this.chk_Jalador.UseVisualStyleBackColor = true;
            // 
            // chk_Trapeador
            // 
            this.chk_Trapeador.AutoSize = true;
            this.chk_Trapeador.Location = new System.Drawing.Point(215, 41);
            this.chk_Trapeador.Name = "chk_Trapeador";
            this.chk_Trapeador.Size = new System.Drawing.Size(93, 17);
            this.chk_Trapeador.TabIndex = 37;
            this.chk_Trapeador.Text = "TRAPEADOR";
            this.chk_Trapeador.UseVisualStyleBackColor = true;
            // 
            // dbg_catalogoproducto
            // 
            this.dbg_catalogoproducto.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dbg_catalogoproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbg_catalogoproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Producto,
            this.Column_Nombre,
            this.Column_IdBaño,
            this.Column_Edificio});
            this.dbg_catalogoproducto.Location = new System.Drawing.Point(12, 361);
            this.dbg_catalogoproducto.Name = "dbg_catalogoproducto";
            this.dbg_catalogoproducto.RowHeadersWidth = 51;
            this.dbg_catalogoproducto.Size = new System.Drawing.Size(693, 178);
            this.dbg_catalogoproducto.TabIndex = 36;
            // 
            // Column_Producto
            // 
            this.Column_Producto.FillWeight = 160F;
            this.Column_Producto.HeaderText = "ID DE PRODUCTO";
            this.Column_Producto.MinimumWidth = 6;
            this.Column_Producto.Name = "Column_Producto";
            this.Column_Producto.Width = 160;
            // 
            // Column_Nombre
            // 
            this.Column_Nombre.FillWeight = 160F;
            this.Column_Nombre.HeaderText = "NOMBRE";
            this.Column_Nombre.MinimumWidth = 6;
            this.Column_Nombre.Name = "Column_Nombre";
            this.Column_Nombre.Width = 160;
            // 
            // Column_IdBaño
            // 
            this.Column_IdBaño.FillWeight = 160F;
            this.Column_IdBaño.HeaderText = "ID DE BAÑO";
            this.Column_IdBaño.MinimumWidth = 6;
            this.Column_IdBaño.Name = "Column_IdBaño";
            this.Column_IdBaño.Width = 160;
            // 
            // Column_Edificio
            // 
            this.Column_Edificio.FillWeight = 160F;
            this.Column_Edificio.HeaderText = "ID EDIFICIO";
            this.Column_Edificio.MinimumWidth = 6;
            this.Column_Edificio.Name = "Column_Edificio";
            this.Column_Edificio.Width = 160;
            // 
            // chk_AromatizantePRO
            // 
            this.chk_AromatizantePRO.AutoSize = true;
            this.chk_AromatizantePRO.Location = new System.Drawing.Point(4, 213);
            this.chk_AromatizantePRO.Name = "chk_AromatizantePRO";
            this.chk_AromatizantePRO.Size = new System.Drawing.Size(111, 17);
            this.chk_AromatizantePRO.TabIndex = 33;
            this.chk_AromatizantePRO.Text = "AROMATIZANTE";
            this.chk_AromatizantePRO.UseVisualStyleBackColor = true;
            // 
            // chk_Cloro
            // 
            this.chk_Cloro.AutoSize = true;
            this.chk_Cloro.Location = new System.Drawing.Point(4, 174);
            this.chk_Cloro.Name = "chk_Cloro";
            this.chk_Cloro.Size = new System.Drawing.Size(63, 17);
            this.chk_Cloro.TabIndex = 32;
            this.chk_Cloro.Text = "CLORO";
            this.chk_Cloro.UseVisualStyleBackColor = true;
            // 
            // chk_Jabon
            // 
            this.chk_Jabon.AutoSize = true;
            this.chk_Jabon.Location = new System.Drawing.Point(4, 132);
            this.chk_Jabon.Name = "chk_Jabon";
            this.chk_Jabon.Size = new System.Drawing.Size(61, 17);
            this.chk_Jabon.TabIndex = 31;
            this.chk_Jabon.Text = "JABON";
            this.chk_Jabon.UseVisualStyleBackColor = true;
            // 
            // chk_FabPRO
            // 
            this.chk_FabPRO.AutoSize = true;
            this.chk_FabPRO.Location = new System.Drawing.Point(4, 86);
            this.chk_FabPRO.Name = "chk_FabPRO";
            this.chk_FabPRO.Size = new System.Drawing.Size(46, 17);
            this.chk_FabPRO.TabIndex = 30;
            this.chk_FabPRO.Text = "FAB";
            this.chk_FabPRO.UseVisualStyleBackColor = true;
            // 
            // chk_Fabuloso
            // 
            this.chk_Fabuloso.AutoSize = true;
            this.chk_Fabuloso.Location = new System.Drawing.Point(4, 41);
            this.chk_Fabuloso.Name = "chk_Fabuloso";
            this.chk_Fabuloso.Size = new System.Drawing.Size(83, 17);
            this.chk_Fabuloso.TabIndex = 29;
            this.chk_Fabuloso.Text = "FABULOSO";
            this.chk_Fabuloso.UseVisualStyleBackColor = true;
            // 
            // GbxSeleccCheckProducdo
            // 
            this.GbxSeleccCheckProducdo.BackColor = System.Drawing.Color.Transparent;
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Trapeador);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Fabuloso);
            this.GbxSeleccCheckProducdo.Controls.Add(this.txt_OtroProduc);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_FabPRO);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_otroproducto);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Jabon);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chK_Cubeta);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Cloro);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Mechudo);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_AromatizantePRO);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Escoba);
            this.GbxSeleccCheckProducdo.Controls.Add(this.chk_Jalador);
            this.GbxSeleccCheckProducdo.Location = new System.Drawing.Point(12, 85);
            this.GbxSeleccCheckProducdo.Name = "GbxSeleccCheckProducdo";
            this.GbxSeleccCheckProducdo.Size = new System.Drawing.Size(693, 250);
            this.GbxSeleccCheckProducdo.TabIndex = 45;
            this.GbxSeleccCheckProducdo.TabStop = false;
            this.GbxSeleccCheckProducdo.Text = "SELECCIONAR";
            // 
            // Tbx_BuscarProductoChecklist
            // 
            this.Tbx_BuscarProductoChecklist.BackColor = System.Drawing.Color.White;
            this.Tbx_BuscarProductoChecklist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tbx_BuscarProductoChecklist.BackgroundImage")));
            this.Tbx_BuscarProductoChecklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tbx_BuscarProductoChecklist.ForeColor = System.Drawing.Color.Black;
            this.Tbx_BuscarProductoChecklist.Icon = ((System.Drawing.Image)(resources.GetObject("Tbx_BuscarProductoChecklist.Icon")));
            this.Tbx_BuscarProductoChecklist.Location = new System.Drawing.Point(239, 37);
            this.Tbx_BuscarProductoChecklist.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_BuscarProductoChecklist.Name = "Tbx_BuscarProductoChecklist";
            this.Tbx_BuscarProductoChecklist.Size = new System.Drawing.Size(433, 42);
            this.Tbx_BuscarProductoChecklist.TabIndex = 46;
            this.Tbx_BuscarProductoChecklist.text = "";
            // 
            // Buscar
            // 
            this.Buscar.ActiveBorderThickness = 1;
            this.Buscar.ActiveCornerRadius = 20;
            this.Buscar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Buscar.ActiveForecolor = System.Drawing.Color.Blue;
            this.Buscar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Buscar.BackColor = System.Drawing.Color.LightCyan;
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.ButtonText = "Buscar";
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.Black;
            this.Buscar.IdleBorderThickness = 1;
            this.Buscar.IdleCornerRadius = 20;
            this.Buscar.IdleFillColor = System.Drawing.Color.Transparent;
            this.Buscar.IdleForecolor = System.Drawing.Color.Black;
            this.Buscar.IdleLineColor = System.Drawing.Color.Black;
            this.Buscar.Location = new System.Drawing.Point(50, 36);
            this.Buscar.Margin = new System.Windows.Forms.Padding(5);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(181, 41);
            this.Buscar.TabIndex = 47;
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(715, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Checklist_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(830, 542);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Tbx_BuscarProductoChecklist);
            this.Controls.Add(this.GbxSeleccCheckProducdo);
            this.Controls.Add(this.dbg_catalogoproducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checklist_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checklist_Producto";
            this.Load += new System.EventHandler(this.Checklist_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbg_catalogoproducto)).EndInit();
            this.GbxSeleccCheckProducdo.ResumeLayout(false);
            this.GbxSeleccCheckProducdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_OtroProduc;
        private System.Windows.Forms.CheckBox chk_otroproducto;
        private System.Windows.Forms.CheckBox chK_Cubeta;
        private System.Windows.Forms.CheckBox chk_Mechudo;
        private System.Windows.Forms.CheckBox chk_Escoba;
        private System.Windows.Forms.CheckBox chk_Jalador;
        private System.Windows.Forms.CheckBox chk_Trapeador;
        private System.Windows.Forms.DataGridView dbg_catalogoproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IdBaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Edificio;
        private System.Windows.Forms.CheckBox chk_AromatizantePRO;
        private System.Windows.Forms.CheckBox chk_Cloro;
        private System.Windows.Forms.CheckBox chk_Jabon;
        private System.Windows.Forms.CheckBox chk_FabPRO;
        private System.Windows.Forms.CheckBox chk_Fabuloso;
        private System.Windows.Forms.GroupBox GbxSeleccCheckProducdo;
        private Bunifu.Framework.UI.BunifuTextbox Tbx_BuscarProductoChecklist;
        private Bunifu.Framework.UI.BunifuThinButton2 Buscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}