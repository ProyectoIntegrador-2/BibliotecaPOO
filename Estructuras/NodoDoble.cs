using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPOO.Models;

namespace BibliotecaPOO.Estructuras
{
    public class NodoDoble
    {
        public Libro Dato { get; set; }
        public NodoDoble Anterior { get; set; }
        public NodoDoble Siguiente { get; set; }

        public NodoDoble(Libro dato)
        {
            Dato = dato;
        }
    }
}
