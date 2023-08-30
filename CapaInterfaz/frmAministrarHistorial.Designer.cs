
namespace CapaInterfaz
{
    partial class frmAministrarHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAministrarHistorial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusIdDiag = new System.Windows.Forms.Button();
            this.btnBusIdMed = new System.Windows.Forms.Button();
            this.btnBusIdPac = new System.Windows.Forms.Button();
            this.txtIdDiagnostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMedicamento = new System.Windows.Forms.TextBox();
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.idhistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdHistorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusIdDiag);
            this.groupBox1.Controls.Add(this.btnBusIdMed);
            this.groupBox1.Controls.Add(this.btnBusIdPac);
            this.groupBox1.Controls.Add(this.txtIdDiagnostico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIdMedicamento);
            this.groupBox1.Controls.Add(this.grdListaEspecialista);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdPaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdHistorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(676, 320);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Historial";
            // 
            // btnBusIdDiag
            // 
            this.btnBusIdDiag.Location = new System.Drawing.Point(422, 83);
            this.btnBusIdDiag.Name = "btnBusIdDiag";
            this.btnBusIdDiag.Size = new System.Drawing.Size(94, 36);
            this.btnBusIdDiag.TabIndex = 37;
            this.btnBusIdDiag.Text = "buscar";
            this.btnBusIdDiag.UseVisualStyleBackColor = true;
            this.btnBusIdDiag.Click += new System.EventHandler(this.btnBusIdDiag_Click);
            // 
            // btnBusIdMed
            // 
            this.btnBusIdMed.Location = new System.Drawing.Point(290, 83);
            this.btnBusIdMed.Name = "btnBusIdMed";
            this.btnBusIdMed.Size = new System.Drawing.Size(94, 36);
            this.btnBusIdMed.TabIndex = 36;
            this.btnBusIdMed.Text = "buscar";
            this.btnBusIdMed.UseVisualStyleBackColor = true;
            this.btnBusIdMed.Click += new System.EventHandler(this.btnBusIdMed_Click);
            // 
            // btnBusIdPac
            // 
            this.btnBusIdPac.Location = new System.Drawing.Point(146, 83);
            this.btnBusIdPac.Name = "btnBusIdPac";
            this.btnBusIdPac.Size = new System.Drawing.Size(94, 36);
            this.btnBusIdPac.TabIndex = 35;
            this.btnBusIdPac.Text = "buscar";
            this.btnBusIdPac.UseVisualStyleBackColor = true;
            this.btnBusIdPac.Click += new System.EventHandler(this.btnBusIdPac_Click);
            // 
            // txtIdDiagnostico
            // 
            this.txtIdDiagnostico.Location = new System.Drawing.Point(422, 48);
            this.txtIdDiagnostico.Name = "txtIdDiagnostico";
            this.txtIdDiagnostico.ReadOnly = true;
            this.txtIdDiagnostico.Size = new System.Drawing.Size(92, 23);
            this.txtIdDiagnostico.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID Diagnostico";
            // 
            // txtIdMedicamento
            // 
            this.txtIdMedicamento.Location = new System.Drawing.Point(292, 48);
            this.txtIdMedicamento.Name = "txtIdMedicamento";
            this.txtIdMedicamento.ReadOnly = true;
            this.txtIdMedicamento.Size = new System.Drawing.Size(92, 23);
            this.txtIdMedicamento.TabIndex = 29;
            // 
            // grdListaEspecialista
            // 
            this.grdListaEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhistorial,
            this.idpaciente,
            this.idmedicamento,
            this.iddiagnostico});
            this.grdListaEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialista.Location = new System.Drawing.Point(12, 147);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.ReadOnly = true;
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.ShowCellErrors = false;
            this.grdListaEspecialista.ShowCellToolTips = false;
            this.grdListaEspecialista.ShowEditingIcon = false;
            this.grdListaEspecialista.ShowRowErrors = false;
            this.grdListaEspecialista.Size = new System.Drawing.Size(642, 166);
            this.grdListaEspecialista.TabIndex = 22;
            this.grdListaEspecialista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaEspecialista_CellContentClick);
            // 
            // idhistorial
            // 
            this.idhistorial.DataPropertyName = "ID_HISTORIAL_CLINICO";
            this.idhistorial.HeaderText = "ID Historial";
            this.idhistorial.Name = "idhistorial";
            this.idhistorial.ReadOnly = true;
            this.idhistorial.Width = 150;
            // 
            // idpaciente
            // 
            this.idpaciente.DataPropertyName = "ID_PACIENTE";
            this.idpaciente.HeaderText = "ID Paciente";
            this.idpaciente.Name = "idpaciente";
            this.idpaciente.ReadOnly = true;
            this.idpaciente.Width = 150;
            // 
            // idmedicamento
            // 
            this.idmedicamento.DataPropertyName = "ID_MEDICAMENTO";
            this.idmedicamento.HeaderText = "ID Medicamento";
            this.idmedicamento.Name = "idmedicamento";
            this.idmedicamento.ReadOnly = true;
            this.idmedicamento.Width = 150;
            // 
            // iddiagnostico
            // 
            this.iddiagnostico.DataPropertyName = "ID_DIAGNOSTICO";
            this.iddiagnostico.HeaderText = "ID Diagnostico";
            this.iddiagnostico.Name = "iddiagnostico";
            this.iddiagnostico.ReadOnly = true;
            this.iddiagnostico.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID Medicamento";
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(146, 48);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.ReadOnly = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(92, 23);
            this.txtIdPaciente.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "ID Paciente";
            // 
            // txtIdHistorial
            // 
            this.txtIdHistorial.Location = new System.Drawing.Point(13, 48);
            this.txtIdHistorial.Name = "txtIdHistorial";
            this.txtIdHistorial.ReadOnly = true;
            this.txtIdHistorial.Size = new System.Drawing.Size(92, 23);
            this.txtIdHistorial.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Historial Clinico";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(578, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 66);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(390, 342);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 68);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "LImpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaInterfaz.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(220, 341);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 68);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaInterfaz.Properties.Resources.icons8_guardar_50;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(17, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 68);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAministrarHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 415);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAministrarHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial Clinico";
            this.Load += new System.EventHandler(this.frmAministrarHistorial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdHistorial;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMedicamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Button btnBusIdDiag;
        private System.Windows.Forms.Button btnBusIdMed;
        private System.Windows.Forms.Button btnBusIdPac;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiagnostico;
    }
}