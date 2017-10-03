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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.lblTituloCrear = new System.Windows.Forms.Label();
            this.lblDescripcionCrear = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.cbPermitePromocion = new System.Windows.Forms.CheckBox();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.cmbTienda = new PresentationControls.CheckBoxComboBox();
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
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Location = new System.Drawing.Point(16, 261);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(281, 73);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Gray;
            this.txtPrecio.Location = new System.Drawing.Point(16, 142);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(285, 22);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.Text = "Precio";
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // cmbActivo
            // 
            this.cmbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActivo.ForeColor = System.Drawing.Color.Gray;
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Items.AddRange(new object[] {
            "Activo",
            "No activo"});
            this.cmbActivo.Location = new System.Drawing.Point(16, 170);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(285, 24);
            this.cmbActivo.TabIndex = 4;
            this.cmbActivo.Text = "Estado";
            // 
            // txtSKU
            // 
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.ForeColor = System.Drawing.Color.Gray;
            this.txtSKU.Location = new System.Drawing.Point(16, 86);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(285, 22);
            this.txtSKU.TabIndex = 1;
            this.txtSKU.Text = "SKU";
            this.txtSKU.Enter += new System.EventHandler(this.txtSKU_Enter);
            this.txtSKU.Leave += new System.EventHandler(this.txtSKU_Leave);
            // 
            // cbPermitePromocion
            // 
            this.cbPermitePromocion.AutoSize = true;
            this.cbPermitePromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPermitePromocion.Location = new System.Drawing.Point(16, 345);
            this.cbPermitePromocion.Name = "cbPermitePromocion";
            this.cbPermitePromocion.Size = new System.Drawing.Size(242, 20);
            this.cbPermitePromocion.TabIndex = 8;
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
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
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
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // cmbRubro
            // 
            this.cmbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRubro.ForeColor = System.Drawing.Color.Gray;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(16, 231);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(285, 24);
            this.cmbRubro.TabIndex = 6;
            this.cmbRubro.Text = "Rubro";
            // 
            // cmbTienda
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbTienda.CheckBoxProperties = checkBoxProperties1;
            this.cmbTienda.DisplayMemberSingleItem = "";
            this.cmbTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cmbTienda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbTienda.FormattingEnabled = true;
            this.cmbTienda.Location = new System.Drawing.Point(16, 200);
            this.cmbTienda.Name = "cmbTienda";
            this.cmbTienda.Size = new System.Drawing.Size(285, 24);
            this.cmbTienda.TabIndex = 5;
            this.cmbTienda.Text = "Tienda";
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 442);
            this.Controls.Add(this.cmbTienda);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.btnCancelarProducto);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.cbPermitePromocion);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.cmbActivo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcionCrear);
            this.Controls.Add(this.lblTituloCrear);
            this.Name = "CrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CrearProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCrear;
        private System.Windows.Forms.Label lblDescripcionCrear;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbActivo;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.CheckBox cbPermitePromocion;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.ComboBox cmbRubro;
        private PresentationControls.CheckBoxComboBox cmbTienda;
    }
}