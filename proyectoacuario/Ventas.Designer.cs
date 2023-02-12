namespace proyectoacuario
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.picb_logo = new System.Windows.Forms.PictureBox();
            this.gbox_venta = new System.Windows.Forms.GroupBox();
            this.list_venta = new System.Windows.Forms.ListView();
            this.btn_agregarv = new System.Windows.Forms.Button();
            this.btn_Calcularfactura = new System.Windows.Forms.Button();
            this.rb_Tercera = new System.Windows.Forms.RadioButton();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_producto = new System.Windows.Forms.Label();
            this.gbox_Factura = new System.Windows.Forms.GroupBox();
            this.btn_Nuevafact = new System.Windows.Forms.Button();
            this.txt_Totalfactura = new System.Windows.Forms.TextBox();
            this.lbl_totalfactura = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).BeginInit();
            this.gbox_venta.SuspendLayout();
            this.gbox_Factura.SuspendLayout();
            this.SuspendLayout();
            // 
            // picb_logo
            // 
            this.picb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picb_logo.BackgroundImage")));
            this.picb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picb_logo.Location = new System.Drawing.Point(12, 0);
            this.picb_logo.Name = "picb_logo";
            this.picb_logo.Size = new System.Drawing.Size(87, 71);
            this.picb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_logo.TabIndex = 6;
            this.picb_logo.TabStop = false;
            // 
            // gbox_venta
            // 
            this.gbox_venta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gbox_venta.Controls.Add(this.list_venta);
            this.gbox_venta.Controls.Add(this.btn_agregarv);
            this.gbox_venta.Controls.Add(this.btn_Calcularfactura);
            this.gbox_venta.Controls.Add(this.rb_Tercera);
            this.gbox_venta.Controls.Add(this.txt_cantidad);
            this.gbox_venta.Controls.Add(this.lbl_Cantidad);
            this.gbox_venta.Controls.Add(this.txt_precio);
            this.gbox_venta.Controls.Add(this.lbl_Precio);
            this.gbox_venta.Controls.Add(this.comboBox1);
            this.gbox_venta.Controls.Add(this.LBL_producto);
            this.gbox_venta.Location = new System.Drawing.Point(13, 90);
            this.gbox_venta.Name = "gbox_venta";
            this.gbox_venta.Size = new System.Drawing.Size(621, 132);
            this.gbox_venta.TabIndex = 7;
            this.gbox_venta.TabStop = false;
            this.gbox_venta.Text = "VENTAS";
            // 
            // list_venta
            // 
            this.list_venta.Location = new System.Drawing.Point(16, 69);
            this.list_venta.Name = "list_venta";
            this.list_venta.Size = new System.Drawing.Size(542, 42);
            this.list_venta.TabIndex = 8;
            this.list_venta.UseCompatibleStateImageBehavior = false;
            // 
            // btn_agregarv
            // 
            this.btn_agregarv.Location = new System.Drawing.Point(498, 39);
            this.btn_agregarv.Name = "btn_agregarv";
            this.btn_agregarv.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarv.TabIndex = 7;
            this.btn_agregarv.Text = "AGREGAR";
            this.btn_agregarv.UseVisualStyleBackColor = true;
            // 
            // btn_Calcularfactura
            // 
            this.btn_Calcularfactura.Location = new System.Drawing.Point(498, 10);
            this.btn_Calcularfactura.Name = "btn_Calcularfactura";
            this.btn_Calcularfactura.Size = new System.Drawing.Size(77, 23);
            this.btn_Calcularfactura.TabIndex = 8;
            this.btn_Calcularfactura.Text = "CALCULAR";
            this.btn_Calcularfactura.UseVisualStyleBackColor = true;
            this.btn_Calcularfactura.Click += new System.EventHandler(this.btn_Calcularfactura_Click);
            // 
            // rb_Tercera
            // 
            this.rb_Tercera.AutoSize = true;
            this.rb_Tercera.Location = new System.Drawing.Point(386, 44);
            this.rb_Tercera.Name = "rb_Tercera";
            this.rb_Tercera.Size = new System.Drawing.Size(90, 17);
            this.rb_Tercera.TabIndex = 6;
            this.rb_Tercera.TabStop = true;
            this.rb_Tercera.Text = "Tercera Edad";
            this.rb_Tercera.UseVisualStyleBackColor = true;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(269, 42);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 5;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(266, 21);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(90, 18);
            this.lbl_Cantidad.TabIndex = 4;
            this.lbl_Cantidad.Text = "CANTIDAD";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(147, 42);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 3;
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(144, 21);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(71, 18);
            this.lbl_Precio.TabIndex = 2;
            this.lbl_Precio.Text = "PRECIO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pecera",
            "Pez",
            "Alimento",
            "Otro",
            "Accesorio"});
            this.comboBox1.Location = new System.Drawing.Point(10, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // LBL_producto
            // 
            this.LBL_producto.AutoSize = true;
            this.LBL_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_producto.Location = new System.Drawing.Point(7, 21);
            this.LBL_producto.Name = "LBL_producto";
            this.LBL_producto.Size = new System.Drawing.Size(103, 18);
            this.LBL_producto.TabIndex = 0;
            this.LBL_producto.Text = "PRODUCTO";
            // 
            // gbox_Factura
            // 
            this.gbox_Factura.BackColor = System.Drawing.Color.DarkTurquoise;
            this.gbox_Factura.Controls.Add(this.btn_Nuevafact);
            this.gbox_Factura.Controls.Add(this.txt_Totalfactura);
            this.gbox_Factura.Controls.Add(this.lbl_totalfactura);
            this.gbox_Factura.Location = new System.Drawing.Point(23, 284);
            this.gbox_Factura.Name = "gbox_Factura";
            this.gbox_Factura.Size = new System.Drawing.Size(227, 100);
            this.gbox_Factura.TabIndex = 8;
            this.gbox_Factura.TabStop = false;
            this.gbox_Factura.Text = "FACTURA";
            // 
            // btn_Nuevafact
            // 
            this.btn_Nuevafact.Location = new System.Drawing.Point(49, 58);
            this.btn_Nuevafact.Name = "btn_Nuevafact";
            this.btn_Nuevafact.Size = new System.Drawing.Size(131, 23);
            this.btn_Nuevafact.TabIndex = 11;
            this.btn_Nuevafact.Text = "NUEVA FACTURA";
            this.btn_Nuevafact.UseVisualStyleBackColor = true;
            this.btn_Nuevafact.Click += new System.EventHandler(this.btn_Nuevafact_Click);
            // 
            // txt_Totalfactura
            // 
            this.txt_Totalfactura.Location = new System.Drawing.Point(74, 22);
            this.txt_Totalfactura.Name = "txt_Totalfactura";
            this.txt_Totalfactura.Size = new System.Drawing.Size(131, 20);
            this.txt_Totalfactura.TabIndex = 10;
            this.txt_Totalfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_totalfactura
            // 
            this.lbl_totalfactura.AutoSize = true;
            this.lbl_totalfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalfactura.Location = new System.Drawing.Point(15, 25);
            this.lbl_totalfactura.Name = "lbl_totalfactura";
            this.lbl_totalfactura.Size = new System.Drawing.Size(51, 13);
            this.lbl_totalfactura.TabIndex = 9;
            this.lbl_totalfactura.Text = "TOTAL:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(557, 361);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(77, 23);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "INICIO";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 455);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gbox_Factura);
            this.Controls.Add(this.gbox_venta);
            this.Controls.Add(this.picb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.picb_logo)).EndInit();
            this.gbox_venta.ResumeLayout(false);
            this.gbox_venta.PerformLayout();
            this.gbox_Factura.ResumeLayout(false);
            this.gbox_Factura.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_logo;
        private System.Windows.Forms.GroupBox gbox_venta;
        private System.Windows.Forms.ListView list_venta;
        private System.Windows.Forms.Button btn_agregarv;
        private System.Windows.Forms.Button btn_Calcularfactura;
        private System.Windows.Forms.RadioButton rb_Tercera;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_producto;
        private System.Windows.Forms.GroupBox gbox_Factura;
        private System.Windows.Forms.Button btn_Nuevafact;
        private System.Windows.Forms.TextBox txt_Totalfactura;
        private System.Windows.Forms.Label lbl_totalfactura;
        private System.Windows.Forms.Button btn_Salir;
    }
}