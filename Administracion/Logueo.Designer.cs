namespace Administracion
{
    partial class Logueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logueo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.statustrip = new System.Windows.Forms.StatusStrip();
            this.lblerror = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnver = new System.Windows.Forms.Button();
            this.statustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña :";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(152, 85);
            this.txtusu.MaxLength = 10;
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(116, 20);
            this.txtusu.TabIndex = 1;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(152, 120);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(116, 20);
            this.txtcontra.TabIndex = 3;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(166, 161);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(87, 23);
            this.btningresar.TabIndex = 4;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // statustrip
            // 
            this.statustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblerror});
            this.statustrip.Location = new System.Drawing.Point(0, 239);
            this.statustrip.Name = "statustrip";
            this.statustrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statustrip.Size = new System.Drawing.Size(411, 22);
            this.statustrip.TabIndex = 5;
            // 
            // lblerror
            // 
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            // 
            // btnver
            // 
            this.btnver.Image = ((System.Drawing.Image)(resources.GetObject("btnver.Image")));
            this.btnver.Location = new System.Drawing.Point(292, 120);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(27, 20);
            this.btnver.TabIndex = 7;
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.statustrip);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logueo";
            this.Text = "Logueo";
            this.statustrip.ResumeLayout(false);
            this.statustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.StatusStrip statustrip;
        private System.Windows.Forms.ToolStripStatusLabel lblerror;
        private System.Windows.Forms.Button btnver;
    }
}