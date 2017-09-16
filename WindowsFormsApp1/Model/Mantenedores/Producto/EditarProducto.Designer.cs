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
            this.lblTituloEditar = new System.Windows.Forms.Label();
            this.lblDescripcionCrear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloEditar
            // 
            this.lblTituloEditar.AutoSize = true;
            this.lblTituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditar.Location = new System.Drawing.Point(12, 9);
            this.lblTituloEditar.Name = "lblTituloEditar";
            this.lblTituloEditar.Size = new System.Drawing.Size(134, 20);
            this.lblTituloEditar.TabIndex = 1;
            this.lblTituloEditar.Text = "Editar Producto";
            // 
            // lblDescripcionCrear
            // 
            this.lblDescripcionCrear.AutoSize = true;
            this.lblDescripcionCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCrear.Location = new System.Drawing.Point(12, 39);
            this.lblDescripcionCrear.Name = "lblDescripcionCrear";
            this.lblDescripcionCrear.Size = new System.Drawing.Size(281, 32);
            this.lblDescripcionCrear.TabIndex = 2;
            this.lblDescripcionCrear.Text = "Ingrese los datos solicitados para agregar un \r\nnuevo producto al sistema:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.lblDescripcionCrear);
            this.Controls.Add(this.lblTituloEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEditar;
        private System.Windows.Forms.Label lblDescripcionCrear;
    }
}