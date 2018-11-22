using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_de_Chefellas
{
    public  class Nodo
    {
        public Nodo Siguiente;

        public string Nombres;
        public string Direcciones;
        public int Items;
        public double TotalNeto, TotalBruto;

        public Nodo(string nombre, string direccion, double neto, double bruto, int items)
        {
            Nombres = nombre;
            Direcciones = direccion;
            Items = items;
            TotalNeto = neto;
            TotalBruto = bruto;

            Siguiente = null;
        }
    }
}
