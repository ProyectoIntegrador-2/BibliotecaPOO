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
    public partial class FrmMostrarLibros : Form
    {
        public FrmMostrarLibros()
        {
            InitializeComponent();
        }
        private void FrmMostrarLibros_Load(object sender, EventArgs e)
        {
            CargarLibrosEnTabla();
        }
        private void CargarLibrosEnTabla()
        {
            dgvLibros.Rows.Clear();

            // Configurar columnas solo la primera vez
            if (dgvLibros.Columns.Count == 0)
            {
                dgvLibros.Columns.Add("ISBN", "ISBN");
                dgvLibros.Columns.Add("Titulo", "Título");
                dgvLibros.Columns.Add("Autor", "Autor");
                dgvLibros.Columns.Add("Anio", "Año");
            }

            var lista = DatosGlobales.ListaLibros.ToListForward();

            foreach (var libro in lista)
            {
                dgvLibros.Rows.Add(libro.ISBN, libro.Titulo, libro.Autor, libro.Anio);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
