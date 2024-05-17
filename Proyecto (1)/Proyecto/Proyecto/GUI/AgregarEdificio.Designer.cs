namespace Proyecto.GUI
{
    partial class AgregarEdificio
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
            this.lbl_Edificio = new System.Windows.Forms.Label();
            this.txt_Edificio = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dtgv_Edificio = new System.Windows.Forms.DataGridView();
            this.ID_Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letra_Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptb_Cerrrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Edificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Cerrrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Edificio
            // 
            this.lbl_Edificio.AutoSize = true;
            this.lbl_Edificio.Location = new System.Drawing.Point(56, 61);
            this.lbl_Edificio.Name = "lbl_Edificio";
            this.lbl_Edificio.Size = new System.Drawing.Size(41, 13);
            this.lbl_Edificio.TabIndex = 0;
            this.lbl_Edificio.Text = "Edificio";
            // 
            // txt_Edificio
            // 
            this.txt_Edificio.Location = new System.Drawing.Point(139, 61);
            this.txt_Edificio.Name = "txt_Edificio";
            this.txt_Edificio.Size = new System.Drawing.Size(205, 20);
            this.txt_Edificio.TabIndex = 1;
            this.txt_Edificio.TextChanged += new System.EventHandler(this.txt_Edificio_TextChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(391, 56);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 2;
            this.btn_guardar.Text = "guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // dtgv_Edificio
            // 
            this.dtgv_Edificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Edificio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Edificio,
            this.letra_Edificio});
            this.dtgv_Edificio.Location = new System.Drawing.Point(49, 164);
            this.dtgv_Edificio.Name = "dtgv_Edificio";
            this.dtgv_Edificio.Size = new System.Drawing.Size(260, 172);
            this.dtgv_Edificio.TabIndex = 3;
            this.dtgv_Edificio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_Edificio_CellMouseClick);
            // 
            // ID_Edificio
            // 
            this.ID_Edificio.DataPropertyName = "ID_Edificio";
            this.ID_Edificio.HeaderText = "ID";
            this.ID_Edificio.Name = "ID_Edificio";
            // 
            // letra_Edificio
            // 
            this.letra_Edificio.DataPropertyName = "letra_Edificio";
            this.letra_Edificio.HeaderText = "Edificio";
            this.letra_Edificio.Name = "letra_Edificio";
            // 
            // ptb_Cerrrar
            // 
            this.ptb_Cerrrar.Image = global::Proyecto.Properties.Resources.delete_remove_16744;
            this.ptb_Cerrrar.Location = new System.Drawing.Point(557, 47);
            this.ptb_Cerrrar.Name = "ptb_Cerrrar";
            this.ptb_Cerrrar.Size = new System.Drawing.Size(35, 32);
            this.ptb_Cerrrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Cerrrar.TabIndex = 125;
            this.ptb_Cerrrar.TabStop = false;
            this.ptb_Cerrrar.Click += new System.EventHandler(this.ptb_Cerrrar_Click);
            // 
            // AgregarEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_Cerrrar);
            this.Controls.Add(this.dtgv_Edificio);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_Edificio);
            this.Controls.Add(this.lbl_Edificio);
            this.Name = "AgregarEdificio";
            this.Text = "AgregarEdificio";
            this.Load += new System.EventHandler(this.AgregarEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Edificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Cerrrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Edificio;
        private System.Windows.Forms.TextBox txt_Edificio;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dtgv_Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn letra_Edificio;
        private System.Windows.Forms.PictureBox ptb_Cerrrar;
    }
}