namespace WindowsFormsApp1.Model.Mantenedores.Oferta
{
    partial class CrearOferta
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarTienda = new System.Windows.Forms.Button();
            this.btnCrearOferta = new System.Windows.Forms.Button();
            this.lblTituloCrear = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.lblCantMinProd = new System.Windows.Forms.Label();
            this.nudCantMinProd = new System.Windows.Forms.NumericUpDown();
            this.lblCantMaxProx = new System.Windows.Forms.Label();
            this.nudCantMaxProd = new System.Windows.Forms.NumericUpDown();
            this.lblTiendas = new System.Windows.Forms.Label();
            this.chkListBoxTiendas = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMinProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Genere una oferta para que sea visible en la página de ofertas disponibles. Recue" +
    "rde subir una imagen.";
            // 
            // btnCancelarTienda
            // 
            this.btnCancelarTienda.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTienda.Location = new System.Drawing.Point(154, 428);
            this.btnCancelarTienda.Name = "btnCancelarTienda";
            this.btnCancelarTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarTienda.TabIndex = 37;
            this.btnCancelarTienda.Text = "Cancelar";
            this.btnCancelarTienda.UseVisualStyleBackColor = false;
            this.btnCancelarTienda.Click += new System.EventHandler(this.btnCancelarTienda_Click);
            // 
            // btnCrearOferta
            // 
            this.btnCrearOferta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCrearOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearOferta.ForeColor = System.Drawing.Color.White;
            this.btnCrearOferta.Location = new System.Drawing.Point(588, 428);
            this.btnCrearOferta.Name = "btnCrearOferta";
            this.btnCrearOferta.Size = new System.Drawing.Size(121, 38);
            this.btnCrearOferta.TabIndex = 36;
            this.btnCrearOferta.Text = "Crear oferta";
            this.btnCrearOferta.UseVisualStyleBackColor = false;
            this.btnCrearOferta.Click += new System.EventHandler(this.btnCrearOferta_Click);
            // 
            // lblTituloCrear
            // 
            this.lblTituloCrear.AutoSize = true;
            this.lblTituloCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrear.Location = new System.Drawing.Point(28, 22);
            this.lblTituloCrear.Name = "lblTituloCrear";
            this.lblTituloCrear.Size = new System.Drawing.Size(115, 20);
            this.lblTituloCrear.TabIndex = 35;
            this.lblTituloCrear.Text = "Nueva Oferta";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(57, 119);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(83, 13);
            this.lblFechaInicio.TabIndex = 39;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(154, 112);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(258, 22);
            this.dtpFechaInicio.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(154, 153);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(258, 22);
            this.dtpFechaFin.TabIndex = 42;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(57, 202);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 43;
            this.lblProducto.Text = "Producto:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(154, 193);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(258, 24);
            this.cbxProducto.TabIndex = 44;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(57, 248);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(45, 13);
            this.lblImagen.TabIndex = 45;
            this.lblImagen.Text = "Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Enabled = false;
            this.txtUrlImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlImagen.Location = new System.Drawing.Point(154, 240);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(163, 22);
            this.txtUrlImagen.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarImagen.ForeColor = System.Drawing.Color.White;
            this.btnBuscarImagen.Location = new System.Drawing.Point(323, 239);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarImagen.TabIndex = 48;
            this.btnBuscarImagen.Text = "Buscar imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = false;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // lblCantMinProd
            // 
            this.lblCantMinProd.AutoSize = true;
            this.lblCantMinProd.Location = new System.Drawing.Point(485, 119);
            this.lblCantMinProd.Name = "lblCantMinProd";
            this.lblCantMinProd.Size = new System.Drawing.Size(134, 13);
            this.lblCantMinProd.TabIndex = 49;
            this.lblCantMinProd.Text = "Cantidad mínima producto:";
            // 
            // nudCantMinProd
            // 
            this.nudCantMinProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantMinProd.Location = new System.Drawing.Point(638, 112);
            this.nudCantMinProd.Name = "nudCantMinProd";
            this.nudCantMinProd.Size = new System.Drawing.Size(90, 22);
            this.nudCantMinProd.TabIndex = 50;
            // 
            // lblCantMaxProx
            // 
            this.lblCantMaxProx.AutoSize = true;
            this.lblCantMaxProx.Location = new System.Drawing.Point(485, 160);
            this.lblCantMaxProx.Name = "lblCantMaxProx";
            this.lblCantMaxProx.Size = new System.Drawing.Size(135, 13);
            this.lblCantMaxProx.TabIndex = 51;
            this.lblCantMaxProx.Text = "Cantidad máxima producto:";
            // 
            // nudCantMaxProd
            // 
            this.nudCantMaxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantMaxProd.Location = new System.Drawing.Point(638, 153);
            this.nudCantMaxProd.Name = "nudCantMaxProd";
            this.nudCantMaxProd.Size = new System.Drawing.Size(90, 22);
            this.nudCantMaxProd.TabIndex = 52;
            // 
            // lblTiendas
            // 
            this.lblTiendas.AutoSize = true;
            this.lblTiendas.Location = new System.Drawing.Point(485, 202);
            this.lblTiendas.Name = "lblTiendas";
            this.lblTiendas.Size = new System.Drawing.Size(54, 13);
            this.lblTiendas.TabIndex = 53;
            this.lblTiendas.Text = "Tienda(s):";
            // 
            // chkListBoxTiendas
            // 
            this.chkListBoxTiendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListBoxTiendas.FormattingEnabled = true;
            this.chkListBoxTiendas.Location = new System.Drawing.Point(638, 202);
            this.chkListBoxTiendas.Name = "chkListBoxTiendas";
            this.chkListBoxTiendas.Size = new System.Drawing.Size(165, 89);
            this.chkListBoxTiendas.TabIndex = 54;
            // 
            // CrearOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 491);
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
            this.Controls.Add(this.btnCrearOferta);
            this.Controls.Add(this.lblTituloCrear);
            this.Name = "CrearOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearOferta";
            this.Load += new System.EventHandler(this.CrearOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMinProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantMaxProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarTienda;
        private System.Windows.Forms.Button btnCrearOferta;
        private System.Windows.Forms.Label lblTituloCrear;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.Label lblCantMinProd;
        private System.Windows.Forms.NumericUpDown nudCantMinProd;
        private System.Windows.Forms.Label lblCantMaxProx;
        private System.Windows.Forms.NumericUpDown nudCantMaxProd;
        private System.Windows.Forms.Label lblTiendas;
        private System.Windows.Forms.CheckedListBox chkListBoxTiendas;
    }
}