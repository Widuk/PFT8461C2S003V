namespace WindowsFormsApp1
{
    partial class CrearProducto
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
            this.lblTituloCrear = new System.Windows.Forms.Label();
            this.lblDescripcionCrear = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbIsActivo = new System.Windows.Forms.ComboBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.cbPermitePromocion = new System.Windows.Forms.CheckBox();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloCrear
            // 
            this.lblTituloCrear.AutoSize = true;
            this.lblTituloCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrear.Location = new System.Drawing.Point(12, 9);
            this.lblTituloCrear.Name = "lblTituloCrear";
            this.lblTituloCrear.Size = new System.Drawing.Size(136, 20);
            this.lblTituloCrear.TabIndex = 0;
            this.lblTituloCrear.Text = "Nuevo Producto";
            this.lblTituloCrear.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcionCrear
            // 
            this.lblDescripcionCrear.AutoSize = true;
            this.lblDescripcionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCrear.Location = new System.Drawing.Point(13, 40);
            this.lblDescripcionCrear.Name = "lblDescripcionCrear";
            this.lblDescripcionCrear.Size = new System.Drawing.Size(281, 32);
            this.lblDescripcionCrear.TabIndex = 1;
            this.lblDescripcionCrear.Text = "Ingrese los datos solicitados para agregar un \r\nnuevo producto al sistema:";
            this.lblDescripcionCrear.Click += new System.EventHandler(this.lblDescripcionCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(16, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.Size = new System.Drawing.Size(285, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(16, 230);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(285, 73);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecio.Location = new System.Drawing.Point(16, 142);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(285, 22);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "Precio";
            // 
            // cbIsActivo
            // 
            this.cbIsActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActivo.ForeColor = System.Drawing.Color.Gray;
            this.cbIsActivo.FormattingEnabled = true;
            this.cbIsActivo.Location = new System.Drawing.Point(16, 170);
            this.cbIsActivo.Name = "cbIsActivo";
            this.cbIsActivo.Size = new System.Drawing.Size(285, 24);
            this.cbIsActivo.TabIndex = 5;
            this.cbIsActivo.Text = "Estado";
            // 
            // txtSKU
            // 
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.ForeColor = System.Drawing.Color.Gray;
            this.txtSKU.Location = new System.Drawing.Point(16, 86);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(285, 22);
            this.txtSKU.TabIndex = 6;
            this.txtSKU.Text = "SKU";
            // 
            // cbPermitePromocion
            // 
            this.cbPermitePromocion.AutoSize = true;
            this.cbPermitePromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPermitePromocion.Location = new System.Drawing.Point(16, 345);
            this.cbPermitePromocion.Name = "cbPermitePromocion";
            this.cbPermitePromocion.Size = new System.Drawing.Size(242, 20);
            this.cbPermitePromocion.TabIndex = 7;
            this.cbPermitePromocion.Text = "Permite propociones 2x1 y similares";
            this.cbPermitePromocion.UseVisualStyleBackColor = true;
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.ForeColor = System.Drawing.Color.White;
            this.btnCrearProducto.Location = new System.Drawing.Point(180, 389);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(121, 38);
            this.btnCrearProducto.TabIndex = 9;
            this.btnCrearProducto.Text = "Crear producto";
            this.btnCrearProducto.UseVisualStyleBackColor = false;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.ForeColor = System.Drawing.Color.White;
            this.btnCancelarProducto.Location = new System.Drawing.Point(16, 389);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarProducto.TabIndex = 10;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpFechaVencimiento.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(104, 316);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(197, 20);
            this.dtpFechaVencimiento.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Gray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Tienda asociada";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(13, 316);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(85, 16);
            this.lblFechaVencimiento.TabIndex = 13;
            this.lblFechaVencimiento.Text = "Vencimiento:";
            this.lblFechaVencimiento.Click += new System.EventHandler(this.lblFechaVencimiento_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 442);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.cbPermitePromocion);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.cbIsActivo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcionCrear);
            this.Controls.Add(this.lblTituloCrear);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCrear;
        private System.Windows.Forms.Label lblDescripcionCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbIsActivo;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.CheckBox cbPermitePromocion;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFechaVencimiento;
    }
}