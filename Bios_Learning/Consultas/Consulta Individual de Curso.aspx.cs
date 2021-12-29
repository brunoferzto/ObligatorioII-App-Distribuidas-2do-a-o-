using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompositeControl;
using ServicioWeb;
public partial class Consulta_Individual_de_Curso : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Cursos c = (ServicioWeb.Cursos)Session["CursoSel"];

            string concre; 

            if (c is Cortos)
            {
                 concre = ((Cortos)c).Area;
            }
            else
            {
                 concre = ((Especializados)c).Duracion.ToString();
            }

            string cod = c.Codigo;
            int costo = c.Costo;
            int cupos = c.Cupos;
            string nombre = c.Nombre;
            string tipo = c.TipoCurso;
            DateTime fecha = c.Fecha_Inicio;
            string emple = c.Empleados.Usuario;
            string contra = c.Empleados.Contraseña;
            string local = c.Local.Nombre;
            string dire = c.Local.Direccion;
            List<string> lista = c.Local.Facilidad.ToList();

            Composite1.CurSelec(cod, costo, cupos, nombre, tipo, fecha, emple, contra, local, dire, lista,concre );
        }
    }
}