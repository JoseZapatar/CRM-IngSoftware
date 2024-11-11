namespace CRM_IngSoftware
{
    partial class GadgetCalendario
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
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.listEventos = new System.Windows.Forms.ListBox();
            this.lblEventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(9, 28);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected_1);
            // 
            // listEventos
            // 
            this.listEventos.FormattingEnabled = true;
            this.listEventos.Location = new System.Drawing.Point(222, 28);
            this.listEventos.Name = "listEventos";
            this.listEventos.Size = new System.Drawing.Size(266, 160);
            this.listEventos.TabIndex = 1;
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Location = new System.Drawing.Point(269, 191);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(58, 13);
            this.lblEventos.TabIndex = 2;
            this.lblEventos.Text = "EVENTOS";
            // 
            // GadgetCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.listEventos);
            this.Controls.Add(this.calendario);
            this.Name = "GadgetCalendario";
            this.Size = new System.Drawing.Size(711, 511);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.ListBox listEventos;
        private System.Windows.Forms.Label lblEventos;
    }
}
