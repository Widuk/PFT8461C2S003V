namespace WindowsFormsApp1.Model.Mantenedores.Empresa
{
    partial class CrearTienda
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
            this.btnCancelarTienda = new System.Windows.Forms.Button();
            this.btnCrearTienda = new System.Windows.Forms.Button();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtDireccionTienda = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreTienda = new System.Windows.Forms.TextBox();
            this.lblTituloCrear = new System.Windows.Forms.Label();
            this.dtFechaIngresoTienda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoTienda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelarTienda
            // 
            this.btnCancelarTienda.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTienda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarTienda.Location = new System.Drawing.Point(93, 511);
            this.btnCancelarTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarTienda.Name = "btnCancelarTienda";
            this.btnCancelarTienda.Size = new System.Drawing.Size(182, 58);
            this.btnCancelarTienda.TabIndex = 23;
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
            this.btnCrearTienda.Location = new System.Drawing.Point(339, 511);
            this.btnCrearTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearTienda.Name = "btnCrearTienda";
            this.btnCrearTienda.Size = new System.Drawing.Size(182, 58);
            this.btnCrearTienda.TabIndex = 22;
            this.btnCrearTienda.Text = "Crear tienda";
            this.btnCrearTienda.UseVisualStyleBackColor = false;
            this.btnCrearTienda.Click += new System.EventHandler(this.btnCrearTienda_Click);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudad.ForeColor = System.Drawing.Color.Gray;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(93, 315);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(426, 33);
            this.cmbCiudad.TabIndex = 4;
            // 
            // txtDireccionTienda
            // 
            this.txtDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtDireccionTienda.Location = new System.Drawing.Point(93, 257);
            this.txtDireccionTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccionTienda.Name = "txtDireccionTienda";
            this.txtDireccionTienda.Size = new System.Drawing.Size(426, 30);
            this.txtDireccionTienda.TabIndex = 3;
            this.txtDireccionTienda.Text = "Dirección";
            this.txtDireccionTienda.Enter += new System.EventHandler(this.txtDireccionTienda_Enter);
            this.txtDireccionTienda.Leave += new System.EventHandler(this.txtDireccionTienda_Leave);
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpresa.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(93, 438);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreEmpresa.Multiline = true;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(426, 36);
            this.txtNombreEmpresa.TabIndex = 6;
            this.txtNombreEmpresa.Text = "Nombre de empresa";
            this.txtNombreEmpresa.Enter += new System.EventHandler(this.txtNombreEmpresa_Enter);
            this.txtNombreEmpresa.Leave += new System.EventHandler(this.txtNombreEmpresa_Leave);
            // 
            // txtNombreTienda
            // 
            this.txtNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtNombreTienda.Location = new System.Drawing.Point(93, 200);
            this.txtNombreTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreTienda.Name = "txtNombreTienda";
            this.txtNombreTienda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreTienda.Size = new System.Drawing.Size(426, 30);
            this.txtNombreTienda.TabIndex = 2;
            this.txtNombreTienda.Text = "Nombre de la tienda";
            this.txtNombreTienda.Enter += new System.EventHandler(this.txtNombreTienda_Enter);
            this.txtNombreTienda.Leave += new System.EventHandler(this.txtNombreTienda_Leave);
            // 
            // lblTituloCrear
            // 
            this.lblTituloCrear.AutoSize = true;
            this.lblTituloCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrear.Location = new System.Drawing.Point(87, 25);
            this.lblTituloCrear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCrear.Name = "lblTituloCrear";
            this.lblTituloCrear.Size = new System.Drawing.Size(176, 29);
            this.lblTituloCrear.TabIndex = 14;
            this.lblTituloCrear.Text = "Nueva Tienda";
            // 
            // dtFechaIngresoTienda
            // 
            this.dtFechaIngresoTienda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaIngresoTienda.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtFechaIngresoTienda.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtFechaIngresoTienda.Enabled = false;
            this.dtFechaIngresoTienda.Location = new System.Drawing.Point(93, 146);
            this.dtFechaIngresoTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFechaIngresoTienda.Name = "dtFechaIngresoTienda";
            this.dtFechaIngresoTienda.Size = new System.Drawing.Size(426, 26);
            this.dtFechaIngresoTienda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 50);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ingrese los datos solicitados para agregar una \r\nnueva tienda al sistema:";
            // 
            // txtTelefonoTienda
            // 
            this.txtTelefonoTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoTienda.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefonoTienda.Location = new System.Drawing.Point(93, 377);
            this.txtTelefonoTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonoTienda.MaxLength = 9;
            this.txtTelefonoTienda.Name = "txtTelefonoTienda";
            this.txtTelefonoTienda.Size = new System.Drawing.Size(426, 30);
            this.txtTelefonoTienda.TabIndex = 5;
            this.txtTelefonoTienda.Text = "Teléfono ## ### ####";
            this.txtTelefonoTienda.Enter += new System.EventHandler(this.txtTelefonoTienda_Enter);
            this.txtTelefonoTienda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoTienda_KeyPress);
            this.txtTelefonoTienda.Leave += new System.EventHandler(this.txtTelefonoTienda_Leave);
            // 
            // CrearTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 618);
            this.Controls.Add(this.txtTelefonoTienda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaIngresoTienda);
            this.Controls.Add(this.btnCancelarTienda);
            this.Controls.Add(this.btnCrearTienda);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtDireccionTienda);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.txtNombreTienda);
            this.Controls.Add(this.lblTituloCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrearTienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tienda";
            this.Load += new System.EventHandler(this.CrearTienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarTienda;
        private System.Windows.Forms.Button btnCrearTienda;
        private System.Windows.Forms.Label lblTituloCrear;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbCiudad;
        public System.Windows.Forms.TextBox txtDireccionTienda;
        public System.Windows.Forms.TextBox txtNombreEmpresa;
        public System.Windows.Forms.TextBox txtNombreTienda;
        public System.Windows.Forms.DateTimePicker dtFechaIngresoTienda;
        public System.Windows.Forms.TextBox txtTelefonoTienda;
    }
}