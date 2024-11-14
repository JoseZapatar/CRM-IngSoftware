namespace CRM_IngSoftware
{
    partial class WidgetTareas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listTareasPendientes = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.listTareasCompletadas = new System.Windows.Forms.ListBox();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblCompletadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listTareasPendientes
            // 
            this.listTareasPendientes.FormattingEnabled = true;
            this.listTareasPendientes.ItemHeight = 16;
            this.listTareasPendientes.Location = new System.Drawing.Point(4, 4);
            this.listTareasPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.listTareasPendientes.Name = "listTareasPendientes";
            this.listTareasPendientes.Size = new System.Drawing.Size(287, 148);
            this.listTareasPendientes.TabIndex = 0;
            this.listTareasPendientes.SelectedIndexChanged += new System.EventHandler(this.lstTareas_SelectedIndexChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(260, 226);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 39);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // listTareasCompletadas
            // 
            this.listTareasCompletadas.FormattingEnabled = true;
            this.listTareasCompletadas.ItemHeight = 16;
            this.listTareasCompletadas.Location = new System.Drawing.Point(349, 4);
            this.listTareasCompletadas.Margin = new System.Windows.Forms.Padding(4);
            this.listTareasCompletadas.Name = "listTareasCompletadas";
            this.listTareasCompletadas.Size = new System.Drawing.Size(316, 148);
            this.listTareasCompletadas.TabIndex = 2;
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.Location = new System.Drawing.Point(48, 161);
            this.lblPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(113, 18);
            this.lblPendientes.TabIndex = 3;
            this.lblPendientes.Text = "PENDIENTES";
            this.lblPendientes.Click += new System.EventHandler(this.lblPendientes_Click);
            // 
            // lblCompletadas
            // 
            this.lblCompletadas.AutoSize = true;
            this.lblCompletadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletadas.Location = new System.Drawing.Point(481, 161);
            this.lblCompletadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompletadas.Name = "lblCompletadas";
            this.lblCompletadas.Size = new System.Drawing.Size(131, 18);
            this.lblCompletadas.TabIndex = 4;
            this.lblCompletadas.Text = "COMPLETADAS";
            // 
            // WidgetTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCompletadas);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.listTareasCompletadas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.listTareasPendientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WidgetTareas";
            this.Size = new System.Drawing.Size(699, 501);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTareasPendientes;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox listTareasCompletadas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCompletadas;
    }
}
