using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido_de_Chefellas
{
    public class Datos
    {

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                            //Datos necesarios para el funcionamiento de las estructuras
        private static int max;
        private static int tope=0;
        private static int inicio=0;
        private static int final=0;

        public int Max
        {
            get
            {
                return max;
            }

            set
            {
                max = value;
            }
        }
        public int Tope
        {
            get
            {
                return tope;
            }

            set
            {
                tope = value;
            }
        }
        public int Inicio
        {
            get
            {
                return inicio;
            }

            set
            {
                inicio = value;
            }
        }
        public int Final
        {
            get
            {
                return final;
            }

            set
            {
                final = value;
            }
        }




        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Estructura de Pila

        public struct Pila
        {
            public string Nombres;
            public string Direcciones;
            public int Items;
            public double TotalNeto, TotalBruto;
        }
        public Pila[] pila;


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                            //Estructura de Cola Simple

        public struct ColaS
        {
            public string Nombres;
            public string Direcciones;
            public int Items;
            public double TotalNeto, TotalBruto;
        }
        public ColaS[] colas;

       
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                            //Estrucutura de Cola Circular

        public struct ColaC
        {
            public string Nombres;
            public string Direcciones;
            public int Items;
            public double TotalNeto, TotalBruto;
        }
        public ColaC[] colac;

        
    }
}
