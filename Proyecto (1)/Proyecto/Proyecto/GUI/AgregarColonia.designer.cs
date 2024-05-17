namespace Proyecto.GUI
{
    partial class AgregarColonia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarColonia));
            this.txt_AgCol = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblAgregarColonia = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CbxCiudad = new System.Windows.Forms.ComboBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_AgCol
            // 
            this.txt_AgCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AgCol.Location = new System.Drawing.Point(181, 74);
            this.txt_AgCol.Name = "txt_AgCol";
            this.txt_AgCol.Size = new System.Drawing.Size(200, 40);
            this.txt_AgCol.TabIndex = 1;
            this.txt_AgCol.TextChanged += new System.EventHandler(this.txt_AgCol_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LblAgregarColonia
            // 
            this.LblAgregarColonia.AutoSize = true;
            this.LblAgregarColonia.BackColor = System.Drawing.Color.Transparent;
            this.LblAgregarColonia.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarColonia.Location = new System.Drawing.Point(31, 84);
            this.LblAgregarColonia.Name = "LblAgregarColonia";
            this.LblAgregarColonia.Size = new System.Drawing.Size(78, 25);
            this.LblAgregarColonia.TabIndex = 8;
            this.LblAgregarColonia.Text = "Colonia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(766, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // CbxCiudad
            // 
            this.CbxCiudad.FormattingEnabled = true;
            this.CbxCiudad.Location = new System.Drawing.Point(181, 39);
            this.CbxCiudad.Name = "CbxCiudad";
            this.CbxCiudad.Size = new System.Drawing.Size(194, 21);
            this.CbxCiudad.TabIndex = 129;
            this.CbxCiudad.Text = "Seleccionar";
            this.CbxCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.LblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(29, 23);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(119, 37);
            this.LblCiudad.TabIndex = 128;
            this.LblCiudad.Text = "Ciudad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Colonia,
            this.Nombre_Colonia,
            this.ID_Ciudad});
            this.dataGridView1.Location = new System.Drawing.Point(71, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 213);
            this.dataGridView1.TabIndex = 130;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ID_Colonia
            // 
            this.ID_Colonia.DataPropertyName = "ID_Colonia";
            this.ID_Colonia.HeaderText = "ID Colonia";
            this.ID_Colonia.Name = "ID_Colonia";
            // 
            // Nombre_Colonia
            // 
            this.Nombre_Colonia.DataPropertyName = "Nombre_Colonia";
            this.Nombre_Colonia.HeaderText = "Nombre Colonia";
            this.Nombre_Colonia.Name = "Nombre_Colonia";
            // 
            // ID_Ciudad
            // 
            this.ID_Ciudad.DataPropertyName = "ID_Ciudad";
            this.ID_Ciudad.HeaderText = "Ciudad";
            this.ID_Ciudad.Name = "ID_Ciudad";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox3.Location = new System.Drawing.Point(525, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AgregarColonia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CbxCiudad);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblAgregarColonia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_AgCol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarColonia";
            this.Text = "AgregarColonia";
            this.Load += new System.EventHandler(this.AgregarColonia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_AgCol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel LblAgregarColonia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CbxCiudad;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ciudad;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}