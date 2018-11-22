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
    public partial class Conversiones : Form
    {
        public Conversiones()
        {
            InitializeComponent();
        }

        private void BTConvertir_Click(object sender, EventArgs e)
        {
            //Instanciamos un objeto de la clase para utilizar sus metodos.
            Acciones Acc = new Acciones();

            //Aqui hacemos que el texto del textbox sea igual a lo que retorne el metodo convertir
            textBoxInfija.Text = Acc.convertirinfija(textBoxPrefija.Text);
            textBoxPosfija.Text = Acc.convertirposfija(textBoxPrefija.Text);
        }

        private void BTReset_Click(object sender, EventArgs e)
        {
            textBoxInfija.Text = "";
            textBoxPosfija.Text = "";
            textBoxPrefija.Text = "";
        }
    }
}
