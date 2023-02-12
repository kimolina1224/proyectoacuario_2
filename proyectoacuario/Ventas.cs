using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using proyectoacuario.DataSet1TableAdapters;

namespace proyectoacuario
{
    
    public partial class Ventas : Form
    {
        
        public Ventas()
        {
            InitializeComponent();
        }

        private void btn_Calcularfactura_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txt_cantidad.Text);
            double n2 = double.Parse(txt_precio.Text);
            double r = 0;
            r = n1 * n2;
            txt_Totalfactura.Text = r.ToString();

            if (rb_Tercera.Checked)
            {
                r = r * 0.85;
                txt_Totalfactura.Text = r.ToString();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login salir = new Login();
            salir.Show();
        }

        private void btn_Nuevafact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas vent = new Ventas();
            vent.Show();
        }
    } 
    }
