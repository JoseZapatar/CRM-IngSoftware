namespace CRM_IngSoftware.Presentation
{
    partial class ActualizadorEstadosForm
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnActualizarEstados = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(246, 103);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(325, 150);
            this.dgvClientes.TabIndex = 0;
            // 
            // btnActualizarEstados
            // 
            this.btnActualizarEstados.Location = new System.Drawing.Point(374, 259);
            this.btnActualizarEstados.Name = "btnActualizarEstados";
            this.btnActualizarEstados.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarEstados.TabIndex = 1;
            this.btnActualizarEstados.Text = "Actualizar";
            this.btnActualizarEstados.UseVisualStyleBackColor = true;
            this.btnActualizarEstados.Click += new System.EventHandler(this.btnActualizarEstados_Click_1);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(402, 285);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(12, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "l-";
            // 
            // ActualizadorEstadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnActualizarEstados);
            this.Controls.Add(this.dgvClientes);
            this.Name = "ActualizadorEstadosForm";
            this.Text = "ActualizadorEstadosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnActualizarEstados;
        private System.Windows.Forms.Label lblResultado;
    }
}