namespace CRM_IngSoftware.Presentation
{
    partial class GestionClientesEstadoForm
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
            this.dgvClientesEstado = new System.Windows.Forms.DataGridView();
            this.btnEnviarAlertas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbAlertas = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientesEstado
            // 
            this.dgvClientesEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesEstado.Location = new System.Drawing.Point(167, 135);
            this.dgvClientesEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientesEstado.Name = "dgvClientesEstado";
            this.dgvClientesEstado.RowHeadersWidth = 51;
            this.dgvClientesEstado.Size = new System.Drawing.Size(720, 185);
            this.dgvClientesEstado.TabIndex = 0;
            this.dgvClientesEstado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesEstado_CellContentClick);
            // 
            // btnEnviarAlertas
            // 
            this.btnEnviarAlertas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEnviarAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEnviarAlertas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviarAlertas.Location = new System.Drawing.Point(477, 347);
            this.btnEnviarAlertas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviarAlertas.Name = "btnEnviarAlertas";
            this.btnEnviarAlertas.Size = new System.Drawing.Size(133, 38);
            this.btnEnviarAlertas.TabIndex = 1;
            this.btnEnviarAlertas.Text = "Enviar Aviso";
            this.btnEnviarAlertas.UseVisualStyleBackColor = false;
            this.btnEnviarAlertas.Click += new System.EventHandler(this.btnEnviarAlertas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "GESTIÓN DE ESTADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.customer_service;
            this.pictureBox1.Location = new System.Drawing.Point(684, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // rtbAlertas
            // 
            this.rtbAlertas.Location = new System.Drawing.Point(167, 410);
            this.rtbAlertas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbAlertas.Name = "rtbAlertas";
            this.rtbAlertas.Size = new System.Drawing.Size(719, 117);
            this.rtbAlertas.TabIndex = 11;
            this.rtbAlertas.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(906, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Estado Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionClientesEstadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbAlertas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarAlertas);
            this.Controls.Add(this.dgvClientesEstado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionClientesEstadoForm";
            this.Text = "GestionClientesEstadoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientesEstado;
        private System.Windows.Forms.Button btnEnviarAlertas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtbAlertas;
        private System.Windows.Forms.Button button1;
    }
}