﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServicioWeb;

public partial class Consulta_de_Cursos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            try
            {

                    
                  List<Cursos> curList  = new MiServicio().ListarCursos().ToList();


                Session["CursosList"] = (from uncurso in curList
                                         where uncurso.Fecha_Inicio > DateTime.Now
                                        select uncurso).ToList<Cursos>();

                RTCurso.DataSource = (List<Cursos>)Session["CursosList"];
                RTCurso.DataBind();


                Session["SucursalList"] = new MiServicio().ListarSucursales().ToList(); 
                DDLSucursal.DataSource = (List<Sucursales>)Session["SucursalList"];
                DDLSucursal.DataTextField = "Nombre";
                DDLSucursal.DataBind();
                DDLSucursal.Items.Insert(0, new ListItem("Seleccionar", "0"));

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

  

    protected void RTCurso_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        try
        {
            if (e.CommandName == "aIndividual")
            {
                Session["CursoSel"] = new MiServicio().BuscarCurso(Convert.ToString(((TextBox)(e.Item.Controls[1])).Text));
                Response.Redirect("~/Consulta Individual de Curso.aspx");
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

    protected void CargarDatos()
    {
        RTCurso.DataSource = (List<Cursos>)Session["Resultados"];
        RTCurso.DataBind();
    }

    protected void RBLtipo_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string tipo = RBLtipo.SelectedValue.ToString();
            Session["Tipo"] = tipo; 

            Session["Resultados"] = (from uncurso in (List<Cursos>)Session["CursosList"]
                                     where uncurso.TipoCurso.Trim() == tipo
                                     select uncurso).ToList<Cursos>();

            CargarDatos();


            txtfecha.Text = "";
            txtfechados.Text = "";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

       
    }

    protected void DDLSucursal_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (RBLtipo.SelectedIndex != -1 && DDLSucursal.SelectedIndex != 0)
            {
                string tipo = (string)Session["Tipo"];

                Session["Resultados"] = (from uncurso in (List<Cursos>)Session["CursosList"]
                                         where uncurso.Local.Nombre == DDLSucursal.SelectedValue.ToString() && uncurso.TipoCurso == tipo
                                         select uncurso).ToList<Cursos>();

                CargarDatos();
            }
            else
                DDLSucursal.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message; 
        }

    }



    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        DDLSucursal.SelectedIndex = -1;
        RBLtipo.SelectedIndex = -1;
        RTCurso.DataSource = (List<Cursos>)Session["CursosList"];
        RTCurso.DataBind();
        txtfecha.Text = "";
        txtfechados.Text = "";
        lblerror.Text = "";
        txtfecha.Enabled = true;
        txtfechados.Enabled = true;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
     try
        { 
            

            if (RBLtipo.SelectedIndex != -1)
            {
                DDLSucursal.SelectedIndex = 0;

                if (txtfecha.Text.Trim() != "" && txtfechados.Text.Trim() != "")
                {
                    DateTime fechaUNO = DateTime.MinValue;
                    DateTime fechaDos = DateTime.MaxValue;

                    if (Convert.ToDateTime(txtfecha.Text.Trim()) < Convert.ToDateTime(txtfechados.Text.Trim()))
                    {
                        fechaUNO = Convert.ToDateTime(txtfecha.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfechados.Text.Trim());
                    }

                    else if (Convert.ToDateTime(txtfecha.Text.Trim()) > Convert.ToDateTime(txtfechados.Text.Trim()))
                    {
                        fechaUNO = Convert.ToDateTime(txtfechados.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfecha.Text.Trim());

                    }

                    else
                    {
                        fechaUNO = Convert.ToDateTime(txtfecha.Text.Trim());
                        fechaDos = Convert.ToDateTime(txtfechados.Text.Trim());
                    }

                    string tipo = (string)Session["Tipo"]; 

                    Session["Resultados"] = (from uncurso in (List<Cursos>)Session["CursosList"]
                           where uncurso.Fecha_Inicio >= fechaUNO && uncurso.Fecha_Inicio <= fechaDos && uncurso.TipoCurso == tipo
                           select uncurso).ToList<Cursos>();

                    CargarDatos();
                    txtfecha.Enabled = false;
                    txtfechados.Enabled = false; 


                }
                else
                    lblerror.Text = "Error, debe ingresar dos fechas";
            }
            else
            {
                txtfecha.Text = "";
                txtfechados.Text = "";
            }
        }
        catch (Exception ex)
        {
            if (ex.Message == "")
            {
                lblerror.Text = "Error, en Fecha";
            }
            else
            lblerror.Text = ex.Message; 
        }
    }



    protected void txtfechados_TextChanged(object sender, EventArgs e)
    {

    }
}