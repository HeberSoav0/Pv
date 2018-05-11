namespace PV
{
    partial class PuntoDeVenta
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
            this.btCorteCaja = new System.Windows.Forms.Button();
            this.gbAnadirProducto = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblCajero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbFotoProducto = new System.Windows.Forms.PictureBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFechayHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAnadirProducto.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btCorteCaja
            // 
            this.btCorteCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCorteCaja.Location = new System.Drawing.Point(453, 33);
            this.btCorteCaja.Name = "btCorteCaja";
            this.btCorteCaja.Size = new System.Drawing.Size(130, 23);
            this.btCorteCaja.TabIndex = 2;
            this.btCorteCaja.Text = "Corte De Caja [F7]";
            this.btCorteCaja.UseVisualStyleBackColor = true;
            // 
            // gbAnadirProducto
            // 
            this.gbAnadirProducto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbAnadirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbAnadirProducto.Controls.Add(this.txtCodigo);
            this.gbAnadirProducto.Controls.Add(this.txtTotal);
            this.gbAnadirProducto.Controls.Add(this.txtIva);
            this.gbAnadirProducto.Controls.Add(this.label5);
            this.gbAnadirProducto.Controls.Add(this.label3);
            this.gbAnadirProducto.Controls.Add(this.txtCantidad);
            this.gbAnadirProducto.Controls.Add(this.label2);
            this.gbAnadirProducto.Controls.Add(this.label1);
            this.gbAnadirProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gbAnadirProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnadirProducto.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbAnadirProducto.Location = new System.Drawing.Point(17, 200);
            this.gbAnadirProducto.Name = "gbAnadirProducto";
            this.gbAnadirProducto.Size = new System.Drawing.Size(678, 133);
            this.gbAnadirProducto.TabIndex = 19;
            this.gbAnadirProducto.TabStop = false;
            this.gbAnadirProducto.Text = "Añadir Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(173, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 24);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(496, 78);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 24);
            this.txtTotal.TabIndex = 7;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(496, 45);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 24);
            this.txtIva.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "IVA:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(173, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(115, 24);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave de Producto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btCorteCaja);
            this.panel2.Controls.Add(this.btnRealizarVenta);
            this.panel2.Controls.Add(this.btnBuscarProducto);
            this.panel2.Location = new System.Drawing.Point(17, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 100);
            this.panel2.TabIndex = 18;
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.Location = new System.Drawing.Point(278, 33);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(138, 23);
            this.btnRealizarVenta.TabIndex = 1;
            this.btnRealizarVenta.Text = "Realizar Venta [F5]";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(92, 34);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(147, 23);
            this.btnBuscarProducto.TabIndex = 0;
            this.btnBuscarProducto.Text = "Buscar Producto [F2]";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Location = new System.Drawing.Point(96, 8);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(37, 13);
            this.lblCajero.TabIndex = 17;
            this.lblCajero.Text = "Cajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(31, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "PV";
            // 
            // pbFotoProducto
            // 
            this.pbFotoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbFotoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoProducto.Location = new System.Drawing.Point(749, 27);
            this.pbFotoProducto.Name = "pbFotoProducto";
            this.pbFotoProducto.Size = new System.Drawing.Size(163, 219);
            this.pbFotoProducto.TabIndex = 15;
            this.pbFotoProducto.TabStop = false;
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Precio,
            this.Iva,
            this.SubTotal});
            this.lvProductos.Location = new System.Drawing.Point(17, 27);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(678, 144);
            this.lvProductos.TabIndex = 14;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Tag = "";
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 105;
            // 
            // Nombre
            // 
            this.Nombre.Tag = "";
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Width = 214;
            // 
            // Cantidad
            // 
            this.Cantidad.Tag = "";
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 68;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 97;
            // 
            // Iva
            // 
            this.Iva.Text = "Iva";
            this.Iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "Sub-Total";
            this.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubTotal.Width = 128;
            // 
            // lblFechayHora
            // 
            this.lblFechayHora.AutoSize = true;
            this.lblFechayHora.Location = new System.Drawing.Point(841, 493);
            this.lblFechayHora.Name = "lblFechayHora";
            this.lblFechayHora.Size = new System.Drawing.Size(71, 13);
            this.lblFechayHora.TabIndex = 20;
            this.lblFechayHora.Text = "Fecha y Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha y Hora";
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbAnadirProducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCajero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbFotoProducto);
            this.Controls.Add(this.lvProductos);
            this.Controls.Add(this.lblFechayHora);
            this.Name = "PuntoDeVenta";
            this.Text = "PuntoDeVenta";
            this.Load += new System.EventHandler(this.PuntoDeVenta_Load);
            this.gbAnadirProducto.ResumeLayout(false);
            this.gbAnadirProducto.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCorteCaja;
        private System.Windows.Forms.GroupBox gbAnadirProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbFotoProducto;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Iva;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.Label lblFechayHora;
        private System.Windows.Forms.Label label6;
    }
}