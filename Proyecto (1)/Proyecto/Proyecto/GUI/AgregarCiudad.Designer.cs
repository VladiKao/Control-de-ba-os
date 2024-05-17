namespace Proyecto.GUI
{
    partial class AgregarCiudad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCiudad));
            this.dtgv_Agciudad = new System.Windows.Forms.DataGridView();
            this.ID_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_guardarciudad = new System.Windows.Forms.PictureBox();
            this.txt_Agciudad = new System.Windows.Forms.TextBox();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Agciudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardarciudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Agciudad
            // 
            this.dtgv_Agciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Agciudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ciudad,
            this.Nombre_Ciudad,
            this.idEstado});
            this.dtgv_Agciudad.Location = new System.Drawing.Point(108, 143);
            this.dtgv_Agciudad.Name = "dtgv_Agciudad";
            this.dtgv_Agciudad.RowHeadersWidth = 51;
            this.dtgv_Agciudad.Size = new System.Drawing.Size(580, 273);
            this.dtgv_Agciudad.TabIndex = 11;
            this.dtgv_Agciudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Agciudad_CellContentClick);
            this.dtgv_Agciudad.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_Agciudad_CellMouseClick);
            // 
            // ID_Ciudad
            // 
            this.ID_Ciudad.DataPropertyName = "ID_Ciudad";
            this.ID_Ciudad.HeaderText = "ID Ciudad";
            this.ID_Ciudad.Name = "ID_Ciudad";
            // 
            // Nombre_Ciudad
            // 
            this.Nombre_Ciudad.DataPropertyName = "Nombre_Ciudad";
            this.Nombre_Ciudad.HeaderText = "Nombre Ciudad";
            this.Nombre_Ciudad.Name = "Nombre_Ciudad";
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "Estado";
            this.idEstado.Name = "idEstado";
            // 
            // btn_guardarciudad
            // 
            this.btn_guardarciudad.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardarciudad.Image")));
            this.btn_guardarciudad.Location = new System.Drawing.Point(525, 68);
            this.btn_guardarciudad.Name = "btn_guardarciudad";
            this.btn_guardarciudad.Size = new System.Drawing.Size(56, 44);
            this.btn_guardarciudad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_guardarciudad.TabIndex = 10;
            this.btn_guardarciudad.TabStop = false;
            this.btn_guardarciudad.Click += new System.EventHandler(this.btn_guardarciudad_Click);
            // 
            // txt_Agciudad
            // 
            this.txt_Agciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Agciudad.Location = new System.Drawing.Point(216, 90);
            this.txt_Agciudad.Name = "txt_Agciudad";
            this.txt_Agciudad.Size = new System.Drawing.Size(200, 40);
            this.txt_Agciudad.TabIndex = 9;
            this.txt_Agciudad.TextChanged += new System.EventHandler(this.txt_Agciudad_TextChanged);
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudad.Location = new System.Drawing.Point(40, 93);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(119, 37);
            this.lbl_ciudad.TabIndex = 8;
            this.lbl_ciudad.Text = "Ciudad";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(669, -2);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 125;
            this.label1.Text = "Estado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 21);
            this.comboBox2.TabIndex = 127;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AgregarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtgv_Agciudad);
            this.Controls.Add(this.btn_guardarciudad);
            this.Controls.Add(this.txt_Agciudad);
            this.Controls.Add(this.lbl_ciudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCiudad";
            this.Load += new System.EventHandler(this.AgregarCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Agciudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardarciudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Agciudad;
        private System.Windows.Forms.PictureBox btn_guardarciudad;
        private System.Windows.Forms.TextBox txt_Agciudad;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}