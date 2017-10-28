namespace WindowsFormsApp1
{
    partial class EditarProducto
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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaIngresoTienda = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarTienda = new System.Windows.Forms.Button();
            this.btnCrearTienda = new System.Windows.Forms.Button();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblTituloModificar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.chDisponiblidad = new System.Windows.Forms.CheckBox();
            this.cmbTienda = new PresentationControls.CheckBoxComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "SKU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Rubro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(34, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 20);
            this.lblFecha.TabIndex = 72;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtSku
            // 
            this.txtSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSku.ForeColor = System.Drawing.Color.Gray;
            this.txtSku.Location = new System.Drawing.Point(123, 255);
            this.txtSku.MaxLength = 9;
            this.txtSku.Name = "txtSku";
            this.txtSku.ReadOnly = true;
            this.txtSku.Size = new System.Drawing.Size(267, 30);
            this.txtSku.TabIndex = 5;
            this.txtSku.Text = "SKU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Ingrese los datos solicitados para editar un producto del sistema:";
            // 
            // dtFechaIngresoTienda
            // 
            this.dtFechaIngresoTienda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngresoTienda.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaIngresoTienda.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtFechaIngresoTienda.Location = new System.Drawing.Point(123, 105);
            this.dtFechaIngresoTienda.Name = "dtFechaIngresoTienda";
            this.dtFechaIngresoTienda.Size = new System.Drawing.Size(267, 30);
            this.dtFechaIngresoTienda.TabIndex = 1;
            // 
            // btnCancelarTienda
            // 
            this.btnCancelarTienda.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTienda.Location = new System.Drawing.Point(37, 318);
            this.btnCancelarTienda.Name = "btnCancelarTienda";
            this.btnCancelarTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarTienda.TabIndex = 68;
            this.btnCancelarTienda.Text = "Cancelar";
            this.btnCancelarTienda.UseVisualStyleBackColor = false;
            this.btnCancelarTienda.Click += new System.EventHandler(this.btnCancelarTienda_Click);
            // 
            // btnCrearTienda
            // 
            this.btnCrearTienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrearTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearTienda.ForeColor = System.Drawing.Color.White;
            this.btnCrearTienda.Location = new System.Drawing.Point(663, 318);
            this.btnCrearTienda.Name = "btnCrearTienda";
            this.btnCrearTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCrearTienda.TabIndex = 67;
            this.btnCrearTienda.Text = "Editar tienda";
            this.btnCrearTienda.UseVisualStyleBackColor = false;
            this.btnCrearTienda.Click += new System.EventHandler(this.btnCrearTienda_Click);
            // 
            // cmbRubro
            // 
            this.cmbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRubro.ForeColor = System.Drawing.Color.Gray;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(517, 138);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(267, 33);
            this.cmbRubro.TabIndex = 7;
            this.cmbRubro.Text = "Rubro";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(123, 177);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 30);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreProducto.Location = new System.Drawing.Point(123, 140);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreProducto.Size = new System.Drawing.Size(267, 30);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // lblTituloModificar
            // 
            this.lblTituloModificar.AutoSize = true;
            this.lblTituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificar.Location = new System.Drawing.Point(33, 18);
            this.lblTituloModificar.Name = "lblTituloModificar";
            this.lblTituloModificar.Size = new System.Drawing.Size(192, 29);
            this.lblTituloModificar.TabIndex = 62;
            this.lblTituloModificar.Text = "Editar producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecio.Location = new System.Drawing.Point(123, 217);
            this.txtPrecio.MaxLength = 9;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(267, 30);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.Text = "1.234.567.890";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Tienda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.Color.Gray;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cmbEstado.Location = new System.Drawing.Point(517, 175);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(267, 33);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.Text = "Estado";
            // 
            // chDisponiblidad
            // 
            this.chDisponiblidad.AutoSize = true;
            this.chDisponiblidad.Location = new System.Drawing.Point(441, 222);
            this.chDisponiblidad.Name = "chDisponiblidad";
            this.chDisponiblidad.Size = new System.Drawing.Size(224, 29);
            this.chDisponiblidad.TabIndex = 9;
            this.chDisponiblidad.Text = "Disponibilidad 2 por 1";
            this.chDisponiblidad.UseVisualStyleBackColor = true;
            // 
            // cmbTienda
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTienda.CheckBoxProperties = checkBoxProperties1;
            this.cmbTienda.DisplayMemberSingleItem = "";
            this.cmbTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbTienda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbTienda.FormattingEnabled = true;
            this.cmbTienda.Location = new System.Drawing.Point(517, 105);
            this.cmbTienda.Name = "cmbTienda";
            this.cmbTienda.Size = new System.Drawing.Size(267, 33);
            this.cmbTienda.TabIndex = 84;
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 368);
            this.Controls.Add(this.cmbTienda);
            this.Controls.Add(this.chDisponiblidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaIngresoTienda);
            this.Controls.Add(this.btnCancelarTienda);
            this.Controls.Add(this.btnCrearTienda);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblTituloModificar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtFechaIngresoTienda;
        private System.Windows.Forms.Button btnCancelarTienda;
        private System.Windows.Forms.Button btnCrearTienda;
        public System.Windows.Forms.ComboBox cmbRubro;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblTituloModificar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox chDisponiblidad;
        private PresentationControls.CheckBoxComboBox cmbTienda;
    }
}