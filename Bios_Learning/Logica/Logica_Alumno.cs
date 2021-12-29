using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia;
using System.Xml;

namespace Logica
{
    internal class Logica_Alumno:ILogicaAlumno
    {

        private static Logica_Alumno _instancia = null;

        private Logica_Alumno() { }
        public static Logica_Alumno GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Logica_Alumno();

            return _instancia;
        }

        public void Agregar (Alumnos e)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            intAlu.Agregar(e); 
        }

        public void Inscribir (Inscripcion i)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            intAlu.Inscripcion(i);
        }

        public Alumnos Buscar(int ced)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            return intAlu.Buscar(ced);
        }

        public XmlDocument Listar()
        {
            try
            {
                List<Inscripcion> lista = FabricaPersistencia.getPersistenciaAlumnos().Listar();

                XmlDocument _Documento = new XmlDocument();
                _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
                XmlNode _raiz = _Documento.DocumentElement;

                foreach (Inscripcion ins in lista)
                {
                    XmlElement CodigoCurso = _Documento.CreateElement("CodigoCurso");
                    CodigoCurso.InnerText = ins.Curso.Codigo.ToString();

                    XmlElement NombreCurso = _Documento.CreateElement("NombreCurso");
                    NombreCurso.InnerText = ins.Curso.Nombre;

                    XmlElement FechaInicioCurso = _Documento.CreateElement("FechaInicioCurso");
                    FechaInicioCurso.InnerText = ins.Curso.Fecha_Inicio.ToShortDateString();

                    XmlElement SucursalNombre = _Documento.CreateElement("SucursalNombre");
                    SucursalNombre.InnerText = ins.Curso.Local.Nombre;

                    XmlElement FechaInsc = _Documento.CreateElement("FechaInsc");
                    FechaInsc.InnerText = ins.Fecha.ToShortDateString();

                    XmlElement Nodo = _Documento.CreateElement("Inscripcion");
                    Nodo.AppendChild(CodigoCurso);
                    Nodo.AppendChild(NombreCurso);
                    Nodo.AppendChild(FechaInicioCurso);
                    Nodo.AppendChild(SucursalNombre);
                    Nodo.AppendChild(FechaInsc);

                    _raiz.AppendChild(Nodo);
                }
                return _Documento;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
