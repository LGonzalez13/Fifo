using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class FIFO
    {
        private Proceso inicio { get; set; }

        public FIFO()
        {
            inicio = null;
        }

        public void enqueue(Proceso nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
                agregar(inicio, nuevo);
        }

        private void agregar(Proceso ultimo, Proceso nuevo)
        {
            if (ultimo.siguiente == null)
            {
                ultimo.siguiente = nuevo;
            }
            else
                agregar(ultimo.siguiente, nuevo);
        }

        public Proceso dequeue()
        {
            Proceso temp = inicio;
            inicio = inicio.siguiente;
            return temp;
        }

        public Proceso peek()
        {
            return inicio;
        }

        public override string ToString()
        {
            return inicio.ToString();
        }
    }
}
