namespace WindowsFormsApplication1
{
    partial class Atender_consultas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarExpedienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPerfilToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.resumenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.verPerfilToolStripMenuItem.Text = "Inicio";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = " Ver perfil";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarExpedienteToolStripMenuItem,
            this.verHistorialToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // buscarExpedienteToolStripMenuItem
            // 
            this.buscarExpedienteToolStripMenuItem.Name = "buscarExpedienteToolStripMenuItem";
            this.buscarExpedienteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.buscarExpedienteToolStripMenuItem.Text = "Buscar expediente";
            // 
            // verHistorialToolStripMenuItem
            // 
            this.verHistorialToolStripMenuItem.Name = "verHistorialToolStripMenuItem";
            this.verHistorialToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.verHistorialToolStripMenuItem.Text = "Ver historial";
            // 
            // resumenToolStripMenuItem
            // 
            this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
            this.resumenToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.resumenToolStripMenuItem.Text = "Resumen";
            // 
            // Atender_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 491);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Atender_consultas";
            this.Text = "Atender_consultas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Atender_consultas_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarExpedienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
    }
}