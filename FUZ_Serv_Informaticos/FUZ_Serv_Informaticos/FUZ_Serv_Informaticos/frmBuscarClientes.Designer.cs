namespace FUZ_Serv_Informaticos
{
    partial class frmBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClientes));
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.panelBuscarApe = new System.Windows.Forms.Panel();
            this.lblDomicilioCliente = new System.Windows.Forms.Label();
            this.btnTodosLosClientes = new System.Windows.Forms.Button();
            this.btnLimpiarBusqueda = new System.Windows.Forms.Button();
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabDgvClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabDatosClientes = new System.Windows.Forms.TabPage();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtNroDni = new System.Windows.Forms.TextBox();
            this.txtTipoDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipoDni = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.panelBuscarTodCli = new System.Windows.Forms.Panel();
            this.panelLimpiarBusqueda = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.panelDecorativo = new System.Windows.Forms.Panel();
            this.panelBuscarApe.SuspendLayout();
            this.tabClientes.SuspendLayout();
            this.tabDgvClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabDatosClientes.SuspendLayout();
            this.panelBuscarTodCli.SuspendLayout();
            this.panelLimpiarBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBuscarCliente.Location = new System.Drawing.Point(36, 33);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(107, 20);
            this.txtBuscarCliente.TabIndex = 26;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // panelBuscarApe
            // 
            this.panelBuscarApe.AccessibleName = "";
            this.panelBuscarApe.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelBuscarApe.Controls.Add(this.txtBuscarCliente);
            this.panelBuscarApe.Controls.Add(this.lblDomicilioCliente);
            this.panelBuscarApe.Location = new System.Drawing.Point(71, 84);
            this.panelBuscarApe.Name = "panelBuscarApe";
            this.panelBuscarApe.Size = new System.Drawing.Size(176, 82);
            this.panelBuscarApe.TabIndex = 24;
            this.panelBuscarApe.Tag = "";
            // 
            // lblDomicilioCliente
            // 
            this.lblDomicilioCliente.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblDomicilioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioCliente.Image = global::FUZ_Serv_Informaticos.Properties.Resources.search__1_;
            this.lblDomicilioCliente.Location = new System.Drawing.Point(3, 33);
            this.lblDomicilioCliente.Name = "lblDomicilioCliente";
            this.lblDomicilioCliente.Size = new System.Drawing.Size(38, 28);
            this.lblDomicilioCliente.TabIndex = 0;
            this.lblDomicilioCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTodosLosClientes
            // 
            this.btnTodosLosClientes.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTodosLosClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosLosClientes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLosClientes.Location = new System.Drawing.Point(36, 21);
            this.btnTodosLosClientes.Name = "btnTodosLosClientes";
            this.btnTodosLosClientes.Size = new System.Drawing.Size(108, 43);
            this.btnTodosLosClientes.TabIndex = 3;
            this.btnTodosLosClientes.Text = "Listar Todos los Clientes";
            this.btnTodosLosClientes.UseVisualStyleBackColor = false;
            this.btnTodosLosClientes.Click += new System.EventHandler(this.btnTodosLosClientes_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(36, 20);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(108, 46);
            this.btnLimpiarBusqueda.TabIndex = 2;
            this.btnLimpiarBusqueda.Text = "Limpiar Busqueda";
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // tabClientes
            // 
            this.tabClientes.AccessibleName = "";
            this.tabClientes.Controls.Add(this.tabDgvClientes);
            this.tabClientes.Controls.Add(this.tabDatosClientes);
            this.tabClientes.Location = new System.Drawing.Point(284, 62);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(546, 387);
            this.tabClientes.TabIndex = 26;
            this.tabClientes.SelectedIndexChanged += new System.EventHandler(this.tabClientes_SelectedIndexChanged);
            // 
            // tabDgvClientes
            // 
            this.tabDgvClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabDgvClientes.Controls.Add(this.dgvClientes);
            this.tabDgvClientes.Location = new System.Drawing.Point(4, 22);
            this.tabDgvClientes.Name = "tabDgvClientes";
            this.tabDgvClientes.Padding = new System.Windows.Forms.Padding(2, 3, 3, 3);
            this.tabDgvClientes.Size = new System.Drawing.Size(538, 361);
            this.tabDgvClientes.TabIndex = 0;
            this.tabDgvClientes.Text = " Cliente(s)";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(-4, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(643, 361);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientes_CellMouseClick);
            // 
            // tabDatosClientes
            // 
            this.tabDatosClientes.BackColor = System.Drawing.SystemColors.Desktop;
            this.tabDatosClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabDatosClientes.Controls.Add(this.txtBarrio);
            this.tabDatosClientes.Controls.Add(this.txtNroDni);
            this.tabDatosClientes.Controls.Add(this.txtTipoDni);
            this.tabDatosClientes.Controls.Add(this.label1);
            this.tabDatosClientes.Controls.Add(this.lblBarrio);
            this.tabDatosClientes.Controls.Add(this.lblNroCliente);
            this.tabDatosClientes.Controls.Add(this.txtNombre);
            this.tabDatosClientes.Controls.Add(this.txtNroCliente);
            this.tabDatosClientes.Controls.Add(this.txtDomicilio);
            this.tabDatosClientes.Controls.Add(this.lblNombre);
            this.tabDatosClientes.Controls.Add(this.txtTelefono);
            this.tabDatosClientes.Controls.Add(this.lblTelefono);
            this.tabDatosClientes.Controls.Add(this.lblTipoDni);
            this.tabDatosClientes.Controls.Add(this.lblDomicilio);
            this.tabDatosClientes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDatosClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDatosClientes.Location = new System.Drawing.Point(4, 22);
            this.tabDatosClientes.Name = "tabDatosClientes";
            this.tabDatosClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosClientes.Size = new System.Drawing.Size(538, 361);
            this.tabDatosClientes.TabIndex = 1;
            this.tabDatosClientes.Text = "+ info";
//            this.tabDatosClientes.Click += new System.EventHandler(this.tabDatosClientes_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(196, 279);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.ReadOnly = true;
            this.txtBarrio.Size = new System.Drawing.Size(100, 21);
            this.txtBarrio.TabIndex = 32;
            // 
            // txtNroDni
            // 
            this.txtNroDni.Location = new System.Drawing.Point(292, 237);
            this.txtNroDni.Name = "txtNroDni";
            this.txtNroDni.ReadOnly = true;
            this.txtNroDni.Size = new System.Drawing.Size(100, 21);
            this.txtNroDni.TabIndex = 31;
            // 
            // txtTipoDni
            // 
            this.txtTipoDni.Location = new System.Drawing.Point(196, 237);
            this.txtTipoDni.Name = "txtTipoDni";
            this.txtTipoDni.ReadOnly = true;
            this.txtTipoDni.Size = new System.Drawing.Size(80, 21);
            this.txtTipoDni.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::FUZ_Serv_Informaticos.Properties.Resources.user;
            this.label1.Location = new System.Drawing.Point(541, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 29;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblBarrio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(109, 282);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(50, 15);
            this.lblBarrio.TabIndex = 27;
            this.lblBarrio.Text = "Barrio...";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblNroCliente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCliente.Location = new System.Drawing.Point(109, 64);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(79, 15);
            this.lblNroCliente.TabIndex = 12;
            this.lblNroCliente.Text = "Nro Cliente...";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(196, 21);
            this.txtNombre.TabIndex = 14;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(196, 61);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.ReadOnly = true;
            this.txtNroCliente.Size = new System.Drawing.Size(34, 21);
            this.txtNroCliente.TabIndex = 13;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(196, 149);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(196, 21);
            this.txtDomicilio.TabIndex = 15;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(109, 108);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Cliente...";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(196, 193);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(100, 21);
            this.txtTelefono.TabIndex = 16;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(109, 196);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 15);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono...";
            // 
            // lblTipoDni
            // 
            this.lblTipoDni.AutoSize = true;
            this.lblTipoDni.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTipoDni.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDni.Location = new System.Drawing.Point(109, 240);
            this.lblTipoDni.Name = "lblTipoDni";
            this.lblTipoDni.Size = new System.Drawing.Size(36, 15);
            this.lblTipoDni.TabIndex = 10;
            this.lblTipoDni.Text = "Dni...";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblDomicilio.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(109, 152);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(68, 15);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "Domicilio...";
            // 
            // panelBuscarTodCli
            // 
            this.panelBuscarTodCli.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelBuscarTodCli.Controls.Add(this.btnTodosLosClientes);
            this.panelBuscarTodCli.Location = new System.Drawing.Point(71, 223);
            this.panelBuscarTodCli.Name = "panelBuscarTodCli";
            this.panelBuscarTodCli.Size = new System.Drawing.Size(176, 82);
            this.panelBuscarTodCli.TabIndex = 27;
            // 
            // panelLimpiarBusqueda
            // 
            this.panelLimpiarBusqueda.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelLimpiarBusqueda.Controls.Add(this.btnLimpiarBusqueda);
            this.panelLimpiarBusqueda.Location = new System.Drawing.Point(71, 362);
            this.panelLimpiarBusqueda.Name = "panelLimpiarBusqueda";
            this.panelLimpiarBusqueda.Size = new System.Drawing.Size(176, 82);
            this.panelLimpiarBusqueda.TabIndex = 28;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::FUZ_Serv_Informaticos.Properties.Resources.exit__3_;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(854, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 30);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(901, 39);
            this.panelBusqueda.TabIndex = 30;
            // 
            // panelDecorativo
            // 
            this.panelDecorativo.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDecorativo.Location = new System.Drawing.Point(0, 38);
            this.panelDecorativo.Name = "panelDecorativo";
            this.panelDecorativo.Size = new System.Drawing.Size(39, 464);
            this.panelDecorativo.TabIndex = 31;
            // 
            // frmBuscarClientes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 501);
            this.Controls.Add(this.panelDecorativo);
            this.Controls.Add(this.panelBusqueda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panelLimpiarBusqueda);
            this.Controls.Add(this.panelBuscarTodCli);
            this.Controls.Add(this.panelBuscarApe);
            this.Controls.Add(this.tabClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmClientes_FormClosing);
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panelBuscarApe.ResumeLayout(false);
            this.panelBuscarApe.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            this.tabDgvClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabDatosClientes.ResumeLayout(false);
            this.tabDatosClientes.PerformLayout();
            this.panelBuscarTodCli.ResumeLayout(false);
            this.panelLimpiarBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipoDni;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDomicilioCliente;
        private System.Windows.Forms.Panel panelBuscarApe;
        private System.Windows.Forms.Button btnLimpiarBusqueda;
        private System.Windows.Forms.TabPage tabDatosClientes;
        private System.Windows.Forms.Button btnTodosLosClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Panel panelBuscarTodCli;
        private System.Windows.Forms.Panel panelLimpiarBusqueda;
        private System.Windows.Forms.TabPage tabDgvClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Panel panelDecorativo;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtNroDni;
        private System.Windows.Forms.TextBox txtTipoDni;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}