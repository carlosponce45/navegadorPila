using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Pila
    {
        public Nodo tope;

        public Pila()
        {
            tope = null;      
        }

        public void Insertar(string URL)
        {
            Nodo nuevo = new Nodo(URL);
            if (tope == null)
            {
                tope = nuevo;
            }
            else
            { 
                nuevo.siguiente = tope;
                tope = nuevo;
                    }

        }

        public string Eliminar()
        {
            if (tope == null) return "La lista esta vacìa";
            else
            {
                Nodo aux = tope;
                tope = aux.siguiente;
                aux = null;
                return "Elementyo eliminado";
            }

        }

        public void Listar(ListBox lstPila)
        { 
            lstPila.Items.Clear();
            if (tope == null) lstPila.Items.Add("Pila vacia");
            else 
            {
                Nodo aux = tope;
                while (aux != null) 
                {
                    lstPila.Items.Add(aux.URL);
                    aux = aux.siguiente;
                }
            }
        }

      

        public bool Buscar(string URL)
        {
            bool existe = false;
            if (tope == null) existe= false;
            else
            {
                Nodo aux = tope;
                while (aux != null)
                {
                    if(URL == aux.URL) existe= true;
                    aux = aux.siguiente;
                }
            }
            return existe;
        }
    }
}
