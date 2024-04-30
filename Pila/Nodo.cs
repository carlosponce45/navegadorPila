using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Nodo
    {
        public string URL;
        public Nodo siguiente;

        public Nodo(string URL)
        { 
            this.URL = URL;
            this.siguiente = null;
        }
    }
}
