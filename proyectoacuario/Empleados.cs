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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Empleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Inicio admi = new form_Inicio();
            admi.Show();
        }

        private void tabla_Empleado_Paint(object sender, PaintEventArgs e)
        {
            this.Hide();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.dataSet11.Empleado);
            // TODO: This line of code loads data into the 'dataSet1.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.dataSet1.Empleado);

        }

        
    }
}
