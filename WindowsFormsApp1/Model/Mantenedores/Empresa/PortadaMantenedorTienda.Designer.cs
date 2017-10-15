namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    partial class PortadaMantenedorTienda
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
            this.dtgTiendas = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaTienda = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarDescuento = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiendas)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgTiendas
            // 
            this.dtgTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTiendas.Location = new System.Drawing.Point(255, 201);
            this.dtgTiendas.Name = "dtgTiendas";
            this.dtgTiendas.ReadOnly = true;
            this.dtgTiendas.Size = new System.Drawing.Size(645, 264);
            this.dtgTiendas.TabIndex = 13;
            this.dtgTiendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTiendas_CellClick);
            this.dtgTiendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTiendas_CellContentClick);
            this.dtgTiendas.DoubleClick += new System.EventHandler(this.dtgTiendas_DoubleClick);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(253, 126);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(493, 16);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Lista de tiendas. Para operar sobre una tienda, selecciona la fila correspondient" +
    "e.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(252, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 20);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Mantenedor de Tiendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(937, 37);
            this.panel1.TabIndex = 9;
            // 
            // btnNuevaTienda
            // 
            this.btnNuevaTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevaTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTienda.ForeColor = System.Drawing.Color.White;
            this.btnNuevaTienda.Location = new System.Drawing.Point(767, 168);
            this.btnNuevaTienda.Name = "btnNuevaTienda";
            this.btnNuevaTienda.Size = new System.Drawing.Size(133, 27);
            this.btnNuevaTienda.TabIndex = 8;
            this.btnNuevaTienda.Text = "Nueva tienda";
            this.btnNuevaTienda.UseVisualStyleBackColor = false;
            this.btnNuevaTienda.Click += new System.EventHandler(this.btnNuevaTienda_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(628, 481);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnModificar.Size = new System.Drawing.Size(133, 27);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarDescuento
            // 
            this.btnEliminarDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDescuento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarDescuento.Location = new System.Drawing.Point(767, 481);
            this.btnEliminarDescuento.Name = "btnEliminarDescuento";
            this.btnEliminarDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarDescuento.Size = new System.Drawing.Size(133, 27);
            this.btnEliminarDescuento.TabIndex = 19;
            this.btnEliminarDescuento.Text = "Eliminar";
            this.btnEliminarDescuento.UseVisualStyleBackColor = false;
            this.btnEliminarDescuento.Click += new System.EventHandler(this.btnEliminarDescuento_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(489, 481);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnActualizar.Size = new System.Drawing.Size(133, 27);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 523);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 37);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(24, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 412);
            this.panel3.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(30, 412);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PortadaMantenedorTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarDescuento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtgTiendas);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNuevaTienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PortadaMantenedorTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiendas";
            this.Load += new System.EventHandler(this.Tienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTiendas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaTienda;
        public System.Windows.Forms.DataGridView dtgTiendas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarDescuento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}