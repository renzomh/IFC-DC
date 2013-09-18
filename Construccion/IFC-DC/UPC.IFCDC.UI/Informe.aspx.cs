﻿using System;
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

            grdOutcomesDataBind();
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
    }
}