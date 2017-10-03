namespace WindowsFormsApp1.Model.Mantenedores.Producto
{
    partial class PRUEBA
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
            this.cmbAlgo = new PresentationControls.CheckBoxComboBox();
            this.SuspendLayout();
            // 
            // cmbAlgo
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbAlgo.CheckBoxProperties = checkBoxProperties1;
            this.cmbAlgo.DisplayMemberSingleItem = "";
            this.cmbAlgo.FormattingEnabled = true;
            this.cmbAlgo.Location = new System.Drawing.Point(314, 120);
            this.cmbAlgo.Name = "cmbAlgo";
            this.cmbAlgo.Size = new System.Drawing.Size(121, 21);
            this.cmbAlgo.TabIndex = 0;
            // 
            // PRUEBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 494);
            this.Controls.Add(this.cmbAlgo);
            this.Name = "PRUEBA";
            this.Text = "PRUEBA";
            this.Load += new System.EventHandler(this.PRUEBA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PresentationControls.CheckBoxComboBox cmbAlgo;
    }
}