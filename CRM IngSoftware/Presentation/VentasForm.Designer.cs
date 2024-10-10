namespace CRM_IngSoftware.Presentation
{
    partial class VentasForm
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

        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;

        private void InitializeComponent()
        {
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();


            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(50, 50);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(200, 26);
            this.txtClienteID.Text = "ID del Cliente";
            this.txtClienteID.ForeColor = System.Drawing.Color.Gray;
            this.txtClienteID.Enter += new System.EventHandler(this.txtClienteID_Enter);
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);

            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(50, 100);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(200, 26);
            this.txtMontoTotal.Text = "Monto Total";
            this.txtMontoTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtMontoTotal.Enter += new System.EventHandler(this.txtMontoTotal_Enter);
            this.txtMontoTotal.Leave += new System.EventHandler(this.txtMontoTotal_Leave);

            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(50, 150);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);

            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(50, 200);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(400, 200);

            // 
            // VentasForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Name = "VentasForm";
            this.Text = "Gestionar Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
        }

    }
}