namespace PV
{
    partial class BajaDeProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BajaDeProveedores));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNoProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lvProveedor = new System.Windows.Forms.ListView();
            this.NoEmpleado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contraseña = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(535, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 57);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtNoProveedor
            // 
            this.txtNoProveedor.Location = new System.Drawing.Point(407, 82);
            this.txtNoProveedor.Name = "txtNoProveedor";
            this.txtNoProveedor.Size = new System.Drawing.Size(122, 20);
            this.txtNoProveedor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "No. Proveedor:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(422, 489);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 35);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lvProveedor
            // 
            this.lvProveedor.BackColor = System.Drawing.Color.White;
            this.lvProveedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoEmpleado,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Email,
            this.TipoUsuario,
            this.Contraseña});
            this.lvProveedor.GridLines = true;
            this.lvProveedor.Location = new System.Drawing.Point(48, 148);
            this.lvProveedor.Name = "lvProveedor";
            this.lvProveedor.Size = new System.Drawing.Size(821, 289);
            this.lvProveedor.TabIndex = 32;
            this.lvProveedor.UseCompatibleStateImageBehavior = false;
            this.lvProveedor.View = System.Windows.Forms.View.Details;
            // 
            // NoEmpleado
            // 
            this.NoEmpleado.Text = "No. Empleado";
            this.NoEmpleado.Width = 81;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre(s)";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Width = 143;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido(s)";
            this.Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apellido.Width = 138;
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            this.Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefono.Width = 103;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 160;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.Text = "Tipo de Usuario";
            this.TipoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipoUsuario.Width = 97;
            // 
            // Contraseña
            // 
            this.Contraseña.Text = "Contraseña";
            this.Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contraseña.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ingresa el No. Empleado para hacer la búsqueda, selecciona y elimina";
            // 
            // BajaDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(917, 550);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNoProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lvProveedor);
            this.Controls.Add(this.label1);
            this.Name = "BajaDeProveedores";
            this.Text = "BajaDeProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNoProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView lvProveedor;
        private System.Windows.Forms.ColumnHeader NoEmpleado;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader TipoUsuario;
        private System.Windows.Forms.ColumnHeader Contraseña;
        private System.Windows.Forms.Label label1;
    }
}