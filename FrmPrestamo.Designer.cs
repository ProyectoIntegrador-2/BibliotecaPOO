namespace BibliotecaPOO
{
    partial class FrmPrestamo
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmblibros = new System.Windows.Forms.ComboBox();
            this.dtpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(41, 54);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(189, 25);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre del Usuario:";
            // 
            // txtPersona
            // 
            this.txtPersona.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersona.Location = new System.Drawing.Point(45, 83);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(248, 27);
            this.txtPersona.TabIndex = 1;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(316, 54);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(141, 25);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro a prestar:";
            // 
            // cmblibros
            // 
            this.cmblibros.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblibros.FormattingEnabled = true;
            this.cmblibros.Location = new System.Drawing.Point(321, 83);
            this.cmblibros.Name = "cmblibros";
            this.cmblibros.Size = new System.Drawing.Size(242, 25);
            this.cmblibros.TabIndex = 3;
            // 
            // dtpPrestamo
            // 
            this.dtpPrestamo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPrestamo.Location = new System.Drawing.Point(45, 147);
            this.dtpPrestamo.Name = "dtpPrestamo";
            this.dtpPrestamo.Size = new System.Drawing.Size(248, 25);
            this.dtpPrestamo.TabIndex = 4;
            // 
            // dtpDevolucion
            // 
            this.dtpDevolucion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDevolucion.Location = new System.Drawing.Point(321, 147);
            this.dtpDevolucion.Name = "dtpDevolucion";
            this.dtpDevolucion.Size = new System.Drawing.Size(242, 25);
            this.dtpDevolucion.TabIndex = 5;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(44, 114);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(179, 25);
            this.lblFechaPrestamo.TabIndex = 6;
            this.lblFechaPrestamo.Text = "Fecha de préstamo:";
            this.lblFechaPrestamo.Click += new System.EventHandler(this.lblFechaPrestamo_Click);
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(316, 114);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(192, 25);
            this.lblFechaDevolucion.TabIndex = 7;
            this.lblFechaDevolucion.Text = "Fecha de devolución:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRegistrar.Location = new System.Drawing.Point(442, 178);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 62);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar préstamo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(172, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prestamos De Libros ";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersona,
            this.colLibro,
            this.colFechaInicio,
            this.colFechaFin});
            this.dgvDatos.Location = new System.Drawing.Point(45, 256);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(518, 86);
            this.dgvDatos.TabIndex = 10;
            // 
            // colPersona
            // 
            this.colPersona.HeaderText = "Persona";
            this.colPersona.Name = "colPersona";
            this.colPersona.ReadOnly = true;
            // 
            // colLibro
            // 
            this.colLibro.HeaderText = "Libro";
            this.colLibro.Name = "colLibro";
            this.colLibro.ReadOnly = true;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.HeaderText = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.ReadOnly = true;
            // 
            // colFechaFin
            // 
            this.colFechaFin.HeaderText = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(59, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 62);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar préstamo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 376);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.dtpDevolucion);
            this.Controls.Add(this.dtpPrestamo);
            this.Controls.Add(this.cmblibros);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmblibros;
        private System.Windows.Forms.DateTimePicker dtpPrestamo;
        private System.Windows.Forms.DateTimePicker dtpDevolucion;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaFin;
        private System.Windows.Forms.Button btnEliminar;
    }
}