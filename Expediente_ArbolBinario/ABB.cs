using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Expediente_ArbolBinario
{
    class ABB
    {
        public Nodo raiz;
        public ABB()
        {
            raiz = null;
        }

        //METODO INSERTAR
        public void insertar(string valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.valor = valor;
            }
            else
            {
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                nuevo.hd = null;
                nuevo.hi = null;

                Nodo anterior = null, recorrer;
                recorrer = raiz;
                while (recorrer != null)
                {
                    anterior = recorrer;
                    if (valor.Length < recorrer.valor.Length)
                    {
                        recorrer = recorrer.hd;
                    }
                    else
                    {
                        recorrer = recorrer.hi;
                    }
                }
                if(valor.Length < anterior.valor.Length)
                {
                    anterior.hd = nuevo;
                }
                else
                {
                    anterior.hi = nuevo;
                }

            }
        }//FIN METODO INSERTAR

        public bool busqueda(string busqueda)
        {
            if(raiz == null)
            {
                return false;
            }
            return false;
        }

        //METODO MOSTRAR ABB EN PREORDEN(RAIZ, IZQUIERDA, DERECHA)
        public void PreOrden(Nodo raiz, string busqueda){
            if (raiz.valor == busqueda)
            {
                MessageBox.Show("Se encontro el valor: " + busqueda + " en el arbol");
            }
            if (raiz.hi != null)
                PreOrden(raiz.hi, busqueda);
            if(raiz.hd != null)
                PreOrden(raiz.hd, busqueda);
        }

    }
}
