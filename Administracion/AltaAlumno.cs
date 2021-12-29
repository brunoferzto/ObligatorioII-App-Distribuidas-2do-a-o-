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
    public partial class AltaAlumno : Form
    {
        private Alumnos alMemo = null; 
        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttel.Text.Trim().Length == 8 && txtnombre.Text.Trim().Length > 4)
                {
                    Alumnos nueAlu = new Alumnos();
                    nueAlu.Nombre = txtnombre.Text.Trim();
                    nueAlu.Cedula = Convert.ToInt32(txtcédula.Text.Trim());
                    nueAlu.Telefono = Convert.ToInt32(txttel.Text.Trim());

                    new MiServicio().AgregarAlumno(nueAlu);
                    lblerror.Text = "Se agregó el Alumno Correctamente";
                    txtnombre.Text = "";
                    txtcédula.Text = "";
                    txttel.Text = "";
                    tsbAlta.Enabled = false;
                }
                else
                    lblerror.Text = "Datos Incorrectos";
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
            tsbAlta.Enabled = false;
            lblerror.Text = "";
            txtcédula.Text = "";
            txtnombre.Text = "";
            txttel.Text = "";
            tsbAlta.Enabled = false;
            txtnombre.ReadOnly = true;
            txttel.ReadOnly = true;
        }

        private void txtcédula_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                alMemo = new MiServicio().BuscarAlumno(Convert.ToInt32(txtcédula.Text.Trim()));
                if(alMemo != null)
                {
                    txtnombre.Text = alMemo.Nombre.ToString();
                    txttel.Text = alMemo.Telefono.ToString();     

                }
                else
                {
                    tsbAlta.Enabled = true;
                    txttel.Enabled = true;
                    txtnombre.Enabled = true;
                    txtnombre.ReadOnly = false;
                    txttel.ReadOnly = false; 

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

        private void txttel_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
