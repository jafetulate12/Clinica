
namespace CapaInterfaz
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIDFuncionario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grdListaFuncionario = new System.Windows.Forms.DataGridView();
            this.IdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPuestoFuncionario = new System.Windows.Forms.TextBox();
            this.txtCorreoFuncionario = new System.Windows.Forms.TextBox();
            this.txtTelefonoFuncionario = new System.Windows.Forms.TextBox();
            this.txtNombreFuncionario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDFuncionario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.grdListaFuncionario);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtPuestoFuncionario);
            this.groupBox1.Controls.Add(this.txtCorreoFuncionario);
            this.groupBox1.Controls.Add(this.txtTelefonoFuncionario);
            this.groupBox1.Controls.Add(this.txtNombreFuncionario);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(801, 498);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Funcionarios";
            // 
            // txtIDFuncionario
            // 
            this.txtIDFuncionario.Location = new System.Drawing.Point(141, 43);
            this.txtIDFuncionario.Name = "txtIDFuncionario";
            this.txtIDFuncionario.ReadOnly = true;
            this.txtIDFuncionario.Size = new System.Drawing.Size(196, 27);
            this.txtIDFuncionario.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Funcionario";
            // 
            // grdListaFuncionario
            // 
            this.grdListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFuncionario,
            this.PuestoFuncionario,
            this.NombreFuncionario,
            this.TelefonoFuncionario,
            this.CorreoFuncionario});
            this.grdListaFuncionario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaFuncionario.Location = new System.Drawing.Point(18, 217);
            this.grdListaFuncionario.Name = "grdListaFuncionario";
            this.grdListaFuncionario.RowTemplate.Height = 25;
            this.grdListaFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaFuncionario.ShowCellErrors = false;
            this.grdListaFuncionario.ShowCellToolTips = false;
            this.grdListaFuncionario.ShowEditingIcon = false;
            this.grdListaFuncionario.ShowRowErrors = false;
            this.grdListaFuncionario.Size = new System.Drawing.Size(749, 202);
            this.grdListaFuncionario.TabIndex = 22;
            this.grdListaFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaFuncionario_CellContentClick);
            // 
            // IdFuncionario
            // 
            this.IdFuncionario.DataPropertyName = "ID_FUNCIONARIO";
            this.IdFuncionario.HeaderText = "ID Funcionario";
            this.IdFuncionario.Name = "IdFuncionario";
            // 
            // PuestoFuncionario
            // 
            this.PuestoFuncionario.DataPropertyName = "PUESTO_FUNCIONARIO";
            this.PuestoFuncionario.HeaderText = "Puesto";
            this.PuestoFuncionario.Name = "PuestoFuncionario";
            this.PuestoFuncionario.Width = 150;
            // 
            // NombreFuncionario
            // 
            this.NombreFuncionario.DataPropertyName = "NOMBRE_COMPLETO_FUNCIONARIO";
            this.NombreFuncionario.HeaderText = "Nombre";
            this.NombreFuncionario.Name = "NombreFuncionario";
            this.NombreFuncionario.Width = 200;
            // 
            // TelefonoFuncionario
            // 
            this.TelefonoFuncionario.DataPropertyName = "TELEFONO_FUNCIONARIO";
            this.TelefonoFuncionario.HeaderText = "Telefono";
            this.TelefonoFuncionario.Name = "TelefonoFuncionario";
            this.TelefonoFuncionario.Width = 125;
            // 
            // CorreoFuncionario
            // 
            this.CorreoFuncionario.DataPropertyName = "CORREO_FUNCIONARIO";
            this.CorreoFuncionario.HeaderText = "Correo";
            this.CorreoFuncionario.Name = "CorreoFuncionario";
            this.CorreoFuncionario.Width = 150;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(647, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 68);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(484, 425);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 68);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "LImpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaInterfaz.Properties.Resources.icons8_eliminar_26;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(337, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 68);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CapaInterfaz.Properties.Resources.icons8_guardar_50;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(180, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 68);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::CapaInterfaz.Properties.Resources.icons8_agregar_carpeta_50;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(23, 425);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 68);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPuestoFuncionario
            // 
            this.txtPuestoFuncionario.Location = new System.Drawing.Point(492, 48);
            this.txtPuestoFuncionario.Name = "txtPuestoFuncionario";
            this.txtPuestoFuncionario.Size = new System.Drawing.Size(256, 27);
            this.txtPuestoFuncionario.TabIndex = 16;
            // 
            // txtCorreoFuncionario
            // 
            this.txtCorreoFuncionario.Location = new System.Drawing.Point(492, 166);
            this.txtCorreoFuncionario.Name = "txtCorreoFuncionario";
            this.txtCorreoFuncionario.Size = new System.Drawing.Size(248, 27);
            this.txtCorreoFuncionario.TabIndex = 14;
            // 
            // txtTelefonoFuncionario
            // 
            this.txtTelefonoFuncionario.Location = new System.Drawing.Point(492, 110);
            this.txtTelefonoFuncionario.Name = "txtTelefonoFuncionario";
            this.txtTelefonoFuncionario.Size = new System.Drawing.Size(256, 27);
            this.txtTelefonoFuncionario.TabIndex = 13;
            // 
            // txtNombreFuncionario
            // 
            this.txtNombreFuncionario.Location = new System.Drawing.Point(23, 131);
            this.txtNombreFuncionario.Multiline = true;
            this.txtNombreFuncionario.Name = "txtNombreFuncionario";
            this.txtNombreFuncionario.Size = new System.Drawing.Size(244, 80);
            this.txtNombreFuncionario.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Correo Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono Funcionario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo Funcionario";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 532);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Funcionarios";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdListaFuncionario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPuestoFuncionario;
        private System.Windows.Forms.TextBox txtCorreoFuncionario;
        private System.Windows.Forms.TextBox txtTelefonoFuncionario;
        private System.Windows.Forms.TextBox txtNombreFuncionario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoFuncionario;
    }
}