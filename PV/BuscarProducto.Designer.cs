namespace PV
{
    partial class BuscarProducto
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
            this.dgvBuscarProducto = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarProducto
            // 
            this.dgvBuscarProducto.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProducto.Location = new System.Drawing.Point(89, 142);
            this.dgvBuscarProducto.Name = "dgvBuscarProducto";
            this.dgvBuscarProducto.Size = new System.Drawing.Size(597, 199);
            this.dgvBuscarProducto.TabIndex = 7;
            this.dgvBuscarProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProducto_CellContentClick);
            this.dgvBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvBuscarProducto_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(263, 98);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(213, 20);
            this.txtProducto.TabIndex = 5;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingresa el Código o Nombre del Producto para realizar la Búsqueda";
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 412);
            this.Controls.Add(this.dgvBuscarProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Name = "BuscarProducto";
            this.Text = "BuscarProducto";
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
    }
}