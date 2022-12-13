using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_enlazada_circular
{
    class Nodo
    {
        private string dato;
        private Nodo siguiente;

        public string Dato { get => dato; 
            set => dato = value; }
        internal Nodo Siguiente { get => siguiente;
            set => siguiente = value; } 
    }
}
