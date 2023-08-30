
namespace CapaInterfaz
{
    partial class frmAdministrarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDFactura = new System.Windows.Forms.TextBox();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIdFuncionario = new System.Windows.Forms.Button();
            this.btnIdPaciente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdPagos = new System.Windows.Forms.DataGridView();
            this.idfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Factura";
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.Location = new System.Drawing.Point(95, 38);
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.ReadOnly = true;
            this.txtIDFactura.Size = new System.Drawing.Size(57, 23);
            this.txtIDFactura.TabIndex = 1;
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(15, 107);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.ReadOnly = true;
            this.txtIdFuncionario.Size = new System.Drawing.Size(123, 23);
            this.txtIdFuncionario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Funcionario";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(15, 184);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(123, 23);
            this.txtPaciente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Paciente";
            // 
            // btnIdFuncionario
            // 
            this.btnIdFuncionario.Location = new System.Drawing.Point(144, 107);
            this.btnIdFuncionario.Name = "btnIdFuncionario";
            this.btnIdFuncionario.Size = new System.Drawing.Size(77, 23);
            this.btnIdFuncionario.TabIndex = 7;
            this.btnIdFuncionario.Text = "Buscar";
            this.btnIdFuncionario.UseVisualStyleBackColor = true;
            this.btnIdFuncionario.Click += new System.EventHandler(this.btnIdFuncionario_Click);
            // 
            // btnIdPaciente
            // 
            this.btnIdPaciente.Location = new System.Drawing.Point(144, 183);
            this.btnIdPaciente.Name = "btnIdPaciente";
            this.btnIdPaciente.Size = new System.Drawing.Size(77, 23);
            this.btnIdPaciente.TabIndex = 8;
            this.btnIdPaciente.Text = "Buscar";
            this.btnIdPaciente.UseVisualStyleBackColor = true;
            this.btnIdPaciente.Click += new System.EventHandler(this.btnIdPaciente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPagos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaPago);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMontoPago);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtIDFactura);
            this.groupBox1.Controls.Add(this.btnIdPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIdFuncionario);
            this.groupBox1.Controls.Add(this.txtIdFuncionario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPaciente);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 426);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pagos";
            // 
            // grdPagos
            // 
            this.grdPagos.AllowUserToAddRows = false;
            this.grdPagos.AllowUserToDeleteRows = false;
            this.grdPagos.AllowUserToResizeColumns = false;
            this.grdPagos.AllowUserToResizeRows = false;
            this.grdPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfactura,
            this.Funcionarios,
            this.Monto,
            this.Fecha,
            this.Tipo,
            this.idpaciente});
            this.grdPagos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdPagos.Location = new System.Drawing.Point(227, 156);
            this.grdPagos.Name = "grdPagos";
            this.grdPagos.RowTemplate.Height = 25;
            this.grdPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPagos.Size = new System.Drawing.Size(565, 157);
            this.grdPagos.TabIndex = 33;
            this.grdPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPagos_CellContentClick);
            // 
            // idfactura
            // 
            this.idfactura.DataPropertyName = "ID_FACTURA";
            this.idfactura.HeaderText = "ID Factura";
            this.idfactura.Name = "idfactura";
            this.idfactura.Width = 75;
            // 
            // Funcionarios
            // 
            this.Funcionarios.DataPropertyName = "ID_FUNCIONARIO";
            this.Funcionarios.HeaderText = "ID Funcionario";
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Width = 75;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "MONTO_PAGO";
            this.Monto.HeaderText = "Monto Pago";
            this.Monto.Name = "Monto";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FECHA_PAGO";
            this.Fecha.HeaderText = "Fecha Pago";
            this.Fecha.Name = "Fecha";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "TIPO_PAGO";
            this.Tipo.HeaderText = "Tipo Pago";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idpaciente
            // 
            this.idpaciente.DataPropertyName = "ID_PACIENTE";
            this.idpaciente.HeaderText = "ID Paciente";
            this.idpaciente.Name = "idpaciente";
            this.idpaciente.Width = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo De Pago";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.cboTipo.Location = new System.Drawing.Point(409, 123);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(151, 23);
            this.cboTipo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha De Pago";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(501, 56);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(233, 23);
            this.dtpFechaPago.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Monto De Pago";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(321, 56);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(149, 23);
            this.txtMontoPago.TabIndex = 28;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(321, 338);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 68);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "LImpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaInterfaz.Properties.Resources.icons8_guardar_50;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(15, 338);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 68);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(627, 338);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 68);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAdministrarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrarPagos";
            this.Text = "Administrar Pagos";
            this.Load += new System.EventHandler(this.frmAdministrarPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIdFuncionario;
        private System.Windows.Forms.Button btnIdPaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}