namespace CRM_IngSoftware.Presentation
{
    partial class GestionInteraccionesForm
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
            this.cmbTipoInteraccion = new System.Windows.Forms.ComboBox();
            this.txtDetalleInteraccion = new System.Windows.Forms.TextBox();
            this.dgvInteracciones = new System.Windows.Forms.DataGridView();
            this.btnAgregarInteraccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteracciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoInteraccion
            // 
            this.cmbTipoInteraccion.FormattingEnabled = true;
            this.cmbTipoInteraccion.Location = new System.Drawing.Point(603, 94);
            this.cmbTipoInteraccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoInteraccion.Name = "cmbTipoInteraccion";
            this.cmbTipoInteraccion.Size = new System.Drawing.Size(385, 24);
            this.cmbTipoInteraccion.TabIndex = 0;
            // 
            // txtDetalleInteraccion
            // 
            this.txtDetalleInteraccion.Location = new System.Drawing.Point(603, 171);
            this.txtDetalleInteraccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalleInteraccion.Name = "txtDetalleInteraccion";
            this.txtDetalleInteraccion.Size = new System.Drawing.Size(385, 22);
            this.txtDetalleInteraccion.TabIndex = 1;
            this.txtDetalleInteraccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvInteracciones
            // 
            this.dgvInteracciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteracciones.Location = new System.Drawing.Point(603, 441);
            this.dgvInteracciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInteracciones.Name = "dgvInteracciones";
            this.dgvInteracciones.RowHeadersWidth = 51;
            this.dgvInteracciones.Size = new System.Drawing.Size(385, 185);
            this.dgvInteracciones.TabIndex = 2;
            // 
            // btnAgregarInteraccion
            // 
            this.btnAgregarInteraccion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarInteraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarInteraccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarInteraccion.Location = new System.Drawing.Point(702, 652);
            this.btnAgregarInteraccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarInteraccion.Name = "btnAgregarInteraccion";
            this.btnAgregarInteraccion.Size = new System.Drawing.Size(221, 39);
            this.btnAgregarInteraccion.TabIndex = 3;
            this.btnAgregarInteraccion.Text = "Agregar";
            this.btnAgregarInteraccion.UseVisualStyleBackColor = false;
            this.btnAgregarInteraccion.Click += new System.EventHandler(this.btnAgregarInteraccion_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(718, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interacciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.interactive;
            this.pictureBox1.Location = new System.Drawing.Point(121, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(603, 220);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(385, 185);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Detalle de Interacción";
            // 
            // GestionInteraccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1203, 746);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarInteraccion);
            this.Controls.Add(this.dgvInteracciones);
            this.Controls.Add(this.txtDetalleInteraccion);
            this.Controls.Add(this.cmbTipoInteraccion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionInteraccionesForm";
            this.Text = "GestionInteraccionesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteracciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoInteraccion;
        private System.Windows.Forms.TextBox txtDetalleInteraccion;
        private System.Windows.Forms.DataGridView dgvInteracciones;
        private System.Windows.Forms.Button btnAgregarInteraccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label2;
    }
}