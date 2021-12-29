using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion.ServicioWeb;

namespace Administracion
{
    public partial class ABMEmpleado : Form
    {
        private Empleado emMemo = null;
        private Empleado eLog = null;

        public ABMEmpleado()
         {
            InitializeComponent();
          
        }

        public ABMEmpleado(Empleado em)
        {
            InitializeComponent();
            eLog = em;
        }

        private void ActivoPorDefecto()
        {
            eperror.Clear();
            
            lblerror.Text = "";
            

            tsbAlta.Enabled = false;
            tsbBaja.Enabled = false;
            tsbModificar.Enabled = false;
            btnver.Enabled = false; 

            txtnUSU.Text = "";
            txtnUSU.Enabled = true; 
            txtcontra.Text = "";
            txtcontra.ReadOnly = true;
            txtnUSU.Focus();
            emMemo = null;
        }

        private void Actualizacion ()
        {
            btnver.Enabled = true;
            tsbAlta.Enabled = false;
            tsbBaja.Enabled = true;
            tsbModificar.Enabled = true;
            txtcontra.ReadOnly = false;
            txtcontra.Text = emMemo.Contraseña.ToString();
        }
        
        private void ActivoAgregar ()
        {
            tsbAlta.Enabled = true;
            tsbBaja.Enabled = false;
            tsbModificar.Enabled = false;
            txtnUSU.Enabled = false;
            txtcontra.Text = "";
            btnver.Enabled = true;
            txtcontra.ReadOnly = false;
        }

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado emNuev = new Empleado();
                emNuev.Usuario = txtnUSU.Text.Trim();
                emNuev.Contraseña = txtcontra.Text.Trim();
                new MiServicio().RegistrarEmpleado(emNuev);

                ActivoPorDefecto();
                lblerror.Text = "Se agregó el Empleado Correctamente";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void txtnUSU_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtnUSU.Text.Trim().Length != 10)
                {
                    e.Cancel = true;
                    eperror.SetError(txtnUSU, "Valor Incorrecto");
                }
                else
                {
                    eperror.Clear();
                    emMemo =  new MiServicio().BuscarEmpleado(txtnUSU.Text.Trim());
                    if (emMemo != null)
                    {
                        Actualizacion();
                    }
                    else
                    {
                        ActivoAgregar();
                    }
                }

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void tsbDeshacer_Click(object sender, EventArgs e)
        {
            ActivoPorDefecto();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
                
            if (txtcontra.UseSystemPasswordChar == false)
                txtcontra.UseSystemPasswordChar = true;
            else
                txtcontra.UseSystemPasswordChar = false;

        
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {             
                emMemo.Usuario = txtnUSU.Text.Trim();
                emMemo.Contraseña = txtcontra.Text.Trim();
                new MiServicio().ModificarEmlpeado(emMemo);
                ActivoPorDefecto();
                lblerror.Text = "Modificación Exitosa";               
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }

        }

        private void tsbBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (emMemo.Usuario == eLog.Usuario)
                {
                    new MiServicio().EliminarEmpleado(emMemo);

                    foreach (Form F in Application.OpenForms)
                        F.Close();                 
                }
                else
                {
                    new MiServicio().EliminarEmpleado(emMemo);
                    ActivoPorDefecto();
                    lblerror.Text = "Eliminación Correcta";
                   
                }         

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;
            }
        }

        private void ABMEmpleado_Load(object sender, EventArgs e)
        {
            ActivoPorDefecto(); 
        }


    }
}
