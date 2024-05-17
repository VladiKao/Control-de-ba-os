namespace Proyecto.GUI
{
    partial class BañoHombres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BañoHombres));
            this.Btn_CheklisBaño = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matBH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_NumCubiculos = new System.Windows.Forms.TextBox();
            this.cmb_empleado = new System.Windows.Forms.ComboBox();
            this.txt_LUZ = new System.Windows.Forms.TextBox();
            this.txt_AGUA = new System.Windows.Forms.TextBox();
            this.txt_ESPE = new System.Windows.Forms.TextBox();
            this.txt_JABON = new System.Windows.Forms.TextBox();
            this.txt_GEL = new System.Windows.Forms.TextBox();
            this.txt_BASU = new System.Windows.Forms.TextBox();
            this.txt_LAV = new System.Windows.Forms.TextBox();
            this.txt_PAPEL = new System.Windows.Forms.TextBox();
            this.BtnModificarEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEliminarEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgv_bañohom = new System.Windows.Forms.DataGridView();
            this.idbanio_hom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculabanio_hom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelantibacterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basurero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lavabos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papel_servilletero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inodoros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuarioemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.LBL_BUSCAR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bañohom)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CheklisBaño
            // 
            this.Btn_CheklisBaño.ActiveBorderThickness = 1;
            this.Btn_CheklisBaño.ActiveCornerRadius = 20;
            this.Btn_CheklisBaño.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.ActiveForecolor = System.Drawing.Color.Blue;
            this.Btn_CheklisBaño.ActiveLineColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_CheklisBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CheklisBaño.BackgroundImage")));
            this.Btn_CheklisBaño.ButtonText = "BUSCAR";
            this.Btn_CheklisBaño.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CheklisBaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CheklisBaño.ForeColor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.IdleBorderThickness = 1;
            this.Btn_CheklisBaño.IdleCornerRadius = 20;
            this.Btn_CheklisBaño.IdleFillColor = System.Drawing.Color.Transparent;
            this.Btn_CheklisBaño.IdleForecolor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.IdleLineColor = System.Drawing.Color.Black;
            this.Btn_CheklisBaño.Location = new System.Drawing.Point(358, 275);
            this.Btn_CheklisBaño.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_CheklisBaño.Name = "Btn_CheklisBaño";
            this.Btn_CheklisBaño.Size = new System.Drawing.Size(146, 35);
            this.Btn_CheklisBaño.TabIndex = 49;
            this.Btn_CheklisBaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CheklisBaño.Click += new System.EventHandler(this.Btn_CheklisBaño_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(535, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Matricula";
            // 
            // txt_matBH
            // 
            this.txt_matBH.Location = new System.Drawing.Point(124, 52);
            this.txt_matBH.Name = "txt_matBH";
            this.txt_matBH.Size = new System.Drawing.Size(201, 20);
            this.txt_matBH.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "luz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "agua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "espejo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 130;
            this.label5.Text = "jabon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 131;
            this.label6.Text = "gel antibacterial";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "basurero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "lavabos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 134;
            this.label9.Text = "papel de mano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 135;
            this.label10.Text = "numero de cubiculos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(374, 101);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 142;
            this.btn_guardar.Text = "guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 144;
            this.label12.Text = "empleado";
            // 
            // txt_NumCubiculos
            // 
            this.txt_NumCubiculos.Location = new System.Drawing.Point(137, 290);
            this.txt_NumCubiculos.Name = "txt_NumCubiculos";
            this.txt_NumCubiculos.Size = new System.Drawing.Size(107, 20);
            this.txt_NumCubiculos.TabIndex = 155;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(124, 316);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(121, 21);
            this.cmb_empleado.TabIndex = 157;
            this.cmb_empleado.SelectedIndexChanged += new System.EventHandler(this.cmb_empleado_SelectedIndexChanged);
            // 
            // txt_LUZ
            // 
            this.txt_LUZ.Location = new System.Drawing.Point(138, 78);
            this.txt_LUZ.Name = "txt_LUZ";
            this.txt_LUZ.Size = new System.Drawing.Size(107, 20);
            this.txt_LUZ.TabIndex = 160;
            // 
            // txt_AGUA
            // 
            this.txt_AGUA.Location = new System.Drawing.Point(138, 104);
            this.txt_AGUA.Name = "txt_AGUA";
            this.txt_AGUA.Size = new System.Drawing.Size(107, 20);
            this.txt_AGUA.TabIndex = 161;
            // 
            // txt_ESPE
            // 
            this.txt_ESPE.Location = new System.Drawing.Point(138, 129);
            this.txt_ESPE.Name = "txt_ESPE";
            this.txt_ESPE.Size = new System.Drawing.Size(107, 20);
            this.txt_ESPE.TabIndex = 162;
            // 
            // txt_JABON
            // 
            this.txt_JABON.Location = new System.Drawing.Point(138, 155);
            this.txt_JABON.Name = "txt_JABON";
            this.txt_JABON.Size = new System.Drawing.Size(107, 20);
            this.txt_JABON.TabIndex = 163;
            // 
            // txt_GEL
            // 
            this.txt_GEL.Location = new System.Drawing.Point(137, 180);
            this.txt_GEL.Name = "txt_GEL";
            this.txt_GEL.Size = new System.Drawing.Size(107, 20);
            this.txt_GEL.TabIndex = 164;
            // 
            // txt_BASU
            // 
            this.txt_BASU.Location = new System.Drawing.Point(138, 206);
            this.txt_BASU.Name = "txt_BASU";
            this.txt_BASU.Size = new System.Drawing.Size(107, 20);
            this.txt_BASU.TabIndex = 165;
            // 
            // txt_LAV
            // 
            this.txt_LAV.Location = new System.Drawing.Point(137, 235);
            this.txt_LAV.Name = "txt_LAV";
            this.txt_LAV.Size = new System.Drawing.Size(107, 20);
            this.txt_LAV.TabIndex = 166;
            // 
            // txt_PAPEL
            // 
            this.txt_PAPEL.Location = new System.Drawing.Point(137, 261);
            this.txt_PAPEL.Name = "txt_PAPEL";
            this.txt_PAPEL.Size = new System.Drawing.Size(107, 20);
            this.txt_PAPEL.TabIndex = 167;
            // 
            // BtnModificarEmpleado
            // 
            this.BtnModificarEmpleado.ActiveBorderThickness = 1;
            this.BtnModificarEmpleado.ActiveCornerRadius = 20;
            this.BtnModificarEmpleado.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarEmpleado.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnModificarEmpleado.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.BtnModificarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificarEmpleado.BackgroundImage")));
            this.BtnModificarEmpleado.ButtonText = "Modificar";
            this.BtnModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.IdleBorderThickness = 1;
            this.BtnModificarEmpleado.IdleCornerRadius = 20;
            this.BtnModificarEmpleado.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarEmpleado.IdleForecolor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.IdleLineColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.Location = new System.Drawing.Point(341, 155);
            this.BtnModificarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificarEmpleado.Name = "BtnModificarEmpleado";
            this.BtnModificarEmpleado.Size = new System.Drawing.Size(150, 39);
            this.BtnModificarEmpleado.TabIndex = 168;
            this.BtnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarEmpleado.Click += new System.EventHandler(this.BtnModificarEmpleado_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.ActiveBorderThickness = 1;
            this.BtnEliminarEmpleado.ActiveCornerRadius = 20;
            this.BtnEliminarEmpleado.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEmpleado.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnEliminarEmpleado.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarEmpleado.BackgroundImage")));
            this.BtnEliminarEmpleado.ButtonText = "Eliminar";
            this.BtnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.IdleBorderThickness = 1;
            this.BtnEliminarEmpleado.IdleCornerRadius = 20;
            this.BtnEliminarEmpleado.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEmpleado.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.IdleLineColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(354, 216);
            this.BtnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminarEmpleado.TabIndex = 169;
            this.BtnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // dtgv_bañohom
            // 
            this.dtgv_bañohom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bañohom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbanio_hom,
            this.matriculabanio_hom,
            this.luz,
            this.agua,
            this.espejo,
            this.jabon,
            this.gelantibacterial,
            this.basurero,
            this.lavabos,
            this.papel_servilletero,
            this.inodoros,
            this.nombre_usuarioemp});
            this.dtgv_bañohom.Location = new System.Drawing.Point(30, 412);
            this.dtgv_bañohom.Name = "dtgv_bañohom";
            this.dtgv_bañohom.Size = new System.Drawing.Size(539, 119);
            this.dtgv_bañohom.TabIndex = 171;
            this.dtgv_bañohom.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_bañohom_CellMouseClick_2);
            // 
            // idbanio_hom
            // 
            this.idbanio_hom.DataPropertyName = "idbanio_hom";
            this.idbanio_hom.HeaderText = "ID";
            this.idbanio_hom.Name = "idbanio_hom";
            // 
            // matriculabanio_hom
            // 
            this.matriculabanio_hom.DataPropertyName = "matriculabanio_hom";
            this.matriculabanio_hom.HeaderText = "Matricula";
            this.matriculabanio_hom.Name = "matriculabanio_hom";
            // 
            // luz
            // 
            this.luz.DataPropertyName = "luz";
            this.luz.HeaderText = "Luz";
            this.luz.Name = "luz";
            // 
            // agua
            // 
            this.agua.DataPropertyName = "agua";
            this.agua.HeaderText = "Agua";
            this.agua.Name = "agua";
            // 
            // espejo
            // 
            this.espejo.DataPropertyName = "espejo";
            this.espejo.HeaderText = "Espejo";
            this.espejo.Name = "espejo";
            // 
            // jabon
            // 
            this.jabon.DataPropertyName = "jabon";
            this.jabon.HeaderText = "Jabón";
            this.jabon.Name = "jabon";
            // 
            // gelantibacterial
            // 
            this.gelantibacterial.DataPropertyName = "gelantibacterial";
            this.gelantibacterial.HeaderText = "Gel Antibacterial";
            this.gelantibacterial.Name = "gelantibacterial";
            // 
            // basurero
            // 
            this.basurero.DataPropertyName = "basurero";
            this.basurero.HeaderText = "Basurero";
            this.basurero.Name = "basurero";
            // 
            // lavabos
            // 
            this.lavabos.DataPropertyName = "lavabos";
            this.lavabos.HeaderText = "Lavabos";
            this.lavabos.Name = "lavabos";
            // 
            // papel_servilletero
            // 
            this.papel_servilletero.DataPropertyName = "papel_servilletero";
            this.papel_servilletero.HeaderText = "Papel Servilletero";
            this.papel_servilletero.Name = "papel_servilletero";
            // 
            // inodoros
            // 
            this.inodoros.DataPropertyName = "inodoros";
            this.inodoros.HeaderText = "Inodoros";
            this.inodoros.Name = "inodoros";
            // 
            // nombre_usuarioemp
            // 
            this.nombre_usuarioemp.DataPropertyName = "nombre_usuarioemp";
            this.nombre_usuarioemp.HeaderText = "Empleado";
            this.nombre_usuarioemp.Name = "nombre_usuarioemp";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(145, 22);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 13);
            this.lbl_id.TabIndex = 172;
            this.lbl_id.Text = "Codigo";
            this.lbl_id.Visible = false;
            // 
            // txt_buscador
            // 
            this.txt_buscador.Location = new System.Drawing.Point(341, 356);
            this.txt_buscador.Multiline = true;
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(221, 35);
            this.txt_buscador.TabIndex = 173;
            this.txt_buscador.TextChanged += new System.EventHandler(this.txt_buscador_TextChanged);
            // 
            // LBL_BUSCAR
            // 
            this.LBL_BUSCAR.AutoSize = true;
            this.LBL_BUSCAR.Location = new System.Drawing.Point(206, 377);
            this.LBL_BUSCAR.Name = "LBL_BUSCAR";
            this.LBL_BUSCAR.Size = new System.Drawing.Size(69, 13);
            this.LBL_BUSCAR.TabIndex = 174;
            this.LBL_BUSCAR.Text = "MATRICULA";
            // 
            // BañoHombres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(625, 543);
            this.Controls.Add(this.LBL_BUSCAR);
            this.Controls.Add(this.txt_buscador);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dtgv_bañohom);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.BtnModificarEmpleado);
            this.Controls.Add(this.txt_PAPEL);
            this.Controls.Add(this.txt_LAV);
            this.Controls.Add(this.txt_BASU);
            this.Controls.Add(this.txt_GEL);
            this.Controls.Add(this.txt_JABON);
            this.Controls.Add(this.txt_ESPE);
            this.Controls.Add(this.txt_AGUA);
            this.Controls.Add(this.txt_LUZ);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.txt_NumCubiculos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matBH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_CheklisBaño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BañoHombres";
            this.Text = "BañoHombres";
            this.Load += new System.EventHandler(this.BañoHombres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bañohom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_CheklisBaño;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matBH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_NumCubiculos;
        private System.Windows.Forms.ComboBox cmb_empleado;
        private System.Windows.Forms.TextBox txt_LUZ;
        private System.Windows.Forms.TextBox txt_AGUA;
        private System.Windows.Forms.TextBox txt_ESPE;
        private System.Windows.Forms.TextBox txt_JABON;
        private System.Windows.Forms.TextBox txt_GEL;
        private System.Windows.Forms.TextBox txt_BASU;
        private System.Windows.Forms.TextBox txt_LAV;
        private System.Windows.Forms.TextBox txt_PAPEL;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnModificarEmpleado;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dtgv_bañohom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbanio_hom;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculabanio_hom;
        private System.Windows.Forms.DataGridViewTextBoxColumn luz;
        private System.Windows.Forms.DataGridViewTextBoxColumn agua;
        private System.Windows.Forms.DataGridViewTextBoxColumn espejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelantibacterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn basurero;
        private System.Windows.Forms.DataGridViewTextBoxColumn lavabos;
        private System.Windows.Forms.DataGridViewTextBoxColumn papel_servilletero;
        private System.Windows.Forms.DataGridViewTextBoxColumn inodoros;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuarioemp;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_buscador;
        private System.Windows.Forms.Label LBL_BUSCAR;
    }
}