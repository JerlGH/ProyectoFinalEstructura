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
    public partial class Form1 : Form
    {
        Acciones Acc = new Acciones();
        public int cant;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNMenu.Visible = true;
            PNTamaño.Visible = false;
        }                 //Paneles de Inicio
        private void BTMostrarRegistros_Click(object sender, EventArgs e)
        {
            Formulario_de_pedidos Formulario = new Formulario_de_pedidos(Convert.ToInt32(TBCant.Text));
            Formulario.Show();
            this.Hide();
        }   //Iniciar el formulario
        private void BTCasoPila_Click(object sender, EventArgs e)
        {
            Acc.Seleccion = "CasoPila";
            PNMenu.Visible = false;
            PNTamaño.Visible = true;
        }           //Envio de la selección Caso Pila
        private void BTCasoColaS_Click(object sender, EventArgs e)
        {
            Acc.Seleccion = "CasoColaS";
            PNMenu.Visible = false;
            PNTamaño.Visible = true;
        }          //Envio de la selección Caso Cola Simple
        private void BTCasoColaC_Click(object sender, EventArgs e)
        {
            Acc.Seleccion = "CasoColaC";
            PNMenu.Visible = false;
            PNTamaño.Visible = true;
        }          //Envio de la selección Caso Cola Circular

        private void BTCasoListEnlazadaS_Click(object sender, EventArgs e)
        {
            Acc.Seleccion = "CasoListEnlazS";
            Formulario_de_pedidos Formulario = new Formulario_de_pedidos(1);
            Formulario.Show();
            this.Hide();
        }  //Encio de la selección Caso Lista Enlazada Simple

        private void BTConversiones_Click(object sender, EventArgs e)
        {
            Conversiones Conv = new Conversiones();
            Conv.Show();
            this.Hide();

        }       //Selección Caso Converciones















        //Malos Clicks
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
