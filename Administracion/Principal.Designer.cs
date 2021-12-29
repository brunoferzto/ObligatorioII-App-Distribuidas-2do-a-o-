namespace Administracion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cusosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especializadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaInscipciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBToolStripMenuItem,
            this.nuevaInscipciónToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBToolStripMenuItem
            // 
            this.aBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.cusosToolStripMenuItem,
            this.alumnosToolStripMenuItem});
            this.aBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aBToolStripMenuItem.Image")));
            this.aBToolStripMenuItem.Name = "aBToolStripMenuItem";
            this.aBToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.aBToolStripMenuItem.Text = "Administración";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sucursalesToolStripMenuItem.Image")));
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // cusosToolStripMenuItem
            // 
            this.cusosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortosToolStripMenuItem,
            this.especializadosToolStripMenuItem});
            this.cusosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cusosToolStripMenuItem.Image")));
            this.cusosToolStripMenuItem.Name = "cusosToolStripMenuItem";
            this.cusosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.cusosToolStripMenuItem.Text = "Cusos ";
            // 
            // cortosToolStripMenuItem
            // 
            this.cortosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortosToolStripMenuItem.Image")));
            this.cortosToolStripMenuItem.Name = "cortosToolStripMenuItem";
            this.cortosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cortosToolStripMenuItem.Text = "Cortos";
            this.cortosToolStripMenuItem.Click += new System.EventHandler(this.cortosToolStripMenuItem_Click);
            // 
            // especializadosToolStripMenuItem
            // 
            this.especializadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("especializadosToolStripMenuItem.Image")));
            this.especializadosToolStripMenuItem.Name = "especializadosToolStripMenuItem";
            this.especializadosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.especializadosToolStripMenuItem.Text = "Especializados";
            this.especializadosToolStripMenuItem.Click += new System.EventHandler(this.especializadosToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosToolStripMenuItem.Image")));
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // nuevaInscipciónToolStripMenuItem
            // 
            this.nuevaInscipciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaInscipciónToolStripMenuItem.Image")));
            this.nuevaInscipciónToolStripMenuItem.Name = "nuevaInscipciónToolStripMenuItem";
            this.nuevaInscipciónToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.nuevaInscipciónToolStripMenuItem.Text = "Nueva Inscipción";
            this.nuevaInscipciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaInscipciónToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("estadisticasToolStripMenuItem.Image")));
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(567, 267);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cusosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especializadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaInscipciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
    }
}