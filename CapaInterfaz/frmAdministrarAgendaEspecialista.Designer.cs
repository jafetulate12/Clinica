
namespace CapaInterfaz
{
    partial class frmAdministrarAgendaEspecialista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarAgendaEspecialista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.hora = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.grdListaAgendaEspe = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idepsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusEspecialidad = new System.Windows.Forms.Button();
            this.btnBusEspecialista = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEspecialista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCitas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idcita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaAgendaEspe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.hora);
            this.groupBox1.Controls.Add(this.dtpFechaCita);
            this.groupBox1.Controls.Add(this.grdListaAgendaEspe);
            this.groupBox1.Controls.Add(this.btnBusEspecialidad);
            this.groupBox1.Controls.Add(this.btnBusEspecialista);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpHoraFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpHoraInicio);
            this.groupBox1.Controls.Add(this.txtEspecialidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdEspecialista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIDCitas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agenda";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(468, 314);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 57);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(233, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 57);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(17, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 57);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(356, 116);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(61, 15);
            this.hora.TabIndex = 14;
            this.hora.Text = "Hora Final";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(356, 146);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(230, 23);
            this.dtpFechaCita.TabIndex = 13;
            // 
            // grdListaAgendaEspe
            // 
            this.grdListaAgendaEspe.AllowUserToAddRows = false;
            this.grdListaAgendaEspe.AllowUserToDeleteRows = false;
            this.grdListaAgendaEspe.AllowUserToResizeColumns = false;
            this.grdListaAgendaEspe.AllowUserToResizeRows = false;
            this.grdListaAgendaEspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaAgendaEspe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idEspe,
            this.Idepsc,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Fecha});
            this.grdListaAgendaEspe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaAgendaEspe.Location = new System.Drawing.Point(17, 175);
            this.grdListaAgendaEspe.Name = "grdListaAgendaEspe";
            this.grdListaAgendaEspe.RowTemplate.Height = 25;
            this.grdListaAgendaEspe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaAgendaEspe.Size = new System.Drawing.Size(641, 113);
            this.grdListaAgendaEspe.TabIndex = 12;
            this.grdListaAgendaEspe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaAgendaEspe_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID_CITAS";
            this.id.HeaderText = "ID Cita";
            this.id.Name = "id";
            // 
            // idEspe
            // 
            this.idEspe.DataPropertyName = "ID_ESPECIALISTA";
            this.idEspe.HeaderText = "ID Especialista";
            this.idEspe.Name = "idEspe";
            // 
            // Idepsc
            // 
            this.Idepsc.DataPropertyName = "ID_ESPECIALIDAD";
            this.Idepsc.HeaderText = "ID Especialidad";
            this.Idepsc.Name = "Idepsc";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HORA_INICIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hora Inicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HORA_FINAL";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora Fin";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FECHA_CITA";
            this.Fecha.HeaderText = "Fecha Cita";
            this.Fecha.Name = "Fecha";
            // 
            // btnBusEspecialidad
            // 
            this.btnBusEspecialidad.Location = new System.Drawing.Point(397, 72);
            this.btnBusEspecialidad.Name = "btnBusEspecialidad";
            this.btnBusEspecialidad.Size = new System.Drawing.Size(146, 28);
            this.btnBusEspecialidad.TabIndex = 11;
            this.btnBusEspecialidad.Text = "BUSCAR";
            this.btnBusEspecialidad.UseVisualStyleBackColor = true;
            this.btnBusEspecialidad.Click += new System.EventHandler(this.btnBusEspecialidad_Click);
            // 
            // btnBusEspecialista
            // 
            this.btnBusEspecialista.Location = new System.Drawing.Point(205, 72);
            this.btnBusEspecialista.Name = "btnBusEspecialista";
            this.btnBusEspecialista.Size = new System.Drawing.Size(146, 28);
            this.btnBusEspecialista.TabIndex = 10;
            this.btnBusEspecialista.Text = "BUSCAR";
            this.btnBusEspecialista.UseVisualStyleBackColor = true;
            this.btnBusEspecialista.Click += new System.EventHandler(this.btnBusEspecialista_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora Final";
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Enabled = false;
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(205, 146);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(108, 23);
            this.dtpHoraFinal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hora Inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(24, 146);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(117, 23);
            this.dtpHoraInicio.TabIndex = 6;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(397, 43);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(146, 23);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Especialidad";
            // 
            // txtIdEspecialista
            // 
            this.txtIdEspecialista.Location = new System.Drawing.Point(205, 43);
            this.txtIdEspecialista.Name = "txtIdEspecialista";
            this.txtIdEspecialista.ReadOnly = true;
            this.txtIdEspecialista.Size = new System.Drawing.Size(146, 23);
            this.txtIdEspecialista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Especialista";
            // 
            // txtIDCitas
            // 
            this.txtIDCitas.Location = new System.Drawing.Point(7, 43);
            this.txtIDCitas.Name = "txtIDCitas";
            this.txtIDCitas.ReadOnly = true;
            this.txtIDCitas.Size = new System.Drawing.Size(146, 23);
            this.txtIDCitas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Citas";
            // 
            // idcita
            // 
            this.idcita.DataPropertyName = "ID_CITAS";
            this.idcita.HeaderText = "ID Cita";
            this.idcita.Name = "idcita";
            // 
            // idespecialista
            // 
            this.idespecialista.DataPropertyName = "ID_ESPECIALISTA";
            this.idespecialista.HeaderText = "ID Especialista";
            this.idespecialista.Name = "idespecialista";
            // 
            // idespecialidad
            // 
            this.idespecialidad.DataPropertyName = "ID_ESPECIALIDAD";
            this.idespecialidad.HeaderText = "ID Especialidad";
            this.idespecialidad.Name = "idespecialidad";
            // 
            // HoraI
            // 
            this.HoraI.DataPropertyName = "HORA_INICIO";
            this.HoraI.HeaderText = "Hora Inicio";
            this.HoraI.Name = "HoraI";
            // 
            // Horaf
            // 
            this.Horaf.DataPropertyName = "HORA_FINAL";
            this.Horaf.HeaderText = "Hora Fin";
            this.Horaf.Name = "Horaf";
            // 
            // frmAdministrarAgendaEspecialista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 433);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrarAgendaEspecialista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Especialista";
            this.Load += new System.EventHandler(this.frmAdministrarAgendaEspecialista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaAgendaEspe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEspecialista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.DataGridView grdListaAgendaEspe;
        private System.Windows.Forms.Button btnBusEspecialidad;
        private System.Windows.Forms.Button btnBusEspecialista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idepsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcita;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horaf;
    }
}