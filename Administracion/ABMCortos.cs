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
    public partial class ABMCortos : Form
    {
        Cursos curCorto = null;
        Empleado emplLog = null;
        List<Sucursales> lista = new List<Sucursales>();

        public ABMCortos(Empleado emLO)
        {
            InitializeComponent();
            emplLog = emLO;
        }
        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtcodigo.Text.Trim() != "") //si esta vacio no lo "baja" a buscarlo
                {
                    curCorto = new ServicioWeb.MiServicio().BuscarCurso(txtcodigo.Text.Trim());
                    if (curCorto is Cortos)
                    {

                        txtcodigo.Text = curCorto.Codigo.ToString();
                        txtnombre.Text = curCorto.Nombre;
                        dtpfecha.Value = curCorto.Fecha_Inicio;
                        txtcupos.Text = curCorto.Cupos.ToString();
                        txtcosto.Text = curCorto.Costo.ToString();
                        clbarea.SelectedItem = ((Cortos)curCorto).Area.ToString();
                        clbarea.SetItemChecked(clbarea.SelectedIndex, true);
                        txtempleado.Text = curCorto.Empleados.Usuario;
                        lbsucursales.SelectedValue = curCorto.Local.Nombre;
                        ActivoActulización();

                    }
                    else if (curCorto is Especializados)
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
        private void ABMCortos_Load(object sender, EventArgs e)
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
            dtpfecha.Enabled = false;


            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtcupos.Text = "";
            txtcosto.Text = "";
            txtempleado.Text = "";

            clbarea.Enabled = false;
            clbarea.SelectedIndex = -1;
            for (int i = 0; i < clbarea.Items.Count; i++)
                clbarea.SetItemChecked(i, false);

            lbsucursales.Enabled = false;
            lbsucursales.SelectedIndex = -1;


            eperror.Clear();
            txtcodigo.Focus();
            curCorto = null;


        }
        private void ActivoAgregar()
        {
            tsbAlta.Enabled = true;
            txtnombre.ReadOnly = false;
            dtpfecha.Enabled = true;
            txtcupos.Enabled = true;
            txtcosto.Enabled = true;
            clbarea.Enabled = true;
            lbsucursales.Enabled = true;

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
            clbarea.Enabled = true;
            lbsucursales.Enabled = true;
        }
        private void tsbDeshacer_Click(object sender, EventArgs e)
        {
            
            ActivoxDefecto();
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (clbarea.SelectedItem.ToString() != "" && lbsucursales.SelectedIndex != -1)
                {
                    ((Cortos)curCorto).Area = clbarea.SelectedItem.ToString();
                    curCorto.Costo = Convert.ToInt32(txtcosto.Text.Trim());
                    curCorto.Cupos = Convert.ToInt32(txtcupos.Text.Trim());
                    curCorto.Empleados = emplLog;
                    curCorto.Fecha_Inicio = dtpfecha.Value;
                    curCorto.Nombre = txtnombre.Text;
                    curCorto.Local = lista[lbsucursales.SelectedIndex];

                    new MiServicio().ModificarCursos(curCorto);
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
        private void clbarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < clbarea.Items.Count; i++)
                    clbarea.SetItemChecked(i, false);
                if (clbarea.SelectedIndex != -1)
                    clbarea.SetItemChecked(clbarea.SelectedIndex, true);
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }
        private void tsbBaja_Click(object sender, EventArgs e)
        {
            try
            {
                new MiServicio().EliminarCurso(curCorto);
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
        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {


                if (clbarea.SelectedIndex != -1 && lbsucursales.SelectedIndex != -1)
                {

                    Cortos nueCur = new Cortos();
                    nueCur.Area = clbarea.SelectedItem.ToString();
                    nueCur.Nombre = txtnombre.Text.Trim();
                    nueCur.Codigo = txtcodigo.Text.Trim();
                    nueCur.Costo = Convert.ToInt32(txtcosto.Text.Trim());
                    nueCur.Cupos = Convert.ToInt32(txtcupos.Text.Trim());
                    nueCur.Fecha_Inicio = dtpfecha.Value;
                    nueCur.Local = lista[lbsucursales.SelectedIndex];
                    nueCur.Empleados = emplLog;

                    new MiServicio().AgregarCurso(nueCur);
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
        private void txtcupos_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtcodigo.Text.Trim() != "")
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
                if (txtcodigo.Text.Trim() != "")
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

    }
}
