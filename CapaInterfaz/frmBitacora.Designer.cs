
namespace CapaInterfaz
{
    partial class frmBitacora
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdBitacora = new System.Windows.Forms.DataGridView();
            this.idBitacora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimineto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::CapaInterfaz.Properties.Resources.icons8_maletín_médico_941;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(521, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(228, 72);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdBitacora);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(22, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora";
            // 
            // grdBitacora
            // 
            this.grdBitacora.AllowUserToAddRows = false;
            this.grdBitacora.AllowUserToDeleteRows = false;
            this.grdBitacora.AllowUserToResizeColumns = false;
            this.grdBitacora.AllowUserToResizeRows = false;
            this.grdBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBitacora,
            this.fecha,
            this.Hora,
            this.Movimineto});
            this.grdBitacora.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdBitacora.Location = new System.Drawing.Point(7, 19);
            this.grdBitacora.Name = "grdBitacora";
            this.grdBitacora.ReadOnly = true;
            this.grdBitacora.RowTemplate.Height = 25;
            this.grdBitacora.Size = new System.Drawing.Size(741, 311);
            this.grdBitacora.TabIndex = 1;
            // 
            // idBitacora
            // 
            this.idBitacora.DataPropertyName = "ID_BITACORA";
            this.idBitacora.HeaderText = "ID Bitacora";
            this.idBitacora.Name = "idBitacora";
            this.idBitacora.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "FECHA";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 135;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "HORA";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 125;
            // 
            // Movimineto
            // 
            this.Movimineto.DataPropertyName = "MOVIMIENTO_REALIZADO";
            this.Movimineto.HeaderText = "Movimiento";
            this.Movimineto.Name = "Movimineto";
            this.Movimineto.ReadOnly = true;
            this.Movimineto.Width = 500;
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBitacora;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimineto;
    }
}