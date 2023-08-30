
namespace CapaInterfaz
{
    partial class frmAdministrarEspecialistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarEspecialistas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdEspecialista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grdListaEspecialista = new System.Windows.Forms.DataGridView();
            this.Idespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombreespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrreoEspecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionespecialista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionEspecialista = new System.Windows.Forms.TextBox();
            this.txtCorreoEspecialista = new System.Windows.Forms.TextBox();
            this.txtTelefonoEspecialista = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdEspecialista);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.grdListaEspecialista);
            this.groupBox1.Controls.Add(this.txtDireccionEspecialista);
            this.groupBox1.Controls.Add(this.txtCorreoEspecialista);
            this.groupBox1.Controls.Add(this.txtTelefonoEspecialista);
            this.groupBox1.Controls.Add(this.txtNombreEspecialista);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(801, 397);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Funcionarios";
            // 
            // txtIdEspecialista
            // 
            this.txtIdEspecialista.Location = new System.Drawing.Point(103, 52);
            this.txtIdEspecialista.Name = "txtIdEspecialista";
            this.txtIdEspecialista.Size = new System.Drawing.Size(187, 23);
            this.txtIdEspecialista.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Especialista";
            // 
            // grdListaEspecialista
            // 
            this.grdListaEspecialista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaEspecialista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idespecialista,
            this.Nombreespecialista,
            this.telefonoEspecialista,
            this.corrreoEspecialista,
            this.direccionespecialista});
            this.grdListaEspecialista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaEspecialista.Location = new System.Drawing.Point(12, 217);
            this.grdListaEspecialista.Name = "grdListaEspecialista";
            this.grdListaEspecialista.RowTemplate.Height = 25;
            this.grdListaEspecialista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaEspecialista.ShowCellErrors = false;
            this.grdListaEspecialista.ShowCellToolTips = false;
            this.grdListaEspecialista.ShowEditingIcon = false;
            this.grdListaEspecialista.ShowRowErrors = false;
            this.grdListaEspecialista.Size = new System.Drawing.Size(742, 166);
            this.grdListaEspecialista.TabIndex = 22;
            this.grdListaEspecialista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaEspecialista_CellContentClick);
            // 
            // Idespecialista
            // 
            this.Idespecialista.DataPropertyName = "ID_ESPECIALISTA";
            this.Idespecialista.HeaderText = "ID Especialista";
            this.Idespecialista.Name = "Idespecialista";
            // 
            // Nombreespecialista
            // 
            this.Nombreespecialista.DataPropertyName = "NOMBRE_COMPLETO_ESPECIALISTA";
            this.Nombreespecialista.HeaderText = "Nombre";
            this.Nombreespecialista.Name = "Nombreespecialista";
            this.Nombreespecialista.Width = 200;
            // 
            // telefonoEspecialista
            // 
            this.telefonoEspecialista.DataPropertyName = "TELEFONO_ESPECIALISTA";
            this.telefonoEspecialista.HeaderText = "Telefono ";
            this.telefonoEspecialista.Name = "telefonoEspecialista";
            this.telefonoEspecialista.Width = 150;
            // 
            // corrreoEspecialista
            // 
            this.corrreoEspecialista.DataPropertyName = "CORREO_ESPECIALISTA";
            this.corrreoEspecialista.HeaderText = "Correo";
            this.corrreoEspecialista.Name = "corrreoEspecialista";
            this.corrreoEspecialista.Width = 125;
            // 
            // direccionespecialista
            // 
            this.direccionespecialista.DataPropertyName = "DIRECCION_ESPECIALISTA";
            this.direccionespecialista.HeaderText = "Direccion";
            this.direccionespecialista.Name = "direccionespecialista";
            this.direccionespecialista.Width = 150;
            // 
            // txtDireccionEspecialista
            // 
            this.txtDireccionEspecialista.Location = new System.Drawing.Point(511, 47);
            this.txtDireccionEspecialista.Multiline = true;
            this.txtDireccionEspecialista.Name = "txtDireccionEspecialista";
            this.txtDireccionEspecialista.Size = new System.Drawing.Size(256, 59);
            this.txtDireccionEspecialista.TabIndex = 16;
            // 
            // txtCorreoEspecialista
            // 
            this.txtCorreoEspecialista.Location = new System.Drawing.Point(506, 188);
            this.txtCorreoEspecialista.Name = "txtCorreoEspecialista";
            this.txtCorreoEspecialista.Size = new System.Drawing.Size(248, 23);
            this.txtCorreoEspecialista.TabIndex = 14;
            // 
            // txtTelefonoEspecialista
            // 
            this.txtTelefonoEspecialista.Location = new System.Drawing.Point(506, 131);
            this.txtTelefonoEspecialista.Name = "txtTelefonoEspecialista";
            this.txtTelefonoEspecialista.Size = new System.Drawing.Size(256, 23);
            this.txtTelefonoEspecialista.TabIndex = 13;
            // 
            // txtNombreEspecialista
            // 
            this.txtNombreEspecialista.Location = new System.Drawing.Point(12, 131);
            this.txtNombreEspecialista.Multiline = true;
            this.txtNombreEspecialista.Name = "txtNombreEspecialista";
            this.txtNombreEspecialista.Size = new System.Drawing.Size(244, 80);
            this.txtNombreEspecialista.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Direccion ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Correo Especialista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono Especialista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Especialista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo Especialista";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(647, 404);
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
            this.btnLimpiar.Location = new System.Drawing.Point(484, 404);
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
            this.btnEliminar.Location = new System.Drawing.Point(345, 404);
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
            this.btnGuardar.Location = new System.Drawing.Point(183, 404);
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
            this.btnBuscar.Location = new System.Drawing.Point(12, 404);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 68);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAdministrarEspecialistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrarEspecialistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Especialistas";
            this.Load += new System.EventHandler(this.frmAdministrarEspecialistas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaEspecialista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdListaEspecialista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDireccionEspecialista;
        private System.Windows.Forms.TextBox txtCorreoEspecialista;
        private System.Windows.Forms.TextBox txtTelefonoEspecialista;
        private System.Windows.Forms.TextBox txtNombreEspecialista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombreespecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrreoEspecialista;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionespecialista;
        private System.Windows.Forms.TextBox txtIdEspecialista;
    }
}