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

        AccionMejoraBC objAccionMejoraBC = null;
        AccionMejoraCollectionBE objAccionesMejoraCollectionBE = null;

        AccionMejoraBC objAccionesPreviasBC = null;
        AccionMejoraCollectionBE objAccionesPreviasCollectionBE = null;

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

            //OBTENER ACCIONES DE MEJORA
            objAccionMejoraBC = new AccionMejoraBC();

            if (objAccionesMejoraCollectionBE == null)
            {
                AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
                objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
                objAccionesMejoraCollectionBE = objAccionMejoraBC.listarAccionesMejora(objAccionMejoraBE);
            }

            grdAccionesMejoraDataBind();

            //OBTENER ACCIONES PREVIAS
            objAccionesPreviasBC = new AccionMejoraBC();

            if(objAccionesPreviasCollectionBE == null)
            {
                InformeFinCicloBE objInformeAccioneMejoraBE = new InformeFinCicloBE();
                objInformeAccioneMejoraBE.CursoId = objCursoxProfesorBE.CursoId;
                objInformeAccioneMejoraBE.PeriodoId = objPeriodoBE.PeriodoId;
                objAccionesPreviasCollectionBE = objAccionesPreviasBC.listarAccionesPrevias(objInformeAccioneMejoraBE);
            }

            grdAccionesPreviasDataBind();

            //SETEANDO DATOS DE INFORME DE FIN DE CICLO
            txt_DesarrolloAprendizaje.Text = objInformeBE.DesarrolloUnidades;
            txt_Infraestructura.Text = objInformeBE.ComentarioInfraestructura;
            txt_Alumnos.Text = objInformeBE.ComentarioAlumnos;
            txt_Delegados.Text = objInformeBE.ComentarioDelegados;
            txt_EncuestaAcademica.Text = objInformeBE.ComentarioEncuesta;
        }


        //DATA BINDS

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

        private void grdAccionesMejoraDataBind()
        {
            AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
            objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objAccionesMejoraCollectionBE = objAccionMejoraBC.listarAccionesMejora(objAccionMejoraBE);

            grdAccionesdeMejora.DataSource = objAccionesMejoraCollectionBE.LstAccionesMejora;
            grdAccionesdeMejora.DataBind();
        }

        private void grdAccionesPreviasDataBind()
        {
            InformeFinCicloBE objInformeAccionPreviaBE = new InformeFinCicloBE();
            objInformeAccionPreviaBE.CursoId = objCursoxProfesorBE.CursoId;
            objInformeAccionPreviaBE.PeriodoId = objPeriodoBE.PeriodoId;
            objAccionesPreviasCollectionBE = objAccionesPreviasBC.listarAccionesPrevias(objInformeAccionPreviaBE);

            grdAccionesPrevias.DataSource = objAccionesPreviasCollectionBE.LstAccionesMejora;
            grdAccionesPrevias.DataBind();
        }


        //POPUPS
        
        protected void popup_buttonRegistrarHallazgo_Click(object sender, EventArgs e)
        {
            objHallazgoBC = new HallazgoBC();

            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objHallazgoBE.Descripcion = popup_textoDescripcionHallazgoRegistrar.Text;
            objHallazgoBE.PeriodoId = objPeriodoBE.PeriodoId;
            objHallazgoCollectionBE = objHallazgoBC.resgistrarHallazgo(objHallazgoBE);
            grdHallazgosDataBind();
        }

        protected void popup_buttonEditarHallazgo_Click(object sender, EventArgs e)
        {
            objHallazgoBC = new HallazgoBC();

            HallazgoBE objHallazgoBE = new HallazgoBE();
            objHallazgoBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objHallazgoBE.Descripcion = popup_textoDescripcionHallazgoEditar.Text;
            //HallazgoId?

            objHallazgoCollectionBE = objHallazgoBC.editarHallazgo(objHallazgoBE);
            grdHallazgosDataBind();
        }


        //ROW COMMANDS

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
                }

                if (e.CommandName.ToUpper().Equals("CMDAGREGARACCIONMEJORA"))
                {
                }

                if (e.CommandName.ToUpper().Equals("CMDEDITARHALLAZGO"))
                {
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void grdAccionesMejora_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.ToUpper().Equals("CMDELIMINARACCIONMEJORA"))
                {
                    objAccionMejoraBC = new AccionMejoraBC();

                    AccionMejoraBE objAccionMejoraBE = new AccionMejoraBE();
                    objAccionMejoraBE.AccionMejoraId = Convert.ToInt32(e.CommandArgument.ToString());
                    objAccionMejoraBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;

                    objAccionesMejoraCollectionBE = objAccionMejoraBC.eliminarAccionMejora(objAccionMejoraBE);
                    grdAccionesMejoraDataBind();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdvAccionesPrevias_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        protected void dpdListEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /*
        public void selectedItem( CommandEventArgs e)
        {
            for (int i = 0; i < objAccionesPreviasCollectionBE.LstAccionesMejora.Count; i++)
            {
                if (int.Parse(e.CommandName) == objAccionesPreviasCollectionBE.LstAccionesMejora[i].AccionMejoraId)
                {
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "EN PROCESO")
                    { 
                        //seteo el index en EN PROCESO
                        grdAccionesPrevias.
                        dpdListEstatus.SelectedIndex = 0;
                    }
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "NO REALIZADO")
                    {
                        //seteo el index en EN PROCESO
                        dpdListEstatus.SelectedIndex = 1;
                    }
                    if (objAccionesPreviasCollectionBE.LstAccionesMejora[i].Estado == "IMPLEMENTADO")
                    {
                        //seteo el index en EN PROCESO
                        dpdListEstatus.SelectedIndex = 2;
                    }
                }
            }
        }*/
        public void OnConfirm(object sender, EventArgs e)
        {
           
            InformeFinCicloBC objInformeFinCicloBC = new InformeFinCicloBC();
            InformeFinCicloBE objInformeFinCicloBE = new InformeFinCicloBE();

            objInformeFinCicloBE.InformeFinCicloId = objInformeBE.InformeFinCicloId;
            objInformeFinCicloBE.DesarrolloUnidades = txt_DesarrolloAprendizaje.Text;
            objInformeFinCicloBE.ComentarioInfraestructura = txt_Infraestructura.Text;
            objInformeFinCicloBE.ComentarioAlumnos = txt_Alumnos.Text;
            objInformeFinCicloBE.ComentarioDelegados = txt_Delegados.Text;
            objInformeFinCicloBE.ComentarioEncuesta = txt_EncuestaAcademica.Text;
            objInformeFinCicloBE.Estado = "EN PROCESO";

            //string confirmValue = Request.Form["confirm_value"];
            //if (confirmValue == "YES")
            //{
                if (!existenCamposVacios() && objHallazgoCollectionBE.LstHallazgos.Count < 0)
                {
                    objInformeFinCicloBE.Estado = "FINALIZADO";
                    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted ha finalizado el Informe de Fin de Ciclo satisfactorimente.')", true);
                }

                else
                {
                    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
                    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Usted debe llenar todos los campos para completar el Informe de Fin de Ciclo.')", true);
                }
               
            //}
            //else
            //{
            //    objInformeBE = objInformeFinCicloBC.editarInformeFinCiclo(objInformeFinCicloBE);
            //    //this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('La información ha sido almacenada. Para finalizar el Informe de Fin de Ciclo, debe enviar el Informe.')", true);
            //}
        }

        public void OnCancel(object sender, EventArgs e)
        {
            Response.Redirect("CursosxCoordinador.aspx");
        }

        private bool existenCamposVacios()
        {
            if (txt_DesarrolloAprendizaje.Text.Equals("") || txt_Infraestructura.Text.Equals("") ||
                txt_Alumnos.Text.Equals("") || txt_Delegados.Text.Equals("") ||
                txt_EncuestaAcademica.Text.Equals(""))
                return true;
            return false;
        }
    }
}