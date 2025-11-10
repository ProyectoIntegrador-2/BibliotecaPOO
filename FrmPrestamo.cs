using BibliotecaPOO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPOO
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            listarLibros();
            MostrarPrestamos();
        }

        public void listarLibros()
        {
            try
            {
                var lstLibros = DatosGlobales.ListaLibros.ToListForward();
                cmblibros.Items.Clear();

                foreach (var libro in lstLibros)
                {
                    cmblibros.Items.Add(libro.Titulo);
                }
            }
            catch (Exception ex)
            {
            }
        }


        private void lblFechaPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {            
            bool validacionesOK = true;

            //VALIDAR NOMBRE NO VACIO
            if (string.IsNullOrEmpty(txtPersona.Text))
            {
                validacionesOK = false;
                MessageBox.Show("El nombre de la persona no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmblibros.SelectedItem == null)
            {
                validacionesOK = false;
                MessageBox.Show("Debe seleccionar un libro.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtpPrestamo.Value.Date < DateTime.Now.Date)//fecha inicio mayor o igual a fecha actual
            {
                validacionesOK = false;
                MessageBox.Show("La fecha de préstamo no puede ser anterior a la fecha actual.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dtpDevolucion.Value.Date <= dtpPrestamo.Value.Date )
            {
                validacionesOK = false;
                MessageBox.Show("La fecha de devolución debe ser mayor a la fecha de préstamo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (validacionesOK)
            {
                Prestamos_Devoluciones nuevoPrestamo = new Prestamos_Devoluciones();
                nuevoPrestamo.libro.Titulo = cmblibros.SelectedItem.ToString();
                nuevoPrestamo.persona.Nombre = txtPersona.Text;
                nuevoPrestamo.fechaInicio = dtpPrestamo.Value;
                nuevoPrestamo.fechaFin = dtpDevolucion.Value;
                DatosGlobales.ListaPrestamos.Push(nuevoPrestamo);

                limpiarCampos();
                MostrarPrestamos();
            }
        }

        public void limpiarCampos()
        {
            txtPersona.Clear();
            cmblibros.SelectedIndex = -1;
            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now;
        }

        public void MostrarPrestamos()
        {
            dgvDatos.Rows.Clear();

            if(DatosGlobales.ListaPrestamos.contador > 0)
            {
                foreach(var item in DatosGlobales.ListaPrestamos.prestamos)
                {
                    if (item != null)
                    {
                        if (!string.IsNullOrEmpty(item.persona.Nombre))
                        {
                            dgvDatos.Rows.Add(item.persona.Nombre,
                                      item.libro.Titulo,
                                      item.fechaInicio.ToShortDateString(),
                                      item.fechaFin.ToShortDateString());
                        }
                    }
                }
            }            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DatosGlobales.ListaPrestamos.Pop();
            MostrarPrestamos();
        }
    }
}
