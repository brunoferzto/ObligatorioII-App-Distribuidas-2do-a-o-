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
    public partial class Logueo : Form
    {
        

        public Logueo()
        {
            InitializeComponent();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                Administracion.ServicioWeb.Empleado eLog = new ServicioWeb.Empleado();

               eLog.Usuario = txtusu.Text.Trim();
               eLog.Contraseña = txtcontra.Text.Trim();
               eLog = new ServicioWeb.MiServicio().LogueoEmpleado(eLog);

                if (eLog != null)
                {                 
                    Hide();
                    Principal form = new Principal(eLog);                   
                    form.ShowDialog();                   
                    form.Close();                    
                }
                else
                    lblerror.Text = "No existe Empleado activo con los datos ingresados";

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 40)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 40);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch(Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 40);
                else
                    lblerror.Text = ex.Message;                
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (txtcontra.UseSystemPasswordChar == false)
                txtcontra.UseSystemPasswordChar = true;
            else
                txtcontra.UseSystemPasswordChar = false;
        }
    }
}
