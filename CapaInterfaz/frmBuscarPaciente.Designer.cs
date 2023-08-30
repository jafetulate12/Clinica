
namespace CapaInterfaz
{
    partial class frmBuscarPaciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdListaPacientes = new System.Windows.Forms.DataGridView();
            this.txtNombrePacienteB = new System.Windows.Forms.TextBox();
            this.Idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.grdListaPacientes);
            this.groupBox1.Controls.Add(this.txtNombrePacienteB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Pacientes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(576, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(187, 35);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(58, 220);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(187, 35);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(620, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(187, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdListaPacientes
            // 
            this.grdListaPacientes.AllowUserToAddRows = false;
            this.grdListaPacientes.AllowUserToDeleteRows = false;
            this.grdListaPacientes.AllowUserToResizeColumns = false;
            this.grdListaPacientes.AllowUserToResizeRows = false;
            this.grdListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idpaciente,
            this.CedulaPaciente,
            this.nombre,
            this.Telefono,
            this.Correo,
            this.Direccion});
            this.grdListaPacientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaPacientes.Location = new System.Drawing.Point(8, 75);
            this.grdListaPacientes.Name = "grdListaPacientes";
            this.grdListaPacientes.RowTemplate.Height = 25;
            this.grdListaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaPacientes.ShowCellErrors = false;
            this.grdListaPacientes.ShowCellToolTips = false;
            this.grdListaPacientes.ShowEditingIcon = false;
            this.grdListaPacientes.ShowRowErrors = false;
            this.grdListaPacientes.Size = new System.Drawing.Size(835, 142);
            this.grdListaPacientes.TabIndex = 2;
            this.grdListaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaPacientes_CellContentClick);
            // 
            // txtNombrePacienteB
            // 
            this.txtNombrePacienteB.Location = new System.Drawing.Point(422, 28);
            this.txtNombrePacienteB.Name = "txtNombrePacienteB";
            this.txtNombrePacienteB.Size = new System.Drawing.Size(168, 23);
            this.txtNombrePacienteB.TabIndex = 1;
            // 
            // Idpaciente
            // 
            this.Idpaciente.DataPropertyName = "ID_PACIENTE";
            this.Idpaciente.HeaderText = "Id Paciente";
            this.Idpaciente.Name = "Idpaciente";
            // 
            // CedulaPaciente
            // 
            this.CedulaPaciente.DataPropertyName = "CEDULA_PACIENTE";
            this.CedulaPaciente.HeaderText = "Cedula";
            this.CedulaPaciente.Name = "CedulaPaciente";
            this.CedulaPaciente.Width = 150;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NOMBRE_COMPLETO_PACIENTE";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TELEFONO_PACIENTE";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CORREO_PACIENTE";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 150;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "DIRECCION_PACIENTE";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 200;
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 292);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Paciente";
            this.Load += new System.EventHandler(this.frmBuscarPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdListaPacientes;
        private System.Windows.Forms.TextBox txtNombrePacienteB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idpaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}