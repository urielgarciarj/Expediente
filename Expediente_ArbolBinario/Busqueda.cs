using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Expediente_ArbolBinario
{
    public partial class Busqueda : Form
    {
        Contenido expedientes = new Contenido();
        public Busqueda()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if(Program.arbol.PreOrden(Program.arbol.raiz, textBox.Text))
            {
                expedientes.Show();
                expedientes.contenido(textBox.Text);
            }
            else
            {
                MessageBox.Show("No se encontro Nodo");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }
    }
}
