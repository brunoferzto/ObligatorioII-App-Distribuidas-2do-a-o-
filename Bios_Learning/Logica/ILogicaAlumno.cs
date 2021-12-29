using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using System.Xml;

namespace Logica
{
       public interface ILogicaAlumno
    {
        void Agregar(Alumnos e);
        void Inscribir(Inscripcion i);
        Alumnos Buscar(int ced);
        XmlDocument Listar();
      

    }
}
