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

namespace proyectoacuario
{
    public partial class Producto : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        public Producto()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database113.mdb");
            cmd = new OleDbCommand();
           
            cmd.Connection = con; 
            cmd.CommandText = @"INSERT INTO Producto where Categoria='" + textbox1.Text + "' AND Nombre='" + textbox2.Text + "' AND Precio='" + textbox3.Text + "'";
            ////cmd.Parameters.AddWithValue("@Categoria", textbox1.Text);
            ////cmd.Parameters.AddWithValue("@Nombre", textbox2.Text);
            ////cmd.Parameters.AddWithValue("@Precio", textbox3.Text);
            con.Open();
            //dr = cmd.ExecuteReader();

            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }

        }
    }

       
    }
    
    

