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
    public partial class ABMEspecializados : Form
    {
        Cursos curEsp = null;
        Empleado emplLog = null;
        List<Sucursales> lista = new List<Sucursales>();
        
       

        public ABMEspecializados(Empleado emLO)
        {
            InitializeComponent();
            emplLog = emLO;
        }

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbsucursales.SelectedIndex != -1)
                {
                    Especializados NueEsp = new Especializados();
                    NueEsp.Duracion = Convert.ToInt32(txtdura.Text.Trim());
                    NueEsp.Nombre = txtnombre.Text.Trim();
                    NueEsp.Codigo = txtcodigo.Text.Trim();
                    NueEsp.Costo = Convert.ToInt32(txtcosto.Text.Trim());
                    NueEsp.Cupos = Convert.ToInt32(txtcupos.Text.Trim());
                    NueEsp.Fecha_Inicio = dtpfecha.Value;
                    NueEsp.Local = lista[lbsucursales.SelectedIndex];
                    NueEsp.Empleados = emplLog;

                    new MiServicio().AgregarCurso(NueEsp);
                    ActivoxDefecto();
                    lblerror.Text = "Se agregó el Curso Correctamente";
                }
                else
                    lblerror.Text = "Deben Ingresarse Todos los Datos";

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
                new MiServicio().EliminarCurso(curEsp);
                ActivoxDefecto();
                lblerror.Text = "Eliminación Correcta";
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
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbsucursales.SelectedIndex != -1)
                {
                    curEsp.Costo = Convert.ToInt32(txtcosto.Text.Trim());
                    curEsp.Cupos = Convert.ToInt32(txtcupos.Text.Trim());
                    curEsp.Empleados = emplLog;
                    curEsp.Fecha_Inicio = dtpfecha.Value;
                    curEsp.Local = lista[lbsucursales.SelectedIndex];
                    curEsp.Nombre = txtnombre.Text.Trim();
                    ((Especializados)curEsp).Duracion = Convert.ToInt32(txtdura.Text.Trim());

                    new MiServicio().ModificarCursos(curEsp);

                    ActivoxDefecto();
                    lblerror.Text = "Se Modificó el Curso Correctamente";
                }
                else
                lblerror.Text = "Deben Ingresarse Todos los Datos";

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
            ActivoxDefecto();
        }

        private void ActivoxDefecto()
        {
          
            lblerror.Text = "";

            tsbAlta.Enabled = false;
            tsbBaja.Enabled = false;
            tsbModificar.Enabled = false;

          
            txtcodigo.Enabled = true;
            txtcupos.Enabled = false;
            txtcosto.Enabled = false;
            txtnombre.ReadOnly = true;
            txtdura.Enabled = false;
            dtpfecha.Enabled = false;


            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtcupos.Text = "";
            txtcosto.Text = "";
            txtdura.Text = "";
            txtempleado.Text = "";
           

            lbsucursales.Enabled = false;
            lbsucursales.SelectedIndex = -1;

            
            eperror.Clear();
            txtcodigo.Focus();
            curEsp = null;
        }

        private void ActivoAgregar()
        {
            tsbAlta.Enabled = true;
            txtnombre.ReadOnly = false;
            dtpfecha.Enabled = true;
            txtcupos.Enabled = true;
            txtcosto.Enabled = true;
            lbsucursales.Enabled = true;
            txtdura.Enabled = true;
        }

        private void ActivoActulización()
        {
            txtcodigo.Enabled = false;
            tsbBaja.Enabled = true;
            tsbModificar.Enabled = true;
            txtnombre.ReadOnly = false;
            dtpfecha.Enabled = true;
            txtcupos.Enabled = true;
            txtcosto.Enabled = true;
            lbsucursales.Enabled = true;
            txtdura.Enabled = true;

        }

        private void txtcupos_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtcupos.Text.Trim() != "")
                {
                    Convert.ToInt32(txtcupos.Text);
                    eperror.Clear();
                }    
            }
            catch 
            {
                e.Cancel = true;
                eperror.SetError(txtcupos, "Valor Incorrecto");
            }
        }

        private void txtcosto_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtcosto.Text.Trim() != "")
                {
                    Convert.ToInt32(txtcosto.Text);
                    eperror.Clear();
                }
            }
            catch
            {
                e.Cancel = true;
                eperror.SetError(txtcosto, "Valor Incorrecto");
            }
        }

        private void txtdura_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtdura.Text.Trim() != "")
                {
                    Convert.ToInt32(txtdura.Text);
                    eperror.Clear();
                }
            }
            catch
            {
                e.Cancel = true;
                eperror.SetError(txtdura, "Valor Incorrecto");
            }
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtcodigo.Text.Trim() != "")
                {
                    curEsp = new MiServicio().BuscarCurso(txtcodigo.Text.Trim());

                    if (curEsp is Especializados)
                    {

                        txtcodigo.Text = curEsp.Codigo.ToString();
                        txtnombre.Text = curEsp.Nombre;
                        dtpfecha.Value = curEsp.Fecha_Inicio;
                        txtcupos.Text = curEsp.Cupos.ToString();
                        txtcosto.Text = curEsp.Costo.ToString();
                        txtempleado.Text = curEsp.Empleados.Usuario;
                        lbsucursales.SelectedValue = curEsp.Local.Nombre;
                        txtdura.Text = ((Especializados)curEsp).Duracion.ToString();
                        ActivoActulización();

                    }
                    else if (curEsp is Cortos)
                    {
                        ActivoxDefecto();
                        lblerror.Text = "El codigo : " + txtcodigo.Text.Trim() + " " + "pertenece a otro tipo de Curso";
                    }
                    else
                    {
                        ActivoAgregar();
                    }
                }
                else
                    ActivoxDefecto();
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

        private void ABMEspecializados_Load(object sender, EventArgs e)
        {
            try
            {
                lista = new MiServicio().ListarSucursales().ToList();
                  
                lbsucursales.DataSource = lista;
                lbsucursales.ValueMember = "Nombre";
                ActivoxDefecto();
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
    }
}
