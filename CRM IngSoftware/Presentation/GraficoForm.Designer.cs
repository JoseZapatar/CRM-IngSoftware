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
            this.SuspendLayout();
            // 
            // graficoVentas1
            // 
            this.graficoVentas1.Location = new System.Drawing.Point(92, 28);
            this.graficoVentas1.Name = "graficoVentas1";
            this.graficoVentas1.Size = new System.Drawing.Size(609, 393);
            this.graficoVentas1.TabIndex = 0;
            // 
            // GraficoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graficoVentas1);
            this.Name = "GraficoForm";
            this.Text = "GraficoForm";
            this.Load += new System.EventHandler(this.GraficoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GraficoVentas graficoVentas1;
    }
}