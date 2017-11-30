namespace WindowsFormsApp1.Model.Mantenedores.Descuento
{
    partial class CrearDescuento
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
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.chkDescuentoPorcentaje = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcionCrear = new System.Windows.Forms.Label();
            this.lblTituloCrear = new System.Windows.Forms.Label();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.chkDescuentoPrecio = new System.Windows.Forms.CheckBox();
            this.txtPrecioDescuento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.ForeColor = System.Drawing.Color.Black;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(66, 325);
            this.cbxProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(426, 33);
            this.cbxProducto.TabIndex = 25;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProducto.Location = new System.Drawing.Point(66, 569);
            this.btnCancelarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(182, 58);
            this.btnCancelarProducto.TabIndex = 23;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.ForeColor = System.Drawing.Color.White;
            this.btnCrearProducto.Location = new System.Drawing.Point(312, 569);
            this.btnCrearProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(182, 58);
            this.btnCrearProducto.TabIndex = 22;
            this.btnCrearProducto.Text = "Crear Descuento";
            this.btnCrearProducto.UseVisualStyleBackColor = false;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // chkDescuentoPorcentaje
            // 
            this.chkDescuentoPorcentaje.AutoSize = true;
            this.chkDescuentoPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescuentoPorcentaje.Location = new System.Drawing.Point(66, 371);
            this.chkDescuentoPorcentaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDescuentoPorcentaje.Name = "chkDescuentoPorcentaje";
            this.chkDescuentoPorcentaje.Size = new System.Drawing.Size(282, 29);
            this.chkDescuentoPorcentaje.TabIndex = 21;
            this.chkDescuentoPorcentaje.Text = "Es descuento en Porcentaje";
            this.chkDescuentoPorcentaje.UseVisualStyleBackColor = true;
            this.chkDescuentoPorcentaje.CheckedChanged += new System.EventHandler(this.chkDescuentoPorcentaje_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(66, 203);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(426, 110);
            this.txtDescripcion.TabIndex = 17;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(66, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(426, 30);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblDescripcionCrear
            // 
            this.lblDescripcionCrear.AutoSize = true;
            this.lblDescripcionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCrear.Location = new System.Drawing.Point(62, 86);
            this.lblDescripcionCrear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCrear.Name = "lblDescripcionCrear";
            this.lblDescripcionCrear.Size = new System.Drawing.Size(404, 50);
            this.lblDescripcionCrear.TabIndex = 15;
            this.lblDescripcionCrear.Text = "Ingrese los datos solicitados para agregar un \r\nnuevo descuento al sistema:";
            // 
            // lblTituloCrear
            // 
            this.lblTituloCrear.AutoSize = true;
            this.lblTituloCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrear.Location = new System.Drawing.Point(60, 38);
            this.lblTituloCrear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCrear.Name = "lblTituloCrear";
            this.lblTituloCrear.Size = new System.Drawing.Size(219, 29);
            this.lblTituloCrear.TabIndex = 14;
            this.lblTituloCrear.Text = "Nuevo Descuento";
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Enabled = false;
            this.txtPorcentajeDescuento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(66, 411);
            this.txtPorcentajeDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPorcentajeDescuento.Multiline = true;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(426, 32);
            this.txtPorcentajeDescuento.TabIndex = 26;
            this.txtPorcentajeDescuento.Text = "0%";
            this.txtPorcentajeDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeDescuento_KeyPress);
            // 
            // chkDescuentoPrecio
            // 
            this.chkDescuentoPrecio.AutoSize = true;
            this.chkDescuentoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkDescuentoPrecio.Location = new System.Drawing.Point(66, 455);
            this.chkDescuentoPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDescuentoPrecio.Name = "chkDescuentoPrecio";
            this.chkDescuentoPrecio.Size = new System.Drawing.Size(244, 29);
            this.chkDescuentoPrecio.TabIndex = 27;
            this.chkDescuentoPrecio.Text = "Es descuento en Precio";
            this.chkDescuentoPrecio.UseVisualStyleBackColor = true;
            this.chkDescuentoPrecio.CheckedChanged += new System.EventHandler(this.chkDescuentoPrecio_CheckedChanged);
            // 
            // txtPrecioDescuento
            // 
            this.txtPrecioDescuento.Enabled = false;
            this.txtPrecioDescuento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrecioDescuento.Location = new System.Drawing.Point(66, 497);
            this.txtPrecioDescuento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioDescuento.Name = "txtPrecioDescuento";
            this.txtPrecioDescuento.Size = new System.Drawing.Size(426, 26);
            this.txtPrecioDescuento.TabIndex = 28;
            this.txtPrecioDescuento.Text = "$0";
            this.txtPrecioDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDescuento_KeyPress);
            // 
            // CrearDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 682);
            this.Controls.Add(this.txtPrecioDescuento);
            this.Controls.Add(this.chkDescuentoPrecio);
            this.Controls.Add(this.txtPorcentajeDescuento);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.chkDescuentoPorcentaje);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcionCrear);
            this.Controls.Add(this.lblTituloCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Descuento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CrearDescuento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.CheckBox chkDescuentoPorcentaje;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcionCrear;
        private System.Windows.Forms.Label lblTituloCrear;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.CheckBox chkDescuentoPrecio;
        private System.Windows.Forms.TextBox txtPrecioDescuento;
    }
}