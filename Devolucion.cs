using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO
{
    internal class Devolucion
    {
        public string TituloLibro { get; set; }
        public string NombreAutor { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Devolucion(string titulo, string autor, DateTime fecha)
        {
            TituloLibro = titulo;
            NombreAutor = autor;
            FechaDevolucion = fecha;
        }

        public override string ToString()
        {
            return $"{FechaDevolucion.ToShortDateString()} - '{TituloLibro}' Autor {NombreAutor}";
        }
    }
}
