using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Arbol
    {
        public Nodo raiz { get; set; }

        public Arbol()
        {
            raiz = null;
        }

        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregar(nuevo, raiz);
        }

        private void agregar(Nodo nuevo, Nodo padre)
        {
            if(nuevo.dato<padre.dato)
            {
                if (padre.hIzq == null)
                    padre.hIzq = nuevo;
                else
                    agregar(nuevo, padre.hIzq);
            }
            else
            {
                if (padre.hDer == null)
                    padre.hDer = nuevo;
                else
                    agregar(nuevo, padre.hDer);
            }   
        }

        public Nodo buscar(int nodo)
        {
            if (raiz != null)
                if (raiz.dato == nodo)
                    return raiz;
                else
                    return buscar(nodo, raiz);
            else
                return null;
        }

        private Nodo buscar(int buscado, Nodo padre)
        {
            Nodo nodo = null;
            if (buscado < padre.dato && padre.hIzq!=null)
            {
                if (padre.hIzq.dato == buscado)
                    nodo = padre.hIzq;
                else
                    nodo = buscar(buscado, padre.hIzq);
            }
            else if(padre.hDer != null)
            {
                if (padre.hDer.dato == buscado)
                    nodo = padre.hDer;
                else
                    nodo = buscar(buscado, padre.hDer);
            }
            return nodo;
        }

        public string InOrder()
        {
            if (raiz == null)
                return "";
            else
                return InOrder(raiz);
        }

        private string InOrder(Nodo nodo)
        {
            string res = "";
            if (nodo.hIzq != null)
                res = InOrder(nodo.hIzq);

            res += nodo.ToString();

            if (nodo.hDer != null)
                res += InOrder(nodo.hDer);
            return res;
        }


        public string PreOrder()
        {
            if (raiz == null)
                return "";
            else
                return PreOrder(raiz);
        }

        private string PreOrder(Nodo nodo)
        {
            string res = "";

            res += nodo.ToString();

            if (nodo.hIzq != null)
                res += PreOrder(nodo.hIzq);

            if (nodo.hDer != null)
                res += PreOrder(nodo.hDer);
            return res;
        }

        public string PostOrder()
        {
            if (raiz == null)
                return "";
            else
                return PostOrder(raiz);
        }

        private string PostOrder(Nodo nodo)
        {
            string res = "";
            if (nodo.hIzq != null)
                res = PostOrder(nodo.hIzq);

            if (nodo.hDer != null)
                res += PostOrder(nodo.hDer);

            res += nodo.ToString();

            return res;
        }
    }
}
