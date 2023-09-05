namespace FUZ_Serv_Informaticos
{
    partial class frmBuscarPresupuesto
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
            this.panelDeco1 = new System.Windows.Forms.Panel();
            this.txtNroPresup = new System.Windows.Forms.TextBox();
            this.lblNroPresup = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.datatimepHasta = new System.Windows.Forms.DateTimePicker();
            this.datatimepDesde = new System.Windows.Forms.DateTimePicker();
            this.panelDeco2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditarPresup = new System.Windows.Forms.Button();
            this.btnAbrirPresup = new System.Windows.Forms.Button();
            this.dgbBuscarPresupuesto = new System.Windows.Forms.DataGridView();
            this.nroPresup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Presup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeYnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panelDeco1.SuspendLayout();
            this.panelDeco2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBuscarPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDeco1
            // 
            this.panelDeco1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDeco1.Controls.Add(this.txtNroPresup);
            this.panelDeco1.Controls.Add(this.lblNroPresup);
            this.panelDeco1.Controls.Add(this.btnBuscar);
            this.panelDeco1.Controls.Add(this.txtApellido);
            this.panelDeco1.Controls.Add(this.lblApellido);
            this.panelDeco1.Controls.Add(this.lblHasta);
            this.panelDeco1.Controls.Add(this.lblDesde);
            this.panelDeco1.Controls.Add(this.datatimepHasta);
            this.panelDeco1.Controls.Add(this.datatimepDesde);
            this.panelDeco1.Location = new System.Drawing.Point(1, 1);
            this.panelDeco1.Name = "panelDeco1";
            this.panelDeco1.Size = new System.Drawing.Size(798, 137);
            this.panelDeco1.TabIndex = 0;
            // 
            // txtNroPresup
            // 
            this.txtNroPresup.Location = new System.Drawing.Point(456, 80);
            this.txtNroPresup.Name = "txtNroPresup";
            this.txtNroPresup.Size = new System.Drawing.Size(48, 20);
            this.txtNroPresup.TabIndex = 8;
            // 
            // lblNroPresup
            // 
            this.lblNroPresup.AutoSize = true;
            this.lblNroPresup.Location = new System.Drawing.Point(360, 87);
            this.lblNroPresup.Name = "lblNroPresup";
            this.lblNroPresup.Size = new System.Drawing.Size(90, 13);
            this.lblNroPresup.TabIndex = 7;
            this.lblNroPresup.Text = "Presupuesto Nº...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscar.Location = new System.Drawing.Point(646, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 34);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Presupuesto";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(419, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(360, 40);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(53, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido...";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(43, 87);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta...";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(43, 40);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(47, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde...";
            // 
            // datatimepHasta
            // 
            this.datatimepHasta.Location = new System.Drawing.Point(96, 81);
            this.datatimepHasta.Name = "datatimepHasta";
            this.datatimepHasta.Size = new System.Drawing.Size(200, 20);
            this.datatimepHasta.TabIndex = 1;
            // 
            // datatimepDesde
            // 
            this.datatimepDesde.Location = new System.Drawing.Point(96, 34);
            this.datatimepDesde.Name = "datatimepDesde";
            this.datatimepDesde.Size = new System.Drawing.Size(200, 20);
            this.datatimepDesde.TabIndex = 0;
            this.datatimepDesde.Value = new System.DateTime(2023, 8, 29, 2, 35, 0, 0);
            // 
            // panelDeco2
            // 
            this.panelDeco2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelDeco2.Controls.Add(this.btnEliminar);
            this.panelDeco2.Controls.Add(this.btnSalir);
            this.panelDeco2.Controls.Add(this.btnEditarPresup);
            this.panelDeco2.Controls.Add(this.btnAbrirPresup);
            this.panelDeco2.Location = new System.Drawing.Point(1, 344);
            this.panelDeco2.Name = "panelDeco2";
            this.panelDeco2.Size = new System.Drawing.Size(798, 106);
            this.panelDeco2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 42);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditarPresup
            // 
            this.btnEditarPresup.Location = new System.Drawing.Point(258, 42);
            this.btnEditarPresup.Name = "btnEditarPresup";
            this.btnEditarPresup.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPresup.TabIndex = 1;
            this.btnEditarPresup.Text = "Editar";
            this.btnEditarPresup.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPresup
            // 
            this.btnAbrirPresup.Location = new System.Drawing.Point(56, 42);
            this.btnAbrirPresup.Name = "btnAbrirPresup";
            this.btnAbrirPresup.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirPresup.TabIndex = 0;
            this.btnAbrirPresup.Text = "Abrir";
            this.btnAbrirPresup.UseVisualStyleBackColor = true;
            // 
            // dgbBuscarPresupuesto
            // 
            this.dgbBuscarPresupuesto.AllowUserToAddRows = false;
            this.dgbBuscarPresupuesto.AllowUserToDeleteRows = false;
            this.dgbBuscarPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBuscarPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroPresup,
            this.Fecha_Presup,
            this.ApeYnom});
            this.dgbBuscarPresupuesto.Location = new System.Drawing.Point(1, 137);
            this.dgbBuscarPresupuesto.Name = "dgbBuscarPresupuesto";
            this.dgbBuscarPresupuesto.ReadOnly = true;
            this.dgbBuscarPresupuesto.Size = new System.Drawing.Size(798, 210);
            this.dgbBuscarPresupuesto.TabIndex = 2;
            // 
            // nroPresup
            // 
            this.nroPresup.HeaderText = "Nº Presupuesto";
            this.nroPresup.Name = "nroPresup";
            this.nroPresup.ReadOnly = true;
            this.nroPresup.Width = 200;
            // 
            // Fecha_Presup
            // 
            this.Fecha_Presup.HeaderText = "Fecha";
            this.Fecha_Presup.Name = "Fecha_Presup";
            this.Fecha_Presup.ReadOnly = true;
            this.Fecha_Presup.Width = 200;
            // 
            // ApeYnom
            // 
            this.ApeYnom.HeaderText = "Cliente";
            this.ApeYnom.Name = "ApeYnom";
            this.ApeYnom.ReadOnly = true;
            this.ApeYnom.Width = 355;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(460, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmBuscarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbBuscarPresupuesto);
            this.Controls.Add(this.panelDeco2);
            this.Controls.Add(this.panelDeco1);
            this.Name = "frmBuscarPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Presupuesto";
            this.panelDeco1.ResumeLayout(false);
            this.panelDeco1.PerformLayout();
            this.panelDeco2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbBuscarPresupuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeco1;
        private System.Windows.Forms.Panel panelDeco2;
        private System.Windows.Forms.DataGridView dgbBuscarPresupuesto;
        private System.Windows.Forms.TextBox txtNroPresup;
        private System.Windows.Forms.Label lblNroPresup;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker datatimepHasta;
        private System.Windows.Forms.DateTimePicker datatimepDesde;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditarPresup;
        private System.Windows.Forms.Button btnAbrirPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPresup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Presup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeYnom;
        private System.Windows.Forms.Button btnEliminar;
    }
}