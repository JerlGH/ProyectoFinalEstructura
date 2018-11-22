using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido_de_Chefellas
{
    public class Acciones : Datos 
    {



        private static string seleccion; //Variable de control. Este será quien defina que metodo usar segun la elección del menu inicial

        public string Seleccion
        {
            get
            {
                return seleccion;
            }

            set
            {
                seleccion = value;
            }
        } //Get y Set para uso de la variable en cualquier parte del proyecto



        public Acciones(int max)
        {
            Max = max;
            pila = new Pila[Max];
            colas = new ColaS[Max];
            colac = new ColaC[Max];
        } //Instanciar las estructuras mediante este constructor
        public Acciones()
        {
        } //Contructor vacio para uso de la clase sin enviar parametros






        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodos para el funcionamiento de Pila

        public bool TestVacioPila()
        {
            if (Tope == 0)
                return true;
            else
                return false;
        } //Evaluar que la pila este vacia
        public bool TestLlenoPila()
        {
            if (Tope == Max)
                return true;
            else
                return false;
        } //Evaluar que la pila este llena
        public void AgregarPila(string Nombre, string Direccion, double Neto, double Bruto, int items)
        {
            bool Resp = TestLlenoPila();

            if (Resp == true)
                MessageBox.Show("No hay espacio para agregar mas datos. Elimine un registro para agregar otro", "Erro: Desbordamiento de datos");
            else
            {
                pila[Tope].Direcciones = Convert.ToString(Direccion);
                pila[Tope].TotalNeto = Neto;
                pila[Tope].Nombres = Convert.ToString(Nombre);
                pila[Tope].TotalBruto = Bruto;
                pila[Tope].Items = items;
                Tope++;
            }
        }  //Agregar datos a la pila
        public void EliminarPila()
        {
            bool Resp = TestVacioPila();
            if (Resp == false)
            {
                Tope--;
            }
            else
                MessageBox.Show("Ya no hay datos en la cola simle", "Error: Subdesbordamiento de datos");
        }  //Eliminar un dato de la pila
        public void MostrarPila(DataGridView DGVRegistro)
        {
            DGVRegistro.Rows.Clear();
            for (int i = 0; i < Tope; i++)
            {
                DGVRegistro.Rows.Add(pila[i].Nombres, pila[i].Direcciones, pila[i].Items, pila[i].TotalBruto, pila[i].TotalNeto);
            }
        } //Mostrar datos de la pila


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodos para el funcionamiento de Cola Simple

        public bool TestVacioColaS()
        {
            if (Inicio == Final)
                return true;
            else
                return false;
        } //Evaluar que la cola este vacia
        public bool TestLlenoColaS()
        {
            if (Final == Max)
                return true;
            else
                return false;
        } //Evaluar que la cola este llena
        public void AgregarColaS(string Nombre, string Direccion, double Neto, double Bruto, int items)
        {
            bool Resp = TestLlenoColaS();

            if (Resp == true)
                MessageBox.Show("No hay espacio para agregar mas datos. Elimine un registro para agregar otro","Erro: Desbordamiento de datos");
            else
            {
                colas[Final].Direcciones = Convert.ToString(Direccion);
                colas[Final].TotalNeto = Neto;
                colas[Final].Nombres = Convert.ToString(Nombre);
                colas[Final].TotalBruto = Bruto;
                colas[Final].Items = items;
                Final++;
            }
        }  //Agregar datos a la cola
        public void EliminarColaS()
        {
            bool Resp = TestVacioColaS();
            if (Resp == false)
            {
                Inicio++;

                if (Inicio == Final)
                {
                    Inicio = 0;
                    Final = 0;
                }
            }
            else
            {
                MessageBox.Show("Ya no hay datos en la cola simple", "Error: Subdesbordamiento de datos");
            }
        }  //Eliminar un dato de la cola
        public void MostrarColaS(DataGridView DGVRegistro)
        {
            DGVRegistro.Rows.Clear();
            for (int i = Inicio; i < Final; i++)
            {
                DGVRegistro.Rows.Add(colas[i].Nombres, colas[i].Direcciones, colas[i].Items, colas[i].TotalBruto, colas[i].TotalNeto);
            }
        } //Mostrar cola de la pila


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodos para el funcionamiento de Cola Circular

        public bool TestVacioColaC()
        {
            if (Inicio == 0)
                return true;
            else
                return false;
        } //Evaluar que la cola este vacia
        public bool TestLlenoColaC()
        {
            if ((Final == Max && Inicio == 1) || ((Final + 1) == Inicio))
                return true;

            else
            {
                if (Final == Max)
                {
                    Final = 0;
                    return false;

                }
                else
                {
                    if (Inicio == 0)
                        Inicio = 1;
                    return false;

                }
            }


        } //Evaluar que la cola este llena
        public void AgregarColaC(string Nombre, string Direccion, double Neto, double Bruto, int items)
        {
            bool Resp = TestLlenoColaC();

            if (Resp == true)
                MessageBox.Show("No hay espacio para agregar mas datos. Elimine un registro para agregar otro", "Erro: Desbordamiento de datos");
            else
            {
                colac[Final].Direcciones = Convert.ToString(Direccion);
                colac[Final].TotalNeto = Neto;
                colac[Final].Nombres = Convert.ToString(Nombre);
                colac[Final].TotalBruto = Bruto;
                colac[Final].Items = items;
                Final = Final + 1;
            }
        }  //Agregar datos a la cola
        public void EliminarColaC()
        {
            bool Resp = TestVacioColaC();
            if (Resp == true)
                MessageBox.Show("Ya no hay datos en la cola simple", "Error: Subdesbordamiento de datos");
            else
                if (Inicio == Final && Inicio == 0 && Final == 0)
            {
                Inicio = -1;
                Final = 0;
                MessageBox.Show("La Base de datos se limpiado correctamente");
            }

            else if (Inicio == Final && Inicio != 0 && Final != 0)
            {
                colac[Inicio - 1].Direcciones = "---";
                colac[Inicio - 1].TotalNeto = 0;
                colac[Inicio - 1].Nombres = "---";
                colac[Inicio - 1].TotalBruto = 0;
                colac[Inicio - 1].Items = 0;
                Inicio = 0;
                Final = 0;
            }

            else if (Inicio == Max)
            {
                colac[Inicio - 1].Direcciones = "---";
                colac[Inicio - 1].TotalNeto = 0;
                colac[Inicio - 1].Nombres = "---";
                colac[Inicio - 1].TotalBruto = 0;
                colac[Inicio - 1].Items = 0;
                Inicio = 0;
                Inicio++;
            }
            else
            {
                colac[Inicio - 1].Direcciones = "---";
                colac[Inicio - 1].TotalNeto = 0;
                colac[Inicio - 1].Nombres = "---";
                colac[Inicio - 1].TotalBruto = 0;
                colac[Inicio - 1].Items = 0;
                Inicio++;
            }
        }  //Eliminar un dato de la cola
        public void MostrarColaC(DataGridView DGVRegistro)
        {
            DGVRegistro.Rows.Clear();
            for (int i = 0; i < Max; i++)
            {
                DGVRegistro.Rows.Add(colac[i].Nombres, colac[i].Direcciones, colac[i].Items, colac[i].TotalBruto, colac[i].TotalNeto);
            }
        } //Mostrar cola de la pila


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Metodos para el funcionamiento de la pila en conversiones

        public bool esOperador(char x)
        {
            if (x == '*' || x == '/' || x == '+' || x == '-' || x == '^'|| x =='=')
            {
                return true;
            }
            return false;
        } //Evaluar e identificar el char enviado al metodo
        public string convertirinfija(string expresionPrefija)
        {
            //creamos e instanciamos un arreglo unidimensional con el largo de la expresión.
            string[] stackEx = new string[expresionPrefija.Length];
            //El maximo sera igual a la de la expresión.
            int max = expresionPrefija.Length;


            { //Este ciclo difiere de lo normal en que empieza desde el maximo hacia abajo, o sea se le va restando al acumulador, esto se hace para que el acumulador nos sirva para "leer" la expresión de derecha a izquierda.
                for (int i = max - 1; i >= 0; i--)
                {
                    //Si la función retorna true...
                    if (esOperador(expresionPrefija[i]))
                    {
                        //Utilizamos variables auxiliares para guardar ese operador y seguido limpiamos ese "lugar" del stack
                        string operador1 = stackEx[Tope];
                        stackEx[Tope] = null;
                        Tope = Tope - 1;
                        string operador2 = stackEx[Tope];
                        stackEx[Tope] = null;

                        //El stack en la posición que este el tope se le asigna la concatenación del operador mas el número mas el otro operador
                        if ((esOperador(expresionPrefija[i + 1]) && (esOperador(expresionPrefija[i]))) || i == 0)
                            stackEx[Tope] = operador1 + expresionPrefija[i] + operador2;
                        else
                            stackEx[Tope] = "(" + operador1 + expresionPrefija[i] + operador2 + ")";
                    }


                    //Si no es un operador, es un número...
                    else
                    {
                        //Le agregamos al tope y agregamos el número al stack
                        Tope = Tope + 1;
                        stackEx[Tope] = (Convert.ToString(expresionPrefija[i]));
                    }
                }
                //Retornamos el stack...
                return stackEx[Tope];

            }
        } //Metodo de conversión a expresión prefija
        public string convertirposfija(string expresionPrefija)
        {
            string[] stackEx = new string[expresionPrefija.Length]; //Creamos un arreglo culla longitud según el total de caracteres de la expresión inicial.
            int max = expresionPrefija.Length;   //Creamos una variable de control para el ciclo con un valor según la logitud de la expresión.

            if (esOperador(expresionPrefija[max - 1]))//Evalua si es correcta la expresión mediante el primer dato que entra al ciclo
            {
                return "Expresión errónea";
            }
            else
            {
                //Este ciclo difiere de lo normal en que empieza desde el maximo hacia abajo, o sea se le va restando al acumulador, esto se hace para que el acumulador nos sirva para "leer" la expresion de derecha a izquierda.
                for (int i = max - 1; i >= 0; i--)
                {
                    //Si la funcion retorna true...
                    if (esOperador(expresionPrefija[i]))
                    {
                        //Utilizamos variables auxiliares para guardar ese operador y seguido limpiamos ese "lugar" del stack
                        string aux1 = stackEx[Tope]; stackEx[Tope] = null; Tope = Tope - 1;
                        string aux2 = stackEx[Tope]; stackEx[Tope] = null;

                        //El stack en la posicion que este el tope se le asigna la concatenación de las variables auxiliares 1 y 2, Mas el operador actual en expresionPrefija[i] 
                        stackEx[Tope] = aux1 + aux2 + expresionPrefija[i];
                    }


                    //Si no es un operador, es un número...
                    else
                    {
                        //Le agregamos al tope y agregamos el número al stack
                        Tope = Tope + 1;
                        stackEx[Tope] = (Convert.ToString(expresionPrefija[i]));
                    }
                }

                //Retornamos el stack...
                return stackEx[Tope];
            }
        }//Metodo de conversion a expreción posfija


    }
}
