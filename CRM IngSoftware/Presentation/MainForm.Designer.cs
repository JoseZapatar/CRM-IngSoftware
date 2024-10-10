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

            // 
            // btnGestionarClientes
            // 
            this.btnGestionarClientes.Location = new System.Drawing.Point(50, 50);
            this.btnGestionarClientes.Name = "btnGestionarClientes";
            this.btnGestionarClientes.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarClientes.Text = "Gestionar Clientes";
            this.btnGestionarClientes.UseVisualStyleBackColor = true;
            this.btnGestionarClientes.Click += new System.EventHandler(this.btnGestionarClientes_Click);

            // 
            // btnGestionarVentas
            // 
            this.btnGestionarVentas.Location = new System.Drawing.Point(50, 120);
            this.btnGestionarVentas.Name = "btnGestionarVentas";
            this.btnGestionarVentas.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarVentas.Text = "Gestionar Ventas";
            this.btnGestionarVentas.UseVisualStyleBackColor = true;
            this.btnGestionarVentas.Click += new System.EventHandler(this.btnGestionarVentas_Click);

            // 
            // btnGestionarProductos
            // 
            this.btnGestionarProductos.Location = new System.Drawing.Point(50, 190);
            this.btnGestionarProductos.Name = "btnGestionarProductos";
            this.btnGestionarProductos.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarProductos.Text = "Gestionar Productos";
            this.btnGestionarProductos.UseVisualStyleBackColor = true;
            this.btnGestionarProductos.Click += new System.EventHandler(this.btnGestionarProductos_Click);

            // 
            // btnGestionarReportes
            // 
            this.btnGestionarReportes.Location = new System.Drawing.Point(50, 260);
            this.btnGestionarReportes.Name = "btnGestionarReportes";
            this.btnGestionarReportes.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarReportes.Text = "Gestionar Reportes";
            this.btnGestionarReportes.UseVisualStyleBackColor = true;
            this.btnGestionarReportes.Click += new System.EventHandler(this.btnGestionarReportes_Click);

            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(50, 330);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(150, 50);
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnGestionarClientes);
            this.Controls.Add(this.btnGestionarVentas);
            this.Controls.Add(this.btnGestionarProductos);
            this.Controls.Add(this.btnGestionarReportes);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Name = "MainForm";
            this.Text = "Sistema CRM - Principal";
            this.ResumeLayout(false);
        }


        #endregion
    }
}

