namespace PV
{
    partial class ModificacionDeProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificacionDeProveedores));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lvProveedor = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apell = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Correo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.txtNoProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(426, 499);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 37);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lvProveedor
            // 
            this.lvProveedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Nom,
            this.Apell,
            this.Tipo,
            this.Tel,
            this.Correo,
            this.Contra});
            this.lvProveedor.GridLines = true;
            this.lvProveedor.Location = new System.Drawing.Point(31, 139);
            this.lvProveedor.Name = "lvProveedor";
            this.lvProveedor.Size = new System.Drawing.Size(845, 325);
            this.lvProveedor.TabIndex = 16;
            this.lvProveedor.UseCompatibleStateImageBehavior = false;
            this.lvProveedor.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No. Empleado";
            this.No.Width = 80;
            // 
            // Nom
            // 
            this.Nom.Text = "Nombre(s)";
            this.Nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nom.Width = 157;
            // 
            // Apell
            // 
            this.Apell.Text = "Apellido(s)";
            this.Apell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Apell.Width = 176;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo De Usuario";
            this.Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tipo.Width = 91;
            // 
            // Tel
            // 
            this.Tel.Text = "Telefono";
            this.Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tel.Width = 88;
            // 
            // Correo
            // 
            this.Correo.Text = "E-mail";
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correo.Width = 156;
            // 
            // Contra
            // 
            this.Contra.Text = "Contraseña";
            this.Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contra.Width = 79;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(526, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 48);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtNoProveedor
            // 
            this.txtNoProveedor.Location = new System.Drawing.Point(389, 96);
            this.txtNoProveedor.Name = "txtNoProveedor";
            this.txtNoProveedor.Size = new System.Drawing.Size(131, 20);
            this.txtNoProveedor.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "No. Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(96, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(723, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingresa el No. Proveedor para realizar la busqueda, selecciona, modifica y guarda" +
    " los cambios";
            // 
            // ModificacionDeProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 547);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lvProveedor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtNoProveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "ModificacionDeProveedores";
            this.Text = "ModificacionDeProveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListView lvProveedor;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Apell;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Tel;
        private System.Windows.Forms.ColumnHeader Correo;
        private System.Windows.Forms.ColumnHeader Contra;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNoProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}