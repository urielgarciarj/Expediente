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
    public partial class Contenido : Form
    {
        public Contenido()
        {
            InitializeComponent();
        }

        public string contenido(string nombre)
        {
            TextReader leer;
            leer = new StreamReader(@"C:\Users\Usuario\Desktop\Expedientes\" + nombre + ".txt");
            this.Text = nombre;
            textBox1.Text = (leer.ReadLine());
            richTextBox1.Text = (leer.ReadToEnd());
            leer.Close();
            return "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
