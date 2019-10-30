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
    public partial class Creacion_Expediente : Form
    {
        public Creacion_Expediente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Al presionar el boton tomara todos los datos introducidos y los metera a un archivo
            StreamWriter write = new StreamWriter(@"D:\Visual Studio\Expediente\Expediente_ArbolBinario\Expedientes\"+ txtName.Text + ".txt", true);
            try
            {
                write.WriteLine("Edad: " + txtAge.Text);
                write.WriteLine("Antecedentes: " + richTextBox.Text);
                write.WriteLine("\n");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            write.Close();
        }
    }
}
