namespace CRM_IngSoftware.Presentation
{
    partial class GraficoForm
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
            this.graficoVentas1 = new CRM_IngSoftware.GraficoVentas();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // graficoVentas1
            // 
            this.graficoVentas1.Location = new System.Drawing.Point(138, 49);
            this.graficoVentas1.Margin = new System.Windows.Forms.Padding(5);
            this.graficoVentas1.Name = "graficoVentas1";
            this.graficoVentas1.Size = new System.Drawing.Size(823, 470);
            this.graficoVentas1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(404, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRÁFICO DE VENTAS";
            // 
            // GraficoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graficoVentas1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraficoForm";
            this.Text = "GraficoForm";
            this.Load += new System.EventHandler(this.GraficoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GraficoVentas graficoVentas1;
        private System.Windows.Forms.Label label1;
    }
}