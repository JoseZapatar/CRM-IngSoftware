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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gadgetCalendario1
            // 
            this.gadgetCalendario1.BackColor = System.Drawing.SystemColors.Info;
            this.gadgetCalendario1.Location = new System.Drawing.Point(56, 14);
            this.gadgetCalendario1.Margin = new System.Windows.Forms.Padding(5);
            this.gadgetCalendario1.Name = "gadgetCalendario1";
            this.gadgetCalendario1.Size = new System.Drawing.Size(875, 475);
            this.gadgetCalendario1.TabIndex = 0;
            this.gadgetCalendario1.Load += new System.EventHandler(this.gadgetCalendario1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.meeting;
            this.pictureBox1.Location = new System.Drawing.Point(712, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CalendarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(992, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gadgetCalendario1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarioForm";
            this.Text = "CalendarioForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GadgetCalendario gadgetCalendario1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}