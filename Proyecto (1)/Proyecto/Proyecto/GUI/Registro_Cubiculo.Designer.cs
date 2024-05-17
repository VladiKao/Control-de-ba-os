namespace Proyecto.GUI
{
    partial class Registro_Cubiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Cubiculo));
            this.BtnGuardarCubiculo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEliminarCubiculo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtgv_CUB = new System.Windows.Forms.DataGridView();
            this.idcubiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula_cubiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papelera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.papel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inodoro_roto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_ID_Producto = new System.Windows.Forms.Label();
            this.Txt_BuscarProducto = new System.Windows.Forms.TextBox();
            this.btn_modificardatoscubiculo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_matcub = new System.Windows.Forms.Label();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_papelera = new System.Windows.Forms.TextBox();
            this.txt_papel = new System.Windows.Forms.TextBox();
            this.txt_roto = new System.Windows.Forms.TextBox();
            this.txt_agua = new System.Windows.Forms.TextBox();
            this.txt_puerta = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CUB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardarCubiculo
            // 
            this.BtnGuardarCubiculo.ActiveBorderThickness = 1;
            this.BtnGuardarCubiculo.ActiveCornerRadius = 20;
            this.BtnGuardarCubiculo.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCubiculo.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnGuardarCubiculo.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnGuardarCubiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarCubiculo.BackColor = System.Drawing.Color.LightCyan;
            this.BtnGuardarCubiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarCubiculo.BackgroundImage")));
            this.BtnGuardarCubiculo.ButtonText = "Guardar";
            this.BtnGuardarCubiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCubiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCubiculo.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardarCubiculo.IdleBorderThickness = 1;
            this.BtnGuardarCubiculo.IdleCornerRadius = 20;
            this.BtnGuardarCubiculo.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnGuardarCubiculo.IdleForecolor = System.Drawing.Color.Black;
            this.BtnGuardarCubiculo.IdleLineColor = System.Drawing.Color.Black;
            this.BtnGuardarCubiculo.Location = new System.Drawing.Point(532, 373);
            this.BtnGuardarCubiculo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardarCubiculo.Name = "BtnGuardarCubiculo";
            this.BtnGuardarCubiculo.Size = new System.Drawing.Size(151, 37);
            this.BtnGuardarCubiculo.TabIndex = 103;
            this.BtnGuardarCubiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardarCubiculo.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // BtnEliminarCubiculo
            // 
            this.BtnEliminarCubiculo.ActiveBorderThickness = 1;
            this.BtnEliminarCubiculo.ActiveCornerRadius = 20;
            this.BtnEliminarCubiculo.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCubiculo.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnEliminarCubiculo.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnEliminarCubiculo.BackColor = System.Drawing.Color.LightCyan;
            this.BtnEliminarCubiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCubiculo.BackgroundImage")));
            this.BtnEliminarCubiculo.ButtonText = "Eliminar";
            this.BtnEliminarCubiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarCubiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCubiculo.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarCubiculo.IdleBorderThickness = 1;
            this.BtnEliminarCubiculo.IdleCornerRadius = 20;
            this.BtnEliminarCubiculo.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarCubiculo.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEliminarCubiculo.IdleLineColor = System.Drawing.Color.Black;
            this.BtnEliminarCubiculo.Location = new System.Drawing.Point(536, 469);
            this.BtnEliminarCubiculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarCubiculo.Name = "BtnEliminarCubiculo";
            this.BtnEliminarCubiculo.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminarCubiculo.TabIndex = 124;
            this.BtnEliminarCubiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarCubiculo.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // dtgv_CUB
            // 
            this.dtgv_CUB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CUB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcubiculo,
            this.matricula_cubiculo,
            this.papelera,
            this.papel,
            this.inodoro_roto,
            this.agua,
            this.puerta});
            this.dtgv_CUB.Location = new System.Drawing.Point(72, 410);
            this.dtgv_CUB.Name = "dtgv_CUB";
            this.dtgv_CUB.RowHeadersWidth = 51;
            this.dtgv_CUB.Size = new System.Drawing.Size(411, 128);
            this.dtgv_CUB.TabIndex = 127;
            this.dtgv_CUB.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_CUB_CellMouseClick);
            // 
            // idcubiculo
            // 
            this.idcubiculo.DataPropertyName = "idcubiculo";
            this.idcubiculo.HeaderText = "ID";
            this.idcubiculo.Name = "idcubiculo";
            // 
            // matricula_cubiculo
            // 
            this.matricula_cubiculo.DataPropertyName = "matricula_cubiculo";
            this.matricula_cubiculo.HeaderText = "matricula";
            this.matricula_cubiculo.Name = "matricula_cubiculo";
            // 
            // papelera
            // 
            this.papelera.DataPropertyName = "papelera";
            this.papelera.HeaderText = "papelera";
            this.papelera.Name = "papelera";
            // 
            // papel
            // 
            this.papel.DataPropertyName = "papel";
            this.papel.HeaderText = "papel";
            this.papel.Name = "papel";
            // 
            // inodoro_roto
            // 
            this.inodoro_roto.DataPropertyName = "inodoro_roto";
            this.inodoro_roto.HeaderText = "roto";
            this.inodoro_roto.Name = "inodoro_roto";
            // 
            // agua
            // 
            this.agua.DataPropertyName = "agua";
            this.agua.HeaderText = "tiene agua";
            this.agua.Name = "agua";
            // 
            // puerta
            // 
            this.puerta.DataPropertyName = "puerta";
            this.puerta.HeaderText = "tiene puerta";
            this.puerta.Name = "puerta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(590, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Lbl_ID_Producto
            // 
            this.Lbl_ID_Producto.AutoSize = true;
            this.Lbl_ID_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Producto.Location = new System.Drawing.Point(88, 356);
            this.Lbl_ID_Producto.Name = "Lbl_ID_Producto";
            this.Lbl_ID_Producto.Size = new System.Drawing.Size(164, 15);
            this.Lbl_ID_Producto.TabIndex = 130;
            this.Lbl_ID_Producto.Text = "MATRICULA PRODUCTO";
            // 
            // Txt_BuscarProducto
            // 
            this.Txt_BuscarProducto.Location = new System.Drawing.Point(263, 356);
            this.Txt_BuscarProducto.Name = "Txt_BuscarProducto";
            this.Txt_BuscarProducto.Size = new System.Drawing.Size(179, 20);
            this.Txt_BuscarProducto.TabIndex = 129;
            this.Txt_BuscarProducto.TextChanged += new System.EventHandler(this.Txt_BuscarProducto_TextChanged);
            // 
            // btn_modificardatoscubiculo
            // 
            this.btn_modificardatoscubiculo.ActiveBorderThickness = 1;
            this.btn_modificardatoscubiculo.ActiveCornerRadius = 20;
            this.btn_modificardatoscubiculo.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_modificardatoscubiculo.ActiveForecolor = System.Drawing.Color.Blue;
            this.btn_modificardatoscubiculo.ActiveLineColor = System.Drawing.Color.Black;
            this.btn_modificardatoscubiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificardatoscubiculo.BackColor = System.Drawing.Color.LightCyan;
            this.btn_modificardatoscubiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificardatoscubiculo.BackgroundImage")));
            this.btn_modificardatoscubiculo.ButtonText = "Modificar";
            this.btn_modificardatoscubiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificardatoscubiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificardatoscubiculo.ForeColor = System.Drawing.Color.Black;
            this.btn_modificardatoscubiculo.IdleBorderThickness = 1;
            this.btn_modificardatoscubiculo.IdleCornerRadius = 20;
            this.btn_modificardatoscubiculo.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_modificardatoscubiculo.IdleForecolor = System.Drawing.Color.Black;
            this.btn_modificardatoscubiculo.IdleLineColor = System.Drawing.Color.Black;
            this.btn_modificardatoscubiculo.Location = new System.Drawing.Point(534, 420);
            this.btn_modificardatoscubiculo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_modificardatoscubiculo.Name = "btn_modificardatoscubiculo";
            this.btn_modificardatoscubiculo.Size = new System.Drawing.Size(151, 37);
            this.btn_modificardatoscubiculo.TabIndex = 131;
            this.btn_modificardatoscubiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modificardatoscubiculo.Click += new System.EventHandler(this.btn_modificardatoscubiculo_Click);
            // 
            // lbl_matcub
            // 
            this.lbl_matcub.AutoSize = true;
            this.lbl_matcub.Location = new System.Drawing.Point(69, 76);
            this.lbl_matcub.Name = "lbl_matcub";
            this.lbl_matcub.Size = new System.Drawing.Size(69, 13);
            this.lbl_matcub.TabIndex = 132;
            this.lbl_matcub.Text = "MATRICULA";
            // 
            // txt_mat
            // 
            this.txt_mat.Location = new System.Drawing.Point(277, 76);
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(114, 20);
            this.txt_mat.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(60, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 194;
            this.label1.Text = "papelera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 195;
            this.label2.Text = "papel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 196;
            this.label3.Text = "inodoro roto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(71, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 197;
            this.label4.Text = "agua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(71, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 198;
            this.label7.Text = "puerta";
            // 
            // txt_papelera
            // 
            this.txt_papelera.Location = new System.Drawing.Point(277, 144);
            this.txt_papelera.Name = "txt_papelera";
            this.txt_papelera.Size = new System.Drawing.Size(114, 20);
            this.txt_papelera.TabIndex = 204;
            // 
            // txt_papel
            // 
            this.txt_papel.Location = new System.Drawing.Point(277, 174);
            this.txt_papel.Name = "txt_papel";
            this.txt_papel.Size = new System.Drawing.Size(114, 20);
            this.txt_papel.TabIndex = 205;
            // 
            // txt_roto
            // 
            this.txt_roto.Location = new System.Drawing.Point(277, 212);
            this.txt_roto.Name = "txt_roto";
            this.txt_roto.Size = new System.Drawing.Size(114, 20);
            this.txt_roto.TabIndex = 206;
            // 
            // txt_agua
            // 
            this.txt_agua.Location = new System.Drawing.Point(277, 245);
            this.txt_agua.Name = "txt_agua";
            this.txt_agua.Size = new System.Drawing.Size(114, 20);
            this.txt_agua.TabIndex = 207;
            // 
            // txt_puerta
            // 
            this.txt_puerta.Location = new System.Drawing.Point(281, 284);
            this.txt_puerta.Name = "txt_puerta";
            this.txt_puerta.Size = new System.Drawing.Size(114, 20);
            this.txt_puerta.TabIndex = 208;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(277, 43);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(114, 20);
            this.txt_ID.TabIndex = 209;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(94, 52);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 210;
            this.lbl_ID.Text = "ID";
            // 
            // Registro_Cubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(697, 571);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_puerta);
            this.Controls.Add(this.txt_agua);
            this.Controls.Add(this.txt_roto);
            this.Controls.Add(this.txt_papel);
            this.Controls.Add(this.txt_papelera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mat);
            this.Controls.Add(this.lbl_matcub);
            this.Controls.Add(this.btn_modificardatoscubiculo);
            this.Controls.Add(this.Lbl_ID_Producto);
            this.Controls.Add(this.Txt_BuscarProducto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtgv_CUB);
            this.Controls.Add(this.BtnEliminarCubiculo);
            this.Controls.Add(this.BtnGuardarCubiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Cubiculo";
            this.Text = "Registro_Cubiculo";
            this.Load += new System.EventHandler(this.Registro_Cubiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CUB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGuardarCubiculo;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEliminarCubiculo;
        private System.Windows.Forms.DataGridView dtgv_CUB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_ID_Producto;
        private System.Windows.Forms.TextBox Txt_BuscarProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_modificardatoscubiculo;
        private System.Windows.Forms.Label lbl_matcub;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_papelera;
        private System.Windows.Forms.TextBox txt_papel;
        private System.Windows.Forms.TextBox txt_roto;
        private System.Windows.Forms.TextBox txt_agua;
        private System.Windows.Forms.TextBox txt_puerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcubiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula_cubiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn papelera;
        private System.Windows.Forms.DataGridViewTextBoxColumn papel;
        private System.Windows.Forms.DataGridViewTextBoxColumn inodoro_roto;
        private System.Windows.Forms.DataGridViewTextBoxColumn agua;
        private System.Windows.Forms.DataGridViewTextBoxColumn puerta;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
    }
}