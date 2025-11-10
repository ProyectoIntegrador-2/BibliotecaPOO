using BibliotecaPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaPOO.Estructuras
{
    public class ColaPrestamos
    {
        public Prestamos_Devoluciones[] prestamos { get; set; }
        private int frente;   // índice del primer elemento
        private int fin;      // índice donde se insertará el siguiente
        public int contador { get; set; } // cantidad de elementos en la cola

        public ColaPrestamos()
        {
            prestamos = new Prestamos_Devoluciones[5];
            frente = 0;
            fin = -1;
            contador = 0;
        }

        // Método para agregar (push)
        public void Push(Prestamos_Devoluciones nuevo)
        {
            if (contador == prestamos.Length)
            {
                MessageBox.Show("La cola está llena, no se puede agregar más préstamos.",
                                "Cola llena", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fin = (fin + 1) % prestamos.Length;
            prestamos[fin] = nuevo;
            contador++;

            MessageBox.Show(" Préstamo agregado correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para quitar (pop)
        public Prestamos_Devoluciones Pop()
        {
            if (contador == 0)
            {
                MessageBox.Show("La cola está vacía, no hay préstamos para eliminar.",
                                "Cola vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Prestamos_Devoluciones eliminado = prestamos[frente];
            prestamos[frente] = null; // opcional: limpiar la posición
            frente = (frente + 1) % prestamos.Length;
            contador--;

            MessageBox.Show(" Préstamo eliminado correctamente.",
                            "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return eliminado;
        }

        // Método para ver el frente de la cola
        public Prestamos_Devoluciones Peek()
        {
            if (contador == 0)
                return null;
            return prestamos[frente];
        }

        // Propiedades auxiliares
        public bool EstaVacia() => contador == 0;
        public bool EstaLlena() => contador == prestamos.Length;
    }

}

