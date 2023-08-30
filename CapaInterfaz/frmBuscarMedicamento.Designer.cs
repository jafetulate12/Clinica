
namespace CapaInterfaz
{
    partial class frmBuscarMedicamento
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
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.Idmedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombremedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListaEspecialista);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 374);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar Medicamento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(581, 332);
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
            this.btnAceptar.Location = new System.Drawing.Point(427, 332);
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
            // grdListaEspecialista
            // 
            this.grdListaEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idmedicamento,
            this.Nombremedicamento,
            this.descripcion,
            this.indicaciones});
            this.grdListaEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialista.Location = new System.Drawing.Point(3, 104);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.ReadOnly = true;
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.ShowCellErrors = false;
            this.grdListaEspecialista.ShowCellToolTips = false;
            this.grdListaEspecialista.ShowEditingIcon = false;
            this.grdListaEspecialista.ShowRowErrors = false;
            this.grdListaEspecialista.Size = new System.Drawing.Size(782, 166);
            this.grdListaEspecialista.TabIndex = 23;
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
            // frmBuscarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscarMedicamento";
            this.Text = "Buscar Medicamento";
            this.Load += new System.EventHandler(this.frmBuscarMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idmedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombremedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicaciones;
    }
}