namespace PV
{
    partial class ModificacionDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionDeUsuarios));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.tipoUsuario = new System.Windows.Forms.Label();
            this.contrasena = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(425, 504);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(148, 37);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.BackColor = System.Drawing.Color.LightYellow;
            this.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpleado.Location = new System.Drawing.Point(178, 347);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(131, 20);
            this.txtEmpleado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(279, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selecciona de la tabla para Modificar";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(37, 76);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(647, 231);
            this.dgvUsuarios.TabIndex = 12;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Location = new System.Drawing.Point(746, 76);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(165, 202);
            this.pbUsuario.TabIndex = 13;
            this.pbUsuario.TabStop = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.Location = new System.Drawing.Point(790, 284);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 14;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.Transparent;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(37, 395);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(54, 13);
            this.nombre.TabIndex = 15;
            this.nombre.Text = "Nombre:";
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.BackColor = System.Drawing.Color.Transparent;
            this.apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos.Location = new System.Drawing.Point(37, 435);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(62, 13);
            this.apellidos.TabIndex = 16;
            this.apellidos.Text = "Apellidos:";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.BackColor = System.Drawing.Color.Transparent;
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(369, 392);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(61, 13);
            this.telefono.TabIndex = 17;
            this.telefono.Text = "Telefono:";
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.Transparent;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(372, 439);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(48, 13);
            this.correo.TabIndex = 18;
            this.correo.Text = "Correo:";
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.AutoSize = true;
            this.tipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuario.Location = new System.Drawing.Point(629, 392);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(101, 13);
            this.tipoUsuario.TabIndex = 19;
            this.tipoUsuario.Text = "Tipo de Usuario:";
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.BackColor = System.Drawing.Color.Transparent;
            this.contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena.Location = new System.Drawing.Point(629, 442);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(75, 13);
            this.contrasena.TabIndex = 20;
            this.contrasena.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 392);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(139, 435);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(211, 20);
            this.txtApellidos.TabIndex = 22;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(436, 391);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(436, 439);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(175, 20);
            this.txtCorreo.TabIndex = 24;
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(736, 385);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(154, 20);
            this.txtTipoUsuario.TabIndex = 25;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(736, 435);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(154, 20);
            this.txtContrasena.TabIndex = 26;
            // 
            // ModificacionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(923, 553);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.contrasena);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "ModificacionDeUsuarios";
            this.Text = "ModificacionDeUsuarios";
            this.Load += new System.EventHandler(this.ModificacionDeUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label tipoUsuario;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
    }
}