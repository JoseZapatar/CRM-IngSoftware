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
            this.widgetTareas1.Location = new System.Drawing.Point(140, 56);
            this.widgetTareas1.Name = "widgetTareas1";
            this.widgetTareas1.Size = new System.Drawing.Size(509, 328);
            this.widgetTareas1.TabIndex = 0;
            // 
            // TareasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.widgetTareas1);
            this.Name = "TareasForm";
            this.Text = "TareasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetTareas widgetTareas1;
    }
}