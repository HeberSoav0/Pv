namespace PV
{
    partial class Administrador
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificacionesUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificacionesProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.ModificacionesProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportePV = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporteTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1,
            this.AltaProductos,
            this.acercaDeToolStripMenuItem1,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaUsuarios,
            this.BajaUsuarios,
            this.ModificacionesUsuarios});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(71, 21);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // AltaUsuarios
            // 
            this.AltaUsuarios.Name = "AltaUsuarios";
            this.AltaUsuarios.Size = new System.Drawing.Size(180, 22);
            this.AltaUsuarios.Text = "Alta";
            this.AltaUsuarios.Click += new System.EventHandler(this.AltaUsuarios_Click);
            // 
            // BajaUsuarios
            // 
            this.BajaUsuarios.Name = "BajaUsuarios";
            this.BajaUsuarios.Size = new System.Drawing.Size(180, 22);
            this.BajaUsuarios.Text = "Baja";
            this.BajaUsuarios.Click += new System.EventHandler(this.BajaUsuarios_Click);
            // 
            // ModificacionesUsuarios
            // 
            this.ModificacionesUsuarios.Name = "ModificacionesUsuarios";
            this.ModificacionesUsuarios.Size = new System.Drawing.Size(180, 22);
            this.ModificacionesUsuarios.Text = "Modificaciones";
            this.ModificacionesUsuarios.Click += new System.EventHandler(this.ModificacionesUsuarios_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaProveedores,
            this.BajaProveedores,
            this.ModificacionesProveedores});
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(94, 21);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // AltaProveedores
            // 
            this.AltaProveedores.Name = "AltaProveedores";
            this.AltaProveedores.Size = new System.Drawing.Size(164, 22);
            this.AltaProveedores.Text = "Alta";
            this.AltaProveedores.Click += new System.EventHandler(this.AltaProveedores_Click);
            // 
            // BajaProveedores
            // 
            this.BajaProveedores.Name = "BajaProveedores";
            this.BajaProveedores.Size = new System.Drawing.Size(164, 22);
            this.BajaProveedores.Text = "Baja";
            this.BajaProveedores.Click += new System.EventHandler(this.BajaProveedores_Click);
            // 
            // ModificacionesProveedores
            // 
            this.ModificacionesProveedores.Name = "ModificacionesProveedores";
            this.ModificacionesProveedores.Size = new System.Drawing.Size(164, 22);
            this.ModificacionesProveedores.Text = "Modificaciones";
            this.ModificacionesProveedores.Click += new System.EventHandler(this.ModificacionesProeedores_Click);
            // 
            // AltaProductos
            // 
            this.AltaProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem4,
            this.BajaProductos,
            this.ModificacionesProductos});
            this.AltaProductos.Name = "AltaProductos";
            this.AltaProductos.Size = new System.Drawing.Size(73, 21);
            this.AltaProductos.Text = "Producto";
            // 
            // altaToolStripMenuItem4
            // 
            this.altaToolStripMenuItem4.Name = "altaToolStripMenuItem4";
            this.altaToolStripMenuItem4.Size = new System.Drawing.Size(164, 22);
            this.altaToolStripMenuItem4.Text = "Alta";
            this.altaToolStripMenuItem4.Click += new System.EventHandler(this.altaToolStripMenuItem4_Click);
            // 
            // BajaProductos
            // 
            this.BajaProductos.Name = "BajaProductos";
            this.BajaProductos.Size = new System.Drawing.Size(164, 22);
            this.BajaProductos.Text = "Baja";
            this.BajaProductos.Click += new System.EventHandler(this.BajaProductos_Click);
            // 
            // ModificacionesProductos
            // 
            this.ModificacionesProductos.Name = "ModificacionesProductos";
            this.ModificacionesProductos.Size = new System.Drawing.Size(164, 22);
            this.ModificacionesProductos.Text = "Modificaciones";
            this.ModificacionesProductos.Click += new System.EventHandler(this.ModificacionesProductos_Click);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReportePV,
            this.ReporteTicket});
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(87, 21);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de...";
            // 
            // ReportePV
            // 
            this.ReportePV.Name = "ReportePV";
            this.ReportePV.Size = new System.Drawing.Size(165, 22);
            this.ReportePV.Text = "Punto De Venta";
            // 
            // ReporteTicket
            // 
            this.ReporteTicket.Name = "ReporteTicket";
            this.ReporteTicket.Size = new System.Drawing.Size(165, 22);
            this.ReporteTicket.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 526);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AltaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem BajaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ModificacionesUsuarios;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AltaProveedores;
        private System.Windows.Forms.ToolStripMenuItem BajaProveedores;
        private System.Windows.Forms.ToolStripMenuItem ModificacionesProveedores;
        private System.Windows.Forms.ToolStripMenuItem AltaProductos;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem BajaProductos;
        private System.Windows.Forms.ToolStripMenuItem ModificacionesProductos;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ReportePV;
        private System.Windows.Forms.ToolStripMenuItem ReporteTicket;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}