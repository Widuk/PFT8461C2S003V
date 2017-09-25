namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    partial class EditarTiendas
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTelefonoTienda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaIngresoTienda = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarTienda = new System.Windows.Forms.Button();
            this.btnCrearTienda = new System.Windows.Forms.Button();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtDireccionTienda = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.lblTituloModificar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Empresa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(41, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 56;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtTelefonoTienda
            // 
            this.txtTelefonoTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefonoTienda.Location = new System.Drawing.Point(142, 253);
            this.txtTelefonoTienda.MaxLength = 9;
            this.txtTelefonoTienda.Name = "txtTelefonoTienda";
            this.txtTelefonoTienda.Size = new System.Drawing.Size(267, 22);
            this.txtTelefonoTienda.TabIndex = 5;
            this.txtTelefonoTienda.Text = "Teléfono ## ### ####";
            this.txtTelefonoTienda.Enter += new System.EventHandler(this.txtTelefonoTienda_Enter);
            this.txtTelefonoTienda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoTienda_KeyPress);
            this.txtTelefonoTienda.Leave += new System.EventHandler(this.txtTelefonoTienda_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ingrese los nuevos datos para editar la tienda \r\ndentro del sistema:";
            // 
            // dtFechaIngresoTienda
            // 
            this.dtFechaIngresoTienda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngresoTienda.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaIngresoTienda.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtFechaIngresoTienda.Location = new System.Drawing.Point(142, 103);
            this.dtFechaIngresoTienda.Name = "dtFechaIngresoTienda";
            this.dtFechaIngresoTienda.Size = new System.Drawing.Size(267, 20);
            this.dtFechaIngresoTienda.TabIndex = 1;
            // 
            // btnCancelarTienda
            // 
            this.btnCancelarTienda.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTienda.Location = new System.Drawing.Point(82, 340);
            this.btnCancelarTienda.Name = "btnCancelarTienda";
            this.btnCancelarTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCancelarTienda.TabIndex = 52;
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
            this.btnCrearTienda.Location = new System.Drawing.Point(246, 340);
            this.btnCrearTienda.Name = "btnCrearTienda";
            this.btnCrearTienda.Size = new System.Drawing.Size(121, 38);
            this.btnCrearTienda.TabIndex = 51;
            this.btnCrearTienda.Text = "Editar tienda";
            this.btnCrearTienda.UseVisualStyleBackColor = false;
            this.btnCrearTienda.Click += new System.EventHandler(this.btnCrearTienda_Click);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.ForeColor = System.Drawing.Color.Gray;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(142, 213);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(267, 24);
            this.cmbCiudad.TabIndex = 4;
            this.cmbCiudad.Text = "Ciudad";
            // 
            // txtDireccionTienda
            // 
            this.txtDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccionTienda.Location = new System.Drawing.Point(142, 175);
            this.txtDireccionTienda.Name = "txtDireccionTienda";
            this.txtDireccionTienda.Size = new System.Drawing.Size(267, 22);
            this.txtDireccionTienda.TabIndex = 3;
            this.txtDireccionTienda.Text = "Dirección";
            this.txtDireccionTienda.Enter += new System.EventHandler(this.txtDireccionTienda_Enter);
            this.txtDireccionTienda.Leave += new System.EventHandler(this.txtDireccionTienda_Leave);
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(142, 293);
            this.txtNombreEmpresa.Multiline = true;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(267, 25);
            this.txtNombreEmpresa.TabIndex = 6;
            this.txtNombreEmpresa.Text = "Nombre de empresa";
            this.txtNombreEmpresa.Enter += new System.EventHandler(this.txtNombreEmpresa_Enter);
            this.txtNombreEmpresa.Leave += new System.EventHandler(this.txtNombreEmpresa_Leave);
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreTienda.Location = new System.Drawing.Point(142, 138);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreTienda.Size = new System.Drawing.Size(267, 22);
            this.txtNombreTienda.TabIndex = 2;
            this.txtNombreTienda.Text = "Nombre de la tienda";
            this.txtNombreTienda.Enter += new System.EventHandler(this.txtNombreTienda_Enter);
            this.txtNombreTienda.Leave += new System.EventHandler(this.txtNombreTienda_Leave);
            // 
            // lblTituloModificar
            // 
            this.lblTituloModificar.AutoSize = true;
            this.lblTituloModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificar.Location = new System.Drawing.Point(78, 24);
            this.lblTituloModificar.Name = "lblTituloModificar";
            this.lblTituloModificar.Size = new System.Drawing.Size(112, 20);
            this.lblTituloModificar.TabIndex = 46;
            this.lblTituloModificar.Text = "Editar tienda";
            // 
            // EditarTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTelefonoTienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaIngresoTienda);
            this.Controls.Add(this.btnCancelarTienda);
            this.Controls.Add(this.btnCrearTienda);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtDireccionTienda);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.txtNombreTienda);
            this.Controls.Add(this.lblTituloModificar);
            this.Name = "EditarTiendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTiendas";
            this.Load += new System.EventHandler(this.EditarTiendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarTienda;
        private System.Windows.Forms.Button btnCrearTienda;
        private System.Windows.Forms.Label lblTituloModificar;
        public System.Windows.Forms.TextBox txtNombreTienda;
        public System.Windows.Forms.TextBox txtTelefonoTienda;
        public System.Windows.Forms.ComboBox cmbCiudad;
        public System.Windows.Forms.TextBox txtDireccionTienda;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        public System.Windows.Forms.DateTimePicker dtFechaIngresoTienda;
    }
}