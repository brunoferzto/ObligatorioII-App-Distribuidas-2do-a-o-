namespace Administracion
{
    partial class AltaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaAlumno));
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblced = new System.Windows.Forms.Label();
            this.lbltele = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcédula = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.tost = new System.Windows.Forms.ToolStrip();
            this.tsbAlta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.sstrip = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.tost.SuspendLayout();
            this.sstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(64, 95);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre : ";
            // 
            // lblced
            // 
            this.lblced.AutoSize = true;
            this.lblced.Location = new System.Drawing.Point(64, 65);
            this.lblced.Name = "lblced";
            this.lblced.Size = new System.Drawing.Size(46, 13);
            this.lblced.TabIndex = 1;
            this.lblced.Text = "Cédula :";
            // 
            // lbltele
            // 
            this.lbltele.AutoSize = true;
            this.lbltele.Location = new System.Drawing.Point(64, 133);
            this.lbltele.Name = "lbltele";
            this.lbltele.Size = new System.Drawing.Size(58, 13);
            this.lbltele.TabIndex = 2;
            this.lbltele.Text = "Teléfono : ";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(124, 95);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtcédula
            // 
            this.txtcédula.Location = new System.Drawing.Point(124, 58);
            this.txtcédula.MaxLength = 8;
            this.txtcédula.Name = "txtcédula";
            this.txtcédula.Size = new System.Drawing.Size(100, 20);
            this.txtcédula.TabIndex = 1;
            this.txtcédula.Validating += new System.ComponentModel.CancelEventHandler(this.txtcédula_Validating);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(124, 130);
            this.txttel.MaxLength = 8;
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 3;
            this.txttel.Validating += new System.ComponentModel.CancelEventHandler(this.txttel_Validating);
            // 
            // tost
            // 
            this.tost.BackColor = System.Drawing.Color.LightCyan;
            this.tost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlta,
            this.toolStripSeparator1,
            this.tsbDeshacer});
            this.tost.Location = new System.Drawing.Point(0, 0);
            this.tost.Name = "tost";
            this.tost.Size = new System.Drawing.Size(337, 25);
            this.tost.TabIndex = 6;
            this.tost.Text = "BarradeHerramientas";
            // 
            // tsbAlta
            // 
            this.tsbAlta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlta.Enabled = false;
            this.tsbAlta.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlta.Image")));
            this.tsbAlta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlta.Name = "tsbAlta";
            this.tsbAlta.Size = new System.Drawing.Size(23, 22);
            this.tsbAlta.Text = "Alta";
            this.tsbAlta.Click += new System.EventHandler(this.tsbAlta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDeshacer
            // 
            this.tsbDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeshacer.Image")));
            this.tsbDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeshacer.Name = "tsbDeshacer";
            this.tsbDeshacer.Size = new System.Drawing.Size(23, 22);
            this.tsbDeshacer.Text = "Deshacer";
            this.tsbDeshacer.Click += new System.EventHandler(this.tsbDeshacer_Click);
            // 
            // sstrip
            // 
            this.sstrip.BackColor = System.Drawing.Color.LightCyan;
            this.sstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.sstrip.Location = new System.Drawing.Point(0, 239);
            this.sstrip.Name = "sstrip";
            this.sstrip.Size = new System.Drawing.Size(337, 22);
            this.sstrip.TabIndex = 7;
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.sstrip);
            this.Controls.Add(this.tost);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtcédula);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltele);
            this.Controls.Add(this.lblced);
            this.Controls.Add(this.lblnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaAlumno";
            this.Text = "Alumnos";
            this.tost.ResumeLayout(false);
            this.tost.PerformLayout();
            this.sstrip.ResumeLayout(false);
            this.sstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblced;
        private System.Windows.Forms.Label lbltele;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcédula;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.ToolStrip tost;
        private System.Windows.Forms.ToolStripButton tsbAlta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDeshacer;
        private System.Windows.Forms.StatusStrip sstrip;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
    }
}