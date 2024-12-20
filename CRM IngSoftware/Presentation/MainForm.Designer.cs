﻿namespace CRM_IngSoftware.Presentation

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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnOportunidades = new System.Windows.Forms.Button();
            this.btnTarea = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fechaHoraWidget1 = new CRM_IngSoftware.FechaHoraWidget();
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
            this.panel1.Controls.Add(this.fechaHoraWidget1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCalendario);
            this.panel1.Controls.Add(this.btnOportunidades);
            this.panel1.Controls.Add(this.btnTarea);
            this.panel1.Controls.Add(this.btnGrafico);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(298, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 504);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(550, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalendario.Location = new System.Drawing.Point(525, 343);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(120, 50);
            this.btnCalendario.TabIndex = 9;
            this.btnCalendario.Text = "Calendario y Eventos";
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnOportunidades
            // 
            this.btnOportunidades.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOportunidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOportunidades.Location = new System.Drawing.Point(378, 342);
            this.btnOportunidades.Name = "btnOportunidades";
            this.btnOportunidades.Size = new System.Drawing.Size(120, 50);
            this.btnOportunidades.TabIndex = 8;
            this.btnOportunidades.Text = "Oportunidades";
            this.btnOportunidades.UseVisualStyleBackColor = false;
            this.btnOportunidades.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTarea
            // 
            this.btnTarea.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTarea.Location = new System.Drawing.Point(236, 342);
            this.btnTarea.Name = "btnTarea";
            this.btnTarea.Size = new System.Drawing.Size(120, 50);
            this.btnTarea.TabIndex = 7;
            this.btnTarea.Text = "Tareas";
            this.btnTarea.UseVisualStyleBackColor = false;
            this.btnTarea.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGrafico
            // 
            this.btnGrafico.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGrafico.Location = new System.Drawing.Point(87, 343);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(120, 50);
            this.btnGrafico.TabIndex = 6;
            this.btnGrafico.Text = "Grafico Ventas";
            this.btnGrafico.UseVisualStyleBackColor = false;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CRM_IngSoftware.Properties.Resources.crm;
            this.pictureBox1.Location = new System.Drawing.Point(209, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fechaHoraWidget1
            // 
            this.fechaHoraWidget1.BackColor = System.Drawing.SystemColors.Info;
            this.fechaHoraWidget1.Location = new System.Drawing.Point(120, 421);
            this.fechaHoraWidget1.Name = "fechaHoraWidget1";
            this.fechaHoraWidget1.Size = new System.Drawing.Size(477, 81);
            this.fechaHoraWidget1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(992, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGestionarClientes);
            this.Controls.Add(this.btnGestionarVentas);
            this.Controls.Add(this.btnGestionarProductos);
            this.Controls.Add(this.btnGestionarReportes);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Name = "MainForm";
            this.Text = "Sistema CRM - Principal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOportunidades;
        private System.Windows.Forms.Button btnTarea;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button button1;
        private FechaHoraWidget fechaHoraWidget1;
    }
}

