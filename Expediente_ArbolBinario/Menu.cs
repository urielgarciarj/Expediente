using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expediente_ArbolBinario
{
    public partial class Menu : Form
    {
        Creacion_Expediente creacion = new Creacion_Expediente();
        Busqueda search = new Busqueda();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCaseFile_Click(object sender, EventArgs e)
        {
            
            creacion.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            search.Show();
            this.Hide();
        }
    }
}
