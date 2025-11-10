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
    public partial class FrmHistorialDevoluciones : Form
    {
        // Crear una instancia del historial (pila)
        private HistorialDevoluciones historial = new HistorialDevoluciones();
        public FrmHistorialDevoluciones()
        {
            InitializeComponent();
        }

        // Registrar devolución
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto Devolucion
            Devolucion devolucion = new Devolucion(titulo, autor, DateTime.Now);
            historial.RegistrarDevolucion(devolucion);

            MessageBox.Show("Devolución registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Clear();
            txtAutor.Clear();
        }

        // Mostrar historial
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstHistorial.Items.Clear();

            if (historial.EstaVacio())
            {
                lstHistorial.Items.Add("No hay devoluciones registradas.");
                return;
            }

            foreach (var devolucion in historial.ObtenerHistorial())
            {
                lstHistorial.Items.Add(devolucion.ToString());
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal f = new FrmMenuPrincipal();
            f.Show();
        }
    }
}
