namespace Proyecto.GUI
{
    partial class Registro_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Producto));
            this.txt_nombreproducto = new System.Windows.Forms.TextBox();
            this.lbl_nombreproducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEliminarEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnModificarEmpleado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnGuardarProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Lbl_ID_Producto = new System.Windows.Forms.Label();
            this.Txt_BuscarProducto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombreproducto
            // 
            this.txt_nombreproducto.Location = new System.Drawing.Point(82, 99);
            this.txt_nombreproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreproducto.Name = "txt_nombreproducto";
            this.txt_nombreproducto.Size = new System.Drawing.Size(302, 23);
            this.txt_nombreproducto.TabIndex = 112;
            // 
            // lbl_nombreproducto
            // 
            this.lbl_nombreproducto.AutoSize = true;
            this.lbl_nombreproducto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreproducto.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombreproducto.Location = new System.Drawing.Point(5, 99);
            this.lbl_nombreproducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombreproducto.Name = "lbl_nombreproducto";
            this.lbl_nombreproducto.Size = new System.Drawing.Size(64, 16);
            this.lbl_nombreproducto.TabIndex = 107;
            this.lbl_nombreproducto.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "PZ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_nombreproducto);
            this.groupBox1.Controls.Add(this.txt_nombreproducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 162);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(82, 68);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(122, 23);
            this.txt_ID.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Productos,
            this.Nombre_pro});
            this.dataGridView1.Location = new System.Drawing.Point(57, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 133);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ID_Productos
            // 
            this.ID_Productos.DataPropertyName = "idproductos";
            this.ID_Productos.HeaderText = "ID PRoductos";
            this.ID_Productos.Name = "ID_Productos";
            // 
            // Nombre_pro
            // 
            this.Nombre_pro.DataPropertyName = "nombre_pro";
            this.Nombre_pro.HeaderText = "Nombre Productos";
            this.Nombre_pro.Name = "Nombre_pro";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(649, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 123;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnBuscarEmpleado
            // 
            this.BtnBuscarEmpleado.ActiveBorderThickness = 1;
            this.BtnBuscarEmpleado.ActiveCornerRadius = 20;
            this.BtnBuscarEmpleado.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnBuscarEmpleado.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnBuscarEmpleado.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnBuscarEmpleado.BackColor = System.Drawing.Color.LightCyan;
            this.BtnBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarEmpleado.BackgroundImage")));
            this.BtnBuscarEmpleado.ButtonText = "Buscar";
            this.BtnBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscarEmpleado.IdleBorderThickness = 1;
            this.BtnBuscarEmpleado.IdleCornerRadius = 20;
            this.BtnBuscarEmpleado.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnBuscarEmpleado.IdleForecolor = System.Drawing.Color.Black;
            this.BtnBuscarEmpleado.IdleLineColor = System.Drawing.Color.Black;
            this.BtnBuscarEmpleado.Location = new System.Drawing.Point(507, 389);
            this.BtnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado";
            this.BtnBuscarEmpleado.Size = new System.Drawing.Size(150, 39);
            this.BtnBuscarEmpleado.TabIndex = 121;
            this.BtnBuscarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBuscarEmpleado.Click += new System.EventHandler(this.BtnBuscarEmpleado_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.ActiveBorderThickness = 1;
            this.BtnEliminarEmpleado.ActiveCornerRadius = 20;
            this.BtnEliminarEmpleado.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEmpleado.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnEliminarEmpleado.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.BackColor = System.Drawing.Color.LightCyan;
            this.BtnEliminarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarEmpleado.BackgroundImage")));
            this.BtnEliminarEmpleado.ButtonText = "Eliminar";
            this.BtnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.IdleBorderThickness = 1;
            this.BtnEliminarEmpleado.IdleCornerRadius = 20;
            this.BtnEliminarEmpleado.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnEliminarEmpleado.IdleForecolor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.IdleLineColor = System.Drawing.Color.Black;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(507, 342);
            this.BtnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminarEmpleado.TabIndex = 120;
            this.BtnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // BtnModificarEmpleado
            // 
            this.BtnModificarEmpleado.ActiveBorderThickness = 1;
            this.BtnModificarEmpleado.ActiveCornerRadius = 20;
            this.BtnModificarEmpleado.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarEmpleado.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnModificarEmpleado.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.BackColor = System.Drawing.Color.LightCyan;
            this.BtnModificarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnModificarEmpleado.BackgroundImage")));
            this.BtnModificarEmpleado.ButtonText = "Modificar";
            this.BtnModificarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.IdleBorderThickness = 1;
            this.BtnModificarEmpleado.IdleCornerRadius = 20;
            this.BtnModificarEmpleado.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnModificarEmpleado.IdleForecolor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.IdleLineColor = System.Drawing.Color.Black;
            this.BtnModificarEmpleado.Location = new System.Drawing.Point(507, 295);
            this.BtnModificarEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnModificarEmpleado.Name = "BtnModificarEmpleado";
            this.BtnModificarEmpleado.Size = new System.Drawing.Size(150, 39);
            this.BtnModificarEmpleado.TabIndex = 119;
            this.BtnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnModificarEmpleado.Click += new System.EventHandler(this.BtnModificarEmpleado_Click);
            // 
            // BtnGuardarProducto
            // 
            this.BtnGuardarProducto.ActiveBorderThickness = 1;
            this.BtnGuardarProducto.ActiveCornerRadius = 20;
            this.BtnGuardarProducto.ActiveFillColor = System.Drawing.Color.Transparent;
            this.BtnGuardarProducto.ActiveForecolor = System.Drawing.Color.Blue;
            this.BtnGuardarProducto.ActiveLineColor = System.Drawing.Color.Black;
            this.BtnGuardarProducto.BackColor = System.Drawing.Color.LightCyan;
            this.BtnGuardarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardarProducto.BackgroundImage")));
            this.BtnGuardarProducto.ButtonText = "Guardar";
            this.BtnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardarProducto.IdleBorderThickness = 1;
            this.BtnGuardarProducto.IdleCornerRadius = 20;
            this.BtnGuardarProducto.IdleFillColor = System.Drawing.Color.Transparent;
            this.BtnGuardarProducto.IdleForecolor = System.Drawing.Color.Black;
            this.BtnGuardarProducto.IdleLineColor = System.Drawing.Color.Black;
            this.BtnGuardarProducto.Location = new System.Drawing.Point(507, 248);
            this.BtnGuardarProducto.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuardarProducto.Name = "BtnGuardarProducto";
            this.BtnGuardarProducto.Size = new System.Drawing.Size(151, 37);
            this.BtnGuardarProducto.TabIndex = 116;
            this.BtnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProducto_Click);
            // 
            // Lbl_ID_Producto
            // 
            this.Lbl_ID_Producto.AutoSize = true;
            this.Lbl_ID_Producto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Producto.Location = new System.Drawing.Point(54, 252);
            this.Lbl_ID_Producto.Name = "Lbl_ID_Producto";
            this.Lbl_ID_Producto.Size = new System.Drawing.Size(126, 16);
            this.Lbl_ID_Producto.TabIndex = 126;
            this.Lbl_ID_Producto.Text = "NOMBRE PRODUCTO";
            // 
            // Txt_BuscarProducto
            // 
            this.Txt_BuscarProducto.Location = new System.Drawing.Point(227, 248);
            this.Txt_BuscarProducto.Name = "Txt_BuscarProducto";
            this.Txt_BuscarProducto.Size = new System.Drawing.Size(179, 20);
            this.Txt_BuscarProducto.TabIndex = 125;
            this.Txt_BuscarProducto.TextChanged += new System.EventHandler(this.Txt_BuscarProducto_TextChanged);
            // 
            // Registro_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(683, 548);
            this.Controls.Add(this.Lbl_ID_Producto);
            this.Controls.Add(this.Txt_BuscarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBuscarEmpleado);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.BtnModificarEmpleado);
            this.Controls.Add(this.BtnGuardarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Producto";
            this.Load += new System.EventHandler(this.Registro_Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnGuardarProducto;
        private System.Windows.Forms.TextBox txt_nombreproducto;
        private System.Windows.Forms.Label lbl_nombreproducto;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnBuscarEmpleado;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEliminarEmpleado;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnModificarEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lbl_ID_Producto;
        private System.Windows.Forms.TextBox Txt_BuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_pro;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
    }
}