namespace Administracion
{
    partial class ABMSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMSucursal));
            this.tost = new System.Windows.Forms.ToolStrip();
            this.tsbAlta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBaja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeshacer = new System.Windows.Forms.ToolStripButton();
            this.sstrip = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbfacilidad = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbldire = new System.Windows.Forms.Label();
            this.txtfacilidad = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.lblfacilidad = new System.Windows.Forms.Label();
            this.tost.SuspendLayout();
            this.sstrip.SuspendLayout();
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
            this.tost.Size = new System.Drawing.Size(563, 25);
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
            // sstrip
            // 
            this.sstrip.BackColor = System.Drawing.Color.LightCyan;
            this.sstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.sstrip.Location = new System.Drawing.Point(0, 334);
            this.sstrip.Name = "sstrip";
            this.sstrip.Size = new System.Drawing.Size(563, 22);
            this.sstrip.TabIndex = 2;
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 123);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(156, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // lbfacilidad
            // 
            this.lbfacilidad.FormattingEnabled = true;
            this.lbfacilidad.Location = new System.Drawing.Point(166, 189);
            this.lbfacilidad.Name = "lbfacilidad";
            this.lbfacilidad.Size = new System.Drawing.Size(203, 82);
            this.lbfacilidad.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(99, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre :";
            // 
            // lbldire
            // 
            this.lbldire.AutoSize = true;
            this.lbldire.Location = new System.Drawing.Point(99, 126);
            this.lbldire.Name = "lbldire";
            this.lbldire.Size = new System.Drawing.Size(61, 13);
            this.lbldire.TabIndex = 7;
            this.lbldire.Text = "Dirección : ";
            // 
            // txtfacilidad
            // 
            this.txtfacilidad.Location = new System.Drawing.Point(166, 289);
            this.txtfacilidad.Name = "txtfacilidad";
            this.txtfacilidad.Size = new System.Drawing.Size(203, 20);
            this.txtfacilidad.TabIndex = 9;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(376, 289);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(55, 23);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(376, 211);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(55, 23);
            this.btnquitar.TabIndex = 11;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // lblfacilidad
            // 
            this.lblfacilidad.AutoSize = true;
            this.lblfacilidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfacilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfacilidad.Location = new System.Drawing.Point(186, 164);
            this.lblfacilidad.Name = "lblfacilidad";
            this.lblfacilidad.Size = new System.Drawing.Size(136, 13);
            this.lblfacilidad.TabIndex = 12;
            this.lblfacilidad.Text = "Facilidades de la Sucursal :";
            // 
            // ABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(563, 356);
            this.Controls.Add(this.lblfacilidad);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtfacilidad);
            this.Controls.Add(this.lbldire);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbfacilidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.sstrip);
            this.Controls.Add(this.tost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ABMSucursal";
            this.Text = "ABMSucursal";
            this.Load += new System.EventHandler(this.ABMSucursal_Load);
            this.tost.ResumeLayout(false);
            this.tost.PerformLayout();
            this.sstrip.ResumeLayout(false);
            this.sstrip.PerformLayout();
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
        private System.Windows.Forms.StatusStrip sstrip;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ListBox lbfacilidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbldire;
        private System.Windows.Forms.TextBox txtfacilidad;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label lblfacilidad;
    }
}