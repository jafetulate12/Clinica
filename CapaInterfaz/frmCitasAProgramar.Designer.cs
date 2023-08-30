
namespace CapaInterfaz
{
    partial class frmCitasAProgramar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdCitasProgram = new System.Windows.Forms.DataGridView();
            this.idcitapro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDfuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpaceinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCitaProgramada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCitasProgram)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.grdCitasProgram);
            this.groupBox1.Controls.Add(this.btnPaciente);
            this.groupBox1.Controls.Add(this.btnCitas);
            this.groupBox1.Controls.Add(this.btnFuncionario);
            this.groupBox1.Controls.Add(this.txtIdPaciente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdCita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdFuncionario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCitaProgramada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(642, 301);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 44);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(476, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 44);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(476, 135);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 44);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdCitasProgram
            // 
            this.grdCitasProgram.AllowUserToAddRows = false;
            this.grdCitasProgram.AllowUserToDeleteRows = false;
            this.grdCitasProgram.AllowUserToResizeColumns = false;
            this.grdCitasProgram.AllowUserToResizeRows = false;
            this.grdCitasProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCitasProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcitapro,
            this.IDfuncionario,
            this.idcita,
            this.idpaceinte});
            this.grdCitasProgram.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCitasProgram.Location = new System.Drawing.Point(14, 119);
            this.grdCitasProgram.Name = "grdCitasProgram";
            this.grdCitasProgram.RowTemplate.Height = 25;
            this.grdCitasProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCitasProgram.Size = new System.Drawing.Size(443, 197);
            this.grdCitasProgram.TabIndex = 11;
            this.grdCitasProgram.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCitasProgram_CellContentClick);
            // 
            // idcitapro
            // 
            this.idcitapro.DataPropertyName = "ID_CITA_PROGRAMADA";
            this.idcitapro.HeaderText = "ID Cita Programada";
            this.idcitapro.Name = "idcitapro";
            // 
            // IDfuncionario
            // 
            this.IDfuncionario.DataPropertyName = "ID_FUNCIONARIO";
            this.IDfuncionario.HeaderText = "ID Funcionario";
            this.IDfuncionario.Name = "IDfuncionario";
            // 
            // idcita
            // 
            this.idcita.DataPropertyName = "ID_CITAS";
            this.idcita.HeaderText = "ID Citas";
            this.idcita.Name = "idcita";
            // 
            // idpaceinte
            // 
            this.idpaceinte.DataPropertyName = "ID_PACIENTE";
            this.idpaceinte.HeaderText = "ID Paciente";
            this.idpaceinte.Name = "idpaceinte";
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(617, 82);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(150, 35);
            this.btnPaciente.TabIndex = 10;
            this.btnPaciente.Text = "Buscar";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.Location = new System.Drawing.Point(421, 82);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(150, 35);
            this.btnCitas.TabIndex = 9;
            this.btnCitas.Text = "Buscar";
            this.btnCitas.UseVisualStyleBackColor = true;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(219, 82);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(150, 35);
            this.btnFuncionario.TabIndex = 8;
            this.btnFuncionario.Text = "Buscar";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // txtIdPaciente
            // 
            this.txtIdPaciente.Location = new System.Drawing.Point(617, 53);
            this.txtIdPaciente.Name = "txtIdPaciente";
            this.txtIdPaciente.ReadOnly = true;
            this.txtIdPaciente.Size = new System.Drawing.Size(150, 23);
            this.txtIdPaciente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Paciente";
            // 
            // txtIdCita
            // 
            this.txtIdCita.Location = new System.Drawing.Point(421, 53);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.ReadOnly = true;
            this.txtIdCita.Size = new System.Drawing.Size(150, 23);
            this.txtIdCita.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Cita Disponible";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(219, 53);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.ReadOnly = true;
            this.txtIdFuncionario.Size = new System.Drawing.Size(150, 23);
            this.txtIdFuncionario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Funcionario";
            // 
            // txtCitaProgramada
            // 
            this.txtCitaProgramada.Location = new System.Drawing.Point(18, 53);
            this.txtCitaProgramada.Name = "txtCitaProgramada";
            this.txtCitaProgramada.ReadOnly = true;
            this.txtCitaProgramada.Size = new System.Drawing.Size(150, 23);
            this.txtCitaProgramada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cita Programda";
            // 
            // frmCitasAProgramar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCitasAProgramar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Para Programar";
            this.Load += new System.EventHandler(this.frmCitasAProgramar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCitasProgram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCitaProgramada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdCitasProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitapro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcita;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpaceinte;
    }
}