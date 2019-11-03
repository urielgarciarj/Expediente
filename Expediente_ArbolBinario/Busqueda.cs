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
        public Busqueda()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ABB arbol = new ABB();
            arbol.PreOrden(arbol.raiz, textBox.Text);
        }
    }
}
