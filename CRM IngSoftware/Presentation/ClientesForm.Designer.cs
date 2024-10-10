namespace CRM_IngSoftware.Presentation
{
    partial class ClientesForm
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

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;

private void InitializeComponent()
{
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(50, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.Text = "Nombre del Cliente"; // Inicialmente muestra el texto del placeholder
            this.txtNombre.ForeColor = System.Drawing.Color.Gray; // Color del texto placeholder
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);

            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(50, 70);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 26);
            this.txtCorreo.Text = "Correo del Cliente";
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);

            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(50, 110);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 26);
            this.txtTelefono.Text = "Teléfono del Cliente";
            this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);

            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(50, 150);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 26);
            this.txtDireccion.Text = "Dirección del Cliente";
            this.txtDireccion.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(270, 30);
    this.btnAgregarCliente.Name = "btnAgregarCliente";
    this.btnAgregarCliente.Size = new System.Drawing.Size(100, 40);
    this.btnAgregarCliente.Text = "Agregar";
    this.btnAgregarCliente.UseVisualStyleBackColor = true;
    this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);

    // 
    // btnEditarCliente
    // 
    this.btnEditarCliente.Location = new System.Drawing.Point(270, 80);
    this.btnEditarCliente.Name = "btnEditarCliente";
    this.btnEditarCliente.Size = new System.Drawing.Size(100, 40);
    this.btnEditarCliente.Text = "Editar";
    this.btnEditarCliente.UseVisualStyleBackColor = true;
    this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);

    // 
    // btnEliminarCliente
    // 
    this.btnEliminarCliente.Location = new System.Drawing.Point(270, 130);
    this.btnEliminarCliente.Name = "btnEliminarCliente";
    this.btnEliminarCliente.Size = new System.Drawing.Size(100, 40);
    this.btnEliminarCliente.Text = "Eliminar";
    this.btnEliminarCliente.UseVisualStyleBackColor = true;
    this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);

    // 
    // dgvClientes
    // 
    this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dgvClientes.Location = new System.Drawing.Point(50, 200);
    this.dgvClientes.Name = "dgvClientes";
    this.dgvClientes.Size = new System.Drawing.Size(400, 200);
    this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick); // Agregar la asociación del evento


    // 
    // ClientesForm
    // 
    this.ClientSize = new System.Drawing.Size(500, 450);
    this.Controls.Add(this.txtNombre);
    this.Controls.Add(this.txtCorreo);
    this.Controls.Add(this.txtTelefono);
    this.Controls.Add(this.txtDireccion);
    this.Controls.Add(this.btnAgregarCliente);
    this.Controls.Add(this.btnEditarCliente);
    this.Controls.Add(this.btnEliminarCliente);
    this.Controls.Add(this.dgvClientes);
    this.Name = "ClientesForm";
    this.Text = "Gestionar Clientes";
    ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
    this.ResumeLayout(false);
}

        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}