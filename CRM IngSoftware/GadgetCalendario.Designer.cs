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
            this.calendario.Location = new System.Drawing.Point(154, 170);
            this.calendario.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 0;
            this.calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateSelected_1);
            // 
            // listEventos
            // 
            this.listEventos.FormattingEnabled = true;
            this.listEventos.ItemHeight = 16;
            this.listEventos.Location = new System.Drawing.Point(483, 170);
            this.listEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listEventos.Name = "listEventos";
            this.listEventos.Size = new System.Drawing.Size(353, 196);
            this.listEventos.TabIndex = 1;
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblEventos.Location = new System.Drawing.Point(286, 45);
            this.lblEventos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(348, 29);
            this.lblEventos.TabIndex = 2;
            this.lblEventos.Text = "CALENDARIO DE EVENTOS";
            // 
            // GadgetCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.listEventos);
            this.Controls.Add(this.calendario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GadgetCalendario";
            this.Size = new System.Drawing.Size(948, 629);
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
