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
    public partial class ABMSucursal : Form
    {
        Sucursales sucuMemo = null;
        List<string> lista; 
        public ABMSucursal()
        {
            InitializeComponent();
        }

        private void ABMSucursal_Load(object sender, EventArgs e)
        {
            PorDefecto(); 
        }
        protected void ActivoAgregar()
        {
            btnagregar.Enabled = true;
            btnquitar.Enabled = true;
            txtDireccion.ReadOnly = false;
            txtfacilidad.ReadOnly = false;
            lbfacilidad.Enabled = true;
        }
         protected void ActivoActualizacion()
        {
            txtDireccion.ReadOnly = false;
            txtfacilidad.ReadOnly = false;
            lbfacilidad.Enabled = true;
            tsbBaja.Enabled = true;
            tsbModificar.Enabled = true;
            btnagregar.Enabled = true;
            btnquitar.Enabled = true;  
        }

        protected void PorDefecto()
        {
            txtNombre.Focus(); 
            txtDireccion.ReadOnly = true;
            lbfacilidad.Text = "";
            lbfacilidad.Enabled = false;
            btnagregar.Enabled = false;
            btnquitar.Enabled = false;
            txtfacilidad.ReadOnly = true;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            lblerror.Text = "";
            lbfacilidad.DataSource = null; 


        }

        private void ActualizarFacilidades()
        {
            lbfacilidad.DataSource = null;
            lbfacilidad.Items.Clear();
            lbfacilidad.DataSource = lista;
            txtfacilidad.Text = "";
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                sucuMemo = new MiServicio().BuscarSucursal(txtNombre.Text.Trim());
                if (sucuMemo != null)
                {
                    txtNombre.Text = sucuMemo.Nombre;
                    txtDireccion.Text = sucuMemo.Direccion;
                   
                    lista = sucuMemo.Facilidad.ToList();
                    lbfacilidad.DataSource = lista;
                    ActivoActualizacion();

                }
                else
                    ActivoAgregar();
                

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void tsbDeshacer_Click(object sender, EventArgs e)
        {
            PorDefecto(); 
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfacilidad.Text.Trim().Length > 0)
                {
                    lista.Add(txtfacilidad.Text.Trim());
                    ActualizarFacilidades();                  
                }
                else
                    lblerror.Text = "Ingrese la nueva facilidad";
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message; 
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbfacilidad.SelectedIndex >= 0)
                {
                   
                   lista.Remove(lista[lbfacilidad.SelectedIndex]);
                    ActualizarFacilidades();
                }
                else
                    lblerror.Text = "Debes Seleccionar un Elemento de la Lista";

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }

        }

        private void tsbAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Sucursales sucu = new Sucursales();
                sucu.Nombre = txtNombre.Text.Trim();
                sucu.Direccion = txtDireccion.Text.Trim();

                foreach (string unLugar in lbfacilidad.Items)
                    sucu.Facilidad.ToList().Add(unLugar.ToString().Trim());

                new MiServicio().AgregarSucursal(sucu);
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
                new MiServicio().EliminarSucursal(sucuMemo);
                PorDefecto(); 
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
                sucuMemo.Nombre = txtNombre.Text.Trim();
                sucuMemo.Direccion = txtDireccion.Text.Trim();
                sucuMemo.Facilidad = lista.ToArray();

                new MiServicio().ModificarSucursal(sucuMemo);
                PorDefecto();
                lblerror.Text = "Modificacion Correcta";


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
