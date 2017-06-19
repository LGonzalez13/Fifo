using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Proceso
    {
        public int ciclos { get; set; }
        public Proceso siguiente { get; set; }

        public Proceso(int rand)
        {
            ciclos = rand;
            siguiente = null;
        }

        public override string ToString()
        {
            return ciclos.ToString();
        }
    }
}
