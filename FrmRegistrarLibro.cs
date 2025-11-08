using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaPOO.Models;
namespace BibliotecaPOO
{
    public partial class FrmRegistrarLibro : Form
    {
        public FrmRegistrarLibro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            string isbn = txtISBN.Text.Trim();
            string anioTxt = txtAnio.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(anioTxt))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(anioTxt, out int anio))
            {
                MessageBox.Show("El año debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existente = DatosGlobales.ListaLibros.FindByISBN(isbn);
            if (existente != null && isbn != "")
            {
                MessageBox.Show("Ya existe un libro con ese ISBN.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Libro nuevo = new Libro(isbn, titulo, autor, anio);
            DatosGlobales.ListaLibros.AddLast(nuevo);

            MessageBox.Show("Libro registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtISBN.Clear();
            txtTitulo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


