namespace Administracion
{
    partial class NuevaInscripción
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaInscripción));
            this.lblced = new System.Windows.Forms.Label();
            this.txtced = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblCursonam = new System.Windows.Forms.Label();
            this.lblcupodisp = new System.Windows.Forms.Label();
            this.tost = new System.Windows.Forms.ToolStrip();
            this.tsbAlta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblsucursal = new System.Windows.Forms.Label();
            this.tost.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblced
            // 
            this.lblced.AutoSize = true;
            this.lblced.Location = new System.Drawing.Point(61, 58);
            this.lblced.Name = "lblced";
            this.lblced.Size = new System.Drawing.Size(102, 13);
            this.lblced.TabIndex = 0;
            this.lblced.Text = "Cédula de Alumno : ";
            // 
            // txtced
            // 
            this.txtced.Location = new System.Drawing.Point(174, 55);
            this.txtced.MaxLength = 8;
            this.txtced.Name = "txtced";
            this.txtced.Size = new System.Drawing.Size(100, 20);
            this.txtced.TabIndex = 1;
            this.txtced.Validating += new System.ComponentModel.CancelEventHandler(this.txtced_Validating);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(61, 114);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(94, 13);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "Código de Curso : ";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(174, 111);
            this.txtcod.MaxLength = 5;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 3;
            this.txtcod.Validating += new System.ComponentModel.CancelEventHandler(this.txtcod_Validating);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(140, 156);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Visible = false;
            // 
            // lblCursonam
            // 
            this.lblCursonam.AutoSize = true;
            this.lblCursonam.Location = new System.Drawing.Point(140, 183);
            this.lblCursonam.Name = "lblCursonam";
            this.lblCursonam.Size = new System.Drawing.Size(0, 13);
            this.lblCursonam.TabIndex = 8;
            this.lblCursonam.Visible = false;
            // 
            // lblcupodisp
            // 
            this.lblcupodisp.AutoSize = true;
            this.lblcupodisp.Location = new System.Drawing.Point(164, 252);
            this.lblcupodisp.Name = "lblcupodisp";
            this.lblcupodisp.Size = new System.Drawing.Size(35, 13);
            this.lblcupodisp.TabIndex = 13;
            this.lblcupodisp.Text = "label5";
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
            this.tost.Size = new System.Drawing.Size(466, 25);
            this.tost.TabIndex = 14;
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
            this.tsbAlta.Text = "Inscribir";
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // lblsucursal
            // 
            this.lblsucursal.AutoSize = true;
            this.lblsucursal.Location = new System.Drawing.Point(143, 210);
            this.lblsucursal.Name = "lblsucursal";
            this.lblsucursal.Size = new System.Drawing.Size(0, 13);
            this.lblsucursal.TabIndex = 16;
            this.lblsucursal.Visible = false;
            // 
            // NuevaInscripción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(466, 274);
            this.Controls.Add(this.lblsucursal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tost);
            this.Controls.Add(this.lblcupodisp);
            this.Controls.Add(this.lblCursonam);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtced);
            this.Controls.Add(this.lblced);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaInscripción";
            this.Text = "NuevaInscripción";
            this.tost.ResumeLayout(false);
            this.tost.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblced;
        private System.Windows.Forms.TextBox txtced;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblCursonam;
        private System.Windows.Forms.Label lblcupodisp;
        private System.Windows.Forms.ToolStrip tost;
        private System.Windows.Forms.ToolStripButton tsbAlta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDeshacer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Label lblsucursal;
    }
}