namespace Administracion
{
    partial class ABMCortos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMCortos));
            this.tost = new System.Windows.Forms.ToolStrip();
            this.tsbAlta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBaja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtcupos = new System.Windows.Forms.TextBox();
            this.lblempleado = new System.Windows.Forms.Label();
            this.lbsucursales = new System.Windows.Forms.ListBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcupos = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtempleado = new System.Windows.Forms.TextBox();
            this.lblsucursal = new System.Windows.Forms.Label();
            this.clbarea = new System.Windows.Forms.CheckedListBox();
            this.eperror = new System.Windows.Forms.ErrorProvider(this.components);
            this.tost.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).BeginInit();
            this.SuspendLayout();
            // 
            // tost
            // 
            this.tost.BackColor = System.Drawing.Color.LightCyan;
            this.tost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlta,
            this.toolStripSeparator1,
            this.tsbBaja,
            this.toolStripSeparator2,
            this.tsbModificar,
            this.toolStripSeparator3,
            this.tsbDeshacer});
            this.tost.Location = new System.Drawing.Point(0, 0);
            this.tost.Name = "tost";
            this.tost.Size = new System.Drawing.Size(440, 25);
            this.tost.TabIndex = 1;
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
            // tsbBaja
            // 
            this.tsbBaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBaja.Enabled = false;
            this.tsbBaja.Image = ((System.Drawing.Image)(resources.GetObject("tsbBaja.Image")));
            this.tsbBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaja.Name = "tsbBaja";
            this.tsbBaja.Size = new System.Drawing.Size(23, 22);
            this.tsbBaja.Text = "Eliminar";
            this.tsbBaja.Click += new System.EventHandler(this.tsbBaja_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Enabled = false;
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(23, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(440, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblerror
            // 
            this.lblerror.BackColor = System.Drawing.SystemColors.Control;
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(101, 47);
            this.txtcodigo.MaxLength = 5;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(47, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(101, 83);
            this.txtnombre.MaxLength = 40;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(212, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(101, 197);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(47, 20);
            this.txtcosto.TabIndex = 6;
            this.txtcosto.Validating += new System.ComponentModel.CancelEventHandler(this.txtcosto_Validating);
            // 
            // txtcupos
            // 
            this.txtcupos.Location = new System.Drawing.Point(101, 156);
            this.txtcupos.Name = "txtcupos";
            this.txtcupos.Size = new System.Drawing.Size(47, 20);
            this.txtcupos.TabIndex = 4;
            this.txtcupos.Validating += new System.ComponentModel.CancelEventHandler(this.txtcupos_Validating);
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.Location = new System.Drawing.Point(55, 147);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(0, 13);
            this.lblempleado.TabIndex = 11;
            // 
            // lbsucursales
            // 
            this.lbsucursales.FormattingEnabled = true;
            this.lbsucursales.Location = new System.Drawing.Point(101, 300);
            this.lbsucursales.Name = "lbsucursales";
            this.lbsucursales.Size = new System.Drawing.Size(305, 95);
            this.lbsucursales.TabIndex = 8;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 86);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 13;
            this.lblnombre.Text = "Nombre :";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(101, 121);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(212, 20);
            this.dtpfecha.TabIndex = 3;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(15, 47);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(46, 13);
            this.lblcod.TabIndex = 15;
            this.lblcod.Text = "Codigo :";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(12, 121);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(71, 13);
            this.lblfecha.TabIndex = 16;
            this.lblfecha.Text = "Fecha Inicio :";
            // 
            // lblcupos
            // 
            this.lblcupos.AutoSize = true;
            this.lblcupos.Location = new System.Drawing.Point(12, 163);
            this.lblcupos.Name = "lblcupos";
            this.lblcupos.Size = new System.Drawing.Size(43, 13);
            this.lblcupos.TabIndex = 17;
            this.lblcupos.Text = "Cupos :";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(12, 200);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(37, 13);
            this.lblvalor.TabIndex = 18;
            this.lblvalor.Text = "Valor :";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(12, 235);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(38, 13);
            this.lblarea.TabIndex = 20;
            this.lblarea.Text = "Área : ";
            // 
            // txtempleado
            // 
            this.txtempleado.Enabled = false;
            this.txtempleado.Location = new System.Drawing.Point(284, 28);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.ReadOnly = true;
            this.txtempleado.Size = new System.Drawing.Size(100, 20);
            this.txtempleado.TabIndex = 5;
            // 
            // lblsucursal
            // 
            this.lblsucursal.AutoSize = true;
            this.lblsucursal.Location = new System.Drawing.Point(15, 338);
            this.lblsucursal.Name = "lblsucursal";
            this.lblsucursal.Size = new System.Drawing.Size(54, 13);
            this.lblsucursal.TabIndex = 23;
            this.lblsucursal.Text = "Sucursal :";
            // 
            // clbarea
            // 
            this.clbarea.BackColor = System.Drawing.SystemColors.Control;
            this.clbarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbarea.FormattingEnabled = true;
            this.clbarea.Items.AddRange(new object[] {
            "Programación",
            "Diseño",
            "Economía"});
            this.clbarea.Location = new System.Drawing.Point(101, 235);
            this.clbarea.Name = "clbarea";
            this.clbarea.Size = new System.Drawing.Size(120, 45);
            this.clbarea.TabIndex = 7;
            this.clbarea.SelectedIndexChanged += new System.EventHandler(this.clbarea_SelectedIndexChanged);
            // 
            // eperror
            // 
            this.eperror.ContainerControl = this;
            // 
            // ABMCortos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(440, 441);
            this.Controls.Add(this.clbarea);
            this.Controls.Add(this.lblsucursal);
            this.Controls.Add(this.txtempleado);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblcupos);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbsucursales);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.txtcupos);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMCortos";
            this.Text = "ABMCortos";
            this.Load += new System.EventHandler(this.ABMCortos_Load);
            this.tost.ResumeLayout(false);
            this.tost.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tost;
        private System.Windows.Forms.ToolStripButton tsbAlta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDeshacer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.TextBox txtcupos;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.ListBox lbsucursales;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcupos;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtempleado;
        private System.Windows.Forms.Label lblsucursal;
        private System.Windows.Forms.CheckedListBox clbarea;
        private System.Windows.Forms.ErrorProvider eperror;
    }
}