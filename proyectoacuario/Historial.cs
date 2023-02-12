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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_Inicio admi = new form_Inicio();
            admi.Show();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.dataSet11.Factura);
            // TODO: This line of code loads data into the 'dataSet1.Factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.dataSet1.Factura);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.Fill(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.FillBy(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.FillBy1(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.FillBy1(this.dataSet11.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.FillBy1(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet12.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.FillBy1(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet11.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet12.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet13.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_5(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void scalarQueryToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                this.facturaTableAdapter.ScalarQuery(this.dataSet1.Factura);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
