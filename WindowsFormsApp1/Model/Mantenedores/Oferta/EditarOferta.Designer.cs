namespace WindowsFormsApp1.Model.Mantenedores.Oferta
{
    partial class EditarOferta
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
            this.chkListBoxTiendas = new System.Windows.Forms.CheckedListBox();
            this.lblTiendas = new System.Windows.Forms.Label();
            this.nudCantMaxProd = new System.Windows.Forms.NumericUpDown();
            this.lblCantMaxProx = new System.Windows.Forms.Label();
            this.nudCantMinProd = new System.Windows.Forms.NumericUpDown();
            this.lblCantMinProd = new System.Windows.Forms.Label();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarTienda = new System.Windows.Forms.Button();
            this.btnEditarOferta = new System.Windows.Forms.Button();
            this.lblTituloCrear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMinProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkListBoxTiendas
            // 
            this.chkListBoxTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListBoxTiendas.FormattingEnabled = true;
            this.chkListBoxTiendas.Location = new System.Drawing.Point(633, 206);
            this.chkListBoxTiendas.Name = "chkListBoxTiendas";
            this.chkListBoxTiendas.Size = new System.Drawing.Size(165, 89);
            this.chkListBoxTiendas.TabIndex = 74;
            // 
            // lblTiendas
            // 
            this.lblTiendas.AutoSize = true;
            this.lblTiendas.Location = new System.Drawing.Point(480, 206);
            this.lblTiendas.Name = "lblTiendas";
            this.lblTiendas.Size = new System.Drawing.Size(54, 13);
            this.lblTiendas.TabIndex = 73;
            this.lblTiendas.Text = "Tienda(s):";
            // 
            // nudCantMaxProd
            // 
            this.nudCantMaxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantMaxProd.Location = new System.Drawing.Point(633, 157);
            this.nudCantMaxProd.Name = "nudCantMaxProd";
            this.nudCantMaxProd.Size = new System.Drawing.Size(90, 22);
            this.nudCantMaxProd.TabIndex = 72;
            // 
            // lblCantMaxProx
            // 
            this.lblCantMaxProx.AutoSize = true;
            this.lblCantMaxProx.Location = new System.Drawing.Point(480, 164);
            this.lblCantMaxProx.Name = "lblCantMaxProx";
            this.lblCantMaxProx.Size = new System.Drawing.Size(135, 13);
            this.lblCantMaxProx.TabIndex = 71;
            this.lblCantMaxProx.Text = "Cantidad máxima producto:";
            // 
            // nudCantMinProd
            // 
            this.nudCantMinProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantMinProd.Location = new System.Drawing.Point(633, 116);
            this.nudCantMinProd.Name = "nudCantMinProd";
            this.nudCantMinProd.Size = new System.Drawing.Size(90, 22);
            this.nudCantMinProd.TabIndex = 70;
            // 
            // lblCantMinProd
            // 
            this.lblCantMinProd.AutoSize = true;
            this.lblCantMinProd.Location = new System.Drawing.Point(480, 123);
            this.lblCantMinProd.Name = "lblCantMinProd";
            this.lblCantMinProd.Size = new System.Drawing.Size(134, 13);
            this.lblCantMinProd.TabIndex = 69;
            this.lblCantMinProd.Text = "Cantidad mínima producto:";
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.Location = new System.Drawing.Point(318, 243);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarImagen.TabIndex = 68;
            this.btnBuscarImagen.Text = "Buscar imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = false;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Enabled = false;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImagen.Location = new System.Drawing.Point(149, 244);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(163, 22);
            this.txtUrlImagen.TabIndex = 66;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(52, 252);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 65;
            this.lblImagen.Text = "Imagen:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(149, 197);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(258, 24);
            this.cbxProducto.TabIndex = 64;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(52, 206);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 63;
            this.lblProducto.Text = "Producto:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(149, 157);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(258, 22);
            this.dtpFechaFin.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fecha de Fin:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaInicio.Location = new System.Drawing.Point(149, 116);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(258, 22);
            this.dtpFechaInicio.TabIndex = 60;
            this.dtpFechaInicio.Value = new System.DateTime(2017, 10, 3, 20, 21, 13, 0);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(52, 123);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 59;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Edite una oferta para que sea visible en la página de ofertas disponibles. Recuer" +
    "de subir una imagen.";
            // 
            // btnCancelarTienda
            // 
            this.btnCancelarTienda.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTienda.Location = new System.Drawing.Point(149, 432);
            this.btnCancelarTienda.Name = "btnCancelarTienda";
            this.btnCancelarTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarTienda.TabIndex = 57;
            this.btnCancelarTienda.Text = "Cancelar";
            this.btnCancelarTienda.UseVisualStyleBackColor = false;
            // 
            // btnEditarOferta
            // 
            this.btnEditarOferta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditarOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarOferta.ForeColor = System.Drawing.Color.White;
            this.btnEditarOferta.Location = new System.Drawing.Point(583, 432);
            this.btnEditarOferta.Name = "btnEditarOferta";
            this.btnEditarOferta.Size = new System.Drawing.Size(121, 38);
            this.btnEditarOferta.TabIndex = 56;
            this.btnEditarOferta.Text = "Editar oferta";
            this.btnEditarOferta.UseVisualStyleBackColor = false;
            this.btnEditarOferta.Click += new System.EventHandler(this.btnEditarOferta_Click);
            // 
            // lblTituloCrear
            // 
            this.lblTituloCrear.AutoSize = true;
            this.lblTituloCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrear.Location = new System.Drawing.Point(23, 26);
            this.lblTituloCrear.Name = "lblTituloCrear";
            this.lblTituloCrear.Size = new System.Drawing.Size(113, 20);
            this.lblTituloCrear.TabIndex = 55;
            this.lblTituloCrear.Text = "Editar Oferta";
            // 
            // EditarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.chkListBoxTiendas);
            this.Controls.Add(this.lblTiendas);
            this.Controls.Add(this.nudCantMaxProd);
            this.Controls.Add(this.lblCantMaxProx);
            this.Controls.Add(this.nudCantMinProd);
            this.Controls.Add(this.lblCantMinProd);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarTienda);
            this.Controls.Add(this.btnEditarOferta);
            this.Controls.Add(this.lblTituloCrear);
            this.Name = "EditarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarOferta";
            this.Load += new System.EventHandler(this.EditarOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMinProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListBoxTiendas;
        private System.Windows.Forms.Label lblTiendas;
        private System.Windows.Forms.NumericUpDown nudCantMaxProd;
        private System.Windows.Forms.Label lblCantMaxProx;
        private System.Windows.Forms.NumericUpDown nudCantMinProd;
        private System.Windows.Forms.Label lblCantMinProd;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarTienda;
        private System.Windows.Forms.Button btnEditarOferta;
        private System.Windows.Forms.Label lblTituloCrear;
    }
}