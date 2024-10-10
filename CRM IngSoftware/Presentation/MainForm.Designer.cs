namespace CRM_IngSoftware.Presentation

{
    partial class MainForm
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
        private System.Windows.Forms.Button btnGestionarClientes;
        private System.Windows.Forms.Button btnGestionarVentas;
        private System.Windows.Forms.Button btnGestionarProductos;
        private System.Windows.Forms.Button btnGestionarReportes;
        private System.Windows.Forms.Button btnGestionarUsuarios;

        private void InitializeComponent()
        {
            this.btnGestionarClientes = new System.Windows.Forms.Button();
            this.btnGestionarVentas = new System.Windows.Forms.Button();
            this.btnGestionarProductos = new System.Windows.Forms.Button();
            this.btnGestionarReportes = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGestionarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarClientes.Location = new System.Drawing.Point(63, 62);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarClientes.TabIndex = 0;
            this.btnGestionarClientes.Text = "Gestionar Clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = false;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);
            // 
            // btnGestionarVentas
            // 
            this.btnGestionarVentas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGestionarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarVentas.Location = new System.Drawing.Point(63, 132);
            this.btnGestionarVentas.Name = "btnGestionarVentas";
            this.btnGestionarVentas.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarVentas.TabIndex = 1;
            this.btnGestionarVentas.Text = "Gestionar Ventas";
            this.btnGestionarVentas.UseVisualStyleBackColor = false;
            this.btnGestionarVentas.Click += new System.EventHandler(this.btnGestionarVentas_Click);
            // 
            // btnGestionarProductos
            // 
            this.btnGestionarProductos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGestionarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarProductos.Location = new System.Drawing.Point(63, 202);
            this.btnGestionarProductos.Name = "btnGestionarProductos";
            this.btnGestionarProductos.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarProductos.TabIndex = 2;
            this.btnGestionarProductos.Text = "Gestionar Productos";
            this.btnGestionarProductos.UseVisualStyleBackColor = false;
            this.btnGestionarProductos.Click += new System.EventHandler(this.btnGestionarProductos_Click);
            // 
            // btnGestionarReportes
            // 
            this.btnGestionarReportes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGestionarReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarReportes.Location = new System.Drawing.Point(63, 272);
            this.btnGestionarReportes.Name = "btnGestionarReportes";
            this.btnGestionarReportes.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarReportes.TabIndex = 3;
            this.btnGestionarReportes.Text = "Gestionar Reportes";
            this.btnGestionarReportes.UseVisualStyleBackColor = false;
            this.btnGestionarReportes.Click += new System.EventHandler(this.btnGestionarReportes_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(63, 342);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarUsuarios.TabIndex = 4;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(298, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 452);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.crm;
            this.pictureBox1.Location = new System.Drawing.Point(156, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGestionarClientes);
            this.Controls.Add(this.btnGestionarVentas);
            this.Controls.Add(this.btnGestionarProductos);
            this.Controls.Add(this.btnGestionarReportes);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Name = "MainForm";
            this.Text = "Sistema CRM - Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

