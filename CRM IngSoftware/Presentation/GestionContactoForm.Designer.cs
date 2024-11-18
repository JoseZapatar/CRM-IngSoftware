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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoContacto
            // 
            this.cmbTipoContacto.FormattingEnabled = true;
            this.cmbTipoContacto.Location = new System.Drawing.Point(398, 95);
            this.cmbTipoContacto.Name = "cmbTipoContacto";
            this.cmbTipoContacto.Size = new System.Drawing.Size(241, 21);
            this.cmbTipoContacto.TabIndex = 0;
            this.cmbTipoContacto.SelectedIndexChanged += new System.EventHandler(this.cmbTipoContacto_SelectedIndexChanged);
            // 
            // txtValorContacto
            // 
            this.txtValorContacto.Location = new System.Drawing.Point(398, 145);
            this.txtValorContacto.Name = "txtValorContacto";
            this.txtValorContacto.Size = new System.Drawing.Size(241, 20);
            this.txtValorContacto.TabIndex = 1;
            this.txtValorContacto.TextChanged += new System.EventHandler(this.txtValorContacto_TextChanged);
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(399, 355);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(240, 150);
            this.dgvContactos.TabIndex = 2;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarContacto.Location = new System.Drawing.Point(434, 536);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(166, 32);
            this.btnAgregarContacto.TabIndex = 3;
            this.btnAgregarContacto.Text = "Agregar";
            this.btnAgregarContacto.UseVisualStyleBackColor = false;
            this.btnAgregarContacto.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contactos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.contact;
            this.pictureBox1.Location = new System.Drawing.Point(103, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(398, 188);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(240, 150);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // GestionContactoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(902, 580);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarContacto);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.txtValorContacto);
            this.Controls.Add(this.cmbTipoContacto);
            this.Name = "GestionContactoForm";
            this.Text = "GestionContactoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoContacto;
        private System.Windows.Forms.TextBox txtValorContacto;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}