namespace CRM_IngSoftware.Presentation
{
    partial class GestionContactoForm
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
            this.cmbTipoContacto = new System.Windows.Forms.ComboBox();
            this.txtValorContacto = new System.Windows.Forms.TextBox();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoContacto
            // 
            this.cmbTipoContacto.FormattingEnabled = true;
            this.cmbTipoContacto.Location = new System.Drawing.Point(156, 75);
            this.cmbTipoContacto.Name = "cmbTipoContacto";
            this.cmbTipoContacto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoContacto.TabIndex = 0;
            this.cmbTipoContacto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContacto_SelectedIndexChanged);
            // 
            // txtValorContacto
            // 
            this.txtValorContacto.Location = new System.Drawing.Point(156, 118);
            this.txtValorContacto.Name = "txtValorContacto";
            this.txtValorContacto.Size = new System.Drawing.Size(100, 20);
            this.txtValorContacto.TabIndex = 1;
            this.txtValorContacto.TextChanged += new System.EventHandler(this.txtValorContacto_TextChanged);
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(156, 169);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(240, 150);
            this.dgvContactos.TabIndex = 2;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.Location = new System.Drawing.Point(156, 335);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarContacto.TabIndex = 3;
            this.btnAgregarContacto.Text = "Agregar";
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            this.btnAgregarContacto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contactos";
            // 
            // GestionContactoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarContacto);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.txtValorContacto);
            this.Controls.Add(this.cmbTipoContacto);
            this.Name = "GestionContactoForm";
            this.Text = "GestionContactoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoContacto;
        private System.Windows.Forms.TextBox txtValorContacto;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Label label1;
    }
}