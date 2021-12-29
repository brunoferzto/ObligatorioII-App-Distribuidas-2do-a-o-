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
    public partial class NuevaInscripción : Form
    {
        private Alumnos alMemo = null;
        private Cursos curMemo = null; 

        public NuevaInscripción()
        {
            InitializeComponent();
        }

        private void txtced_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                alMemo = new MiServicio().BuscarAlumno(Convert.ToInt32(txtced.Text));
                if (alMemo != null)
                {
                    txtced.ReadOnly = true;
                    lblname.Visible = true; 
                    lblname.Text = "Nombre : " + " " + alMemo.Nombre;                  
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

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            try
            {

               curMemo = new MiServicio().BuscarCurso(txtcod.Text.Trim());
                if (curMemo != null)
                {
                    txtcod.ReadOnly = true;
                    lblsucursal.Visible = true; 
                    lblCursonam.Visible = true; 
                    lblCursonam.Text = "Curso : " + " " + curMemo.Nombre;
                    lblsucursal.Text = "Sucursal : " + " " + curMemo.Local.Nombre + ", " + curMemo.Local.Direccion;
                    
                    tsbAlta.Enabled = true;
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

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (curMemo != null || alMemo != null)
                {

                    Inscripcion nueIns = new Inscripcion();
                    nueIns.Alumno = alMemo;
                    nueIns.Fecha = DateTime.Now;
                    nueIns.Curso = curMemo;

                    new MiServicio().InscripcionAlumno(nueIns);

                    lblerror.Text = "Se agregó el Alumno Correctamente";
                    txtcod.Text = "";
                    txtcod.ReadOnly = false;
                    txtced.Text = "";
                    txtced.ReadOnly = false;
                    lblCursonam.Visible = false;
                    lblsucursal.Visible = false;
                    lblname.Visible = false;

                   
                }
                else
                    lblerror.Text = "Debe Ingresar un Alumno y un Curso para Incripción";
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
            txtcod.Text = "";
            txtced.Text = "";
            lblerror.Text = "";
            txtcod.ReadOnly = false;
            lblsucursal.Visible = false;
            lblCursonam.Visible = false;
            lblCursonam.Text = "";
            lblsucursal.Text = "";
            txtced.ReadOnly = false;
            lblname.Visible = false;
            lblname.Text = "";
        }
    }
}
