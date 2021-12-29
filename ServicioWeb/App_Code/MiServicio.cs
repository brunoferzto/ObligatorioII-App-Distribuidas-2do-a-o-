using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;

/// <summary>
/// Descripción breve de MiServicio
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class MiServicio : System.Web.Services.WebService
{

    public MiServicio()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public void Serializar (Cortos co, Especializados es) { }

    [WebMethod]
    public Cortos SerializarCor ()
    {
        return new Cortos();
    }

    private void GeneroSoapException(Exception ex)
    {

        XmlDocument _undoc = new System.Xml.XmlDocument();
        XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

        XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");
        _NodoDetalle.InnerText = ex.Message;
        _NodoError.AppendChild(_NodoDetalle);

        SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        throw _MiEx;
    }

    /////////////////////////////   CURSOS   ////////////////////////////////////////////////
    [WebMethod]
    public void AgregarCurso (Cursos c)
    {
        try
        {
            FabricaLogica.getLogicaCursos().Agregar(c);

        }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }

    }

    [WebMethod]
    public void EliminarCurso (Cursos c)
    {
        try
        {
            FabricaLogica.getLogicaCursos().Eliminar(c); 
        }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public Cursos BuscarCurso (string cod)
    {
        Cursos cur = null; 
        try
        {
          cur =  FabricaLogica.getLogicaCursos().Buscar(cod); 
        }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }
        return cur; 
    }

    [WebMethod]
    public List<Cursos> ListarCursos()
    {
        List<Cursos> lista = null;
        try
        {
        lista =  FabricaLogica.getLogicaCursos().Listar();
        }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }
        return lista;
    }

    [WebMethod]
    public void ModificarCursos (Cursos c)
    {
        try
        {
            FabricaLogica.getLogicaCursos().Modificar(c);
         }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }
    }

    /////////////////////////////   EMPLEADO   ////////////////////////////////////////////////


    [WebMethod]
    public Empleado LogueoEmpleado (Empleado e)
    {
        Empleado emB = null;    
        try
        {
            emB = FabricaLogica.getLogicaEmpleado().Logueo(e);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return emB; 
    }

    [WebMethod]
    public Empleado BuscarEmpleado (string usu)
    {
        Empleado emBu = null;
        try
        {
            emBu = FabricaLogica.getLogicaEmpleado().Buscar(usu);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return emBu;
    }

    [WebMethod]
    public void RegistrarEmpleado (Empleado e)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Agregar(e);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void ModificarEmlpeado (Empleado e)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Modificar(e);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void EliminarEmpleado (Empleado e)
    {
        try
        {
            FabricaLogica.getLogicaEmpleado().Eliminar(e);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    /// ///////////////////////     ALUMNOS     //////////////////////////////////////////////////////
    [WebMethod]
    public void AgregarAlumno(Alumnos a)
    {
        try
        {
            FabricaLogica.getLogicaAlumno().Agregar(a);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public Alumnos BuscarAlumno (int ced)
    {
        Alumnos al = null; 
        try
        {
           al = FabricaLogica.getLogicaAlumno().Buscar(ced);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return al; 

    }

    [WebMethod]
    public void InscripcionAlumno (Inscripcion insA)
    {
        try
        {
            FabricaLogica.getLogicaAlumno().Inscribir(insA);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public XmlDocument ListarInscripcion ()
    {
        XmlDocument xmlLista = null; 
        try
        {
            xmlLista = FabricaLogica.getLogicaAlumno().Listar();
        }
        catch (Exception ex)
        {
            GeneroSoapException(ex);
        }
        return xmlLista;
    }

    /////////////////////////////   SUCURSAL    ////////////////////////////////////////////////
    [WebMethod]
    public void AgregarSucursal (Sucursales s)
    {
        try
        {
            FabricaLogica.getLogicaSucursal().Agregar(s);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void EliminarSucursal (Sucursales s)
    {
        try
        {
            FabricaLogica.getLogicaSucursal().Eliminar(s);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public void ModificarSucursal(Sucursales s)
    {
        try
        {
            FabricaLogica.getLogicaSucursal().Modificar(s);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }

    [WebMethod]
    public Sucursales BuscarSucursal (string sucu)
    {
        Sucursales suc = null; 
        try
        {
          suc =  FabricaLogica.getLogicaSucursal().Buscar(sucu);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return suc;
    }

    [WebMethod]
    public List<Sucursales> ListarSucursales ()
    {
        List<Sucursales> lista = null; 
        try
        {
          lista =  FabricaLogica.getLogicaSucursal().Listar(); 
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return lista; 
    }



}
