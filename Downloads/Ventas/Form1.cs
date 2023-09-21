using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VentaDeAutomoviles
{
    public partial class Form1 : Form
    {
       
        // Listas para almacenar datos
        private List<Cliente> clientes;
        private List<Suplidor> suplidores;
        private List<Producto> productos;

        

        public Form1()
        {
            InitializeComponent();

            // Inicializa las listas de datos
            clientes = new List<Cliente>();
            suplidores = new List<Suplidor>();
            productos = new List<Producto>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
