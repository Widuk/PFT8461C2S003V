namespace WindowsFormsApp1.Model.Mantenedores.Descuento
{
    partial class ModificarDescuento
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
            this.txtPrecioDescuento = new System.Windows.Forms.TextBox();
            this.chkDescuentoPrecio = new System.Windows.Forms.CheckBox();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.btnCancelarDescuento = new System.Windows.Forms.Button();
            this.btnEditarDescuento = new System.Windows.Forms.Button();
            this.chkDescuentoPorcentaje = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcionCrear = new System.Windows.Forms.Label();
            this.lblTituloEditar = new System.Windows.Forms.Label();
            this.lblNombreDescuento = new System.Windows.Forms.Label();
            this.lblDescripcionDescuento = new System.Windows.Forms.Label();
            this.lblProductoDescuento = new System.Windows.Forms.Label();
            this.lblPorcDescuento = new System.Windows.Forms.Label();
            this.lblPrecioDescuento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecioDescuento
            // 
            this.txtPrecioDescuento.Enabled = false;
            this.txtPrecioDescuento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPrecioDescuento.Location = new System.Drawing.Point(154, 404);
            this.txtPrecioDescuento.Name = "txtPrecioDescuento";
            this.txtPrecioDescuento.Size = new System.Drawing.Size(285, 20);
            this.txtPrecioDescuento.TabIndex = 39;
            this.txtPrecioDescuento.Text = "$0";
            this.txtPrecioDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDescuento_KeyPress);
            // 
            // chkDescuentoPrecio
            // 
            this.chkDescuentoPrecio.AutoSize = true;
            this.chkDescuentoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescuentoPrecio.Location = new System.Drawing.Point(60, 358);
            this.chkDescuentoPrecio.Name = "chkDescuentoPrecio";
            this.chkDescuentoPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDescuentoPrecio.Size = new System.Drawing.Size(280, 20);
            this.chkDescuentoPrecio.TabIndex = 38;
            this.chkDescuentoPrecio.Text = "       Dispone de descuento en precio";
            this.chkDescuentoPrecio.UseVisualStyleBackColor = true;
            this.chkDescuentoPrecio.CheckedChanged += new System.EventHandler(this.chkDescuentoPrecio_CheckedChanged);
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Enabled = false;
            this.txtPorcentajeDescuento.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(154, 302);
            this.txtPorcentajeDescuento.Multiline = true;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(285, 22);
            this.txtPorcentajeDescuento.TabIndex = 37;
            this.txtPorcentajeDescuento.Text = "0%";
            this.txtPorcentajeDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentajeDescuento_KeyPress);
            // 
            // cbxProducto
            // 
            this.cbxProducto.Enabled = false;
            this.cbxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.ForeColor = System.Drawing.Color.Black;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(154, 204);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(285, 24);
            this.cbxProducto.TabIndex = 36;
            this.cbxProducto.Text = "Producto";
            // 
            // btnCancelarDescuento
            // 
            this.btnCancelarDescuento.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDescuento.ForeColor = System.Drawing.Color.White;
            this.btnCancelarDescuento.Location = new System.Drawing.Point(87, 481);
            this.btnCancelarDescuento.Name = "btnCancelarDescuento";
            this.btnCancelarDescuento.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarDescuento.TabIndex = 35;
            this.btnCancelarDescuento.Text = "Cancelar";
            this.btnCancelarDescuento.UseVisualStyleBackColor = false;
            this.btnCancelarDescuento.Click += new System.EventHandler(this.btnCancelarDescuento_Click);
            // 
            // btnEditarDescuento
            // 
            this.btnEditarDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDescuento.ForeColor = System.Drawing.Color.White;
            this.btnEditarDescuento.Location = new System.Drawing.Point(318, 481);
            this.btnEditarDescuento.Name = "btnEditarDescuento";
            this.btnEditarDescuento.Size = new System.Drawing.Size(121, 38);
            this.btnEditarDescuento.TabIndex = 34;
            this.btnEditarDescuento.Text = "Editar Descuento";
            this.btnEditarDescuento.UseVisualStyleBackColor = false;
            this.btnEditarDescuento.Click += new System.EventHandler(this.btnEditarDescuento_Click);
            // 
            // chkDescuentoPorcentaje
            // 
            this.chkDescuentoPorcentaje.AutoSize = true;
            this.chkDescuentoPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescuentoPorcentaje.Location = new System.Drawing.Point(60, 253);
            this.chkDescuentoPorcentaje.Name = "chkDescuentoPorcentaje";
            this.chkDescuentoPorcentaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDescuentoPorcentaje.Size = new System.Drawing.Size(282, 20);
            this.chkDescuentoPorcentaje.TabIndex = 33;
            this.chkDescuentoPorcentaje.Text = "Dispone de descuento en porcentaje";
            this.chkDescuentoPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDescuentoPorcentaje.UseVisualStyleBackColor = true;
            this.chkDescuentoPorcentaje.CheckedChanged += new System.EventHandler(this.chkDescuentoPorcentaje_CheckedChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(154, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(285, 73);
            this.txtDescripcion.TabIndex = 32;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(154, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(285, 22);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // lblDescripcionCrear
            // 
            this.lblDescripcionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCrear.Location = new System.Drawing.Point(43, 53);
            this.lblDescripcionCrear.Name = "lblDescripcionCrear";
            this.lblDescripcionCrear.Size = new System.Drawing.Size(288, 39);
            this.lblDescripcionCrear.TabIndex = 30;
            this.lblDescripcionCrear.Text = "Ingrese los datos solicitados para editar un descuento en el sistema:";
            // 
            // lblTituloEditar
            // 
            this.lblTituloEditar.AutoSize = true;
            this.lblTituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditar.Location = new System.Drawing.Point(42, 16);
            this.lblTituloEditar.Name = "lblTituloEditar";
            this.lblTituloEditar.Size = new System.Drawing.Size(149, 20);
            this.lblTituloEditar.TabIndex = 29;
            this.lblTituloEditar.Text = "Editar Descuento";
            // 
            // lblNombreDescuento
            // 
            this.lblNombreDescuento.AutoSize = true;
            this.lblNombreDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDescuento.Location = new System.Drawing.Point(60, 103);
            this.lblNombreDescuento.Name = "lblNombreDescuento";
            this.lblNombreDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreDescuento.Size = new System.Drawing.Size(67, 16);
            this.lblNombreDescuento.TabIndex = 40;
            this.lblNombreDescuento.Text = "Nombre:";
            // 
            // lblDescripcionDescuento
            // 
            this.lblDescripcionDescuento.AutoSize = true;
            this.lblDescripcionDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDescuento.Location = new System.Drawing.Point(59, 155);
            this.lblDescripcionDescuento.Name = "lblDescripcionDescuento";
            this.lblDescripcionDescuento.Size = new System.Drawing.Size(95, 16);
            this.lblDescripcionDescuento.TabIndex = 41;
            this.lblDescripcionDescuento.Text = "Descripción:";
            // 
            // lblProductoDescuento
            // 
            this.lblProductoDescuento.AutoSize = true;
            this.lblProductoDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoDescuento.Location = new System.Drawing.Point(60, 207);
            this.lblProductoDescuento.Name = "lblProductoDescuento";
            this.lblProductoDescuento.Size = new System.Drawing.Size(74, 16);
            this.lblProductoDescuento.TabIndex = 42;
            this.lblProductoDescuento.Text = "Producto:";
            // 
            // lblPorcDescuento
            // 
            this.lblPorcDescuento.AutoSize = true;
            this.lblPorcDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcDescuento.Location = new System.Drawing.Point(57, 308);
            this.lblPorcDescuento.Name = "lblPorcDescuento";
            this.lblPorcDescuento.Size = new System.Drawing.Size(65, 16);
            this.lblPorcDescuento.TabIndex = 43;
            this.lblPorcDescuento.Text = "% Desc:";
            // 
            // lblPrecioDescuento
            // 
            this.lblPrecioDescuento.AutoSize = true;
            this.lblPrecioDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDescuento.Location = new System.Drawing.Point(60, 408);
            this.lblPrecioDescuento.Name = "lblPrecioDescuento";
            this.lblPrecioDescuento.Size = new System.Drawing.Size(60, 16);
            this.lblPrecioDescuento.TabIndex = 44;
            this.lblPrecioDescuento.Text = "$ Desc:";
            // 
            // ModificarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 541);
            this.Controls.Add(this.lblPrecioDescuento);
            this.Controls.Add(this.lblPorcDescuento);
            this.Controls.Add(this.lblProductoDescuento);
            this.Controls.Add(this.lblDescripcionDescuento);
            this.Controls.Add(this.lblNombreDescuento);
            this.Controls.Add(this.txtPrecioDescuento);
            this.Controls.Add(this.chkDescuentoPrecio);
            this.Controls.Add(this.txtPorcentajeDescuento);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.btnCancelarDescuento);
            this.Controls.Add(this.btnEditarDescuento);
            this.Controls.Add(this.chkDescuentoPorcentaje);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTituloEditar);
            this.Controls.Add(this.lblDescripcionCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Editar Descuento";
            this.Load += new System.EventHandler(this.ModificarDescuento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecioDescuento;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Button btnCancelarDescuento;
        private System.Windows.Forms.Button btnEditarDescuento;
        private System.Windows.Forms.CheckBox chkDescuentoPorcentaje;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcionCrear;
        private System.Windows.Forms.Label lblTituloEditar;
        private System.Windows.Forms.CheckBox chkDescuentoPrecio;
        private System.Windows.Forms.Label lblNombreDescuento;
        private System.Windows.Forms.Label lblDescripcionDescuento;
        private System.Windows.Forms.Label lblProductoDescuento;
        private System.Windows.Forms.Label lblPorcDescuento;
        private System.Windows.Forms.Label lblPrecioDescuento;
    }
}