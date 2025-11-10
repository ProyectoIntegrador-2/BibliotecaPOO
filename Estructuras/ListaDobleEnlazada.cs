using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaPOO.Models;

namespace BibliotecaPOO.Estructuras
{
    public class ListaDobleEnlazada
    {
        private NodoDoble cabeza;
        private NodoDoble cola;

        public void AddLast(Libro libro)
        {
            NodoDoble nuevo = new NodoDoble(libro);

            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
            }
            else
            {
                cola.Siguiente = nuevo;
                nuevo.Anterior = cola;
                cola = nuevo;
            }
        }

        public Libro FindByISBN(string isbn)
        {
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                if (actual.Dato.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase))
                {
                    return actual.Dato;
                }
                actual = actual.Siguiente;
            }

            return null;
        }

        public List<Libro> ToListForward()
        {
            List<Libro> lista = new List<Libro>();
            NodoDoble actual = cabeza;

            while (actual != null)
            {
                lista.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return lista;
        }

        public void Clear()
        {
            cabeza = null;
            cola = null;
        }

        public bool IsEmpty()
        {
            return cabeza == null;
        }
    }
}

