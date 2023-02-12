using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace proyectoacuario

{
    partial class Login : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usr = txtlogin.Text;
            string psw = txtpass.Text;
            con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Database113.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Usuario where User='" + txtlogin.Text + "' AND Password='" + txtpass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (txtlogin.Text == "Admin")
                {
                    this.Hide();
                    form_Inicio f2 = new form_Inicio();
                    f2.Show();
                }
                else
                {
                    this.Hide();
                    Ventas f3 = new Ventas();
                    f3.Show();
                }

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            con.Close();

        }

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbllog = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(145, 111);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(109, 20);
            this.txtlogin.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(145, 153);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(109, 20);
            this.txtpass.TabIndex = 1;
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(56, 106);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(74, 24);
            this.lbllog.TabIndex = 2;
            this.lbllog.Text = "Usuario";
            // 
            // txt_password
            // 
            this.txt_password.AutoSize = true;
            this.txt_password.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(24, 149);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(106, 24);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "Contrasena";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(145, 201);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "INGRESAR";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Label txt_password;
        private System.Windows.Forms.Button btn_Login;
        private PictureBox pictureBox1;
    }
}

