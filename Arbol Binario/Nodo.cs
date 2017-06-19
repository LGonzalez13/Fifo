using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Nodo
    {
        public int dato { get; set; }
        public Nodo hIzq { get; set; }
        public Nodo hDer { get; set; }

        public Nodo(int d)
        {
            dato = d;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
