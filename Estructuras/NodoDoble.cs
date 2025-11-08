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
        public Libro Data { get; set; }
        public NodoDoble Prev { get; set; }
        public NodoDoble Next { get; set; }

        public NodoDoble(Libro libro)
        {
            Data = libro;
            Prev = null;
            Next = null;
        }
    }
}
