namespace Administracion
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.cbxcursos = new System.Windows.Forms.ComboBox();
            this.tost = new System.Windows.Forms.ToolStrip();
            this.tsbfiltrar = new System.Windows.Forms.ToolStripButton();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.cbfiltrar = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            this.tost.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.BackColor = System.Drawing.SystemColors.Control;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvlistado
            // 
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Location = new System.Drawing.Point(97, 175);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.Size = new System.Drawing.Size(559, 150);
            this.dgvlistado.TabIndex = 8;
            // 
            // cbxcursos
            // 
            this.cbxcursos.FormattingEnabled = true;
            this.cbxcursos.Location = new System.Drawing.Point(450, 63);
            this.cbxcursos.Name = "cbxcursos";
            this.cbxcursos.Size = new System.Drawing.Size(142, 21);
            this.cbxcursos.TabIndex = 9;
            // 
            // tost
            // 
            this.tost.BackColor = System.Drawing.Color.LightCyan;
            this.tost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbfiltrar,
            this.tsbDeshacer});
            this.tost.Location = new System.Drawing.Point(0, 0);
            this.tost.Name = "tost";
            this.tost.Size = new System.Drawing.Size(758, 25);
            this.tost.TabIndex = 10;
            this.tost.Text = "BarradeHerramientas";
            // 
            // tsbfiltrar
            // 
            this.tsbfiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbfiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbfiltrar.Image")));
            this.tsbfiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbfiltrar.Name = "tsbfiltrar";
            this.tsbfiltrar.Size = new System.Drawing.Size(23, 22);
            this.tsbfiltrar.Text = "toolStripButton1";
            this.tsbfiltrar.Click += new System.EventHandler(this.tsbfiltrar_Click);
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
            // dtpdesde
            // 
            this.dtpdesde.Location = new System.Drawing.Point(97, 59);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(200, 20);
            this.dtpdesde.TabIndex = 11;
            this.dtpdesde.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta :";
            // 
            // dtphasta
            // 
            this.dtphasta.Location = new System.Drawing.Point(97, 99);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(200, 20);
            this.dtphasta.TabIndex = 18;
            // 
            // cbfiltrar
            // 
            this.cbfiltrar.AutoSize = true;
            this.cbfiltrar.Location = new System.Drawing.Point(450, 90);
            this.cbfiltrar.Name = "cbfiltrar";
            this.cbfiltrar.Size = new System.Drawing.Size(51, 17);
            this.cbfiltrar.TabIndex = 19;
            this.cbfiltrar.Text = "Filtrar";
            this.cbfiltrar.UseVisualStyleBackColor = true;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(758, 386);
            this.Controls.Add(this.cbfiltrar);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.tost);
            this.Controls.Add(this.cbxcursos);
            this.Controls.Add(this.dgvlistado);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            this.tost.ResumeLayout(false);
            this.tost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.ComboBox cbxcursos;
        private System.Windows.Forms.ToolStrip tost;
        private System.Windows.Forms.ToolStripButton tsbDeshacer;
        private System.Windows.Forms.ToolStripButton tsbfiltrar;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.CheckBox cbfiltrar;
    }
}