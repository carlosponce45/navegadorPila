using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form2 : Form
    {
        Pila atras = new Pila();
        Pila adelante = new Pila();

        public Form2()
        {
            InitializeComponent();
        }

        private void cmdIr_Click(object sender, EventArgs e)
        {
            atras.Insertar(txtURL.Text);
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            if(atras.tope.siguiente != null)
            { 
                txtURL.Text = atras.tope.URL;
                adelante.Insertar(atras.tope.URL);
                atras.Eliminar();
            }
        }

        private void cmdAdelnate_Click(object sender, EventArgs e)
        {
            if (adelante.tope.siguiente != null)
            {
                txtURL.Text = adelante.tope.URL;
                atras.Insertar(adelante.tope.URL);
                adelante.Eliminar();
            }
        }
    }
}
