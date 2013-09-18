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
    public partial class WebForm3 : System.Web.UI.Page
    {
        private String sPersonaId = null;

        PeriodoBC objPeriodoBC = null;
        PeriodoBE objPeriodoBE = null;

        CursoxProfesorBC objCursoxProfesorBC = null;
        CursoxProfesorCollectionBE objCursoxProfesorCollectionBE = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            sPersonaId = Session["PersonaId"].ToString();

            if (sPersonaId != null)
            {
                objPeriodoBC = new PeriodoBC();
                objPeriodoBE = objPeriodoBC.obtenerPeriodoActual();

                texto_PeriodoActual.Text = objPeriodoBE.Descripcion;
                texto_FechaLimite.Text = objPeriodoBE.FechaFin;

                grdCursosDataBind();
            }
        }

        private void grdCursosDataBind()
        {
            CursoxProfesorBE objCursoxProfesorBE = new CursoxProfesorBE();
            objCursoxProfesorBE.ProfesorId = sPersonaId;
            objCursoxProfesorBC = new CursoxProfesorBC();
            objCursoxProfesorCollectionBE = objCursoxProfesorBC.listarCursosxProfesor(objCursoxProfesorBE);

            grdCursos.DataSource = objCursoxProfesorCollectionBE.LstCursosxProfesor;
            grdCursos.DataBind();
        }

        public void grdCursos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDINICIAR"))
                {
                    InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
                    InformeFinCicloBE objInformeFinCicloBE = new InformeFinCicloBE();
                    objInformeFinCicloBE.PeriodoId = objPeriodoBE.PeriodoId;
                    objInformeFinCicloBE.CoordinadorId = sPersonaId;
                    objInformeFinCicloBE.CursoId = Convert.ToInt32(e.CommandArgument.ToString());

                    objInformeFinCicloBE = objInformeFinCicloBC.obtenerInformeFinCiclo(objInformeFinCicloBE);

                    if (objInformeFinCicloBE != null)
                    {
                        if (!objInformeFinCicloBE.Estado.Equals(Constantes.ESTADO_INFORME_FINALIZADO))
                        {
                            Session["Informe"] = objInformeFinCicloBE;
                            Session["Periodo"] = objPeriodoBE;
                            Session["CursoxProfesor"] = obtenerCurso(objInformeFinCicloBE.CursoId);

                            Response.Redirect("Informe.aspx");
                        }
                    }

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

        protected void grdCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private CursoxProfesorBE obtenerCurso(int cursoId)
        {
            CursoxProfesorBE sRespuesta = null;

            for (int i = 0; i < objCursoxProfesorCollectionBE.LstCursosxProfesor.Count; i++)
            {
                if (objCursoxProfesorCollectionBE.LstCursosxProfesor[i].CursoId == cursoId)
                    sRespuesta = objCursoxProfesorCollectionBE.LstCursosxProfesor[i];
            }

            return sRespuesta;
        }
    }
}