namespace FUZ_Serv_Informaticos
{
    partial class frmTecnica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNroPresupuesto = new System.Windows.Forms.Label();
            this.lblProxNro = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblCancelacion = new System.Windows.Forms.Label();
            this.hScrollBarCancelacion = new System.Windows.Forms.HScrollBar();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.id_DetalleEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo_a_Reparar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo_Equipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle_equipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Costo_Tecnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garantia_Equipo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estado_equi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Repuesto_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Respuesto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Precio_Repuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar_Equipo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelDecorativo1 = new System.Windows.Forms.Panel();
            this.panelDecorativo2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNroSerie = new System.Windows.Forms.TextBox();
            this.cmbBuscarEquipo = new System.Windows.Forms.ComboBox();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.lblBuscarEquipo = new System.Windows.Forms.Label();
            this.panelDecorativo3 = new System.Windows.Forms.Panel();
            this.lblprecioSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtFallas = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRegistrarPresupuesto = new System.Windows.Forms.Button();
            this.txtTotPresup = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            this.panelDecorativo1.SuspendLayout();
            this.panelDecorativo2.SuspendLayout();
            this.panelDecorativo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroPresupuesto
            // 
            this.lblNroPresupuesto.AutoSize = true;
            this.lblNroPresupuesto.Location = new System.Drawing.Point(934, 78);
            this.lblNroPresupuesto.Name = "lblNroPresupuesto";
            this.lblNroPresupuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNroPresupuesto.Size = new System.Drawing.Size(103, 15);
            this.lblNroPresupuesto.TabIndex = 0;
            this.lblNroPresupuesto.Text = "Presupuesto Nro...";
            // 
            // lblProxNro
            // 
            this.lblProxNro.AutoSize = true;
            this.lblProxNro.Location = new System.Drawing.Point(1043, 78);
            this.lblProxNro.Name = "lblProxNro";
            this.lblProxNro.Size = new System.Drawing.Size(0, 15);
            this.lblProxNro.TabIndex = 1;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(28, 23);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 15);
            this.lblDescuento.TabIndex = 3;
            this.lblDescuento.Text = "Descuento %";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescuento.Location = new System.Drawing.Point(110, 20);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(50, 21);
            this.txtDescuento.TabIndex = 4;
            this.txtDescuento.Text = "0";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Location = new System.Drawing.Point(28, 107);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(116, 15);
            this.lblPresupuesto.TabIndex = 5;
            this.lblPresupuesto.Text = "Total Presupuesto   $";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(279, 23);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(78, 15);
            this.lblFormaPago.TabIndex = 9;
            this.lblFormaPago.Text = "Forma Pago...";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Location = new System.Drawing.Point(363, 18);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(118, 23);
            this.cmbFormaPago.TabIndex = 10;
            // 
            // lblCancelacion
            // 
            this.lblCancelacion.AutoSize = true;
            this.lblCancelacion.Location = new System.Drawing.Point(215, 107);
            this.lblCancelacion.Name = "lblCancelacion";
            this.lblCancelacion.Size = new System.Drawing.Size(142, 15);
            this.lblCancelacion.TabIndex = 11;
            this.lblCancelacion.Text = "$$$ REALIZAR PAGO $$$";
            // 
            // hScrollBarCancelacion
            // 
            this.hScrollBarCancelacion.Location = new System.Drawing.Point(363, 105);
            this.hScrollBarCancelacion.Name = "hScrollBarCancelacion";
            this.hScrollBarCancelacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBarCancelacion.Size = new System.Drawing.Size(118, 17);
            this.hScrollBarCancelacion.TabIndex = 12;
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToOrderColumns = true;
            this.dgvPresupuesto.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_DetalleEquipo,
            this.Equipo_a_Reparar,
            this.Modelo_Equipos,
            this.Detalle_equipo,
            this.Costo_Tecnica,
            this.Garantia_Equipo,
            this.estado_equi,
            this.Repuesto_Equipo,
            this.Cantidad_Respuesto,
            this.Precio_Repuesto,
            this.Quitar_Equipo});
            this.dgvPresupuesto.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPresupuesto.Location = new System.Drawing.Point(-7, 226);
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuesto.Size = new System.Drawing.Size(1199, 192);
            this.dgvPresupuesto.TabIndex = 13;
            this.dgvPresupuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuesto_CellContentClick);
            // 
            // id_DetalleEquipo
            // 
            this.id_DetalleEquipo.HeaderText = "id_detEquipo";
            this.id_DetalleEquipo.Name = "id_DetalleEquipo";
            this.id_DetalleEquipo.Visible = false;
            // 
            // Equipo_a_Reparar
            // 
            this.Equipo_a_Reparar.HeaderText = "Equipo";
            this.Equipo_a_Reparar.Name = "Equipo_a_Reparar";
            this.Equipo_a_Reparar.ReadOnly = true;
            this.Equipo_a_Reparar.Width = 170;
            // 
            // Modelo_Equipos
            // 
            this.Modelo_Equipos.HeaderText = "Modelo / Nro serie";
            this.Modelo_Equipos.Name = "Modelo_Equipos";
            this.Modelo_Equipos.ReadOnly = true;
            this.Modelo_Equipos.Width = 200;
            // 
            // Detalle_equipo
            // 
            this.Detalle_equipo.DropDownWidth = 5;
            this.Detalle_equipo.HeaderText = "Detalles";
            this.Detalle_equipo.Name = "Detalle_equipo";
            this.Detalle_equipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Detalle_equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Detalle_equipo.Width = 150;
            // 
            // Costo_Tecnica
            // 
            this.Costo_Tecnica.HeaderText = "Costo Reparacion";
            this.Costo_Tecnica.Name = "Costo_Tecnica";
            this.Costo_Tecnica.ReadOnly = true;
            this.Costo_Tecnica.Width = 90;
            // 
            // Garantia_Equipo
            // 
            this.Garantia_Equipo.HeaderText = "Garantia";
            this.Garantia_Equipo.Name = "Garantia_Equipo";
            this.Garantia_Equipo.Width = 65;
            // 
            // estado_equi
            // 
            this.estado_equi.HeaderText = "Estado Equipo";
            this.estado_equi.Name = "estado_equi";
            this.estado_equi.Width = 140;
            // 
            // Repuesto_Equipo
            // 
            this.Repuesto_Equipo.HeaderText = "Repuesto";
            this.Repuesto_Equipo.Name = "Repuesto_Equipo";
            this.Repuesto_Equipo.ReadOnly = true;
            // 
            // Cantidad_Respuesto
            // 
            this.Cantidad_Respuesto.HeaderText = "Cantidad Repuesto(s)";
            this.Cantidad_Respuesto.Name = "Cantidad_Respuesto";
            this.Cantidad_Respuesto.Width = 70;
            // 
            // Precio_Repuesto
            // 
            this.Precio_Repuesto.HeaderText = "Precio Repuesto x unidad";
            this.Precio_Repuesto.Name = "Precio_Repuesto";
            this.Precio_Repuesto.ReadOnly = true;
            this.Precio_Repuesto.ToolTipText = " ";
            this.Precio_Repuesto.Width = 90;
            // 
            // Quitar_Equipo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            this.Quitar_Equipo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Quitar_Equipo.HeaderText = "Eliminar Equipo";
            this.Quitar_Equipo.Name = "Quitar_Equipo";
            this.Quitar_Equipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quitar_Equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Quitar_Equipo.Text = "Quitar";
            this.Quitar_Equipo.UseColumnTextForButtonValue = true;
            this.Quitar_Equipo.Width = 75;
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRepuestos.Location = new System.Drawing.Point(737, 4);
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRepuestos.Size = new System.Drawing.Size(139, 29);
            this.btnRepuestos.TabIndex = 15;
            this.btnRepuestos.Text = "Agregar Repuestos ...";
            this.btnRepuestos.UseVisualStyleBackColor = false;
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(18, 8);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscarCliente.Size = new System.Drawing.Size(165, 23);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.Text = "Click para buscar Cliente...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 15);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Text = "Cliente...";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(71, 78);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(0, 15);
            this.lblNomCliente.TabIndex = 20;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1097, 618);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 22;
            this.btncerrar.Text = "Salir";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelDecorativo1
            // 
            this.panelDecorativo1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDecorativo1.Controls.Add(this.txtfecha);
            this.panelDecorativo1.Controls.Add(this.btnBuscarCliente);
            this.panelDecorativo1.Location = new System.Drawing.Point(-7, 3);
            this.panelDecorativo1.Name = "panelDecorativo1";
            this.panelDecorativo1.Size = new System.Drawing.Size(1192, 37);
            this.panelDecorativo1.TabIndex = 23;
            // 
            // panelDecorativo2
            // 
            this.panelDecorativo2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDecorativo2.Controls.Add(this.btnRegistrar);
            this.panelDecorativo2.Controls.Add(this.txtNroSerie);
            this.panelDecorativo2.Controls.Add(this.cmbBuscarEquipo);
            this.panelDecorativo2.Controls.Add(this.lblNroSerie);
            this.panelDecorativo2.Controls.Add(this.lblBuscarEquipo);
            this.panelDecorativo2.Controls.Add(this.btnRepuestos);
            this.panelDecorativo2.Location = new System.Drawing.Point(2, 184);
            this.panelDecorativo2.Name = "panelDecorativo2";
            this.panelDecorativo2.Size = new System.Drawing.Size(1183, 36);
            this.panelDecorativo2.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.Location = new System.Drawing.Point(1014, 6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 23);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "...Click para Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNroSerie
            // 
            this.txtNroSerie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNroSerie.Location = new System.Drawing.Point(405, 6);
            this.txtNroSerie.Name = "txtNroSerie";
            this.txtNroSerie.Size = new System.Drawing.Size(141, 21);
            this.txtNroSerie.TabIndex = 1;
            // 
            // cmbBuscarEquipo
            // 
            this.cmbBuscarEquipo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbBuscarEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarEquipo.FormattingEnabled = true;
            this.cmbBuscarEquipo.Location = new System.Drawing.Point(115, 6);
            this.cmbBuscarEquipo.Name = "cmbBuscarEquipo";
            this.cmbBuscarEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbBuscarEquipo.Size = new System.Drawing.Size(143, 23);
            this.cmbBuscarEquipo.TabIndex = 26;
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Location = new System.Drawing.Point(289, 9);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(116, 15);
            this.lblNroSerie.TabIndex = 0;
            this.lblNroSerie.Text = "Modelo / Nro Serie...";
            // 
            // lblBuscarEquipo
            // 
            this.lblBuscarEquipo.AutoSize = true;
            this.lblBuscarEquipo.Location = new System.Drawing.Point(10, 9);
            this.lblBuscarEquipo.Name = "lblBuscarEquipo";
            this.lblBuscarEquipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBuscarEquipo.Size = new System.Drawing.Size(102, 15);
            this.lblBuscarEquipo.TabIndex = 27;
            this.lblBuscarEquipo.Text = "Equipo a reparar...";
            // 
            // panelDecorativo3
            // 
            this.panelDecorativo3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDecorativo3.Controls.Add(this.txtTotPresup);
            this.panelDecorativo3.Controls.Add(this.lblprecioSubTotal);
            this.panelDecorativo3.Controls.Add(this.lblSubTotal);
            this.panelDecorativo3.Controls.Add(this.lblDescuento);
            this.panelDecorativo3.Controls.Add(this.txtDescuento);
            this.panelDecorativo3.Controls.Add(this.lblFormaPago);
            this.panelDecorativo3.Controls.Add(this.cmbFormaPago);
            this.panelDecorativo3.Controls.Add(this.lblCancelacion);
            this.panelDecorativo3.Controls.Add(this.hScrollBarCancelacion);
            this.panelDecorativo3.Controls.Add(this.lblPresupuesto);
            this.panelDecorativo3.Location = new System.Drawing.Point(666, 450);
            this.panelDecorativo3.Name = "panelDecorativo3";
            this.panelDecorativo3.Size = new System.Drawing.Size(506, 136);
            this.panelDecorativo3.TabIndex = 25;
            // 
            // lblprecioSubTotal
            // 
            this.lblprecioSubTotal.AutoSize = true;
            this.lblprecioSubTotal.Location = new System.Drawing.Point(110, 74);
            this.lblprecioSubTotal.Name = "lblprecioSubTotal";
            this.lblprecioSubTotal.Size = new System.Drawing.Size(13, 15);
            this.lblprecioSubTotal.TabIndex = 14;
            this.lblprecioSubTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(28, 74);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(76, 15);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "SubTotal     $";
            // 
            // txtFallas
            // 
            this.txtFallas.Location = new System.Drawing.Point(15, 450);
            this.txtFallas.Multiline = true;
            this.txtFallas.Name = "txtFallas";
            this.txtFallas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFallas.Size = new System.Drawing.Size(601, 136);
            this.txtFallas.TabIndex = 26;
            this.txtFallas.Text = "Fallas y reparaciones...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRegistrarPresupuesto
            // 
            this.btnRegistrarPresupuesto.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnRegistrarPresupuesto.Location = new System.Drawing.Point(666, 610);
            this.btnRegistrarPresupuesto.Name = "btnRegistrarPresupuesto";
            this.btnRegistrarPresupuesto.Size = new System.Drawing.Size(371, 39);
            this.btnRegistrarPresupuesto.TabIndex = 27;
            this.btnRegistrarPresupuesto.Text = "ACEPTAR PRESUPUESTO";
            this.btnRegistrarPresupuesto.UseVisualStyleBackColor = false;
            this.btnRegistrarPresupuesto.Click += new System.EventHandler(this.btnRegistrarPresupuesto_Click);
            // 
            // txtTotPresup
            // 
            this.txtTotPresup.Location = new System.Drawing.Point(143, 104);
            this.txtTotPresup.Name = "txtTotPresup";
            this.txtTotPresup.ReadOnly = true;
            this.txtTotPresup.Size = new System.Drawing.Size(49, 21);
            this.txtTotPresup.TabIndex = 15;
            this.txtTotPresup.Text = "0";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(1053, 10);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(61, 21);
            this.txtfecha.TabIndex = 19;
            // 
            // frmTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnRegistrarPresupuesto);
            this.Controls.Add(this.txtFallas);
            this.Controls.Add(this.lblProxNro);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.lblNroPresupuesto);
            this.Controls.Add(this.panelDecorativo3);
            this.Controls.Add(this.panelDecorativo2);
            this.Controls.Add(this.panelDecorativo1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dgvPresupuesto);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "frmTecnica";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio Tecnico";
            this.Load += new System.EventHandler(this.frmTecnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.panelDecorativo1.ResumeLayout(false);
            this.panelDecorativo1.PerformLayout();
            this.panelDecorativo2.ResumeLayout(false);
            this.panelDecorativo2.PerformLayout();
            this.panelDecorativo3.ResumeLayout(false);
            this.panelDecorativo3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroPresupuesto;
        private System.Windows.Forms.Label lblProxNro;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lblCancelacion;
        private System.Windows.Forms.HScrollBar hScrollBarCancelacion;
        private System.Windows.Forms.Button btnRepuestos;
        private System.Windows.Forms.Label lblCliente;
        public System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Panel panelDecorativo1;
        private System.Windows.Forms.Panel panelDecorativo2;
        private System.Windows.Forms.Panel panelDecorativo3;
        private System.Windows.Forms.ComboBox cmbBuscarEquipo;
        private System.Windows.Forms.Label lblBuscarEquipo;
        private System.Windows.Forms.TextBox txtNroSerie;
        private System.Windows.Forms.Label lblNroSerie;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtFallas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblprecioSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_DetalleEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo_a_Reparar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo_Equipos;
        private System.Windows.Forms.DataGridViewComboBoxColumn Detalle_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Tecnica;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Garantia_Equipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn estado_equi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repuesto_Equipo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Cantidad_Respuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Repuesto;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar_Equipo;
        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Button btnRegistrarPresupuesto;
        private System.Windows.Forms.TextBox txtTotPresup;
        private System.Windows.Forms.TextBox txtfecha;
    }
}