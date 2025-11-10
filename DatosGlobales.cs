using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPOO.Estructuras;

namespace BibliotecaPOO
{
    public static class DatosGlobales
    {
        public static ListaDobleEnlazada ListaLibros = new ListaDobleEnlazada();

        public static ColaPrestamos ListaPrestamos = new ColaPrestamos();
    }
}
