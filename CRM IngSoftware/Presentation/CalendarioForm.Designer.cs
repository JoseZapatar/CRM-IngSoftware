namespace CRM_IngSoftware.Presentation
{
    partial class CalendarioForm
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
            this.gadgetCalendario1 = new CRM_IngSoftware.GadgetCalendario();
            this.SuspendLayout();
            // 
            // gadgetCalendario1
            // 
            this.gadgetCalendario1.Location = new System.Drawing.Point(84, 33);
            this.gadgetCalendario1.Name = "gadgetCalendario1";
            this.gadgetCalendario1.Size = new System.Drawing.Size(626, 342);
            this.gadgetCalendario1.TabIndex = 0;
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gadgetCalendario1);
            this.Name = "CalendarioForm";
            this.Text = "CalendarioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GadgetCalendario gadgetCalendario1;
    }
}