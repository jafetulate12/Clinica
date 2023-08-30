
namespace CapaInterfaz
{
    partial class frmBuscarEspecialidad
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
            this.grdListaEspecialidad = new System.Windows.Forms.DataGridView();
            this.Idespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombreespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdListaEspecialidad);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 374);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar Formulario";
            // 
            // grdListaEspecialidad
            // 
            this.grdListaEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idespecialista,
            this.Nombreespecialista,
            this.descripcion});
            this.grdListaEspecialidad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialidad.Location = new System.Drawing.Point(0, 113);
            this.grdListaEspecialidad.Name = "grdListaEspecialidad";
            this.grdListaEspecialidad.RowTemplate.Height = 25;
            this.grdListaEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialidad.ShowCellErrors = false;
            this.grdListaEspecialidad.ShowCellToolTips = false;
            this.grdListaEspecialidad.ShowEditingIcon = false;
            this.grdListaEspecialidad.ShowRowErrors = false;
            this.grdListaEspecialidad.Size = new System.Drawing.Size(782, 204);
            this.grdListaEspecialidad.TabIndex = 23;
            this.grdListaEspecialidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaEspecialidad_CellContentClick);
            // 
            // Idespecialista
            // 
            this.Idespecialista.DataPropertyName = "ID_ESPECIALIDAD";
            this.Idespecialista.HeaderText = "ID Especialidad";
            this.Idespecialista.Name = "Idespecialista";
            // 
            // Nombreespecialista
            // 
            this.Nombreespecialista.DataPropertyName = "NOMBRE_ESPECIALIDAD";
            this.Nombreespecialista.HeaderText = "Nombre ";
            this.Nombreespecialista.Name = "Nombreespecialista";
            this.Nombreespecialista.Width = 250;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "DESCRIPCION_ESPECIALIDAD";
            this.descripcion.HeaderText = "Descripcion ";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 390;
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
            // frmBuscarEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Especialidad";
            this.Load += new System.EventHandler(this.frmBuscarEspecialidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdListaEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombreespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}