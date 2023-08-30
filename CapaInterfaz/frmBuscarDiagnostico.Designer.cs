
namespace CapaInterfaz
{
    partial class frmBuscarDiagnostico
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdListaDiagnostico = new System.Windows.Forms.DataGridView();
            this.Idespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombreespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDiagnostico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListaDiagnostico);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 393);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar Diagnostico";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(560, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(449, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 31);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(560, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 24);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(434, 23);
            this.txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
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
            this.grdListaDiagnostico.Location = new System.Drawing.Point(63, 113);
            this.grdListaDiagnostico.Name = "grdListaDiagnostico";
            this.grdListaDiagnostico.ReadOnly = true;
            this.grdListaDiagnostico.RowTemplate.Height = 25;
            this.grdListaDiagnostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaDiagnostico.ShowCellErrors = false;
            this.grdListaDiagnostico.ShowCellToolTips = false;
            this.grdListaDiagnostico.ShowEditingIcon = false;
            this.grdListaDiagnostico.ShowRowErrors = false;
            this.grdListaDiagnostico.Size = new System.Drawing.Size(621, 166);
            this.grdListaDiagnostico.TabIndex = 23;
            this.grdListaDiagnostico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaDiagnostico_CellContentClick);
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
            this.IdEspecialidad.HeaderText = "ID Especialidad";
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
            // frmBuscarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarDiagnostico";
            this.Text = "Buscar Diagnostico";
            this.Load += new System.EventHandler(this.frmBuscarDiagnostico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDiagnostico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdListaDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombreespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
    }
}