
namespace CapaInterfaz
{
    partial class frmAdmistrarMedicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmistrarMedicamentos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIndicacionesUso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMedicamento = new System.Windows.Forms.TextBox();
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.Idmedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombremedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.txtDescripcionMedicamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.txtIndicacionesUso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdMedicamento);
            this.groupBox1.Controls.Add(this.grdListaEspecialista);
            this.groupBox1.Controls.Add(this.txtNombreMedicamento);
            this.groupBox1.Controls.Add(this.txtDescripcionMedicamento);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(801, 389);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Medicamentos";
            // 
            // txtIndicacionesUso
            // 
            this.txtIndicacionesUso.Location = new System.Drawing.Point(509, 30);
            this.txtIndicacionesUso.Multiline = true;
            this.txtIndicacionesUso.Name = "txtIndicacionesUso";
            this.txtIndicacionesUso.Size = new System.Drawing.Size(244, 80);
            this.txtIndicacionesUso.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Indicaciones de Uso";
            // 
            // txtIdMedicamento
            // 
            this.txtIdMedicamento.Location = new System.Drawing.Point(123, 51);
            this.txtIdMedicamento.Name = "txtIdMedicamento";
            this.txtIdMedicamento.ReadOnly = true;
            this.txtIdMedicamento.Size = new System.Drawing.Size(187, 23);
            this.txtIdMedicamento.TabIndex = 25;
            // 
            // grdListaEspecialista
            // 
            this.grdListaEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idmedicamento,
            this.Nombremedicamento,
            this.descripcion,
            this.indicaciones});
            this.grdListaEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialista.Location = new System.Drawing.Point(12, 217);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.ReadOnly = true;
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.ShowCellErrors = false;
            this.grdListaEspecialista.ShowCellToolTips = false;
            this.grdListaEspecialista.ShowEditingIcon = false;
            this.grdListaEspecialista.ShowRowErrors = false;
            this.grdListaEspecialista.Size = new System.Drawing.Size(782, 166);
            this.grdListaEspecialista.TabIndex = 22;
            this.grdListaEspecialista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaEspecialista_CellContentClick);
            // 
            // Idmedicamento
            // 
            this.Idmedicamento.DataPropertyName = "ID_MEDICAMENTO";
            this.Idmedicamento.HeaderText = "ID Medicamento";
            this.Idmedicamento.Name = "Idmedicamento";
            this.Idmedicamento.ReadOnly = true;
            // 
            // Nombremedicamento
            // 
            this.Nombremedicamento.DataPropertyName = "NOMBRE_MEDICAMENTO";
            this.Nombremedicamento.HeaderText = "Nombre ";
            this.Nombremedicamento.Name = "Nombremedicamento";
            this.Nombremedicamento.ReadOnly = true;
            this.Nombremedicamento.Width = 190;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "DESCRIPCION";
            this.descripcion.HeaderText = "Descripcion ";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 250;
            // 
            // indicaciones
            // 
            this.indicaciones.DataPropertyName = "INDICACIONES_USO";
            this.indicaciones.HeaderText = "Indicaciones";
            this.indicaciones.Name = "indicaciones";
            this.indicaciones.ReadOnly = true;
            this.indicaciones.Width = 200;
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(44, 122);
            this.txtNombreMedicamento.Multiline = true;
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(256, 80);
            this.txtNombreMedicamento.TabIndex = 16;
            // 
            // txtDescripcionMedicamento
            // 
            this.txtDescripcionMedicamento.Location = new System.Drawing.Point(509, 131);
            this.txtDescripcionMedicamento.Multiline = true;
            this.txtDescripcionMedicamento.Name = "txtDescripcionMedicamento";
            this.txtDescripcionMedicamento.Size = new System.Drawing.Size(244, 80);
            this.txtDescripcionMedicamento.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nombre Medicamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion Medicamento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(445, 425);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 66);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(660, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 68);
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
            this.btnLimpiar.Location = new System.Drawing.Point(293, 425);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 68);
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
            this.btnEliminar.Location = new System.Drawing.Point(163, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 68);
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
            this.btnGuardar.Location = new System.Drawing.Point(21, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 68);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAdmistrarMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmistrarMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Medicamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdMedicamento;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtDescripcionMedicamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIndicacionesUso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idmedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombremedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicaciones;
    }
}