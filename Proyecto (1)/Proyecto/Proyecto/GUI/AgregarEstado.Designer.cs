namespace Proyecto.GUI
{
    partial class LblAgregarEstado
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
            this.dtgv_AgEstado = new System.Windows.Forms.DataGridView();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_AgESTADO = new System.Windows.Forms.TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.BtnGuardarEstado = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_AgEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_AgEstado
            // 
            this.dtgv_AgEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_AgEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEstado,
            this.nombre_estado});
            this.dtgv_AgEstado.Location = new System.Drawing.Point(38, 144);
            this.dtgv_AgEstado.Name = "dtgv_AgEstado";
            this.dtgv_AgEstado.RowHeadersWidth = 51;
            this.dtgv_AgEstado.Size = new System.Drawing.Size(634, 273);
            this.dtgv_AgEstado.TabIndex = 11;
            this.dtgv_AgEstado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_AgEstado_CellContentClick);
            this.dtgv_AgEstado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_AgEstado_CellMouseClick);
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "ID Estado";
            this.idEstado.Name = "idEstado";
            // 
            // nombre_estado
            // 
            this.nombre_estado.DataPropertyName = "nombre_estado";
            this.nombre_estado.HeaderText = "Nombre Estado";
            this.nombre_estado.Name = "nombre_estado";
            // 
            // txt_AgESTADO
            // 
            this.txt_AgESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AgESTADO.Location = new System.Drawing.Point(247, 48);
            this.txt_AgESTADO.Name = "txt_AgESTADO";
            this.txt_AgESTADO.Size = new System.Drawing.Size(200, 40);
            this.txt_AgESTADO.TabIndex = 9;
            this.txt_AgESTADO.TextChanged += new System.EventHandler(this.txt_AgESTADO_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(48, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(173, 25);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "AGREGAR ESTADO";
            // 
            // BtnGuardarEstado
            // 
            this.BtnGuardarEstado.AnimationHoverSpeed = 0.07F;
            this.BtnGuardarEstado.AnimationSpeed = 0.03F;
            this.BtnGuardarEstado.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.BtnGuardarEstado.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.BtnGuardarEstado.BorderColor = System.Drawing.Color.Black;
            this.BtnGuardarEstado.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnGuardarEstado.FocusedColor = System.Drawing.Color.Empty;
            this.BtnGuardarEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnGuardarEstado.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarEstado.Image = global::Proyecto.Properties.Resources.business_ordering_pencil_table_2333;
            this.BtnGuardarEstado.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnGuardarEstado.Location = new System.Drawing.Point(498, 46);
            this.BtnGuardarEstado.Name = "BtnGuardarEstado";
            this.BtnGuardarEstado.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnGuardarEstado.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.BtnGuardarEstado.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnGuardarEstado.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnGuardarEstado.OnHoverImage = null;
            this.BtnGuardarEstado.OnPressedColor = System.Drawing.Color.Black;
            this.BtnGuardarEstado.Size = new System.Drawing.Size(160, 42);
            this.BtnGuardarEstado.TabIndex = 13;
            this.BtnGuardarEstado.Text = "Guardar Estado";
            this.BtnGuardarEstado.Click += new System.EventHandler(this.BtnGuardarEstado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.pictureBox2.Location = new System.Drawing.Point(726, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 124;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblAgregarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.cleaning_service_concept_colorful_cleaning_set_different_surfaces_kitchen_bathroom_other_rooms_top_view_background_126783_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnGuardarEstado);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.dtgv_AgEstado);
            this.Controls.Add(this.txt_AgESTADO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LblAgregarEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Estado";
            this.Load += new System.EventHandler(this.AgregarEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_AgEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_AgEstado;
        private System.Windows.Forms.TextBox txt_AgESTADO;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton BtnGuardarEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_estado;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}