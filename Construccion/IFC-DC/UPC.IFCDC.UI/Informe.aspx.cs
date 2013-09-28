using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UPC.IFCDC.BE;
using UPC.IFCDC.BC;
using UPC.IFCDC.Utilitarios;

namespace UPC.IFCDC.UI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        PeriodoBE objPeriodoBE = null;
        InformeFinCicloBE objInformeBE = null;
        CursoxProfesorBE objCursoxProfesorBE = null;

        LogroBC objLogroBC = null;
        LogroBE objLogroBE = null;

        ResultadoProgramaxCursoBC objResultadoProgramaBC = null;
        ResultadoProgramaxCursoCollectionBE objResultadoProgramaxCursoCollectionBE = null;

        HallazgoBC objHallazgoBC = null;
        HallazgoCollectionBE objHallazgoCollectionBE = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            objPeriodoBE = (PeriodoBE)Session["Periodo"];
            objInformeBE = (InformeFinCicloBE) Session["Informe"];
            objCursoxProfesorBE = (CursoxProfesorBE)Session["CursoxProfesor"];

            texto_PeriodoActual.Text = objPeriodoBE.Descripcion;
            texto_FechaLimite.Text = objPeriodoBE.FechaFin;
            texto_DescripcionCurso.Text = objCursoxProfesorBE.Codigo + " - " + objCursoxProfesorBE.Nombre;

            //OBTENIENDO LOGRO TERMINAL
            objLogroBE = new LogroBE();
            objLogroBE.CursoId = objCursoxProfesorBE.CursoId;

            objLogroBC = new LogroBC();
            objLogroBE = objLogroBC.obtenerLogroxCurso(objLogroBE);

            texto_LogroTerminal.Text = objLogroBE.Descripcion;

            //OBTENIENDO STUDENT OUTCOMES
            grdOutcomesDataBind();

            //OBTENIENDO HALLAZGOS
            objHallazgoBC = new HallazgoBC();

            if (objHallazgoCollectionBE == null)
            {
                HallazgoBE objHallazgoBE = new HallazgoBE();
                objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
                objHallazgoCollectionBE = objHallazgoBC.listarHallazgos(objHallazgoBE);
            }

            grdHallazgosDataBind();
        }

        private void grdHallazgosDataBind()
        {
            grdHallazgos.DataSource = objHallazgoCollectionBE.LstHallazgos;
            grdHallazgos.DataBind();
        }

        private void grdOutcomesDataBind()
        {
            ResultadoProgramaxCursoBE objResultadoProgramaBE = new ResultadoProgramaxCursoBE();
            objResultadoProgramaBE.CursoId = objCursoxProfesorBE.CursoId;
            objResultadoProgramaBC = new ResultadoProgramaxCursoBC();
            objResultadoProgramaxCursoCollectionBE = objResultadoProgramaBC.listarResultadoProgramaxCurso(objResultadoProgramaBE);

            grdOutcomes.DataSource = objResultadoProgramaxCursoCollectionBE.LstResultadoProgramaxCurso;
            grdOutcomes.DataBind();
        }

        protected void popup_buttonRegistrarHallazgo_Click(object sender, EventArgs e)
        {
            objHallazgoBC = new HallazgoBC();

            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objHallazgoBE.Descripcion = popup_textoDescripcionHallazgo.Text;
            
            objHallazgoCollectionBE = objHallazgoBC.resgistrarHallazgo(objHallazgoBE);
            grdHallazgosDataBind();
        }

        public void grdHallazgos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARHALLAZGO"))
                {
                    objHallazgoBC = new HallazgoBC();

                    HallazgoBE objHallazgoBE = new HallazgoBE();
                    objHallazgoBE.HallazgoId = Convert.ToInt32(e.CommandArgument.ToString());
                    objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;

                    objHallazgoCollectionBE = objHallazgoBC.eliminarHallazgo(objHallazgoBE);
                    grdHallazgosDataBind();

                    //Context.Items.Add("Modo", "2");
                    //Context.Items.Add("CodAlumno", e.CommandArgument);
                    //Server.Transfer("Alumno.aspx");
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}