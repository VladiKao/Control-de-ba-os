namespace RegistroBaño
{
    partial class Registro_Baño
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Baño));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBT_ESPEJO = new System.Windows.Forms.RadioButton();
            this.RBT_LAVABO = new System.Windows.Forms.RadioButton();
            this.RBT_AGUA = new System.Windows.Forms.RadioButton();
            this.RBT_LUZ = new System.Windows.Forms.RadioButton();
            this.TXT_NoPapeleras = new System.Windows.Forms.TextBox();
            this.TXT_NoINIDORO = new System.Windows.Forms.TextBox();
            this.LBL_NoPapeleras = new System.Windows.Forms.Label();
            this.LBL_NoInodoros = new System.Windows.Forms.Label();
            this.Btn_GuardarBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEliminarBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnModificarBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero_inodoros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_papeleras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_ID_Baño = new System.Windows.Forms.Label();
            this.Txt_BuscarBaño = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cmb_edificio = new System.Windows.Forms.ComboBox();
            this.lbl_EDIFICIO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RBT_ESPEJO);
            this.groupBox1.Controls.Add(this.RBT_LAVABO);
            this.groupBox1.Controls.Add(this.RBT_AGUA);
            this.groupBox1.Controls.Add(this.RBT_LUZ);
            this.groupBox1.Location = new System.Drawing.Point(23, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 94);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTIENE";
            // 
            // RBT_ESPEJO
            // 
            this.RBT_ESPEJO.AutoSize = true;
            this.RBT_ESPEJO.BackColor = System.Drawing.Color.Transparent;
            this.RBT_ESPEJO.ForeColor = System.Drawing.Color.Black;
            this.RBT_ESPEJO.Location = new System.Drawing.Point(265, 37);
            this.RBT_ESPEJO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBT_ESPEJO.Name = "RBT_ESPEJO";
            this.RBT_ESPEJO.Size = new System.Drawing.Size(66, 17);
            this.RBT_ESPEJO.TabIndex = 89;
            this.RBT_ESPEJO.TabStop = true;
            this.RBT_ESPEJO.Text = "ESPEJO";
            this.RBT_ESPEJO.UseVisualStyleBackColor = false;
            // 
            // RBT_LAVABO
            // 
            this.RBT_LAVABO.AutoSize = true;
            this.RBT_LAVABO.BackColor = System.Drawing.Color.Transparent;
            this.RBT_LAVABO.ForeColor = System.Drawing.Color.Black;
            this.RBT_LAVABO.Location = new System.Drawing.Point(146, 37);
            this.RBT_LAVABO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBT_LAVABO.Name = "RBT_LAVABO";
            this.RBT_LAVABO.Size = new System.Drawing.Size(67, 17);
            this.RBT_LAVABO.TabIndex = 88;
            this.RBT_LAVABO.TabStop = true;
            this.RBT_LAVABO.Text = "LAVABO";
            this.RBT_LAVABO.UseVisualStyleBackColor = false;
            // 
            // RBT_AGUA
            // 
            this.RBT_AGUA.AutoSize = true;
            this.RBT_AGUA.BackColor = System.Drawing.Color.Transparent;
            this.RBT_AGUA.ForeColor = System.Drawing.Color.Black;
            this.RBT_AGUA.Location = new System.Drawing.Point(369, 37);
            this.RBT_AGUA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBT_AGUA.Name = "RBT_AGUA";
            this.RBT_AGUA.Size = new System.Drawing.Size(55, 17);
            this.RBT_AGUA.TabIndex = 87;
            this.RBT_AGUA.TabStop = true;
            this.RBT_AGUA.Text = "AGUA";
            this.RBT_AGUA.UseVisualStyleBackColor = false;
            // 
            // RBT_LUZ
            // 
            this.RBT_LUZ.AutoSize = true;
            this.RBT_LUZ.BackColor = System.Drawing.Color.Transparent;
            this.RBT_LUZ.ForeColor = System.Drawing.Color.Black;
            this.RBT_LUZ.Location = new System.Drawing.Point(24, 37);
            this.RBT_LUZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBT_LUZ.Name = "RBT_LUZ";
            this.RBT_LUZ.Size = new System.Drawing.Size(46, 17);
            this.RBT_LUZ.TabIndex = 86;
            this.RBT_LUZ.TabStop = true;
            this.RBT_LUZ.Text = "LUZ";
            this.RBT_LUZ.UseVisualStyleBackColor = false;
            // 
            // TXT_NoPapeleras
            // 
            this.TXT_NoPapeleras.Location = new System.Drawing.Point(199, 83);
            this.TXT_NoPapeleras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXT_NoPapeleras.Name = "TXT_NoPapeleras";
            this.TXT_NoPapeleras.Size = new System.Drawing.Size(169, 20);
            this.TXT_NoPapeleras.TabIndex = 98;
            // 
            // TXT_NoINIDORO
            // 
            this.TXT_NoINIDORO.Location = new System.Drawing.Point(199, 21);
            this.TXT_NoINIDORO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXT_NoINIDORO.Name = "TXT_NoINIDORO";
            this.TXT_NoINIDORO.Size = new System.Drawing.Size(169, 20);
            this.TXT_NoINIDORO.TabIndex = 97;
            this.TXT_NoINIDORO.TextChanged += new System.EventHandler(this.TXT_NoINIDORO_TextChanged);
            // 
            // LBL_NoPapeleras
            // 
            this.LBL_NoPapeleras.AutoSize = true;
            this.LBL_NoPapeleras.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NoPapeleras.ForeColor = System.Drawing.Color.Black;
            this.LBL_NoPapeleras.Location = new System.Drawing.Point(14, 90);
            this.LBL_NoPapeleras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_NoPapeleras.Name = "LBL_NoPapeleras";
            this.LBL_NoPapeleras.Size = new System.Drawing.Size(139, 13);
            this.LBL_NoPapeleras.TabIndex = 95;
            this.LBL_NoPapeleras.Text = "NUMERO DE PAPELERAS";
            // 
            // LBL_NoInodoros
            // 
            this.LBL_NoInodoros.AutoSize = true;
            this.LBL_NoInodoros.BackColor = System.Drawing.Color.Transparent;
            this.LBL_NoInodoros.ForeColor = System.Drawing.Color.Black;
            this.LBL_NoInodoros.Location = new System.Drawing.Point(14, 28);
            this.LBL_NoInodoros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_NoInodoros.Name = "LBL_NoInodoros";
            this.LBL_NoInodoros.Size = new System.Drawing.Size(134, 13);
            this.LBL_NoInodoros.TabIndex = 94;
            this.LBL_NoInodoros.Text = "NUMERO DE INODOROS";
            // 
            // Btn_GuardarBaño
            // 
            this.Btn_GuardarBaño.ActiveBorderThickness = 1;
            this.Btn_GuardarBaño.ActiveCornerRadius = 20;
            this.Btn_GuardarBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_GuardarBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.Btn_GuardarBaño.ActiveLineColor = System.Drawing.Color.Black;
            this.Btn_GuardarBaño.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_GuardarBaño.BackColor = System.Drawing.Color.White;
            this.Btn_GuardarBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_GuardarBaño.BackgroundImage")));
            this.Btn_GuardarBaño.ButtonText = "GUARDAR";
            this.Btn_GuardarBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GuardarBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GuardarBaño.ForeColor = System.Drawing.Color.Black;
            this.Btn_GuardarBaño.IdleBorderThickness = 1;
            this.Btn_GuardarBaño.IdleCornerRadius = 20;
            this.Btn_GuardarBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_GuardarBaño.IdleForecolor = System.Drawing.Color.Black;
            this.Btn_GuardarBaño.IdleLineColor = System.Drawing.Color.Black;
            this.Btn_GuardarBaño.Location = new System.Drawing.Point(464, 422);
            this.Btn_GuardarBaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_GuardarBaño.Name = "Btn_GuardarBaño";
            this.Btn_GuardarBaño.Size = new System.Drawing.Size(150, 39);
            this.Btn_GuardarBaño.TabIndex = 100;
            this.Btn_GuardarBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_GuardarBaño.Click += new System.EventHandler(this.Btn_GuardarBaño_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LBL_NoInodoros);
            this.groupBox2.Controls.Add(this.LBL_NoPapeleras);
            this.groupBox2.Controls.Add(this.TXT_NoINIDORO);
            this.groupBox2.Controls.Add(this.TXT_NoPapeleras);
            this.groupBox2.Location = new System.Drawing.Point(23, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 161);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REGISTRO DE BAÑOS";
            // 
            // BtnBuscarBaño
            // 
            this.BtnBuscarBaño.ActiveBorderThickness = 1;
            this.BtnBuscarBaño.ActiveCornerRadius = 20;
            this.BtnBuscarBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnBuscarBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnBuscarBaño.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnBuscarBaño.BackColor = System.Drawing.Color.White;
            this.BtnBuscarBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarBaño.BackgroundImage")));
            this.BtnBuscarBaño.ButtonText = "Buscar";
            this.BtnBuscarBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarBaño.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarBaño.IdleBorderThickness = 1;
            this.BtnBuscarBaño.IdleCornerRadius = 20;
            this.BtnBuscarBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnBuscarBaño.IdleForecolor = System.Drawing.Color.Black;
            this.BtnBuscarBaño.IdleLineColor = System.Drawing.Color.Black;
            this.BtnBuscarBaño.Location = new System.Drawing.Point(464, 565);
            this.BtnBuscarBaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarBaño.Name = "BtnBuscarBaño";
            this.BtnBuscarBaño.Size = new System.Drawing.Size(150, 39);
            this.BtnBuscarBaño.TabIndex = 125;
            this.BtnBuscarBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBuscarBaño.Click += new System.EventHandler(this.BtnBuscarBaño_Click_1);
            // 
            // BtnEliminarBaño
            // 
            this.BtnEliminarBaño.ActiveBorderThickness = 1;
            this.BtnEliminarBaño.ActiveCornerRadius = 20;
            this.BtnEliminarBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnEliminarBaño.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnEliminarBaño.BackColor = System.Drawing.Color.White;
            this.BtnEliminarBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarBaño.BackgroundImage")));
            this.BtnEliminarBaño.ButtonText = "Eliminar";
            this.BtnEliminarBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarBaño.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarBaño.IdleBorderThickness = 1;
            this.BtnEliminarBaño.IdleCornerRadius = 20;
            this.BtnEliminarBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarBaño.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEliminarBaño.IdleLineColor = System.Drawing.Color.Black;
            this.BtnEliminarBaño.Location = new System.Drawing.Point(464, 518);
            this.BtnEliminarBaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarBaño.Name = "BtnEliminarBaño";
            this.BtnEliminarBaño.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminarBaño.TabIndex = 124;
            this.BtnEliminarBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarBaño.Click += new System.EventHandler(this.BtnEliminarBaño_Click);
            // 
            // BtnModificarBaño
            // 
            this.BtnModificarBaño.ActiveBorderThickness = 1;
            this.BtnModificarBaño.ActiveCornerRadius = 20;
            this.BtnModificarBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnModificarBaño.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnModificarBaño.BackColor = System.Drawing.Color.White;
            this.BtnModificarBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificarBaño.BackgroundImage")));
            this.BtnModificarBaño.ButtonText = "Modificar";
            this.BtnModificarBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarBaño.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarBaño.IdleBorderThickness = 1;
            this.BtnModificarBaño.IdleCornerRadius = 20;
            this.BtnModificarBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarBaño.IdleForecolor = System.Drawing.Color.Black;
            this.BtnModificarBaño.IdleLineColor = System.Drawing.Color.Black;
            this.BtnModificarBaño.Location = new System.Drawing.Point(464, 471);
            this.BtnModificarBaño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificarBaño.Name = "BtnModificarBaño";
            this.BtnModificarBaño.Size = new System.Drawing.Size(150, 39);
            this.BtnModificarBaño.TabIndex = 123;
            this.BtnModificarBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarBaño.Click += new System.EventHandler(this.BtnModificarBaño_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero_inodoros,
            this.numero_papeleras});
            this.dataGridView1.Location = new System.Drawing.Point(12, 443);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(391, 147);
            this.dataGridView1.TabIndex = 126;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // numero_inodoros
            // 
            this.numero_inodoros.HeaderText = "Numero de inodoros";
            this.numero_inodoros.MinimumWidth = 6;
            this.numero_inodoros.Name = "numero_inodoros";
            this.numero_inodoros.Width = 125;
            // 
            // numero_papeleras
            // 
            this.numero_papeleras.HeaderText = "Numero de papeleras";
            this.numero_papeleras.MinimumWidth = 6;
            this.numero_papeleras.Name = "numero_papeleras";
            this.numero_papeleras.Width = 125;
            // 
            // Lbl_ID_Baño
            // 
            this.Lbl_ID_Baño.AutoSize = true;
            this.Lbl_ID_Baño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Baño.Location = new System.Drawing.Point(53, 401);
            this.Lbl_ID_Baño.Name = "Lbl_ID_Baño";
            this.Lbl_ID_Baño.Size = new System.Drawing.Size(62, 15);
            this.Lbl_ID_Baño.TabIndex = 128;
            this.Lbl_ID_Baño.Text = "ID BAÑO";
            // 
            // Txt_BuscarBaño
            // 
            this.Txt_BuscarBaño.Location = new System.Drawing.Point(161, 400);
            this.Txt_BuscarBaño.Name = "Txt_BuscarBaño";
            this.Txt_BuscarBaño.Size = new System.Drawing.Size(179, 20);
            this.Txt_BuscarBaño.TabIndex = 127;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(592, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 129;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Cmb_edificio
            // 
            this.Cmb_edificio.FormattingEnabled = true;
            this.Cmb_edificio.Location = new System.Drawing.Point(203, 315);
            this.Cmb_edificio.Name = "Cmb_edificio";
            this.Cmb_edificio.Size = new System.Drawing.Size(189, 21);
            this.Cmb_edificio.TabIndex = 130;
            // 
            // lbl_EDIFICIO
            // 
            this.lbl_EDIFICIO.AutoSize = true;
            this.lbl_EDIFICIO.Location = new System.Drawing.Point(85, 324);
            this.lbl_EDIFICIO.Name = "lbl_EDIFICIO";
            this.lbl_EDIFICIO.Size = new System.Drawing.Size(52, 13);
            this.lbl_EDIFICIO.TabIndex = 131;
            this.lbl_EDIFICIO.Text = "EDIFICIO";
            // 
            // Registro_Baño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(627, 640);
            this.Controls.Add(this.lbl_EDIFICIO);
            this.Controls.Add(this.Cmb_edificio);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lbl_ID_Baño);
            this.Controls.Add(this.Txt_BuscarBaño);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnBuscarBaño);
            this.Controls.Add(this.BtnEliminarBaño);
            this.Controls.Add(this.BtnModificarBaño);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_GuardarBaño);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registro_Baño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Baño_Load);
            this.Resize += new System.EventHandler(this.Registro_Baño_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBT_ESPEJO;
        private System.Windows.Forms.RadioButton RBT_LAVABO;
        private System.Windows.Forms.RadioButton RBT_AGUA;
        private System.Windows.Forms.RadioButton RBT_LUZ;
        private System.Windows.Forms.TextBox TXT_NoPapeleras;
        private System.Windows.Forms.TextBox TXT_NoINIDORO;
        private System.Windows.Forms.Label LBL_NoPapeleras;
        private System.Windows.Forms.Label LBL_NoInodoros;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_GuardarBaño;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnBuscarBaño;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEliminarBaño;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnModificarBaño;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_ID_Baño;
        private System.Windows.Forms.TextBox Txt_BuscarBaño;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_inodoros;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_papeleras;
        private System.Windows.Forms.ComboBox Cmb_edificio;
        private System.Windows.Forms.Label lbl_EDIFICIO;
    }
}

