using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Administracion.ServicioWeb;
using System.Xml.Linq;

namespace Administracion
{
    public partial class Estadisticas : Form
    {
        XElement _DOC = null;
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                List<Cursos> lista = new MiServicio().ListarCursos().ToList();
                cbxcursos.DataSource = lista;
                cbxcursos.ValueMember = "Codigo";
                cbxcursos.DisplayMember = "Nombre";

                XmlNode elDocumento = new MiServicio().ListarInscripcion();

                _DOC = XElement.Parse(elDocumento.OuterXml);



                var resultado = ((from nodis in _DOC.Elements("Inscripcion")
                                  select
                                  new
                                  {
                                      Codigo = nodis.Element("CodigoCurso").Value,
                                      Nombre = nodis.Element("NombreCurso").Value,
                                      Inicio = nodis.Element("FechaInicioCurso").Value,
                                      Sucursal = nodis.Element("SucursalNombre").Value,
                                      Inscripcion = nodis.Element("FechaInsc").Value

                                  }
                              )).ToList();

                dgvlistado.DataSource = resultado.ToList();




            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 100);
                else
                    lblerror.Text = ex.Message;
            }
        }


        private void tsbDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                ActivoxDefecto(); 
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message; 
            }
        }

        private void ActivoxDefecto()
        {
            try
            {
                var resultado = ((from nodis in _DOC.Elements("Inscripcion")
                                  select
                                  new
                                  {
                                      Codigo = nodis.Element("CodigoCurso").Value,
                                      Nombre = nodis.Element("NombreCurso").Value,
                                      Inicio = nodis.Element("FechaInicioCurso").Value,
                                      Sucursal = nodis.Element("SucursalNombre").Value,
                                      Inscripcion = nodis.Element("FechaInsc").Value

                                  }
                              )).ToList();

                dgvlistado.DataSource = resultado.ToList();

                dtpdesde.Value = DateTime.Now;
                dtphasta.Value = DateTime.Now; 

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                if (ex.Detail.InnerText.Length > 100)
                    lblerror.Text = ex.Detail.InnerText.Substring(0, 100);
                else
                    lblerror.Text = ex.Detail.InnerText;
            }

            catch (Exception ex)
            {
                if (ex.Message.Length > 40)
                    lblerror.Text = ex.Message.Substring(0, 100);
                else
                    lblerror.Text = ex.Message;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {


              

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message; 
            }
        }

        private void tsbfiltrar_Click(object sender, EventArgs e)
        {
            try
            {

            if(cbfiltrar.Checked != true/* && cbobtener.Checked != true*/)
                {

                    var resultado = ((from nodis in _DOC.Elements("Inscripcion")
                                      where Convert.ToDateTime(nodis.Element("FechaInicioCurso").Value) >=   dtpdesde.Value.Date &&
                                            Convert.ToDateTime(nodis.Element("FechaInicioCurso").Value) <=   dtphasta.Value.Date                                       
                                      select                                  
                                      new
                                      {
                                          Codigo = nodis.Element("CodigoCurso").Value,
                                          Nombre = nodis.Element("NombreCurso").Value,
                                          Inicio = nodis.Element("FechaInicioCurso").Value,
                                          Sucursal = nodis.Element("SucursalNombre").Value,
                                          Inscripcion = nodis.Element("FechaInsc").Value

                                      }
                                     )).ToList();

                    dgvlistado.DataSource = resultado.ToList();

                }
                if (cbfiltrar.Checked == true)
                {
                    


                    var resultado = ((from nodis in _DOC.Elements("Inscripcion")
                                      where (string)nodis.Element("CodigoCurso") == cbxcursos.SelectedValue.ToString()
                                      select
                                      new
                                      {
                                          Codigo = nodis.Element("CodigoCurso").Value,
                                          Nombre = nodis.Element("NombreCurso").Value,
                                          Inicio = nodis.Element("FechaInicioCurso").Value,
                                          Sucursal = nodis.Element("SucursalNombre").Value,
                                          Inscripcion = nodis.Element("FechaInsc").Value

                                      }
                                    )).ToList();

                    dgvlistado.DataSource = resultado.ToList();
                }

                //if (cbobtener.Checked == true)
                //{
                //    var resultado = ((from nodis in _DOC.Elements("Inscripcion")
                //                      group nodis by nodis.Element("CodigoCurso").Value +  Convert.ToDateTime(nodis.Element("FechaInsc").Value).Year
                //                     into final
                //                     select new
                //                      {
                                          
                //                          Curso = final.Key,
                //                          Cantidad = final.Count()

                //                      }
                //                    )).ToList();

          

                //    dgvlistado.DataSource = resultado.ToList();
                //}


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
