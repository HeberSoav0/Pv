namespace PV
{
    partial class ModificacionDeProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionDeProductos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.pbProductos = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.tipoUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(426, 497);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(261, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selecciona, Modifica y Guarda";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(556, 427);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(187, 54);
            this.txtDescripcion.TabIndex = 41;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(556, 390);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(187, 20);
            this.txtCantidad.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 388);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.Transparent;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(472, 443);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(78, 13);
            this.correo.TabIndex = 35;
            this.correo.Text = "Descripcion:";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.BackColor = System.Drawing.Color.Transparent;
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(489, 395);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(61, 13);
            this.telefono.TabIndex = 34;
            this.telefono.Text = "Cantidad:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(121, 391);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(54, 13);
            this.nombre.TabIndex = 32;
            this.nombre.Text = "Nombre:";
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(799, 289);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 31;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // pbProductos
            // 
            this.pbProductos.Location = new System.Drawing.Point(748, 81);
            this.pbProductos.Name = "pbProductos";
            this.pbProductos.Size = new System.Drawing.Size(165, 202);
            this.pbProductos.TabIndex = 30;
            this.pbProductos.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(47, 81);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(647, 231);
            this.dgvProductos.TabIndex = 29;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(344, 339);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Codigo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(181, 440);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(211, 20);
            this.txtPrecio.TabIndex = 47;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.AutoSize = true;
            this.tipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario.Location = new System.Drawing.Point(121, 443);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(47, 13);
            this.tipoUsuario.TabIndex = 46;
            this.tipoUsuario.Text = "Precio:";
            // 
            // ModificacionDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 544);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.pbProductos);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ModificacionDeProductos";
            this.Text = "ModificacionDeProductos";
            this.Load += new System.EventHandler(this.ModificacionDeProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.PictureBox pbProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label tipoUsuario;
    }
}