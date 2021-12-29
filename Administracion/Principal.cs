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
    public partial class Principal : Form
    {
        private Empleado emLog = null;
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(Empleado emL)
        {
            InitializeComponent();
            emLog = emL; 
        }


        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleado formEm = new ABMEmpleado(emLog);
            formEm.ShowDialog();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMSucursal formSu = new ABMSucursal();
            formSu.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAlumno forAl = new AltaAlumno();
            forAl.ShowDialog();
        }

        private void nuevaInscipciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaInscripción forNueI = new NuevaInscripción();
            forNueI.ShowDialog();
        }

        private void cortosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCortos forCor = new ABMCortos(emLog);
            forCor.ShowDialog(); 
        }

        private void especializadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEspecializados forEsp = new ABMEspecializados(emLog);
            forEsp.ShowDialog(); 
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas forEst = new Estadisticas();
            forEst.ShowDialog();

        }
    }
}
