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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteracciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoInteraccion
            // 
            this.cmbTipoInteraccion.FormattingEnabled = true;
            this.cmbTipoInteraccion.Location = new System.Drawing.Point(116, 82);
            this.cmbTipoInteraccion.Name = "cmbTipoInteraccion";
            this.cmbTipoInteraccion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoInteraccion.TabIndex = 0;
            // 
            // txtDetalleInteraccion
            // 
            this.txtDetalleInteraccion.Location = new System.Drawing.Point(116, 122);
            this.txtDetalleInteraccion.Name = "txtDetalleInteraccion";
            this.txtDetalleInteraccion.Size = new System.Drawing.Size(100, 20);
            this.txtDetalleInteraccion.TabIndex = 1;
            this.txtDetalleInteraccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvInteracciones
            // 
            this.dgvInteracciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInteracciones.Location = new System.Drawing.Point(116, 167);
            this.dgvInteracciones.Name = "dgvInteracciones";
            this.dgvInteracciones.Size = new System.Drawing.Size(240, 150);
            this.dgvInteracciones.TabIndex = 2;
            // 
            // btnAgregarInteraccion
            // 
            this.btnAgregarInteraccion.Location = new System.Drawing.Point(116, 337);
            this.btnAgregarInteraccion.Name = "btnAgregarInteraccion";
            this.btnAgregarInteraccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarInteraccion.TabIndex = 3;
            this.btnAgregarInteraccion.Text = "Agregar";
            this.btnAgregarInteraccion.UseVisualStyleBackColor = true;
            this.btnAgregarInteraccion.Click += new System.EventHandler(this.btnAgregarInteraccion_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interacciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GestionInteraccionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarInteraccion);
            this.Controls.Add(this.dgvInteracciones);
            this.Controls.Add(this.txtDetalleInteraccion);
            this.Controls.Add(this.cmbTipoInteraccion);
            this.Name = "GestionInteraccionesForm";
            this.Text = "GestionInteraccionesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInteracciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoInteraccion;
        private System.Windows.Forms.TextBox txtDetalleInteraccion;
        private System.Windows.Forms.DataGridView dgvInteracciones;
        private System.Windows.Forms.Button btnAgregarInteraccion;
        private System.Windows.Forms.Label label1;
    }
}