namespace CRM_IngSoftware.Presentation
{
    partial class ActivosForm
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
            this.widgetOportunidades1 = new CRM_IngSoftware.WidgetOportunidades();
            this.SuspendLayout();
            // 
            // widgetOportunidades1
            // 
            this.widgetOportunidades1.Location = new System.Drawing.Point(91, 12);
            this.widgetOportunidades1.Name = "widgetOportunidades1";
            this.widgetOportunidades1.Size = new System.Drawing.Size(622, 199);
            this.widgetOportunidades1.TabIndex = 0;
            // 
            // ActivosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.widgetOportunidades1);
            this.Name = "ActivosForm";
            this.Text = "ActivosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private WidgetOportunidades widgetOportunidades1;
    }
}