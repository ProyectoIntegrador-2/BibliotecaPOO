using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPOO
{
    internal class HistorialDevoluciones
    {
        // Pila para almacenar las devoluciones
        private Stack<Devolucion> pilaDevoluciones = new Stack<Devolucion>();

        // Agregar una devolución a la pila
        public void RegistrarDevolucion(Devolucion devolucion)
        {
            pilaDevoluciones.Push(devolucion);
        }

        // Devolver todas las devoluciones (para mostrarlas)
        public List<Devolucion> ObtenerHistorial()
        {
            return new List<Devolucion>(pilaDevoluciones);
        }

        // Ver si hay devoluciones registradas
        public bool EstaVacio()
        {
            return pilaDevoluciones.Count == 0;
        }
    }
}
