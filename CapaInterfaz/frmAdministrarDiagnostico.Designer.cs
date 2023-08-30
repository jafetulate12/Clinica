
namespace CapaInterfaz
{
    partial class frmAdministrarDiagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarDiagnostico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaDiagnostico = new System.Windows.Forms.DateTimePicker();
            this.txtIdDisgnostico = new System.Windows.Forms.TextBox();
            this.grdListaDiagnostico = new System.Windows.Forms.DataGridView();
            this.Idespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombreespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdEspecialista = new System.Windows.Forms.TextBox();
            this.txtResultadoDisgnostico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarDIAG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaDiagnostico);
            this.groupBox1.Controls.Add(this.txtIdDisgnostico);
            this.groupBox1.Controls.Add(this.grdListaDiagnostico);
            this.groupBox1.Controls.Add(this.txtIdEspecialista);
            this.groupBox1.Controls.Add(this.txtResultadoDisgnostico);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(640, 407);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Diagnostico";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(298, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 23);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha de Realizacion";
            // 
            // dtpFechaDiagnostico
            // 
            this.dtpFechaDiagnostico.Location = new System.Drawing.Point(33, 125);
            this.dtpFechaDiagnostico.Name = "dtpFechaDiagnostico";
            this.dtpFechaDiagnostico.Size = new System.Drawing.Size(310, 23);
            this.dtpFechaDiagnostico.TabIndex = 26;
            // 
            // txtIdDisgnostico
            // 
            this.txtIdDisgnostico.Location = new System.Drawing.Point(105, 23);
            this.txtIdDisgnostico.Name = "txtIdDisgnostico";
            this.txtIdDisgnostico.ReadOnly = true;
            this.txtIdDisgnostico.Size = new System.Drawing.Size(187, 23);
            this.txtIdDisgnostico.TabIndex = 25;
            // 
            // grdListaDiagnostico
            // 
            this.grdListaDiagnostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDiagnostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idespecialista,
            this.IdEspecialidad,
            this.Nombreespecialista,
            this.resultado});
            this.grdListaDiagnostico.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaDiagnostico.Location = new System.Drawing.Point(12, 217);
            this.grdListaDiagnostico.Name = "grdListaDiagnostico";
            this.grdListaDiagnostico.ReadOnly = true;
            this.grdListaDiagnostico.RowTemplate.Height = 25;
            this.grdListaDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaDiagnostico.ShowCellErrors = false;
            this.grdListaDiagnostico.ShowCellToolTips = false;
            this.grdListaDiagnostico.ShowEditingIcon = false;
            this.grdListaDiagnostico.ShowRowErrors = false;
            this.grdListaDiagnostico.Size = new System.Drawing.Size(621, 166);
            this.grdListaDiagnostico.TabIndex = 22;
            // 
            // Idespecialista
            // 
            this.Idespecialista.DataPropertyName = "ID_DIAGNOSTICO";
            this.Idespecialista.HeaderText = "ID Diagnostico";
            this.Idespecialista.Name = "Idespecialista";
            this.Idespecialista.ReadOnly = true;
            // 
            // IdEspecialidad
            // 
            this.IdEspecialidad.DataPropertyName = "ID_ESPECIALISTA";
            this.IdEspecialidad.HeaderText = "ID Especialista";
            this.IdEspecialidad.Name = "IdEspecialidad";
            this.IdEspecialidad.ReadOnly = true;
            // 
            // Nombreespecialista
            // 
            this.Nombreespecialista.DataPropertyName = "FECHA_DIAGNOSTICO";
            this.Nombreespecialista.HeaderText = "Fecha ";
            this.Nombreespecialista.Name = "Nombreespecialista";
            this.Nombreespecialista.ReadOnly = true;
            this.Nombreespecialista.Width = 125;
            // 
            // resultado
            // 
            this.resultado.DataPropertyName = "RESULTADOS_DIAGNOSTICO";
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Width = 390;
            // 
            // txtIdEspecialista
            // 
            this.txtIdEspecialista.Location = new System.Drawing.Point(105, 56);
            this.txtIdEspecialista.Name = "txtIdEspecialista";
            this.txtIdEspecialista.ReadOnly = true;
            this.txtIdEspecialista.Size = new System.Drawing.Size(187, 23);
            this.txtIdEspecialista.TabIndex = 16;
            // 
            // txtResultadoDisgnostico
            // 
            this.txtResultadoDisgnostico.Location = new System.Drawing.Point(349, 125);
            this.txtResultadoDisgnostico.Multiline = true;
            this.txtResultadoDisgnostico.Name = "txtResultadoDisgnostico";
            this.txtResultadoDisgnostico.Size = new System.Drawing.Size(244, 80);
            this.txtResultadoDisgnostico.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID Especialista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultados de diagnostico";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(578, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 68);
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
            this.btnLimpiar.Location = new System.Drawing.Point(459, 427);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 68);
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
            this.btnEliminar.Location = new System.Drawing.Point(171, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 68);
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
            this.btnGuardar.Location = new System.Drawing.Point(14, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 68);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarDIAG
            // 
            this.btnBuscarDIAG.Location = new System.Drawing.Point(320, 428);
            this.btnBuscarDIAG.Name = "btnBuscarDIAG";
            this.btnBuscarDIAG.Size = new System.Drawing.Size(93, 67);
            this.btnBuscarDIAG.TabIndex = 40;
            this.btnBuscarDIAG.Text = "Buscar";
            this.btnBuscarDIAG.UseVisualStyleBackColor = true;
            this.btnBuscarDIAG.Click += new System.EventHandler(this.btnBuscarDIAG_Click);
            // 
            // frmAdministrarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(692, 507);
            this.Controls.Add(this.btnBuscarDIAG);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Diagnostico";
            this.Load += new System.EventHandler(this.frmAdministrarDiagnostico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDiagnostico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdDisgnostico;
        private System.Windows.Forms.DataGridView grdListaDiagnostico;
        private System.Windows.Forms.TextBox txtIdEspecialista;
        private System.Windows.Forms.TextBox txtResultadoDisgnostico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaDiagnostico;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscarDIAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombreespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
    }
}