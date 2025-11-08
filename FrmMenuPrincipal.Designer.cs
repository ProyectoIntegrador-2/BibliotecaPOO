namespace BibliotecaPOO
{
    partial class FrmMenuPrincipal
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
            this.btnRegistrarLibro = new System.Windows.Forms.Button();
            this.btnMostrarLibros = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnOrdenarLibros = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarLibro
            // 
            this.btnRegistrarLibro.Location = new System.Drawing.Point(79, 79);
            this.btnRegistrarLibro.Name = "btnRegistrarLibro";
            this.btnRegistrarLibro.Size = new System.Drawing.Size(116, 51);
            this.btnRegistrarLibro.TabIndex = 0;
            this.btnRegistrarLibro.Text = "Registrar Libro";
            this.btnRegistrarLibro.UseVisualStyleBackColor = true;
            this.btnRegistrarLibro.Click += new System.EventHandler(this.btnRegistrarLibro_Click);
            // 
            // btnMostrarLibros
            // 
            this.btnMostrarLibros.Location = new System.Drawing.Point(79, 136);
            this.btnMostrarLibros.Name = "btnMostrarLibros";
            this.btnMostrarLibros.Size = new System.Drawing.Size(116, 42);
            this.btnMostrarLibros.TabIndex = 1;
            this.btnMostrarLibros.Text = "Mostrar Libros";
            this.btnMostrarLibros.UseVisualStyleBackColor = true;
            this.btnMostrarLibros.Click += new System.EventHandler(this.btnMostrarLibros_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(79, 184);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(116, 43);
            this.btnBuscarLibro.TabIndex = 2;
            this.btnBuscarLibro.Text = "Buscar Libro";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnOrdenarLibros
            // 
            this.btnOrdenarLibros.Location = new System.Drawing.Point(79, 233);
            this.btnOrdenarLibros.Name = "btnOrdenarLibros";
            this.btnOrdenarLibros.Size = new System.Drawing.Size(116, 43);
            this.btnOrdenarLibros.TabIndex = 3;
            this.btnOrdenarLibros.Text = "Ordenar Libros";
            this.btnOrdenarLibros.UseVisualStyleBackColor = true;
            this.btnOrdenarLibros.Click += new System.EventHandler(this.btnOrdenarLibros_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Location = new System.Drawing.Point(201, 79);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(126, 51);
            this.btnPrestamo.TabIndex = 4;
            this.btnPrestamo.Text = "Solicitar Prestamo";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(201, 136);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(126, 42);
            this.btnDevolucion.TabIndex = 5;
            this.btnDevolucion.Text = "Registrar Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(201, 184);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(126, 43);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "Historial de Devoluciones";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(201, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione la opción que desee realizar ";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnOrdenarLibros);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.btnMostrarLibros);
            this.Controls.Add(this.btnRegistrarLibro);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarLibro;
        private System.Windows.Forms.Button btnMostrarLibros;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnOrdenarLibros;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}