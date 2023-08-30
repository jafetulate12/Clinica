
namespace CapaInterfaz
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.mnuMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEspecilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEspecialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaEspecialistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMedcamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuPrincipal
            // 
            this.mnuMenuPrincipal.BackColor = System.Drawing.SystemColors.Menu;
            this.mnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadesToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.medicamentosToolStripMenuItem1,
            this.diagnosticosToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.mnuBitacora});
            this.mnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            this.mnuMenuPrincipal.Size = new System.Drawing.Size(826, 24);
            this.mnuMenuPrincipal.TabIndex = 0;
            this.mnuMenuPrincipal.Text = "menuStrip1";
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEspecilidadesToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_find_clinic_94;
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // agregarEspecilidadesToolStripMenuItem
            // 
            this.agregarEspecilidadesToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_engranaje_94;
            this.agregarEspecilidadesToolStripMenuItem.Name = "agregarEspecilidadesToolStripMenuItem";
            this.agregarEspecilidadesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.agregarEspecilidadesToolStripMenuItem.Text = "  Administrar Especialidad";
            this.agregarEspecilidadesToolStripMenuItem.Click += new System.EventHandler(this.agregarEspecilidadesToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPacientesToolStripMenuItem,
            this.historialMedicoToolStripMenuItem});
            this.pacientesToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_pulmones_94__1_;
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarPacientesToolStripMenuItem
            // 
            this.agregarPacientesToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_engranaje_94;
            this.agregarPacientesToolStripMenuItem.Name = "agregarPacientesToolStripMenuItem";
            this.agregarPacientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agregarPacientesToolStripMenuItem.Text = "Administrar Pacientes";
            this.agregarPacientesToolStripMenuItem.Click += new System.EventHandler(this.agregarPacientesToolStripMenuItem_Click);
            // 
            // historialMedicoToolStripMenuItem
            // 
            this.historialMedicoToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_engranaje_94;
            this.historialMedicoToolStripMenuItem.Name = "historialMedicoToolStripMenuItem";
            this.historialMedicoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.historialMedicoToolStripMenuItem.Text = "Historial Medico";
            this.historialMedicoToolStripMenuItem.Click += new System.EventHandler(this.historialMedicoToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarFuncionariosToolStripMenuItem,
            this.administrarEspecialistasToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosToolStripMenuItem.Image")));
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // administrarFuncionariosToolStripMenuItem
            // 
            this.administrarFuncionariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarFuncionariosToolStripMenuItem.Image")));
            this.administrarFuncionariosToolStripMenuItem.Name = "administrarFuncionariosToolStripMenuItem";
            this.administrarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarFuncionariosToolStripMenuItem.Text = "Administrar Funcionarios";
            this.administrarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.administrarFuncionariosToolStripMenuItem_Click);
            // 
            // administrarEspecialistasToolStripMenuItem
            // 
            this.administrarEspecialistasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaEspecialistaToolStripMenuItem1});
            this.administrarEspecialistasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarEspecialistasToolStripMenuItem.Image")));
            this.administrarEspecialistasToolStripMenuItem.Name = "administrarEspecialistasToolStripMenuItem";
            this.administrarEspecialistasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.administrarEspecialistasToolStripMenuItem.Text = "Administrar Especialistas";
            this.administrarEspecialistasToolStripMenuItem.Click += new System.EventHandler(this.administrarEspecialistasToolStripMenuItem_Click);
            // 
            // agendaEspecialistaToolStripMenuItem1
            // 
            this.agendaEspecialistaToolStripMenuItem1.Image = global::CapaInterfaz.Properties.Resources.icons8_silla_de_ruedas_941;
            this.agendaEspecialistaToolStripMenuItem1.Name = "agendaEspecialistaToolStripMenuItem1";
            this.agendaEspecialistaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.agendaEspecialistaToolStripMenuItem1.Text = "Agenda Especialista";
            this.agendaEspecialistaToolStripMenuItem1.Click += new System.EventHandler(this.agendaEspecialistaToolStripMenuItem1_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administarCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_maletín_médico_941;
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            // 
            // administarCitasToolStripMenuItem
            // 
            this.administarCitasToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_maletín_médico_94;
            this.administarCitasToolStripMenuItem.Name = "administarCitasToolStripMenuItem";
            this.administarCitasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.administarCitasToolStripMenuItem.Text = "Administar Citas";
            this.administarCitasToolStripMenuItem.Click += new System.EventHandler(this.administarCitasToolStripMenuItem_Click);
            // 
            // medicamentosToolStripMenuItem1
            // 
            this.medicamentosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarMedcamentosToolStripMenuItem});
            this.medicamentosToolStripMenuItem1.Image = global::CapaInterfaz.Properties.Resources.icons8_píldora_94;
            this.medicamentosToolStripMenuItem1.Name = "medicamentosToolStripMenuItem1";
            this.medicamentosToolStripMenuItem1.Size = new System.Drawing.Size(114, 20);
            this.medicamentosToolStripMenuItem1.Text = "Medicamentos";
            // 
            // administrarMedcamentosToolStripMenuItem
            // 
            this.administrarMedcamentosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_pulmones_94;
            this.administrarMedcamentosToolStripMenuItem.Name = "administrarMedcamentosToolStripMenuItem";
            this.administrarMedcamentosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.administrarMedcamentosToolStripMenuItem.Text = "Administrar Medicamentos";
            this.administrarMedcamentosToolStripMenuItem.Click += new System.EventHandler(this.administrarMedcamentosToolStripMenuItem_Click);
            // 
            // diagnosticosToolStripMenuItem
            // 
            this.diagnosticosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarDiagnosticoToolStripMenuItem});
            this.diagnosticosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_libro_abierto_94;
            this.diagnosticosToolStripMenuItem.Name = "diagnosticosToolStripMenuItem";
            this.diagnosticosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.diagnosticosToolStripMenuItem.Text = "Diagnosticos";
            // 
            // administrarDiagnosticoToolStripMenuItem
            // 
            this.administrarDiagnosticoToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_cerebro_941;
            this.administrarDiagnosticoToolStripMenuItem.Name = "administrarDiagnosticoToolStripMenuItem";
            this.administrarDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.administrarDiagnosticoToolStripMenuItem.Text = "Administrar Diagnostico";
            this.administrarDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.administrarDiagnosticoToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPagosToolStripMenuItem});
            this.pagosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_caja_de_dinero_94;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // administrarPagosToolStripMenuItem
            // 
            this.administrarPagosToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_añadir_96;
            this.administrarPagosToolStripMenuItem.Name = "administrarPagosToolStripMenuItem";
            this.administrarPagosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.administrarPagosToolStripMenuItem.Text = "Administrar Pagos";
            this.administrarPagosToolStripMenuItem.Click += new System.EventHandler(this.administrarPagosToolStripMenuItem_Click);
            // 
            // mnuBitacora
            // 
            this.mnuBitacora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarBitacoraToolStripMenuItem});
            this.mnuBitacora.Image = global::CapaInterfaz.Properties.Resources.icons8_engranaje_941;
            this.mnuBitacora.Name = "mnuBitacora";
            this.mnuBitacora.Size = new System.Drawing.Size(78, 20);
            this.mnuBitacora.Text = "Bitacora";
            // 
            // mostrarBitacoraToolStripMenuItem
            // 
            this.mostrarBitacoraToolStripMenuItem.Image = global::CapaInterfaz.Properties.Resources.icons8_guardar_96;
            this.mostrarBitacoraToolStripMenuItem.Name = "mostrarBitacoraToolStripMenuItem";
            this.mostrarBitacoraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mostrarBitacoraToolStripMenuItem.Text = "Mostrar Bitacora";
            this.mostrarBitacoraToolStripMenuItem.Click += new System.EventHandler(this.mostrarBitacoraToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(826, 396);
            this.Controls.Add(this.mnuMenuPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMenuPrincipal;
            this.MaximumSize = new System.Drawing.Size(1450, 750);
            this.Name = "frmMenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clinica El Buen Vvir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenuPrincipal.ResumeLayout(false);
            this.mnuMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEspecilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEspecialistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaEspecialistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarMedcamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBitacora;
        private System.Windows.Forms.ToolStripMenuItem mostrarBitacoraToolStripMenuItem;
    }
}

