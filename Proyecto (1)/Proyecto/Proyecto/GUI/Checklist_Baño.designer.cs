namespace muc_ups_29_02_2020.GUI
{
    partial class Checklist_Baño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checklist_Baño));
            this.txt_otrafalla = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.dbg_cheklistbaño = new System.Windows.Forms.DataGridView();
            this.Column_IdBaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_numInodros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_espejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_basurero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_luz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Lavabo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Basurero = new System.Windows.Forms.CheckBox();
            this.chk_FallaIno = new System.Windows.Forms.CheckBox();
            this.chk_Tuberia = new System.Windows.Forms.CheckBox();
            this.chk_FaltaA = new System.Windows.Forms.CheckBox();
            this.chk_Piso = new System.Windows.Forms.CheckBox();
            this.Btn_CheklisBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Tbx_buscarchecklistbaño = new Bunifu.Framework.UI.BunifuTextbox();
            this.Gbx_SeleccChecklistBaño = new System.Windows.Forms.GroupBox();
            this.chk_Espejo = new System.Windows.Forms.CheckBox();
            this.chk_Aromatizante = new System.Windows.Forms.CheckBox();
            this.chk_Detergente = new System.Windows.Forms.CheckBox();
            this.chk_Jabon = new System.Windows.Forms.CheckBox();
            this.chk_Papel = new System.Windows.Forms.CheckBox();
            this.chk_Luz = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbg_cheklistbaño)).BeginInit();
            this.Gbx_SeleccChecklistBaño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_otrafalla
            // 
            this.txt_otrafalla.Location = new System.Drawing.Point(407, 226);
            this.txt_otrafalla.Name = "txt_otrafalla";
            this.txt_otrafalla.Size = new System.Drawing.Size(188, 20);
            this.txt_otrafalla.TabIndex = 42;
            this.txt_otrafalla.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(179, 226);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(132, 17);
            this.C.TabIndex = 41;
            this.C.Text = "OTRO(ESPECIFICAR)";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // dbg_cheklistbaño
            // 
            this.dbg_cheklistbaño.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.dbg_cheklistbaño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbg_cheklistbaño.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_IdBaño,
            this.Column_IDEmpleado,
            this.Column_numInodros,
            this.Column_Edificio,
            this.Column_agua,
            this.Column_espejo,
            this.Column_basurero,
            this.Column_luz,
            this.Column_Lavabo});
            this.dbg_cheklistbaño.Location = new System.Drawing.Point(58, 349);
            this.dbg_cheklistbaño.Name = "dbg_cheklistbaño";
            this.dbg_cheklistbaño.RowHeadersWidth = 51;
            this.dbg_cheklistbaño.Size = new System.Drawing.Size(628, 178);
            this.dbg_cheklistbaño.TabIndex = 38;
            // 
            // Column_IdBaño
            // 
            this.Column_IdBaño.HeaderText = "ID DE BAÑO";
            this.Column_IdBaño.MinimumWidth = 6;
            this.Column_IdBaño.Name = "Column_IdBaño";
            this.Column_IdBaño.Width = 125;
            // 
            // Column_IDEmpleado
            // 
            this.Column_IDEmpleado.HeaderText = "ID DE EMPLEADO";
            this.Column_IDEmpleado.MinimumWidth = 6;
            this.Column_IDEmpleado.Name = "Column_IDEmpleado";
            this.Column_IDEmpleado.Width = 125;
            // 
            // Column_numInodros
            // 
            this.Column_numInodros.FillWeight = 80F;
            this.Column_numInodros.HeaderText = "NUMERO DE INODOROS";
            this.Column_numInodros.MinimumWidth = 6;
            this.Column_numInodros.Name = "Column_numInodros";
            this.Column_numInodros.Width = 80;
            // 
            // Column_Edificio
            // 
            this.Column_Edificio.HeaderText = "ID EDIFICIO";
            this.Column_Edificio.MinimumWidth = 6;
            this.Column_Edificio.Name = "Column_Edificio";
            this.Column_Edificio.Width = 125;
            // 
            // Column_agua
            // 
            this.Column_agua.FillWeight = 50F;
            this.Column_agua.HeaderText = "AGUA";
            this.Column_agua.MinimumWidth = 6;
            this.Column_agua.Name = "Column_agua";
            this.Column_agua.Width = 50;
            // 
            // Column_espejo
            // 
            this.Column_espejo.FillWeight = 70F;
            this.Column_espejo.HeaderText = "ESPEJOS";
            this.Column_espejo.MinimumWidth = 6;
            this.Column_espejo.Name = "Column_espejo";
            this.Column_espejo.Width = 70;
            // 
            // Column_basurero
            // 
            this.Column_basurero.FillWeight = 70F;
            this.Column_basurero.HeaderText = "BASUREROS";
            this.Column_basurero.MinimumWidth = 6;
            this.Column_basurero.Name = "Column_basurero";
            this.Column_basurero.Width = 70;
            // 
            // Column_luz
            // 
            this.Column_luz.FillWeight = 70F;
            this.Column_luz.HeaderText = "LUZ";
            this.Column_luz.MinimumWidth = 6;
            this.Column_luz.Name = "Column_luz";
            this.Column_luz.Width = 70;
            // 
            // Column_Lavabo
            // 
            this.Column_Lavabo.FillWeight = 70F;
            this.Column_Lavabo.HeaderText = "LAVABOS";
            this.Column_Lavabo.MinimumWidth = 6;
            this.Column_Lavabo.Name = "Column_Lavabo";
            this.Column_Lavabo.Width = 70;
            // 
            // chk_Basurero
            // 
            this.chk_Basurero.AutoSize = true;
            this.chk_Basurero.Location = new System.Drawing.Point(179, 19);
            this.chk_Basurero.Name = "chk_Basurero";
            this.chk_Basurero.Size = new System.Drawing.Size(86, 17);
            this.chk_Basurero.TabIndex = 37;
            this.chk_Basurero.Text = "BASURERO";
            this.chk_Basurero.UseVisualStyleBackColor = true;
            this.chk_Basurero.CheckedChanged += new System.EventHandler(this.chk_Basurero_CheckedChanged);
            // 
            // chk_FallaIno
            // 
            this.chk_FallaIno.AutoSize = true;
            this.chk_FallaIno.Location = new System.Drawing.Point(179, 185);
            this.chk_FallaIno.Name = "chk_FallaIno";
            this.chk_FallaIno.Size = new System.Drawing.Size(130, 17);
            this.chk_FallaIno.TabIndex = 36;
            this.chk_FallaIno.Text = "FALLA DE INODORO";
            this.chk_FallaIno.UseVisualStyleBackColor = true;
            this.chk_FallaIno.CheckedChanged += new System.EventHandler(this.chk_FallaIno_CheckedChanged);
            // 
            // chk_Tuberia
            // 
            this.chk_Tuberia.AutoSize = true;
            this.chk_Tuberia.Location = new System.Drawing.Point(179, 140);
            this.chk_Tuberia.Name = "chk_Tuberia";
            this.chk_Tuberia.Size = new System.Drawing.Size(163, 17);
            this.chk_Tuberia.TabIndex = 35;
            this.chk_Tuberia.Text = "TUBERIA EN MAL ESTADO";
            this.chk_Tuberia.UseVisualStyleBackColor = true;
            this.chk_Tuberia.CheckedChanged += new System.EventHandler(this.chk_Tuberia_CheckedChanged);
            // 
            // chk_FaltaA
            // 
            this.chk_FaltaA.AutoSize = true;
            this.chk_FaltaA.Location = new System.Drawing.Point(179, 97);
            this.chk_FaltaA.Name = "chk_FaltaA";
            this.chk_FaltaA.Size = new System.Drawing.Size(110, 17);
            this.chk_FaltaA.TabIndex = 34;
            this.chk_FaltaA.Text = "FALTA DE AGUA";
            this.chk_FaltaA.UseVisualStyleBackColor = true;
            this.chk_FaltaA.CheckedChanged += new System.EventHandler(this.chk_FaltaA_CheckedChanged);
            // 
            // chk_Piso
            // 
            this.chk_Piso.AutoSize = true;
            this.chk_Piso.Location = new System.Drawing.Point(179, 60);
            this.chk_Piso.Name = "chk_Piso";
            this.chk_Piso.Size = new System.Drawing.Size(90, 17);
            this.chk_Piso.TabIndex = 33;
            this.chk_Piso.Text = "PISO LIMPIO";
            this.chk_Piso.UseVisualStyleBackColor = true;
            this.chk_Piso.CheckedChanged += new System.EventHandler(this.chk_Pisol_CheckedChanged);
            // 
            // Btn_CheklisBaño
            // 
            this.Btn_CheklisBaño.ActiveBorderThickness = 1;
            this.Btn_CheklisBaño.ActiveCornerRadius = 20;
            this.Btn_CheklisBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.Btn_CheklisBaño.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.Btn_CheklisBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CheklisBaño.BackgroundImage")));
            this.Btn_CheklisBaño.ButtonText = "BUSCAR";
            this.Btn_CheklisBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CheklisBaño.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CheklisBaño.ForeColor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.IdleBorderThickness = 1;
            this.Btn_CheklisBaño.IdleCornerRadius = 20;
            this.Btn_CheklisBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.IdleForecolor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.IdleLineColor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.Location = new System.Drawing.Point(121, 26);
            this.Btn_CheklisBaño.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_CheklisBaño.Name = "Btn_CheklisBaño";
            this.Btn_CheklisBaño.Size = new System.Drawing.Size(146, 35);
            this.Btn_CheklisBaño.TabIndex = 45;
            this.Btn_CheklisBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CheklisBaño.Click += new System.EventHandler(this.Btn_CheklisBaño_Click);
            // 
            // Tbx_buscarchecklistbaño
            // 
            this.Tbx_buscarchecklistbaño.BackColor = System.Drawing.Color.White;
            this.Tbx_buscarchecklistbaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tbx_buscarchecklistbaño.BackgroundImage")));
            this.Tbx_buscarchecklistbaño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tbx_buscarchecklistbaño.ForeColor = System.Drawing.Color.Black;
            this.Tbx_buscarchecklistbaño.Icon = ((System.Drawing.Image)(resources.GetObject("Tbx_buscarchecklistbaño.Icon")));
            this.Tbx_buscarchecklistbaño.Location = new System.Drawing.Point(303, 26);
            this.Tbx_buscarchecklistbaño.Name = "Tbx_buscarchecklistbaño";
            this.Tbx_buscarchecklistbaño.Size = new System.Drawing.Size(324, 35);
            this.Tbx_buscarchecklistbaño.TabIndex = 46;
            this.Tbx_buscarchecklistbaño.text = "";
            // 
            // Gbx_SeleccChecklistBaño
            // 
            this.Gbx_SeleccChecklistBaño.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Gbx_SeleccChecklistBaño.BackColor = System.Drawing.Color.Transparent;
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Espejo);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Aromatizante);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Detergente);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.txt_otrafalla);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Jabon);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.C);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Papel);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Luz);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Basurero);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Tuberia);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_FallaIno);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_Piso);
            this.Gbx_SeleccChecklistBaño.Controls.Add(this.chk_FaltaA);
            this.Gbx_SeleccChecklistBaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gbx_SeleccChecklistBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbx_SeleccChecklistBaño.Location = new System.Drawing.Point(58, 85);
            this.Gbx_SeleccChecklistBaño.Name = "Gbx_SeleccChecklistBaño";
            this.Gbx_SeleccChecklistBaño.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Gbx_SeleccChecklistBaño.Size = new System.Drawing.Size(628, 249);
            this.Gbx_SeleccChecklistBaño.TabIndex = 47;
            this.Gbx_SeleccChecklistBaño.TabStop = false;
            this.Gbx_SeleccChecklistBaño.Text = "SELECCIONE";
            this.Gbx_SeleccChecklistBaño.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk_Espejo
            // 
            this.chk_Espejo.AutoSize = true;
            this.chk_Espejo.Location = new System.Drawing.Point(6, 19);
            this.chk_Espejo.Name = "chk_Espejo";
            this.chk_Espejo.Size = new System.Drawing.Size(74, 17);
            this.chk_Espejo.TabIndex = 46;
            this.chk_Espejo.Text = "ESPEJOS";
            this.chk_Espejo.UseVisualStyleBackColor = true;
            // 
            // chk_Aromatizante
            // 
            this.chk_Aromatizante.AutoSize = true;
            this.chk_Aromatizante.Location = new System.Drawing.Point(6, 226);
            this.chk_Aromatizante.Name = "chk_Aromatizante";
            this.chk_Aromatizante.Size = new System.Drawing.Size(111, 17);
            this.chk_Aromatizante.TabIndex = 45;
            this.chk_Aromatizante.Text = "AROMATIZANTE";
            this.chk_Aromatizante.UseVisualStyleBackColor = true;
            // 
            // chk_Detergente
            // 
            this.chk_Detergente.AutoSize = true;
            this.chk_Detergente.Location = new System.Drawing.Point(5, 185);
            this.chk_Detergente.Name = "chk_Detergente";
            this.chk_Detergente.Size = new System.Drawing.Size(100, 17);
            this.chk_Detergente.TabIndex = 44;
            this.chk_Detergente.Text = "DETERGENTE";
            this.chk_Detergente.UseVisualStyleBackColor = true;
            // 
            // chk_Jabon
            // 
            this.chk_Jabon.AutoSize = true;
            this.chk_Jabon.Location = new System.Drawing.Point(5, 140);
            this.chk_Jabon.Name = "chk_Jabon";
            this.chk_Jabon.Size = new System.Drawing.Size(61, 17);
            this.chk_Jabon.TabIndex = 43;
            this.chk_Jabon.Text = "JABON";
            this.chk_Jabon.UseVisualStyleBackColor = true;
            // 
            // chk_Papel
            // 
            this.chk_Papel.AutoSize = true;
            this.chk_Papel.Location = new System.Drawing.Point(5, 97);
            this.chk_Papel.Name = "chk_Papel";
            this.chk_Papel.Size = new System.Drawing.Size(60, 17);
            this.chk_Papel.TabIndex = 42;
            this.chk_Papel.Text = "PAPEL";
            this.chk_Papel.UseVisualStyleBackColor = true;
            // 
            // chk_Luz
            // 
            this.chk_Luz.AutoSize = true;
            this.chk_Luz.Location = new System.Drawing.Point(5, 60);
            this.chk_Luz.Name = "chk_Luz";
            this.chk_Luz.Size = new System.Drawing.Size(47, 17);
            this.chk_Luz.TabIndex = 41;
            this.chk_Luz.Text = "LUZ";
            this.chk_Luz.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(677, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Checklist_Baño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(770, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Gbx_SeleccChecklistBaño);
            this.Controls.Add(this.Tbx_buscarchecklistbaño);
            this.Controls.Add(this.Btn_CheklisBaño);
            this.Controls.Add(this.dbg_cheklistbaño);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Checklist_Baño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checklist_Baño";
            this.Load += new System.EventHandler(this.Checklist_Baño_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbg_cheklistbaño)).EndInit();
            this.Gbx_SeleccChecklistBaño.ResumeLayout(false);
            this.Gbx_SeleccChecklistBaño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_otrafalla;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.DataGridView dbg_cheklistbaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IdBaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_numInodros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_agua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_espejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_basurero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_luz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Lavabo;
        private System.Windows.Forms.CheckBox chk_Basurero;
        private System.Windows.Forms.CheckBox chk_FallaIno;
        private System.Windows.Forms.CheckBox chk_Tuberia;
        private System.Windows.Forms.CheckBox chk_FaltaA;
        private System.Windows.Forms.CheckBox chk_Piso;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_CheklisBaño;
        private Bunifu.Framework.UI.BunifuTextbox Tbx_buscarchecklistbaño;
        private System.Windows.Forms.GroupBox Gbx_SeleccChecklistBaño;
        private System.Windows.Forms.CheckBox chk_Espejo;
        private System.Windows.Forms.CheckBox chk_Aromatizante;
        private System.Windows.Forms.CheckBox chk_Detergente;
        private System.Windows.Forms.CheckBox chk_Jabon;
        private System.Windows.Forms.CheckBox chk_Papel;
        private System.Windows.Forms.CheckBox chk_Luz;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}