using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace lista_enlazada_circular
{

    class Lista
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();
        public Lista()
        {
            primero = null;
            ultimo = null;
        }



        public void insertarNodo(string dato)

        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
            }
        } 
        
        public void verLista(TextBox list)
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    list.Text += actual.Dato + " -> \n";
                    actual= actual.Siguiente;
                } while (actual != primero);
            }
            
        }

        public void buscarNodo(string dato)
        {
            Nodo actual = new Nodo();
            actual = primero;

            bool encontrado = false;
            string buscado = dato;
            if (actual != null)
            {
                do
                {
                    if (actual.Dato == buscado)
                    {
                        MessageBox.Show( buscado + " encontrado");
                        encontrado = true;
                    }
                    actual = actual.Siguiente;
                } while (actual != primero);
                if (encontrado == false)
                    MessageBox.Show(buscado + " no esta en la lista ");
            }
            else
            {
                MessageBox.Show("lista vacia");
            }
        }

        public void modificarnodo(string dato1, string dato2)
        {
            Nodo actual = new Nodo();
            actual = primero;
            bool encontrado = false;
            string buscado = dato1;
            if (actual != null)
            {
                do
                {
                    if (actual.Dato == buscado)
                    {
                       
                        actual.Dato = dato2;
                        encontrado = true;
                        MessageBox.Show(buscado+" modificado");
                    }

                    actual = actual.Siguiente;
                } while (actual != primero);
                if (encontrado == false)
                    MessageBox.Show(buscado + " no esta en la lista ");
            }
            else
            {
                MessageBox.Show("lista vacia");
            }
        }
        
        
            
        public void eliminarnodo(string dato)
        {
            Nodo actual = new Nodo();
            actual = primero;
            Nodo anterior = new Nodo();
            bool encontrado = false;
            string buscado = dato;
            if (actual != null)
            {
                do
                {
                    if (actual.Dato == buscado)
                    {
                       
                        if (actual == primero)
                        {
                            primero = primero.Siguiente;
                            ultimo.Siguiente = primero;
                        }
                        else if (actual == ultimo)
                        {
                            anterior.Siguiente = primero;
                            ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        MessageBox.Show( buscado+"  eliminado ");
                        encontrado = true;
                    }

                    anterior = actual;
                    actual = actual.Siguiente;
                } while (actual != primero);
                if (encontrado == false)
                    MessageBox.Show(buscado + " no esta en la lista");
            }
            else
            {
                MessageBox.Show("lista vacia");
            }
                
            
        }
    }
}
