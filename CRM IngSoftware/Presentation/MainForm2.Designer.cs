namespace CRM_IngSoftware.Presentation
{
    partial class MainForm2
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
            this.btnAgregarOportunidad = new System.Windows.Forms.Button();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarOportunidad
            // 
            this.btnAgregarOportunidad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarOportunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOportunidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarOportunidad.Location = new System.Drawing.Point(642, 381);
            this.btnAgregarOportunidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarOportunidad.Name = "btnAgregarOportunidad";
            this.btnAgregarOportunidad.Size = new System.Drawing.Size(120, 50);
            this.btnAgregarOportunidad.TabIndex = 11;
            this.btnAgregarOportunidad.Text = "Agregar Oportunidad";
            this.btnAgregarOportunidad.UseVisualStyleBackColor = false;
            this.btnAgregarOportunidad.Click += new System.EventHandler(this.btnAgregarOportunidad_Click);
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEvento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarEvento.Location = new System.Drawing.Point(475, 381);
            this.btnAgregarEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(120, 50);
            this.btnAgregarEvento.TabIndex = 10;
            this.btnAgregarEvento.Text = "Agregar Evento";
            this.btnAgregarEvento.UseVisualStyleBackColor = false;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarTarea.Location = new System.Drawing.Point(304, 381);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(120, 50);
            this.btnAgregarTarea.TabIndex = 9;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.crm;
            this.pictureBox1.Location = new System.Drawing.Point(331, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(992, 503);
            this.Controls.Add(this.btnAgregarOportunidad);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregarOportunidad;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.Button btnAgregarTarea;
    }
}