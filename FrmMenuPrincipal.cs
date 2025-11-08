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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            FrmRegistrarLibro f = new FrmRegistrarLibro();
            f.Show();
        }

        private void btnMostrarLibros_Click(object sender, EventArgs e)
        {
            FrmMostrarLibros f = new FrmMostrarLibros();
            f.Show();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            FrmBuscarLibro f = new FrmBuscarLibro();
            f.Show();
        }

        private void btnOrdenarLibros_Click(object sender, EventArgs e)
        {
            FrmOrdenarLibros f = new FrmOrdenarLibros();
            f.Show();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            FrmPrestamo f = new FrmPrestamo();
            f.Show();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            FrmDevolucion f = new FrmDevolucion();
            f.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorialDevoluciones f = new FrmHistorialDevoluciones();
            f.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
