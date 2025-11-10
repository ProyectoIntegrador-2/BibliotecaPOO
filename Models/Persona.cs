using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Direccion = string.Empty;
        }
        public Persona(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
