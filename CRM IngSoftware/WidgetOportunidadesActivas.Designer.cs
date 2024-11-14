namespace CRM_IngSoftware
{
    partial class WidgetOportunidades
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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.listOportunidadesActivas = new System.Windows.Forms.ListBox();
            this.listOportunidadesCerradas = new System.Windows.Forms.ListBox();
            this.lblActivas = new System.Windows.Forms.Label();
            this.lblCerradas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefrescar.Location = new System.Drawing.Point(335, 188);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(135, 42);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // listOportunidadesActivas
            // 
            this.listOportunidadesActivas.FormattingEnabled = true;
            this.listOportunidadesActivas.ItemHeight = 16;
            this.listOportunidadesActivas.Location = new System.Drawing.Point(0, 0);
            this.listOportunidadesActivas.Margin = new System.Windows.Forms.Padding(4);
            this.listOportunidadesActivas.Name = "listOportunidadesActivas";
            this.listOportunidadesActivas.Size = new System.Drawing.Size(391, 116);
            this.listOportunidadesActivas.TabIndex = 2;
            // 
            // listOportunidadesCerradas
            // 
            this.listOportunidadesCerradas.FormattingEnabled = true;
            this.listOportunidadesCerradas.ItemHeight = 16;
            this.listOportunidadesCerradas.Location = new System.Drawing.Point(400, 0);
            this.listOportunidadesCerradas.Margin = new System.Windows.Forms.Padding(4);
            this.listOportunidadesCerradas.Name = "listOportunidadesCerradas";
            this.listOportunidadesCerradas.Size = new System.Drawing.Size(428, 116);
            this.listOportunidadesCerradas.TabIndex = 3;
            this.listOportunidadesCerradas.SelectedIndexChanged += new System.EventHandler(this.listOportunidadesCerradas_SelectedIndexChanged);
            // 
            // lblActivas
            // 
            this.lblActivas.AutoSize = true;
            this.lblActivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivas.Location = new System.Drawing.Point(151, 126);
            this.lblActivas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivas.Name = "lblActivas";
            this.lblActivas.Size = new System.Drawing.Size(75, 18);
            this.lblActivas.TabIndex = 4;
            this.lblActivas.Text = "ACTIVAS";
            this.lblActivas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCerradas
            // 
            this.lblCerradas.AutoSize = true;
            this.lblCerradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerradas.Location = new System.Drawing.Point(595, 126);
            this.lblCerradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCerradas.Name = "lblCerradas";
            this.lblCerradas.Size = new System.Drawing.Size(98, 18);
            this.lblCerradas.TabIndex = 5;
            this.lblCerradas.Text = "CERRADAS";
            this.lblCerradas.Click += new System.EventHandler(this.lblCerradas_Click);
            // 
            // WidgetOportunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCerradas);
            this.Controls.Add(this.lblActivas);
            this.Controls.Add(this.listOportunidadesCerradas);
            this.Controls.Add(this.listOportunidadesActivas);
            this.Controls.Add(this.btnRefrescar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WidgetOportunidades";
            this.Size = new System.Drawing.Size(829, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ListBox listOportunidadesActivas;
        private System.Windows.Forms.ListBox listOportunidadesCerradas;
        private System.Windows.Forms.Label lblActivas;
        private System.Windows.Forms.Label lblCerradas;
    }
}
