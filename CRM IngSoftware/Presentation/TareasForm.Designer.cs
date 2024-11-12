namespace CRM_IngSoftware.Presentation
{
    partial class TareasForm
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
            this.widgetTareas1 = new CRM_IngSoftware.WidgetTareas();
            this.SuspendLayout();
            // 
            // widgetTareas1
            // 
            this.widgetTareas1.Location = new System.Drawing.Point(185, 63);
            this.widgetTareas1.Margin = new System.Windows.Forms.Padding(5);
            this.widgetTareas1.Name = "widgetTareas1";
            this.widgetTareas1.Size = new System.Drawing.Size(679, 404);
            this.widgetTareas1.TabIndex = 0;
            this.widgetTareas1.Load += new System.EventHandler(this.widgetTareas1_Load);
            // 
            // TareasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.widgetTareas1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TareasForm";
            this.Text = "TareasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetTareas widgetTareas1;
    }
}