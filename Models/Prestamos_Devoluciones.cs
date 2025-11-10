using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO.Models
{
    public class Prestamos_Devoluciones
    {
        public Persona persona { get; set; }
        public Libro libro { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Prestamos_Devoluciones()
        {
            persona = new Persona();
            libro = new Libro();
        }
    }
}
