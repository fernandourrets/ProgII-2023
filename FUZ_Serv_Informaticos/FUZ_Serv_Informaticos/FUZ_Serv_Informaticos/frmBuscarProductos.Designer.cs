namespace FUZ_Serv_Informaticos
{
    partial class frmBuscarProductos
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
            this.panelDecorativo1 = new System.Windows.Forms.Panel();
            this.panelDeco2 = new System.Windows.Forms.Panel();
            this.panelPrecio = new System.Windows.Forms.Panel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.panelDecorativo1.SuspendLayout();
            this.panelDeco2.SuspendLayout();
            this.panelPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDecorativo1
            // 
            this.panelDecorativo1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDecorativo1.Controls.Add(this.panelDeco2);
            this.panelDecorativo1.Location = new System.Drawing.Point(26, 39);
            this.panelDecorativo1.Name = "panelDecorativo1";
            this.panelDecorativo1.Size = new System.Drawing.Size(750, 256);
            this.panelDecorativo1.TabIndex = 0;
            // 
            // panelDeco2
            // 
            this.panelDeco2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDeco2.Controls.Add(this.lblPrecio);
            this.panelDeco2.Controls.Add(this.panelPrecio);
            this.panelDeco2.Controls.Add(this.lblProductos);
            this.panelDeco2.Controls.Add(this.cmbProductos);
            this.panelDeco2.Controls.Add(this.lblModelo);
            this.panelDeco2.Controls.Add(this.cmbModelo);
            this.panelDeco2.Location = new System.Drawing.Point(38, 38);
            this.panelDeco2.Name = "panelDeco2";
            this.panelDeco2.Size = new System.Drawing.Size(676, 179);
            this.panelDeco2.TabIndex = 6;
            // 
            // panelPrecio
            // 
            this.panelPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelPrecio.Controls.Add(this.lblCost);
            this.panelPrecio.Location = new System.Drawing.Point(515, 70);
            this.panelPrecio.Name = "panelPrecio";
            this.panelPrecio.Size = new System.Drawing.Size(83, 21);
            this.panelPrecio.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(463, 73);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio...";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(3, 3);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(16, 13);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "$ ";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(41, 73);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(59, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Producto...";
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(106, 70);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(113, 21);
            this.cmbProductos.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(267, 73);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(51, 13);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo...";
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(324, 70);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(113, 21);
            this.cmbModelo.TabIndex = 3;
            // 
            // frmBuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.panelDecorativo1);
            this.MaximizeBox = false;
            this.Name = "frmBuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR PRODUCTOS";
            this.panelDecorativo1.ResumeLayout(false);
            this.panelDeco2.ResumeLayout(false);
            this.panelDeco2.PerformLayout();
            this.panelPrecio.ResumeLayout(false);
            this.panelPrecio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDecorativo1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Panel panelDeco2;
        private System.Windows.Forms.Panel panelPrecio;
    }
}