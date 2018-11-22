using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido_de_Chefellas
{
    public partial class Formulario_de_pedidos : Form
    {
        ListaEnlazada Lista = new ListaEnlazada();
        public Acciones Acc;
        public int i = 0,Cant;
        public int Items=0;
        public double Neto = 0;
        public List<Panel> Paneles = new List<Panel>();
        public Formulario_de_pedidos(int max)
        {
            InitializeComponent();
            Acc = new Acciones(max);
            PanelPizzas.BringToFront();
            if(Acc.Seleccion== "CasoListEnlazS")
            {
                LBNomBus.Visible = true;
                LBNomElim.Visible = true;
                TBNomBuscar.Visible = true;
                TBNomElim.Visible = true;
                BTBuscXNom.Visible = true;
                BTElimXNom.Visible = true;
            }
        }


        private void BTRealizarPedido_Click(object sender, EventArgs e)
        {
            double Bruto = Neto * 0.85; //Variable para calcular el total bruto del pedido (Sin Iva)
           
            //Condicional para evaluar si se ha ingresado el nombre y la dirección
            if (TBNombre.Text == "" || TBDireccion.Text == "")
                MessageBox.Show("El campo nombre o dirección está vacio, por favor ingrese los datos correctos","Error al registrar pedido");
            else
            {
               
                    //Variables de captura de Nombre y Dirección
                    string Direccion = TBDireccion.Text;
                    string Nombre = TBNombre.Text;

                    //Condicionales de envio de datos segun la selección de Pila, Cola Simple o Cola Circular
                         if (Acc.Seleccion.Equals("CasoPila"))  Acc.AgregarPila(Nombre, Direccion, Neto, Bruto, Items);
                    else if (Acc.Seleccion.Equals("CasoColaS")) Acc.AgregarColaS(Nombre, Direccion, Neto, Bruto, Items);
                    else if(Acc.Seleccion.Equals("CasoColaC"))  Acc.AgregarColaC(Nombre, Direccion, Neto, Bruto, Items);
                    else if (Acc.Seleccion.Equals("CasoListEnlazS")) Lista.AgregarListEnlazS(Nombre, Direccion, Neto, Bruto, Items);

                    //Condicionales para mostrar los datos existentes en la estructura segun la selección de Pila, Cola Simple o Cola Circular
                    if (Acc.Seleccion.Equals("CasoPila")) Acc.MostrarPila(DGVRegistro);
                    else if (Acc.Seleccion.Equals("CasoColaS")) Acc.MostrarColaS(DGVRegistro);
                    else if (Acc.Seleccion.Equals("CasoColaC")) Acc.MostrarColaC(DGVRegistro);
                    else if (Acc.Seleccion.Equals("CasoListEnlazS")) Lista.MostrarListEnlazS(DGVRegistro);

                    //Limpiar datos del cliente
                    TBDireccion.Clear();
                    TBNombre.Clear();

                    //reset de items y total
                    LBCantCamarones.Text = "0";
                    LBCantChicago.Text = "0";
                    LBCantChorizoItaliano.Text = "0";
                    LBCantCorona.Text = "0";
                    LBCantJamonQueso.Text = "0";
                    LBCantMargarita.Text = "0";
                    LBCantMariscosGalleta.Text = "0";
                    LBCantMexicana.Text = "0";
                    LBCantMilanesaPollo.Text = "0";
                    LBCantMilanesaRes.Text = "0";
                    LBCantNica.Text = "0";
                    LBCantPepperoni.Text = "0";
                    LBCantPotpie.Text = "0";
                    LBCantSalmon.Text = "0";
                    LBCantVegetariana.Text = "0";
                    LBTotal.Text = "0";
                    Neto = 0;
                
            }
        }     //Botón para realizar un pedido
        private void BTMostrarRegistros_Click(object sender, EventArgs e)
        {
            panelmostrar.Visible = true;
            panelmostrar.BringToFront();
            if (Acc.Seleccion.Equals("CasoPila"))            Acc.MostrarPila(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoColaS"))      Acc.MostrarColaS(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoColaC"))      Acc.MostrarColaC(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoListEnlazS")) Lista.MostrarListEnlazS(DGVRegistro);
        }   //Botón para mostrar registros
        private void BTVolver_Click(object sender, EventArgs e)
        {
            panelmostrar.Visible = false;
        }             //Botón para ocultar registros
        private void BTEliminar_Click(object sender, EventArgs e)
        {
            //Condicionales para eliminar un registro segun la selección de Pila, Cola Simple o Cola Circular
                 if (Acc.Seleccion.Equals("CasoPila"))   Acc.EliminarPila();
            else if (Acc.Seleccion.Equals("CasoColaS"))  Acc.EliminarColaS();
            else if (Acc.Seleccion.Equals("CasoColaC"))  Acc.EliminarColaC();
            else if (Acc.Seleccion.Equals("CasoListEnlazS")) Lista.EliminarListEnlazS();

            //Condicionales para mostrar los datos existentes en la estructura segun la selección de Pila, Cola Simple o Cola Circular
            if (Acc.Seleccion.Equals("CasoPila"))  Acc.MostrarPila(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoColaS"))  Acc.MostrarColaS(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoColaC"))  Acc.MostrarColaC(DGVRegistro);
            else if (Acc.Seleccion.Equals("CasoListEnlazS")) Lista.MostrarListEnlazS(DGVRegistro);
        }           //Botón para eliminar un registro


        //Controles de paneles
        private void Formulario_de_pedidos_Load(object sender, EventArgs e)
        {
            Paneles.Add(PanelPizzas);
            Paneles.Add(PanelEspeciales);
            Paneles.Add(PanelCarneyMariscos);
            Paneles[0].Visible = true;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Paneles[0].Visible = false;
            Paneles[1].Visible = true;
            Paneles[2].Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Paneles[2].Visible = true;
            Paneles[0].Visible = false;
            Paneles[1].Visible = false;
        }
        private void BTPizzas_Click(object sender, EventArgs e)
        {
            Paneles[0].Visible = true;
            Paneles[1].Visible = false;
            Paneles[2].Visible = false;
        }



        //Controles de agregado
        private void BTMargaritaMas_Click(object sender, EventArgs e)
        {
            Neto = Neto + 220;
            Items++;
            LBCantMargarita.Text = Convert.ToString(Convert.ToInt32(LBCantMargarita.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Neto = Neto + 180;
            Items++;
            LBCantVegetariana.Text = Convert.ToString(Convert.ToInt32(LBCantVegetariana.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Neto = Neto + 210;
            Items++;
            LBCantJamonQueso.Text = Convert.ToString(Convert.ToInt32(LBCantJamonQueso.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Neto = Neto + 220;
            Items++;
            LBCantPepperoni.Text = Convert.ToString(Convert.ToInt32(LBCantPepperoni.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Neto = Neto + 220;
            Items++;
            LBCantChorizoItaliano.Text = Convert.ToString(Convert.ToInt32(LBCantChorizoItaliano.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Neto = Neto + 300;
            Items++;
            LBCantCamarones.Text = Convert.ToString(Convert.ToInt32(LBCantCamarones.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Neto = Neto + 290;
            Items++;
            LBCantMexicana.Text = Convert.ToString(Convert.ToInt32(LBCantMexicana.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Neto = Neto + 290;
            Items++;
            LBCantNica.Text = Convert.ToString(Convert.ToInt32(LBCantNica.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantVegetariana.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 180;
                Items--;
                LBCantVegetariana.Text = Convert.ToString(Convert.ToInt32(LBCantVegetariana.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantJamonQueso.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 210;
                Items--;
                LBCantJamonQueso.Text = Convert.ToString(Convert.ToInt32(LBCantJamonQueso.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantPepperoni.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 220;
                Items--;
                LBCantPepperoni.Text = Convert.ToString(Convert.ToInt32(LBCantPepperoni.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantChorizoItaliano.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 220;
                Items--;
                LBCantChorizoItaliano.Text = Convert.ToString(Convert.ToInt32(LBCantChorizoItaliano.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantCamarones.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 300;
                Items--;
                LBCantCamarones.Text = Convert.ToString(Convert.ToInt32(LBCantCamarones.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantMexicana.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 290;
                Items--;
                LBCantMexicana.Text = Convert.ToString(Convert.ToInt32(LBCantMexicana.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantNica.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 290;
                Items--;
                LBCantNica.Text = Convert.ToString(Convert.ToInt32(LBCantNica.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            Neto = Neto + 200;
            Items++;
            LBCantCorona.Text = Convert.ToString(Convert.ToInt32(LBCantCorona.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void BTMenosCorona_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantCorona.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 200;
                Items--;
                LBCantCorona.Text = Convert.ToString(Convert.ToInt32(LBCantCorona.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void BTMasChicago_Click(object sender, EventArgs e)
        {
            Neto = Neto + 340;
            Items++;
            LBCantChicago.Text = Convert.ToString(Convert.ToInt32(LBCantChicago.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void BTMenosChicago_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantChicago.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 340;
                Items--;
                LBCantChicago.Text = Convert.ToString(Convert.ToInt32(LBCantChicago.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void BTMenosPotPie_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantPotpie.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 220;
                Items--;
                LBCantPotpie.Text = Convert.ToString(Convert.ToInt32(LBCantPotpie.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void BTMasPotPie_Click(object sender, EventArgs e)
        {
            Neto = Neto + 220;
            Items++;
            LBCantPotpie.Text = Convert.ToString(Convert.ToInt32(LBCantPotpie.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            Neto = Neto + 280;
            Items++;
            LBCantMilanesaRes.Text = Convert.ToString(Convert.ToInt32(LBCantMilanesaRes.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantMilanesaRes.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 280;
                Items--;
                LBCantMilanesaRes.Text = Convert.ToString(Convert.ToInt32(LBCantMilanesaRes.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            Neto = Neto + 190;
            Items++;
            LBCantMilanesaPollo.Text = Convert.ToString(Convert.ToInt32(LBCantMilanesaPollo.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantMilanesaPollo.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 190;
                Items--;
                LBCantMilanesaPollo.Text = Convert.ToString(Convert.ToInt32(LBCantMilanesaPollo.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            Neto = Neto + 330;
            Items++;
            LBCantSalmon.Text = Convert.ToString(Convert.ToInt32(LBCantSalmon.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantSalmon.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 330;
                Items--;
                LBCantSalmon.Text = Convert.ToString(Convert.ToInt32(LBCantSalmon.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            Neto = Neto + 300;
            Items++;
            LBCantMariscosGalleta.Text = Convert.ToString(Convert.ToInt32(LBCantMariscosGalleta.Text) + 1);
            LBTotal.Text = Convert.ToString(Neto);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantMariscosGalleta.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 300;
                Items--;
                LBCantMariscosGalleta.Text = Convert.ToString(Convert.ToInt32(LBCantMariscosGalleta.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(LBCantMargarita.Text) < 1)
            {
                MessageBox.Show("La cantidad de este producto ya es 0");
            }
            else
            {
                Neto = Neto - 220;
                Items--;
                LBCantMargarita.Text = Convert.ToString(Convert.ToInt32(LBCantMargarita.Text) - 1);
                LBTotal.Text = Convert.ToString(Neto);
            }
        }


        //Boton de Contacto
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Llamanos al 2772 2100!");
        }
















        //Malos clicks
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBElimXNom_Click(object sender, EventArgs e)
        {
            Lista.EliminarListEnlazSXNombre(TBNomElim.Text, DGVRegistro);
            Lista.MostrarListEnlazS(DGVRegistro);
        }

        private void BTBuscXNom_Click(object sender, EventArgs e)
        {
            Lista.Busqueda(TBNomBuscar.Text, DGVRegistro);

        }

        private void panelmostrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
