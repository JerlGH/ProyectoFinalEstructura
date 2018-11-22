using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido_de_Chefellas
{
    class ListaEnlazada 
    {
        Nodo Primero;
        public Nodo Raiz;



        public void AgregarListEnlazS(string Nombre, string Direccion, double Neto, double Bruto, int items)
        {
            if (Primero == null)
            {
                Primero = new Nodo(Nombre, Direccion, Neto, Bruto, items);
                Raiz = Primero;
            }
            else
            {
                Nodo nuevo = new Nodo(Nombre, Direccion, Neto, Bruto, items);
                nuevo.Siguiente = Primero;
                Primero = nuevo;
                Raiz = Primero;
            }
        }

        public void MostrarListEnlazS(DataGridView DGVTabla)
        {
            DGVTabla.Rows.Clear();
            Nodo Aux = Primero;
            while (Aux != null)
            {
                DGVTabla.Rows.Add(Aux.Nombres, Aux.Direcciones, Aux.Items, Aux.TotalBruto, Aux.TotalNeto);
                Aux = Aux.Siguiente;
            }
        }

        public void EliminarListEnlazSXNombre(string nombre, DataGridView DGVTabla)
        {
            if (Primero != null)
            {
                Boolean encontrado = false;
                Nodo anterior = Primero;
                Nodo actual = Primero;
                    while ((actual != null) && (!encontrado))
                    {
                        encontrado = (actual.Nombres == nombre);

                        if (!encontrado)
                        {
                            anterior = actual;
                            actual = actual.Siguiente;
                        }
                    }
                    if (actual != null)
                    {
                        if (actual == Primero)
                        {
                            Primero = actual.Siguiente;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        actual = null;
                    }
                    else
                    MessageBox.Show("El registro buscado no existe o ha ingresado mal el contenido de busqueda", "Error: El registro no encontrado");
            }
            else
            MessageBox.Show("No hay datos en los nodos para iniciar la busqueda del registro a borrar", "Error: El registro esta vacio");

        }

        public void Busqueda(string nombre, DataGridView DGVTabla)
        {
            Nodo Aux = Raiz;
            try
            {
                while (Aux.Nombres != nombre)
                {
                    Aux = Aux.Siguiente;
                }
                DGVTabla.Rows.Clear();
                DGVTabla.Rows.Add(Aux.Nombres, Aux.Direcciones, Aux.Items, Aux.TotalBruto, Aux.TotalNeto);
            }
            catch
            {
                MessageBox.Show("El registro buscado no existe o ha ingresado mal el contenido de busqueda","Error: El registro no encontrado");
            }
        }

        public void EliminarListEnlazS()
        {
            if (Primero == null)
                MessageBox.Show("Ya no hay datos en los nodos","Error: Subdesbordamiento de datos");
            else
            Primero = Primero.Siguiente;
        }

    }
}
