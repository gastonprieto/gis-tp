namespace GIS
{
    partial class SelectAddress
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
            this.lstAddress = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAddress
            // 
            this.lstAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAddress.FormattingEnabled = true;
            this.lstAddress.Location = new System.Drawing.Point(0, 0);
            this.lstAddress.Name = "lstAddress";
            this.lstAddress.Size = new System.Drawing.Size(395, 262);
            this.lstAddress.TabIndex = 0;
            this.lstAddress.DoubleClick += new System.EventHandler(this.lstAddress_DoubleClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAceptar.Location = new System.Drawing.Point(0, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(395, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // SelectAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstAddress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Dirección";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAddress;
        private System.Windows.Forms.Button btnAceptar;
    }
}