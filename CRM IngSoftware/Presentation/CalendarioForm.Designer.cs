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
            this.gadgetCalendario1.BackColor = System.Drawing.SystemColors.Info;
            this.gadgetCalendario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gadgetCalendario1.Location = new System.Drawing.Point(80, 67);
            this.gadgetCalendario1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gadgetCalendario1.Name = "gadgetCalendario1";
            this.gadgetCalendario1.Size = new System.Drawing.Size(899, 421);
            this.gadgetCalendario1.TabIndex = 0;
            this.gadgetCalendario1.Load += new System.EventHandler(this.gadgetCalendario1_Load);
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gadgetCalendario1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalendarioForm";
            this.Text = "CalendarioForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GadgetCalendario gadgetCalendario1;
    }
}