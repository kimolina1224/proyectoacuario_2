using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoacuario
{
    public partial class form_Inicio : Form
    {
        public form_Inicio()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ventitas = new Ventas();
            ventitas.Show();
        }

        private void totalVentasPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial historial = new Historial();
            historial.Show();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producto prodf = new Producto();
            prodf.Show();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login salir = new Login();
            salir.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados emp = new Empleados();
            emp.Show();
        }


    }
}
